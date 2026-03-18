using System.Collections.Generic; 

namespace ConsoleApp8
{ 
    class Program
    {
        static void DisplayList(List<string> listObj)
        {
            Console.WriteLine($"No. of Cities : {listObj.Count}");

            Console.Write("City Names  : ");
            foreach (string item in listObj)
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            List<string> cityList = new List<string>();

            cityList.Add("Hyderabad");
            cityList.Add("Mumbai");
            cityList.Add("New Delhi");
            cityList.Add("Kolkata");

           DisplayList(cityList);

          
            cityList.Add("Chennai");
            cityList.Add("Goa");
            DisplayList(cityList);

           
            cityList.Remove("Chennai");
            cityList.RemoveAt(0);
            DisplayList(cityList);


            cityList.Clear();
            DisplayList(cityList);
            

            Console.ReadLine();
        }
    }

}
