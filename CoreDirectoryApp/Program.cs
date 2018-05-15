using System;
using System.IO;

namespace CoreDirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String dirName = Directory.GetCurrentDirectory();
            long size = 0; 
            Console.Out.WriteLine("Directory of {0} \n", dirName); 
            foreach (string filename in Directory.EnumerateFiles(dirName))
            {
                string realPath = Path.Combine(dirName, filename);
                //FileAttributes attributes = File.GetAttributes(realPath); 
                
                //DateTime FileCreationDate = File.GetCreationTime(realPath);
                FileInfo fileInfo = new FileInfo(realPath);
                size += fileInfo.Length; 
                if(fileInfo.Attributes == FileAttributes.Directory)
                {
                    Console.Out.WriteLine(" Created: {0} , <Dir> , Name: {1}", fileInfo.CreationTime.ToShortDateString(), fileInfo.Name);
                }
                else
                {
                    Console.Out.WriteLine(" Created: {0} , Size: {1} bytes, Name: {2} ", fileInfo.CreationTime.ToShortDateString(), fileInfo.Length, fileInfo.Name);
                }
              
                Console.Out.WriteLine("Total Size: {0} bytes",size);

                
            }
            Console.ReadKey(); 
                
        }
    }
}
