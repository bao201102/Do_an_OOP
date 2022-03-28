using System;
using System.Collections.Generic;

    public class Intern
    {
        public string majors;
        public int semester;
        public string university;
        public string getMajors
        {
            get 
            {
                return majors;
            }
            set
            {
                majors = value;
            }
        }
        public int getSemester
        {
            get 
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        public string getUniversity
        {
            get 
            {
                return university;
            }
            set
            {
                university = value;
            }
        }
        public Intern(string majors,int semester,string university)
        {
            this.majors = majors;
            this.semester = semester;
            this.university = university;
        }
        public void MajorsSearch(string majors,List<Intern> list)
        {
            foreach (Intern i in list)
            {
                if (i.getMajors == majors) 
                {
                    System.Console.WriteLine("Chuyên ngành: {0} Học kỳ: {1} Trường: {2}",i.getMajors,i.getSemester,i.getUniversity);
                    break;
                }
            }
        }
    
}