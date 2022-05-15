using System.Globalization;
namespace Entities
{
    internal class Employee
    {
        public string name { get; set; }
        public double salario { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            this.name = vect[0];
            this.salario = double.Parse(vect[1],CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{name}, {salario}";
        }
    }
}
