using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO流
{
    class Program
    {
        static void Main(string[] args)
        {
           // string path = "D:\\test1";
         

            //try
            //{
            //    //判断路径是否存在
            //    if (Directory.Exists(path))
            //    {
            //        Console.WriteLine("已经存在");
            //    }
            //    else
            //    {
            //        //创建目录
            //        DirectoryInfo die = Directory.CreateDirectory(path);
            //        Console.WriteLine("创建成功");
            //        Console.WriteLine(Directory.GetCreationTime(path));

            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
                    
            //}

            ////删除目录空目录
            //// Directory.Delete(path);
            ////删除目录所有文件
            //Directory.Delete(path, true);
            ////查看目录
            //Console.WriteLine(Directory.GetCurrentDirectory());


            Console.ReadKey();
        }
    }
}
