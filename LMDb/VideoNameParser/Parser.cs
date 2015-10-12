using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LMDb.VideoNameParser
{
    public static class Parser
    {
        public static InformationGuess ParseName(string name, string path)
        {
            name = name.Replace(" - ", " ");

            var vid = new InformationGuess();
            var vidType = vid.GetType();

            int extensionIndex = name.LastIndexOf(".");
            vid.Container = extensionIndex != -1 ? name.Substring(extensionIndex + 1) : null;

            if (extensionIndex != -1)
                name = name.Substring(0, extensionIndex);

            string pathRemainder = name;
            
            pathRemainder = pathRemainder.Replace(".", " ");

            foreach (var item in patterns)
            {
                var regex = new Regex(item.Value, RegexOptions.IgnoreCase);

                if (!regex.IsMatch(name))
                    continue;

                var match = regex.Match(name);

                pathRemainder = pathRemainder.Replace(match.Value, " ");

                var property = vidType.GetProperty(item.Key);

                if (item.Key != "SeasonEpisode" && Type.GetTypeCode(property.PropertyType) == TypeCode.Boolean)
                {
                    property.SetValue(vid, true);
                    continue;
                }

                int value;

                if (item.Key == "SeasonEpisode")
                {
                    if (match.Groups.Count == 3)
                    {
                        int seasonIndex;
                        int episodeIndex;
                        vid.Season = int.TryParse(match.Groups[1].Value, out seasonIndex) ? seasonIndex : 0;
                        vid.Episode = int.TryParse(match.Groups[2].Value, out episodeIndex) ? episodeIndex : 0;
                    }
                    continue;
                }


                if (Type.GetTypeCode(property.PropertyType) == TypeCode.Int32 && int.TryParse(match.Groups[2].Value, out value))
                {
                    property.SetValue(vid, value);
                    continue;
                }

                property.SetValue(vid, match.Value.Trim());
            }
            pathRemainder = Regex.Replace(pathRemainder, @"([\(](.*?)[\)])", "");
            int spaceIndex = pathRemainder.IndexOf("  ");
            vid.Title = spaceIndex != -1 ? pathRemainder.Substring(0, spaceIndex).Trim() : pathRemainder.Trim();
            if (spaceIndex != -1 && (vid.Season != 0 || vid.Episode != 0))
            {
                string raw = pathRemainder.Substring(spaceIndex).Trim();
                spaceIndex = raw.IndexOf("  ");
                vid.EpisodeName = spaceIndex != -1 ? raw.Substring(0, spaceIndex).Trim() : raw.Trim();
            }
            vid.IsEpisode = vid.Season != 0 && vid.Episode != 0;
            vid.Path = path;
            return vid;
        }

        private static readonly Dictionary<string, string> patterns = new Dictionary<string, string> {
            { "SeasonEpisode", @"(?:[Ss]([0-9]{1,2}))(?:[ ]{0,1})(?:[Eex]([0-9]{1,2}))" },
            { "Year", @"([\[\(]?((?:19[0-9]|20[01])[0-9])[\]\)]?)" },
            { "Resolution", @"([0-9]{3,4}p)" },
            { "Quality", @"(?:PPV\.)?[HP]DTV|(?:HD)?CAM|B[rR]Rip|TS|(?:PPV )?WEB-?DL(?: DVDRip)?|H[dD]Rip|DVDRip|DVDRiP|DVDRIP|CamRip|W[EB]B[rR]ip|[Bb]lu[Rr]ay|DvDScr|hdtv" },
            { "Codec", @"xvid|x264|h\.?264/i" },
            { "Audio", @"MP3|DD5\.?1|Dual[\- ]Audio|LiNE|DTS|AAC(?:\.?2\.0)?|AC3(?:\.5\.1)?" },
            { "Group", @"(- ?([^-]+(?:-={[^-]+-?$)?))$" },
            { "Region", @"R[0-9]" },
            { "Extended", @"EXTENDED" },
            { "Hardcoded", @"HC" },
            { "Proper", @"PROPER" },
            { "Repack", @"REPACK" },
            { "Container", @"MKV|AVI|MOV|WMVMP4|M4P|M4V|MPGMPEG|M2V" },
            { "Widescreen", @"WS" },
            { "Website", @"^(\[ ?([^\]]+?) ?\])" },
            { "Language", @"rus\.eng" },
            { "Garbage", @"1400Mb|3rd Nov| ((Rip))" }
        };
    }
}
