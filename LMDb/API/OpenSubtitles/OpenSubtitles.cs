
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HtmlAgilityPack;
using ICSharpCode.SharpZipLib.Zip;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace LMDb.API.OpenSubtitles
{
    class OpenSubtitles
    {
        private const string DOWNLOAD_URL = "http://dl.opensubtitles.org/en/download/sub/";
        private const string SEARCHURL = "http://www.opensubtitles.org/en/search/imdbid-";

        public static List<Subtitle> SearchSubtitlesByImdbId(string imdbId)
        {
            List<Subtitle> result = new List<Subtitle>();
            string url = SEARCHURL + imdbId.TrimStart("tt".ToCharArray());
            try
            {
                int i = 0;
                while(true) // Now this is rather dangerous *strokes his fluffy white cat*
                {
                    List<Subtitle> funcRes = DoSubtitleSearch(url, i++*40);
                    if (funcRes.Count > 0)
                        result.AddRange(funcRes);
                    else
                        break;
                }
            }
            catch (Exception e)
            {
                // Eewaddafú
            }
           
            
            return result;
        }

        public static void DownloadSubtitles(string path, Subtitle sub)
        {
            string url = DOWNLOAD_URL + sub.id;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(url, string.Format("{0}.zip", sub.id));
                    }

                    extractSRTFile(sub.id, path);
                }
            }
            catch (Exception e)
            {
                // Eewaddafú
            }
        }

        private static List<Subtitle> DoSubtitleSearch(string url, int offset = 0)
        {
            List<Subtitle> result = new List<Subtitle>();
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                HtmlDocument htmlDocument = htmlWeb.Load(url + "/offset-" + offset);
                HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//tr[starts-with(@id, \"name\")]");
                foreach (HtmlNode node in nodes)
                {
                    Subtitle sub = new Subtitle();
                    sub.id = SafeXpath(node, ".//a[@class = \"bnone\"]")?.Attributes["href"]?.Value?.Replace("/en/subtitles/", "");
                    sub.id = sub.id?.Remove(sub.id?.IndexOf("/") ?? 0)?.Trim();
                    string downloaded = SafeXpath(node, "(.//a)[5]")?.InnerText?.Trim().TrimEnd("x".ToCharArray());
                    long l;
                    if (long.TryParse(downloaded, out l))
                        sub.downloaded = l;
                    sub.language = SafeXpath(node, "(.//a)[4]")?.Attributes["title"]?.Value?.Trim();
                    sub.uploaded = SafeXpath(node, ".//time")?.InnerText?.Trim(); ;
                    sub.uploader = SafeXpath(node, "(.//a)[7]")?.InnerText?.Trim();
                    result.Add(sub);
                }
            }
            catch (Exception e)
            {
                // Oops
            }
            
            return result;
        }

        private static HtmlNode SafeXpath(HtmlNode node, string xpath)
        {
            try
            {
                return node.SelectSingleNode(xpath);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private static HtmlNodeCollection SafeXpathPlural(HtmlNode node, string xpath)
        {
            try
            {
                return node.SelectNodes(xpath);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private static void extractSRTFile(string id, string path)
        {
            FastZip fz = new FastZip();
            fz.ExtractZip(string.Format("{0}.zip", id), path, "(.*)");
        }
    }
}
