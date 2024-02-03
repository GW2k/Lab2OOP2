namespace Lab2OOP2
{
    public class Wages : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }
        private string Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
        private long Sin { get; set; }
        private string Dob { get; set; }
        private string Department { get; set; }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string department,
            double rate, double hours) : base(id, name, address, phone, sin, dob, department)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Sin = sin;
            Dob = dob;
            Department = department;
            Rate = rate;
            Hours = hours;
        }
        public void Getters(){}
        public void Setters(){}

        public double GetPay()
        {
            double pay;
            pay = (Rate * Hours);
            if (Hours > 40)
            {
                double rem = Hours - 40;
                double payTime = Rate + (Rate / 2);
                pay = (Rate * Hours) + (payTime * rem);
            }

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
                $"{Environment.NewLine}Salary: {Rate}" +
                $"{Environment.NewLine}Hours: {Hours}";
        }
    }
}