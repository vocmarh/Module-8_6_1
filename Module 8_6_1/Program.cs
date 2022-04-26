using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_8_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\s.hramcov\YandexDisk\UDevelopment\Test\Test");
            string[] fileList = Directory.GetFiles(@"C:\Users\s.hramcov\YandexDisk\UDevelopment\Test\Test");
            try
            {
                if (directoryInfo.Exists)
                {
                    if (directoryInfo.LastAccessTime < DateTime.Now.AddMinutes(-30))
                    {
                        Console.WriteLine("Папка удалится через 30 минут");
                        directoryInfo.Delete();
                    }  
                    
                    //if (File.GetLastAccessTime < )
                    //{
                    //    foreach (string file in fileList)
                    //    {
                    //        File.Delete(file);
                    //    }
                    //}
                    
                }
                
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
