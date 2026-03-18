using System.Collections.Generic; 

namespace ConsoleApp8
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
        public int Deptno { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Job: {Job}, Salary: {Salary}, DeptNo: {Deptno}";
        }
    }
    class Program
    {
   
        static void Main()
        {           
            List<Employee>  employeesList = new List<Employee>();

             // Object Initializer
            Employee e1 = new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 };
            Employee e2 = new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 };
            Employee e3 = new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 };



            employeesList.Add(e1);
            employeesList.Add(e2);
            employeesList.Add(e3);


            foreach (Employee emp in employeesList)
            {
                Console.WriteLine(emp);
            }
             

            Console.ReadLine();
        }
    }

}
