using System;
namespace Do_an_OOP
{
    public class EmployeeType : Exception
    {
        const string errorType = "Loại nhân viên không hợp lệ";
        /*public EmployeeType() : base(errorType)
        {

        }*/
        public static void EmpType(byte s)
        {
            if (s < 0 || s > 2) 
            {
                Exception e = new EmployeeType();
                throw e;
            }
        } 
    }
}