using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignemnt02
{
    internal class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public SecurityLevel securityLevel { get; set; }
        public decimal salary { get; set; }
        public  Date HireDate { get; set; }
        public  Gender gender { get; set; }

        public override string ToString()
        {
            return $"   id: {Id} Name :{Name} Security Level is :{securityLevel} salary is: {salary:C}" +
                $"Hire Date is :{HireDate.day}/{HireDate.month}/{HireDate.year} Gender is :{gender}";
        }
    }
}
