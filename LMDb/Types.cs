using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMDb
{
    public static class Types
    {
        public enum Extensions
        {
            MKV, 
            AVI, 
            MOV, 
            WMV,
            MP4, 
            M4P, 
            M4V, 
            MPG,
            MPEG, 
            M2V
        }

        public enum TomatoImages
        {
            Fresh,
            Certified,
            Rotten
        }

        public enum ItemStatus
        {
            Conflicted,
            Synced,
            Unsynced,
            Ignored,
            Deleted
        }

        public enum SearchType
        {
            Movie,
            Series,
            Episode,
            Game
        }

        public enum PosterWidth
        {
            SD,
            HQ,
            HD,
            FullHD
        }

        public static List<T> GetEnumList<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        public static List<string> GetEnumStrings<T>()
        {
            return (from T val in Enum.GetValues(typeof (T)) select val.ToString()).ToList();
        }

        public static int GetPosterWidthByEnum(PosterWidth width)
        {
            switch (width)
            {
                case PosterWidth.HQ:
                    return 480;
                case PosterWidth.HD:
                    return 720;
                case PosterWidth.FullHD:
                    return 1080;
                default:
                    return 300;
            }
        }

        public static PosterWidth GetEnumByPosterWidth(int width)
        {
            switch (width)
            {
                case 480:
                    return PosterWidth.HQ;
                case 720:
                    return PosterWidth.HD;
                case 1080:
                    return PosterWidth.FullHD;
                default:
                    return PosterWidth.SD;
            }
        }
    }
}
