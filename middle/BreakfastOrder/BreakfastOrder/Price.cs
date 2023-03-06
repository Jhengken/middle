using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastOrder
{
    public static class Price
    {
        public static int SubPrice(string p)
        {
            int pp=0;
            p = p.Substring(p.IndexOf("  ") + 2, (p.IndexOf("元")) - (p.IndexOf("  ") + 2));
            Int32.TryParse(p, out pp);
            
            return pp;
        }
        public static int SubQuantity(string q)
        {
            int qq = 0;
            q = q.Substring(q.IndexOf(":") + 1, (q.IndexOf("  ")) - q.IndexOf(":") + 1);
            Int32.TryParse(q, out qq);
            return qq;
        }
    }
}
