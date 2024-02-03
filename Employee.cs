namespace Lab2OOP2;

public class Employee
{
    private string Id { get; set; }
    public string Name { get; set; }
    private string Address { get; set; }
    private string Phone { get; set; }
    private long Sin { get; set; }
    private string Dob { get; set; }
    private string Department { get; set; }

    public Employee(string id, string name, string address, string phone, long sin, string dob, string department)
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
        Sin = sin;
        Dob = dob;
        Department = department;
    }

    public void Getters()
    {
        
    }

    public void Setters()
    {
        
    }

    public override string ToString()
    {
        return
            $"Id: {Id}" +
            $"{Environment.NewLine}Name: {Name}" +
            $"{Environment.NewLine}Address: {Address}" +
            $"{Environment.NewLine}Phone: {Phone}" +
            $"{Environment.NewLine}SIN: {Sin}" +
            $"{Environment.NewLine}Date Of Birth: {Dob}" +
            $"{Environment.NewLine}Department: {Department}";
    }
}