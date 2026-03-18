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
            // Collection Initializer
            List<Employee> empList = new List<Employee>()
            {
                   new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                   new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                   new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 }
            };


            // LINQ

            var  q1 =  from emp in empList
                       where emp.Deptno == 20
                       orderby emp.Salary descending
                       select emp;


            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            



            Console.ReadLine();
        }
    }

}
