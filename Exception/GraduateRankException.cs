using System;
namespace Do_an_OOP
{
    public class GraduateRankException : Exception
    {
        const string errorRank = "Trình độ nhân viên không hợp lệ";
        public GraduateRankException() : base(errorRank)
        {

        }
    }
}