using System;
using System.Configuration;

namespace ReportGenerator
{
    internal class Program
    {
        static int Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Wingman"].ConnectionString;
            var reportCreator = new ReportCreator(connectionString);

            try
            {
                string result = reportCreator.Create(args);
                Console.WriteLine(result);
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
            
        }
    }
}
