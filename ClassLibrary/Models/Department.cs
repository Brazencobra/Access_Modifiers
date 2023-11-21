using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Department
    {
        string _name;
        int _employeeLimit;
        float _salaryLimit;
        Employee[] _employees;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            } 
        }
        public int EmployeeLimit 
        {
            get
            {
                return _employeeLimit;
            }
            set
            {
                _employeeLimit = value;
            } 
        }   
        public float SalaryLimit 
        {
            get
            {
                return _salaryLimit;
            }
            set
            {
                _salaryLimit = value;
            }
        }
        public Employee[] Employees 
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
            } 
        }

        public Department(string name,int employeelimit,float salarylimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
            SalaryLimit = salarylimit;
            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.Salary <= SalaryLimit && Employees.Length < EmployeeLimit)
            {
                Array.Resize(ref _employees,Employees.Length + 1);
                Employees[Employees.Length-1] = employee;
                Console.WriteLine($"Name : {employee.Name}\nSurname : {employee.Surname}\nSalary : {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Isci elave edilmedi");
            }
        }

    }
}
