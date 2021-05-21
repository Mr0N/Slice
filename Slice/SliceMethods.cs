using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slice
{
    public static class SliceMethods
    {
        public static string Slice(this string text, string begin, string end)
        {
            lock (obj)
            {
               var result =  sliceObj.Value;
                return result.ParsString(text ?? "", begin, end);
            }
        }
        public static List<string> SliceInfo(this string text, string begin, string end)
        {
            lock (objList)
            {
                var result = sliceObjList.Value;
                return result.ParsStringArray(text ?? "", begin, end);
            }
        }
        
        static Lazy<SliceObj> sliceObj;
        static Lazy<SliceObj> sliceObjList;
        static object obj;
        static object objList;
        static SliceMethods()
        {
            obj = new object();
            objList = new object();
            sliceObj = new Lazy<SliceObj>();
            sliceObjList = new Lazy<SliceObj>();
        }
        
    }
}
