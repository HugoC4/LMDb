using LMDb.API.Omdb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace LMDb.API.Omdb
{
    public static class Omdb
    {
        private const string BaseUrl = "http://www.omdbapi.com/";

        private const string QuerySearch = "s";
        private const string QueryTitle = "t";
        private const string QueryImdbId = "i";

        private const string QueryEpisode = "episode";
        private const string QuerySeason = "season";

        private const string QueryType = "type";
        private const string QueryVersion = "v";
        private const string QueryYear = "y";
        private const string QueryPlot = "plot";
        private const string QueryTomatoes = "tomatoes";

        private const string PlotShort = "short";
        private const string PlotFull = "full";

        private const string FormatPrimaryParam = "?{0}={1}";
        private const string FormatSecondaryParams = "&{0}={1}";

        public const string DateFormat = "dd MMM yyyy";
        private const string ValueNotApplicable = "N/A";
        public const int ApiVersion = 1;

        public static SearchResult Search(string query, int? year = null, Types.SearchType? type = null)
        {
            string url = CreateUrl(new Dictionary<string, object>
            {
                {QuerySearch, query},
                {QueryType, type},
                {QueryYear, year}
            });

            SearchResult result;
            if (ApiCall(url, out result))
            {
                List<SearchEntry> entries = new List<SearchEntry>();
                foreach (SearchEntry entry in result.Search)
                    if (entries.All(p => p.imdbID != entry.imdbID))
                        entries.Add(entry);

                result.Search = entries.ToArray();
            }

            return result;
        }

        public static InformationResult GetInformationByImdbId(string imdbId, int? year = null, Types.SearchType? type = null, bool shortPlot = true, bool tomatoes = false, int? season = null, int? episode = null)
        {
            string url = CreateUrl(new Dictionary<string, object>
            {
                { QueryImdbId, imdbId },
                { QueryYear, year },
                { QueryType, type },
                { QuerySeason, season },
                { QueryEpisode, episode },
                { QueryPlot, shortPlot ? PlotShort : PlotFull },
                { QueryTomatoes, tomatoes}

            });

            RawInformationResult result;
            if (ApiCall(url, out result))
            {
                return NormalizeInformationResult(result);
            }

            return null;
            
        }

        public static InformationResult GetInformationByTitle(string title, int? year = null, Types.SearchType? type = null, bool shortPlot = true, bool tomatoes = false, int? season = null, int? episode = null)
        {
            string url = CreateUrl(new Dictionary<string, object>
            {
                { QueryTitle, title },
                { QueryYear, year },
                { QueryType, type },
                { QuerySeason, season },
                { QueryEpisode, episode },
                { QueryPlot, shortPlot ? PlotShort : PlotFull },
                { QueryTomatoes, tomatoes}

            });

            RawInformationResult result;
            if (ApiCall(url, out result))
            {
                return NormalizeInformationResult(result);
            }

            return null;
        }


        private static string CreateUrl(Dictionary<string, object> apiParams) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BaseUrl);
            bool first = true;

            foreach (KeyValuePair<string, object> param in apiParams.Where(param => param.Value != null))
            {
                sb.AppendFormat(first ? FormatPrimaryParam : FormatSecondaryParams, new object[] { param.Key, param.Value.ToString().ToLower() });
                first = false;
            }

            sb.AppendFormat(FormatSecondaryParams, new object[] { QueryVersion, ApiVersion });

            return sb.ToString();
        }

        private static bool ApiCall<T>(string url, out T result) where T : ApiResult
        {
            WebRequest webRequest = WebRequest.Create(url);
            string responseFromServer = null;
            try
            {
                WebResponse webResp = webRequest.GetResponse();
                using (StreamReader reader = new StreamReader(webResp.GetResponseStream()))
                {
                    responseFromServer = reader.ReadToEnd();
                }
                result = JsonConvert.DeserializeObject<T>(responseFromServer);
                result = NormalizeApiResult(result);
                if ((result.Response.HasValue && !result.Response.Value))
                {
                    result = null;
                    return false;
                }

                return true;
            }
            catch (JsonSerializationException e)
            {
                result = null;
                return false;
            }
            catch (Exception e)
            {
                result = null;
                return false;
            }
        }

        private static T NormalizeApiResult<T>(T apiResult) where T : ApiResult
        {
            foreach (var property in apiResult.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    if ((string) property.GetValue(apiResult) == ValueNotApplicable)
                    {
                        property.SetValue(apiResult, null);
                    }
                }
            }
            return apiResult;
        }

        private static InformationResult NormalizeInformationResult(RawInformationResult rawResult) 
        {
            InformationResult cleanResult = (InformationResult)Activator.CreateInstance(typeof(InformationResult));
            var clearProperties = cleanResult.GetType().GetProperties();
            var rawProperties = rawResult.GetType().GetProperties();
            foreach (var property in clearProperties.Where(p => rawProperties.Any(q => q.Name == p.Name)))
            {
                if (rawProperties.Any(p => p.Name == property.Name && p.PropertyType == typeof(string)))
                {
                    var rawProp = rawProperties.Single(p => p.Name == property.Name);
                    var variable = (string)rawProperties.Single(p => p.Name == property.Name).GetValue(rawResult);
                    if (rawProp.PropertyType != property.PropertyType)
                    {
                        var newVariable = Activator.CreateInstance(Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                        object o = new object();
                        if (GenericTryParseFromString(variable, newVariable, out o))
                        {
                            property.SetValue(cleanResult, o);
                        }
                        else if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                        {
                            property.SetValue(cleanResult, null);
                        }
                    }
                    else
                    {
                        property.SetValue(cleanResult, variable);
                    }
                }
            }
            return cleanResult;
        }

        private static bool GenericTryParseFromString<T>(string input, T defaultType, out object success)
        {
            success = null;
            if (input == null)
                return false;

            if (defaultType.GetType() == typeof (List<string>))
            {
                success = input.Split(new [] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();
                return true;
            }

            if (defaultType.GetType() == typeof (int))
            {
                int i;
                if (int.TryParse(input, NumberStyles.Any, new CultureInfo("en-US"), out i))
                {
                    success = i;
                    return true;
                }
            }
            else if (defaultType.GetType() == typeof(float))
            {
                float f;
                if (float.TryParse(input, NumberStyles.Any, new CultureInfo("en-US"), out f))
                {
                    success = f;
                    return true;
                }
            }
            else if (defaultType.GetType() == typeof (DateTime))
            {
                DateTime dt;
                if (DateTime.TryParseExact(input, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {
                    success = dt;
                    return true;
                }
            }
            else if (defaultType.GetType() == typeof(Types.TomatoImages))
            {
                Types.TomatoImages e;
                if (Types.TomatoImages.TryParse(input, true, out e))
                {
                    success = e;
                    return true;
                }
            }
            else if (defaultType.GetType() == typeof(Types.SearchType))
            {
                Types.SearchType e;
                if (Types.SearchType.TryParse(input, true, out e))
                {
                    success = e;
                    return true;
                }
            }

            try
            {
                success = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(null, new CultureInfo("en-US"), input);
                return true;
            }
            catch (NotSupportedException e)
            {
                return false;
            }
        }
    }
}
