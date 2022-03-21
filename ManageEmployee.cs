using System.Collections.Generic;
class ManageEmployee
{
    List<Employee> employees = new List<Employee>();
    public List<Employee> Employees { get; set; }
    public ManageEmployee()
    {
        employees = new List<Employee>();
    }
    public ManageEmployee findId(ManageEmployee data, string id)
    {
        ManageEmployee emp = new ManageEmployee();
        foreach (Employee item in data.Employees)
        {
            if (item.Id.Contains(id))
            {
               // emp.Add(item);
            }
        }
        return emp;
    }
}