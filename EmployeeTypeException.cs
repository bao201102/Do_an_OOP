using System;
namespace Do_an_OOP
{
    public class EmployeeTypeException : Exception
    {
        const string errorType = "Loại nhân viên không hợp lệ";
        public EmployeeTypeException() : base(errorType)
        {

        }
    }
}