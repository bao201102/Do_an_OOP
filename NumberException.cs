using System;
namespace Do_an_OOP
{
    public class NumberException : Exception
    {
        //birthday, phone, email, employeeType(0-2), Grarank(0-3)
        const string errorNumber = "Số điện thoại quá dài";
        public NumberException() : base(errorNumber)
        {
            
        }
    }
}