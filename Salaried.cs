namespace Lab2OOP2
{
    public class Salaried : Employee
    {
        private double Salary { get; set; }
        private string Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private long Sin { get; set; }
        private string Dob { get; set; }
        private string Department { get; set; }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string department, double salary) : base(id, name, address, phone, sin, dob, department)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Sin = sin;
            Dob = dob;
            Department = department;
            Salary = salary;
        }

        public void Gettter()
        {
            
        }

        public void Setter()
        {
            
        }

        public double GetPay()
        {
            double pay;
            pay = Salary;
            return pay;
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
                $"{Environment.NewLine}Department: {Department}" +
                $"{Environment.NewLine}Salary: {Salary}";
        }
    }
}
