using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Title = "简易计算器";
            Console.Write("请输入第一个数：");
            //强制转换
            double num1=double.Parse(Console.ReadLine());
            Console.Write("请输入第二个数：");
            //强制转换
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入第三个数：");
                //强制转换
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}",num1,num2,num3,num1+ num2 + num3);
            Console.WriteLine("{0}*{1}*{2}={3}", num1, num2, num3, num1 * num2 * num3);
            Console.WriteLine("{0}-{1}-{2}={3}", num1, num2, num3, num1 - num2 - num3);
            Console.WriteLine("{0}/{1}/{2}={3}", num1, num2, num3, num1 / num2 / num3);
            Console.WriteLine("{0}%{1}={2}", num1,num2, num1%num2);*/



            /*Console.Write("请输入衬衫单价：");
            float chenShanMoney = float.Parse(Console.ReadLine());
            Console.Write("请输入衬衫个数：");
            float chenShanNum = float.Parse(Console.ReadLine());
            Console.WriteLine("商品\t单价\t个数\t");
            Console.WriteLine($"衬衫\t{chenShanMoney}\t{chenShanNum}\t");
            double sum = chenShanMoney * chenShanNum * 0.8;
            Console.WriteLine($"消费金额为:{sum}");*/

            /*
            double num1 = 43.23;
            string zhiFu = "123123";
            //强制转换1.    数据类型  变量名=（数据类型）要转换的变量名
            int num2 = (int)num1;
            Console.WriteLine(num2);
            //强制转换2.    数据类型  变量名= 数据类型.Parse(把一个数字格式的字符串强转为目标类型);
            int num3 = int.Parse(zhiFu);
            Console.WriteLine(num3);
            //强制转换3.    数据类型  变量名=Convert.ToXXX方法进行显式转换
            int num4=Convert.ToInt32(num1);
            Console.WriteLine(num4);*/


            /*//每年每天走多少米，一共80500千米
            double sumWalk = 80500;
            double yearDay = 365;
            double sumYear = 70;
            double dayWalk = sumWalk / sumYear / yearDay;
            double yearWalk = sumWalk / sumYear;
            Console.WriteLine("每天走{0:F2}千米，每年走{1:F2}千米", dayWalk, yearWalk);*/

            /*//输入的能量能兑换多少红包
            Console.WriteLine("请输入个人能量：");
            int energy=Convert.ToInt32(Console.ReadLine());
            int count = energy / 100;
            Console.WriteLine("输入的能量可以兑换{0}个红包",count);
*/
            /*//验证码
            Random random = new Random();
            int randomNum1=random.Next(0,10);
            int randomNum2=random.Next(0,10);
            Console.WriteLine("本次验证码：{0}*{1}={2}",randomNum1,randomNum2,randomNum1*randomNum2);*/

            /* //比较字符串
             Console.Write("请输入名的密码：");
             string password = "admin";
             bool flag = password == Console.ReadLine();
             Console.WriteLine(flag);*/


            /*//蛋白质总量
            int milk = 200;
            double danBaiZhi = 6.4;
            Console.WriteLine("输入购买牛奶袋数：");
            int count=Convert.ToInt32(Console.ReadLine());
            double zhiLiang=(double)count*danBaiZhi;
            Console.WriteLine("蛋白质质量：{0:f1}",zhiLiang);*/


            /*//产生鸡饲料
            Console.WriteLine("一天支付的次数：");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("一共可产生{0}g鸡饲料", count * 180);*/

            /*//出租车收费
            int qiBuJia = 10;
            int qiBuLiCheng = 2;
            double liChengJia = 2.6;
            int ranYouFei = 3;
            Console.WriteLine("请输入您的运行距离：");
            double JvLi=Convert.ToDouble(Console.ReadLine());
            double money = (double)qiBuJia + liChengJia * (JvLi - (double)qiBuLiCheng) + ranYouFei;
            double endMoney = money - money % 1 + (money % 1 > 0.5 ? 1 : 0);
            Console.WriteLine($"应收费用：{money}，实收费用：{endMoney}");*/


            /*//颠倒字符串
            Console.WriteLine("输入字符串：");
            string str=Console.ReadLine();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string chars1=new string(chars);
            Console.WriteLine($"颠倒后的字符串：{chars1}");*/

            /*//删除字符串中的空格
            string str = "   ABC  DEF";
            string str1 = str.Replace(" ", "");
            Console.WriteLine(str1);
*/


            /*//分离文件相关信息  str.Substring（开始位置，遍历长度）
            string str = "D:\\sf\\WFR\\hello.cs";
            //number2为\\的索引
            int number2 = str.LastIndexOf('\\');
            //文件路径的字符
            string wenJianLuJing=str.Substring(0,number2);
            Console.WriteLine(wenJianLuJing);
            //number1为.的索引
            int number1 = str.LastIndexOf('.');
            //扩展名的字符
            string kuoZhanMing=str.Substring(number1+1);
            int kuoZhanMing_length = kuoZhanMing.Length;
            Console.WriteLine(kuoZhanMing);
            //文件名
            string wenJianMing=str.Substring(number2+1,str.Length-number2-2-kuoZhanMing_length);
            Console.WriteLine(wenJianMing);*/


            /*//提取居民身份证的生日和性别
            Console.WriteLine("输入您的身份证号：");
            string str=Console.ReadLine();
            //提取出生日对应的字符串
            string dateTime = str.Substring(6, 8);
            //ParseExact()将字符串转换为DataTime类型
            DateTime data = DateTime.ParseExact(dateTime, "yyyyMMdd", null);
            Console.WriteLine($"生日：{data}");
            //找到代表性别的数字
            char sexNum=str.ElementAt(16);
            if (sexNum % 2 == 0)
            {
                Console.WriteLine("性别：女");
            }
            else
                Console.WriteLine("性别：男");*/




            /*//打印购物小票
            Console.Write("请输入衬衫单价：");
            float chenShanMoney = float.Parse(Console.ReadLine());
            Console.Write("请输入衬衫个数：");
            float chenShanNum = float.Parse(Console.ReadLine());
            double sum = chenShanMoney * chenShanNum;
            Console.WriteLine("*******************************");
            Console.WriteLine("商品\t单价\t个数\t金额\t");
            Console.WriteLine($"衬衫\t{chenShanMoney}\t{chenShanNum}\t{sum}\t");
            Console.WriteLine("折扣：8折");
            Console.WriteLine("消费总金额{0:C}",sum);
            Console.WriteLine("本次获得的积分：{0}", (sum / 100) * 3);*/



            Console.WriteLine("请输入4位会员卡号：");
            string str= Console.ReadLine();
            int sum= (int)str.ElementAt(0)+ (int)str.ElementAt(1)+ (int)str.ElementAt(2)+ (int)str.ElementAt(3)-192;
            Console.WriteLine(sum);
            Console.WriteLine($"会员卡{str}各位之和：{sum}");
            Console.WriteLine("是幸运客户吗？{0}", sum > 20 ?true:false);



        }
    }
}
