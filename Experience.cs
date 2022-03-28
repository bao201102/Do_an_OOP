using System;
using System.Collections.Generic;
public class Experience : Employee{
    private int yearOfExperience;
    private string proSkills;
    public Experience(){

    }
    public Experience(string id, string fullname, string birthday, string phone, string email, byte employee_type, int employee_count, int yearOfExperience, string proSkills) {
        this.id = id;
        this.fullname = fullname;
        this.birthday = birthday;
        this.phone = phone;
        this.email = email;
        this.employee_type = employee_type;
        this.employee_count = employee_count;
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
    }
    public override string showInfo()
    {
        return base.showInfo() + ", Year of experience: " + yearOfExperience + ", Pro skills: " + proSkills;
    }
}