using System.Collections.Generic;
class ManageEmployee
{
    List<Employee> employees = new List<Employee>();
    public List<Employee> Employees { get; set; }
    public ManageEmployee()
    {
        employees = new List<Employee>();
    }
    public static List<Employee> findId(ManageEmployee data, string id)
    {
        // ManageEmployee emp = new ManageEmployee();
        List<Employee> listEmp = new List<Employee>();
        foreach (Employee item in data.Employees)
        {
            if (item.Id.Contains(id))
            {
                listEmp.Add(item);
            }
        }
        return listEmp;
    }
    public static List<Employee> findByType(ManageEmployee data, int type) {
        List<Employee> listEmp = new List<Employee>();
        foreach (Employee item in data.Employees)
        {
           if (item.Employee_type == type)
            {
                listEmp.Add(item);
            }
        }
        return listEmp;
    }
}