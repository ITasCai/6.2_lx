using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            //属性
            Person person = new Person();
            person.Name = "狗蛋";
            person.Age = 22;
            person.Sex = "男";
            //构造函数
            Person person1 = new Person("张三",18,"男");
            Console.WriteLine(person.Name + "  " + person.Age + "   " + person.Sex);
            Console.WriteLine(person1.Name+"  "+person1.Age+"   "+person1.Sex);

            //对象初始化器
            Person person2 = new Person
            {
                Name = "王五",
                Age = 17,
                Sex="男"
                
            };



            int[] array = new int[] { 1, 2, 3 };
            Person[] aray2 = { new Person {Name = "赵六",  Age = 27, Sex="男" },
                new Person("天机",55,"女"),
                new Person (){Name = "赵蛋",  Age = 27, Sex="男" }
            };

            foreach (Person item in aray2)
            {
                Console.WriteLine(item.Name+" "+item.Age+" "+item.Sex);
            }

            //List<string> list = new List<string>(new string[] { "1","2","3"});
            //List<int> myIntCollection = new List<int> { 5, 9, 10, 2, 99 };


            Console.WriteLine("-----------------------------------------");
            //Add添加
            List<Person> li = new List<Person>();
            li.Add(new Person("天单", 55, "女"));
            li.Add(new Person { Name="嘎嘎龙", Age= 5,Sex= "公"});


            ///集合初始化器
            List<Person> li1 = new List<Person> {
               
                new Person ("天机",55,"女"),

                new Person {
                     Name = "赵蛋",
                     Age = 27,
                     Sex ="男"
                 }
            };

            foreach (Person item in li1)
            {
                Console.WriteLine(item.Name + " " + item.Age + " " + item.Sex);
            }


            #region 匿名类型



            #endregion

            Console.ReadKey();
        }
    }
}
