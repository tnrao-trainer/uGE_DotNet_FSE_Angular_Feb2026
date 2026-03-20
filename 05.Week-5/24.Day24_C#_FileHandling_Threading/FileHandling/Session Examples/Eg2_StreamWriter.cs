using System.IO;

namespace ConsoleApp8 
{
    class Program
    {
        static void Main()
        {

            string dirName = "Logs";

            if (Directory.Exists(dirName) == false)
            {
                Directory.CreateDirectory(dirName);
            }


            string logFilePath = Path.Combine(dirName, "activity_log.txt");

            StreamWriter streamWriter = new StreamWriter(logFilePath);
            streamWriter.WriteLine("Hello World-1");
            streamWriter.WriteLine("Hello World-2");
            streamWriter.Close();

            Console.WriteLine("Content written onto the file successfully");

            Console.ReadLine();


        }
    }

}
