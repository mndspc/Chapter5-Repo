using System;
using System.Collections.Generic;


namespace ArrayAndCollections
{
    //  This program Demo. how List<T> can maintain user defined types.
    class GenericListWithUserDefinedType
    {
        static void Main()
        {
            Employee emp1 = new Employee {EmpCode=100,EmpName="Scott",Email="scott@gmail.com" };
            Employee emp2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            Employee emp3 = new Employee { EmpCode = 102, EmpName = "Smith", Email = "smith@gmail.com" };

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            foreach(var emp in employeeList)
            {
                Console.WriteLine("Code={0} Name={1} Email={2}",emp.EmpCode,emp.EmpName,emp.Email);
            }
            Console.ReadLine();
        }
    }
}
