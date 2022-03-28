using System;
using System.Diagnostics;
public class Employee
{
    protected string id;
    protected string fullname;
    protected string birthday;
    protected string phone;
    protected string email;
    protected int employee_type;
    protected int employee_count;
    public Employee() { }
    public Employee(string id, string fullname, string birthday, string phone, string email, int employee_type, int employee_count)
    {
        this.id = id;
        this.fullname = fullname;
        this.birthday = birthday;
        this.phone = phone;
        this.email = email;
        this.employee_type = employee_type;
        this.employee_count = employee_count;
    }
    public string Id { 
        get { return id; }
        set { id = value; } 
    }
    public int Employee_type {
        get { return employee_type; }
        set { employee_type = value; }
    }
    public virtual string showInfo()
    {
        return GetType() + $" Id: {id}, Fullname: {fullname}, Birthday: {birthday}, Phone: {phone}, Email: {email}";
    }
}