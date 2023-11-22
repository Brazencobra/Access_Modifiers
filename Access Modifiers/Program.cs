using ClassLibrary.Models;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Employee class
             - Name
             - Surname
             - Salary


            Department class
             - Name
             - EmployeeLimit
             - SalaryLimit
             - [] Employees
             - AddEmployee()


             Employee ve Department classlarını ClassLibrary-de yazın. Employee Name və Surname dəyərləri yalnız hərflərdən ibarət olmalıdır və böyük hərflə başlamalıdır. Salary dəyəri 250-dən aşağı ola bilməz. AddEmployee metodu employees array-e employee obyekti əlavə etmək üçündür.*/

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