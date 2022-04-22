using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP
{
    public class IdException : Exception
    {
        const string errorId = "Id đã tồn tại trong hệ thống";
        public IdException() : base(errorId)
        {

        }
    }
}
