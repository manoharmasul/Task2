using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Task2
{
    interface IInt1
    {
         int add(int x,int y);
          int mult(int x,int y);
    }
    class Ch:IInt1
    {
        public int add(int x,int y)
        {
            return (x + y);
        }
        public int mult(int x,int y)
        {
            return (x * y);
        }
    }

    class Task
    {
        public static void Main()
        {
            try
            {
                List<int> li = new List<int>();

                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Ch obj = new Ch();
                li.Add(obj.add(x, y));
                li.Add(obj.mult(x, y));
                FileStream file = new FileStream(@"C:\Users\DELL\Documents\Shaurya\Text22", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(List<int>));
                xml.Serialize(file, li);
                Console.WriteLine("file is Created ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
