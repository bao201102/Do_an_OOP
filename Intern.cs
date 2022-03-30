using System;
using System.Collections.Generic;

public class Intern : Employee
{
    public string majors;
    public int semester;
    public string university;
    public string getMajors
    {
        get { return majors; }
        set { majors = value; }
    }
    public int getSemester
    {
        get { return semester; }
        set { semester = value; }
    }
    public string getUniversity
    {
        get { return university; }
        set { university = value; }
    }
    public Intern(string id, string fullname, string birthday, string phone, string email, int employee_type, string majors, int semester, string university)
    {
        base.id = id;
        base.fullname = fullname;
        base.birthday = birthday;
        base.phone = phone;
        base.email = email;
        base.employee_type = employee_type;
        this.majors = majors;
        this.semester = semester;
        this.university = university;
    }
    public void MajorsSearch(string majors, List<Intern> list)
    {
        foreach (Intern i in list)
        {
            if (i.getMajors == majors)
            {
                System.Console.WriteLine("Chuyên ngành: {0} Học kỳ: {1} Trường: {2}", i.getMajors, i.getSemester, i.getUniversity);
                break;
            }
        }
    }

}