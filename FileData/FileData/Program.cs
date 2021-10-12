using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string firstArg = args[0];
                string secondArg = args[1];
                FileDetails fileDetails = new FileDetails();

                if (args[0] == "-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
                {
                    string version = fileDetails.Version(secondArg);
                    Console.WriteLine("Version is :" + version);
                }

                if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")
                {
                    int size = fileDetails.Size(secondArg);
                    Console.WriteLine("Size is :" + size);
                }

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Program failed" + ex.Message);
            }
            


           
        }
    }
}
