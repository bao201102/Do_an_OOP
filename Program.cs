using System;
using System.Text;

namespace Do_an_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetWindowSize(180, 40);
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.ShowAllEmp();
            manageEmployee.ShowEmpSalary(manageEmployee.FindByType(2));
        }
    }
}
