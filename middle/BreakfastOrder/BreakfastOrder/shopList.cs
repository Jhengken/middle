using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastOrder
{
    public class shopList
    {
        public List<string> shopName = new List<string>();
        public List<int> shopQuantity = new List<int>();
        public List<int> shopPrice = new List<int>();
        public List<int> shopPID = new List<int>();
        public ImageList shopImg = new ImageList();
        
        public  shopList()
        {
            shopImg.ImageSize = new Size(70, 70);
            shopImg.ColorDepth = ColorDepth.Depth32Bit;
        }
        public void add(string name, int quantity, int price, int pid,Image img)
        {
            if (shopPID.IndexOf(pid) == -1)   //如果沒有add進去
            {
                shopName.Add(name);
                shopQuantity.Add(quantity);
                shopPrice.Add(price);
                shopPID.Add(pid);
                shopImg.Images.Add(name ,img);
                //Console.WriteLine("+++ = " + shopImg.Images.Keys[shopImg.Images.Count-1]);
            }
            else                              //修改
            {
                shopName[shopPID.IndexOf(pid)] = name;
                shopQuantity[shopPID.IndexOf(pid)] = quantity;
                shopPrice[shopPID.IndexOf(pid)] = price;
                shopPID[shopPID.IndexOf(pid)] = pid;
            }
        }
        public void reduce(int pid, string name)
        {
            if (shopPID.IndexOf(pid) == -1) {}   //代表沒有，不用改
            else                                 //有，把它刪掉
            {
                shopName.RemoveAt(shopPID.IndexOf(pid));
                shopQuantity.RemoveAt(shopPID.IndexOf(pid));
                shopPrice.RemoveAt(shopPID.IndexOf(pid));
                shopPID.RemoveAt(shopPID.IndexOf(pid));
                shopImg.Images.RemoveByKey(name);
                //shopImg.Images.RemoveAt(shopPID.IndexOf(pid)+1);   //操RemoveAt就是爛 媽的
            }
        }
        public void Clear()
        {
            shopName.Clear();
            shopQuantity.Clear();
            shopPrice.Clear();
            shopPID.Clear();
            shopImg.Images.Clear();
        }

    }
}
