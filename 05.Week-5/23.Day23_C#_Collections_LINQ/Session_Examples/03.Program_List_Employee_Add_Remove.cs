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


            Employee e1  = new Employee() { Id = 4, Name = "Smith", Job = "Analyst", Salary = 60000, Deptno = 20 };
            empList.Add(e1);

            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("-------------------------");

            int eid = 4;
            Employee obj = empList.Find(e  => e.Id == eid);

            if (obj != null)
            {
                empList.Remove(obj);
                Console.WriteLine($"Employee Id : {eid}, removed successfully from List");
            }
            else
            {
                Console.WriteLine($"Employee Id : {eid} does not exists");
                Console.ReadLine();
                return;
            }


            

            Console.ReadLine();
        }
    }

}
