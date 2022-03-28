using System;
using System.Collections.Generic;

namespace Do_an_OOP
{
    public class ManageEmployee
    {
        private List<Employee> employees = new List<Employee>();

        public ManageEmployee()
        {
            employees.Add(new Experience("01", "A", "15/5/2002", "09xxx", "@", 0, 5, "C#"));
        }
        public static List<Employee> findId(List<Employee> list, string id)
        {
            // ManageEmployee emp = new ManageEmployee();
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in list)
            {
                if (item.Id.Contains(id))
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }
        public static List<Employee> findByType(List<Employee> list, int type)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in list)
            {
                if (item.Employee_type == type)
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }
        public void findbyExp(int yearOfExp)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in employees)
            {
                if (item as Experience != null)
                {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.YearOfExp == yearOfExp)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            foreach (Employee item in listEmp)
            {
                Console.WriteLine(item);
            }
        }
    }
}