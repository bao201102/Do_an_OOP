using System;
using System.Text;

namespace Do_an_OOP
{
    class Program
    {
        static void Add(string email)
        {
            if (!email.Contains('@')) 
            {
                Exception e = new EmailException();
                throw e;
            }
            else System.Console.WriteLine("Email hợp lệ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            //Console.SetWindowSize(180, 40);
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Database db = new Database();
            string username = "admin";
            string password = "123";
            if(db.query4Login(username, password)) {
                System.Console.WriteLine("Đăng nhập thành công");
                ManageEmployee manageEmployee = new ManageEmployee();
                manageEmployee.ShowAllEmp();
                manageEmployee.ShowEmpSalary(manageEmployee.FindByType(2));
                manageEmployee.ShowEmpSalary(manageEmployee.FindByType(0));
                manageEmployee.Edit();
            }else {
                System.Console.WriteLine("Đăng nhập không thành công");
            }
            string email = "abcadada";
            try
            {
                Add(email);
            }
            catch (EmailException e)
            {
                System.Console.WriteLine(e.Message);
            }
        } 
    }
}
