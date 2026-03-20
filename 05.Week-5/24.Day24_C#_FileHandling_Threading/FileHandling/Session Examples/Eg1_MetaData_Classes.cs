using System.IO;

namespace ConsoleApp8 
{
    class Program
    {
        static void Main()
        {
           // string filePath = "C:\\CSharp\\File1.txt";
            string filePath = @"C:\CSharp\File1.txt";


            // 1. FileInfo

            FileInfo fileInfo = new FileInfo(filePath);

            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime.ToString());
            Console.WriteLine(fileInfo.Length);

            Console.WriteLine("------------------------------------");

            //2. DirectoryInfo
            DirectoryInfo dio = new DirectoryInfo(@"C:\CSharp\Basics");

            Console.WriteLine("Creation Time    : {0}", dio.CreationTime.ToString());
            Console.WriteLine("Parent folder    : {0}", dio.Parent);
            Console.WriteLine("Root  folder     : {0}", dio.Root);
            Console.WriteLine("No. of Files     : {0}", dio.GetFiles().Length);
            Console.WriteLine("No. of Directories     : {0}", dio.GetDirectories().Length);
          
            Console.WriteLine();


            Console.WriteLine("-----------------------------------------");
            // 3. DriveInfo 
            DriveInfo di = new DriveInfo("C:\\");
            Console.WriteLine(di.DriveType);
            Console.WriteLine(di.TotalSize);
            Console.WriteLine(di.AvailableFreeSpace);
            Console.WriteLine();


            Console.ReadLine();


        }
    }

}
