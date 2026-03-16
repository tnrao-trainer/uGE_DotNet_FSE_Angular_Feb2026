namespace ConsoleApp39
{    
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
		
     // Constructors using expression body
        // public Person() => Name = "";
        public Person(string name) => Name = name;
 
        // Methods using expression body
        public virtual void ShowDetails() =>  Console.WriteLine($"Name : {Name}, Age : {Age}");
             
    }
    

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }

        public Employee(int id, string name) : base(name)
        {
            EmployeeId = id;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Employee Id : {EmployeeId}, Job : {Job}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
            Employee employee = new Employee(6445454, "Narasimha Rao");
            employee.Job = "Manager";          
            employee.Age = 32;


            employee.ShowDetails();
            
            Console.ReadLine();
        }
    }
}
