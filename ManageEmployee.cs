using System;
using System.Collections.Generic;

namespace Do_an_OOP
{
    public class ManageEmployee
    {
        Database db = new Database();

        public ManageEmployee()
        {

        }

        public void Add(Employee e)
        {
<<<<<<< HEAD
            db.Add(e);
=======
            foreach (Employee item in db.Data)
            {
                if ((dt.Id).Contains(item.Id))
                {
                    System.Console.WriteLine("Id {0} đã tồn tại", dt.Id);
                    return;
                }
            }
            db.Add(dt);
>>>>>>> 5bac65e5c0e056f18a39867570bb5cf11bed4a69
        }
        public void ShowAllEmp()
        {
            foreach (Employee item in db.Data)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowEmpInfo(List<Employee> listEmp)
        {
            foreach (Employee item in listEmp)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowEmpSalary(List<Employee> listEmp)
        {
            foreach (Employee item in listEmp)
            {
                Console.WriteLine(item.ShowSalary());
            }
        }
        public List<Employee> FindId(string id)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Contains(id))
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }
        public List<Employee> FindByType(byte type)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item.Employee_type == type)
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }
        public List<Employee> FindByExp(int yearOfExp)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
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
            return listEmp;
        }
        public List<Employee> FindBySkills(string proSkill)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Experience != null)
                {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.ProSkills.Contains(proSkill))
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }
        public List<Employee> FindByGraRank(byte graRank)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Fresher != null)
                {
                    Fresher tempEmp = (Fresher)item;
                    if (tempEmp.GraRank == graRank)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }
        public List<Employee> FindByMajors(string majors)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Intern item in db.Data)
            {
                if (item as Intern != null)
                {
                    Intern tempEmp = (Intern)item;
                    if (tempEmp.Majors == majors)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }
    }
}