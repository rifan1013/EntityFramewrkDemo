using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext(@"Data Source=LAPTOP-UR4UBIL\SQLEXPRESS;Initial Catalog=NoteBook;Integrated Security=True");
            var provider = new EmployeeProvider(context); 
            var employee = provider.Get(1);
            Console.WriteLine($"welcome{employee.FirstName}{employee.LastName}");

            var repo = new EmployeeRepo(context);
            var employee = provider.Get(2);
            employee1.FirstName = "NewFirst";
            repo.Update(employee1);
        }
    }
}
