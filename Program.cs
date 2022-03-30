using System;
using System.Text;

namespace Do_an_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "gioi", 4, "UEH"));
            manageEmployee.ShowAllData();
        }
    }
}
