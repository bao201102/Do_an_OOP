using System.Diagnostics;
class Employee
{
    protected string id;
    protected string fullname;
    protected string birthday;
    protected string phone;
    protected string email;
    protected byte employee_type;
    protected int employee_count;
    public Employee() { }
    public Employee(string id, string fullname, string birthday, string phone, string email, byte employee_type, int employee_count)
    {
        this.id = id;
        this.fullname = fullname;
        this.birthday = birthday;
        this.phone = phone;
        this.email = email;
        this.employee_type = employee_type;
        this.employee_count = employee_count;
    }
    public string Id { get; set; }
    public virtual string showInfo()
    {
        return $"Id: {id}, Fullname: {fullname}, Birthday: {birthday}, Phone: {phone}, Email: {email}";
    }
}