using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_lx
{
    class Person
    {
        public string Name { set; get; }
        public int Age { get; set; }
        public string Sex { get;set; }

        public Person() { }
        public Person(string name,int age,string sex) {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }
}
