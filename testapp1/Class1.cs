using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathbasic
{
    public class math
    {   /// <summary>
    /// giai phuong trinh bac nhat
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="x"></param>
    /// <returns></returns>
        public static int ptb1(int a, int b, out float x)
        {
            x = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                x=(float)-b/a;
                return 1;

                
            }
           }
    }
}
