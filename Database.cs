using System.Data.Common;
using System.Collections.Generic;
public sealed class Database{
    private List<Employee> data = new List<Employee>();
    
    public Database()
    {
        data.Add("01","A","15/5/2002","09xxx","@",0);
        data.Add("02","A","15/5/2002","09xxx","@",1);
        data.Add("03","A","15/5/2002","09xxx","@",2);
    }
}