using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin A
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
               
                if (context.Student.Any())
                {
                   
                    object name = string.Name;
                }
                var Students = context.Student;
                foreach(var item in Student)
                {
                   console.writeline(context.student.item)
                }
            }
            Console.ReadKey();


        }
    }
}
