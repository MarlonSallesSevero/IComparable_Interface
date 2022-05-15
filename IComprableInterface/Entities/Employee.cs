/* 
 *Less than zero	The current instance precedes the object specified by the CompareTo method 
in the sort order.
 
 *Zero	This current instance occurs in the same position in the sort order as the object specified
by the CompareTo method.

 *Greater than zero	This current instance follows the object specified by the CompareTo method in 
the sort order.*/

using System;
using System.Globalization;
namespace Entities
{
    internal class Employee : IComparable
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

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Obj is not a Employee");
            }
            Employee other = obj as Employee; //down casting
            return salario.CompareTo(other.salario); //compareTo o atual com o other
        }
    }
}
