using System;
using System.Collections.Generic;
public class Experience : Employee
{
    private int yearOfExperience;
    private string proSkills;
    
    public Experience(string id, string fullname, string birthday, string phone, string email, int employee_type, int employee_count, int yearOfExperience, string proSkills) {
        base.id = id;
        base.fullname = fullname;
        base.birthday = birthday;
        base.phone = phone;
        base.email = email;
        base.employee_type = employee_type;
        base.employee_count = employee_count;
        this.yearOfExperience = yearOfExperience;
        this.proSkills = proSkills;
    }

    public static Employee SearchByExperience(List<Experience> listExperienceEmployee, int yearOfExperience) {
        for(int i = 0; i < listExperienceEmployee.Count ; i++) {
            if(yearOfExperience == listExperienceEmployee[i].yearOfExperience) {
                return listExperienceEmployee[i];
            }
        }
        return null;
    }

    public static Employee SearchByProskills(List<Experience> listExperienceEmployee, string proSkills) {
        for(int i = 0; i < listExperienceEmployee.Count ; i++) {
            if(proSkills == listExperienceEmployee[i].proSkills) {
                return listExperienceEmployee[i];
            }
        }
        return null;
    } }

namespace Do_an_OOP
{
    public class Experience : Employee

    {
        private int yearOfExp;
        private string proSkills;

        public int YearOfExp { get { return yearOfExp; } set { yearOfExp = value; } }
        public Experience(string id, string fullname, string birthday, string phone, string email, byte employee_type, int yearOfExp, string proSkills)
        {
            base.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
            this.yearOfExp = yearOfExp;
            this.proSkills = proSkills;
        }

        //public static Employee SearchByExperience(List<Experience> listExperienceEmployee, int yearOfExperience)
        //{
        //    for (int i = 0; i < listExperienceEmployee.Count; i++)
        //    {
        //        if (yearOfExperience == listExperienceEmployee[i].yearOfExp)
        //        {
        //            return listExperienceEmployee[i];
        //        }
        //    }
        //    return null;
        //}

        //public static Employee SearchByProskills(List<Experience> listExperienceEmployee, string proSkills)
        //{
        //    for (int i = 0; i < listExperienceEmployee.Count; i++)
        //    {
        //        if (proSkills == listExperienceEmployee[i].proSkills)
        //        {
        //            return listExperienceEmployee[i];
        //        }
        //    }
        //    return null;
        //}

        public override string ToString()
        {
            return base.showInfo() + ", Year of experience: " + yearOfExp + ", Pro skills: " + proSkills;
        }
    }
}