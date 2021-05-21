using System;
using System.Collections.Generic;
using System.Collections;
namespace Slice
{
    class SliceObj
    {
        public string ParsString(string text, string begin, string end)
        {
            int n = text.IndexOf(begin);
            if (n != -1)
            {
                int x = text.IndexOf(end, (n + begin.Length));
                if (x != -1)
                    return text.Substring(n + begin.Length, ((x - n) - begin.Length));
                else
                    return null;
            }
            else
            {
                return null;
            }

        }
        public List<string> ParsStringArray(string text, string begin, string end)
        {
            List<string> result = new List<string>();
            int n = 0;
            while (true)
            {
                n = text.IndexOf(begin, n);
                if (n != -1)
                {

                    int x = text.IndexOf(end, (n + begin.Length));
                    if (x != -1)
                    {
                        result.Add(text.Substring(n + begin.Length, ((x - n) - begin.Length)));
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
                n++;
            }
            return result;
        }
    }
}
