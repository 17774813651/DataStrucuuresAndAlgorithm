using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 百钱百鸡
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cock, Hen, Chick;
            //For循环版本百钱百鸡
            for (Cock = 0; Cock < 19; Cock++)   //因为公鸡最大不会超过19只,所以最多循环19次.
            {
                for (Hen = 0; Hen < 33; Hen++)  //母鸡最大也不会超过33次,所以最多循环33次
                {
                    Chick = 100 - Cock - Hen;  //小鸡等于100 - 公鸡个数 -  母鸡个数
                    if (Cock * 5 + Hen * 3 + Chick / 3 == 100)  // 判断三种鸡乘以单价的总数是否等于100元
                    {
                        Console.WriteLine("公鸡有:{0}只, 母鸡有:{1}, 小鸡有:{2}", Cock, Hen, Chick);
                    }
                }
            }

            Console.WriteLine("................................................................................");
            Console.Read();
        }
    }
}
