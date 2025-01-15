using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//&&短路与   ||短路或
            Console.WriteLine("输入vm成绩");
            int vm=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入音乐成绩");
            int music=Convert.ToInt32(Console.ReadLine());
            if ((vm > 98 && music > 80) || (vm == 100 && music > 70))
            {
                Console.WriteLine("奖励");
            }*/


            /*//幸运抽奖
            Console.WriteLine("输入4位会员号：");
            int account = Convert.ToInt32(Console.ReadLine());
            //获取随机数
            Random random = new Random();
            //num为返回随机小于10的非负整数
            int num = random.Next(10);
            int bai = account / 100 % 10;
            Console.WriteLine("幸运数字是{0}", num);
            if (bai == num)
            {
                Console.WriteLine("恭喜您获得精美台历");
            }
            else
            {
                Console.WriteLine($"{account}号客户，谢谢您的支持");
            }*/

            /*//存款买车
            Console.WriteLine("请输入您的存款（万元）：");
            int money=Convert.ToInt32(Console.ReadLine());
            string level = "";
            if (money > 500)
            {
                level = "凯迪拉克";
            }
            else if (money > 100)
            {
                level = "帕沙特";
            }
            else if (money > 50)
            {
                level = "伊兰特";
            }
            else if (money > 10)
            {
                level = "奥托";
            }
            else
            {
                level = "捷安特";
            }
            Console.WriteLine("你应该买：{0}",level);*/


            /*//会员购物
            Console.WriteLine("请输入您的会员积分：");
            int score=Convert.ToInt32(Console.ReadLine());
            if (score >= 8000)
            {
                Console.WriteLine("六折");
            }else if (score >= 4000)
            {
                Console.WriteLine("七折");
            }
            else if (score >= 2000)
            {
                Console.WriteLine("八折");
            }
            else 
            {
                Console.WriteLine("九折");
            }*/


            //会员购物
            Console.WriteLine("请输入是否为会员：是（Y)/否（其他字符）");
            string str= Console.ReadLine();
            Console.WriteLine("请输入购物金额：");
            double money=Convert.ToDouble(Console.ReadLine());
            if (str == "Y"||str=="y")
            {
                if (money < 200)
                {
                    money = 0.8 * money;
                }
                else
                {
                    money = 0.75 * money;
                }
            }
            else
            {
                if (money < 100)
                {
                    money = money;
                }
                else
                {
                    money = 0.9 * money;
                }
            }
            Console.WriteLine("实际支付：{0}",money);






        }
    }
}
