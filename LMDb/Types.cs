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

        public static List<T> GetEnumList<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        public static List<string> GetEnumStrings<T>()
        {
            return (from T val in Enum.GetValues(typeof (T)) select val.ToString()).ToList();
        }
    }
}
