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
            
            manageEmployee.ShowAllData();
        }
    }
}
