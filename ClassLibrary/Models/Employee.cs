using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Employee
    {
        string _name;
        string _surname;
        float _salary;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length<=15 && NameAndSurnameTester(value) == true)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine($"{value} e yeri get ayna");
                }
            }
        }
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 5 && value.Length <= 20 && NameAndSurnameTester(value) == true)
                {
                    _surname = value;
                }
            } 
        }
        public float Salary 
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250) 
                {
                    _salary = value;
                }
                else 
                {
                    Console.WriteLine("Salary deyeri 250den asagi ola bilmez");
                }
            } 
        }
        public Employee(string name,string surname,float salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public bool LetterTester(string text)
        {
            text = text.Trim();
            byte count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) == true)
                {
                    count++;
                }
            }
            if (count == text.Length)
            {
                return true;
            }
            return false;
        }

        public bool LetterLower(string text)
        {
            text = text.Trim();
            byte count = 0; 
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsLower(text[i]) == true)
                {
                    count++;
                }
            }
            if (count == text.Length-1)
            {
                return true;
            }
            return false;
        }

        public bool NameAndSurnameTester(string text)
        {
            text = text.Trim();
            if (char.IsUpper(text[0]) == true && LetterTester(text) == true && LetterLower(text)  == true)
            {
                return true;
            }
            return false;
        }
        


    }
}
