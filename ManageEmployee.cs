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

        public void Add(Employee dt)
        {
            foreach (Employee item in db.Data)
            {
                if ((dt.Id).Contains(item.Id))
                {
                    System.Console.WriteLine("Id {0} đã tồn tại",dt.Id);
                }
            }
            db.Add(dt);
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
        public void MajorsSearch(string majors, List<Intern> list)
        {
            foreach (Intern i in list)
            {
                if (i.Majors == majors)
                {
                    System.Console.WriteLine("Chuyên ngành: {0} Học kỳ: {1} Trường: {2}", i.Majors, i.Semester, i.University);
                    break;
                }
            }
        }
    }
}