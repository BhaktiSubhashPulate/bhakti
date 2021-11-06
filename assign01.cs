using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    int ID;
    string Name;
    int Age;
    int Salary;

    public override string ToString()
    {
        return base.ToString();
        return ID + " " + Name + " " + Age + " " + Salary;
    }
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee {ID=101, Name="Bhakti", Age=23, Salary=6000},
            new Employee {ID=102, Name="Sayali", Age=24, Salary=7000},
            new Employee {ID=103, Name="Ragini", Age=25, Salary=8000},
            new Employee {ID=104, Name="Swapnali", Age=24, Salary=6000},

        };
        IEnumerable<Employee> Query =
            from emp in employees
            where emp.Salary > 5000
            select emp;

        Console.WriteLine("ID  NAME  AGE  Salary");
        Console.WriteLine("        ");

        foreach (Employee s in Query)
        {
            Console.WriteLine(s.ToString());
        }
        Console.WriteLine("         ");

        Console.ReadLine();
    }
}
 
        
        
    
