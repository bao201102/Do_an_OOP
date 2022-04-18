using System;
namespace Do_an_OOP
{
    public class NumberPhoneException : Exception
    {
        const string errorNumber = "Số điện thoại quá dài";
        public NumberPhoneException() : base(errorNumber)
        {

        }
    }
}