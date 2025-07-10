namespace OOPAssignemnt02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = 
            {   new  Employee{Id=1, Name="ahemd",securityLevel=(SecurityLevel)8,salary=5000,gender=Gender.Male,HireDate=new Date{day=1,month=1,year= 2024}, },
                new Employee{Id=2,Name="Rana",securityLevel=(SecurityLevel)1,salary=9000,gender=Gender.Female,HireDate=new Date{day=2,month=3,year=2022}, },
                new Employee{Id=3,Name="Galal",securityLevel=(SecurityLevel)15,salary=2000,gender=Gender.Male,HireDate=new Date{day=4,month=5,year=2020}, }
            };
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }




        }
    }
}
