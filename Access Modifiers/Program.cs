using ClassLibrary.Models;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 =  new Employee("Elxan","Mammadli",500);
            Employee employee2 =  new Employee("Murad","Babayev",500);
            Employee employee3 =  new Employee("Zerife","Memmedov",500);
            Employee employee4 =  new Employee("Ilham","Mikayilov",500);
            Employee employee5 =  new Employee("Farid","Mustafazade",500);
            Employee employee6 =  new Employee("Eli","Ferzeliyev",500);

            Department department1 = new Department("AB101",4,1000);
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee1);
            department1.AddEmployee(employee1);

        }
    }
}