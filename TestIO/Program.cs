using System;
using System.IO;

namespace TestIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string homePath = "/Users/johnlundgren/";

            if (File.Exists(homePath + "john_lun_cv.pdf"))
            {
                File.Copy(homePath + "john_lun_cv.pdf", homePath + "cv.pdf", true);
            }
            else
            {
                Console.WriteLine("Exists NOT!!!!");
            }

            var fileInfo = new FileInfo(homePath + "cv.pdf");

            if(fileInfo.Exists)
            {
                Console.WriteLine("Exists!");
                fileInfo.Delete();
            }
            else
            {
                Console.WriteLine("Nooooo");
            }

            string[] files = Directory.GetFiles(homePath + "Projects", "*.sln", SearchOption.AllDirectories);
            foreach(string f in files)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine();

            string[] directories = Directory.GetDirectories(homePath + "Projects", "*", SearchOption.AllDirectories);
            foreach(string d in directories)
            {
                Console.WriteLine(d);
            }

            string fileDir = homePath + "cv.pdf";

            string extension = Path.GetExtension(fileDir);

            Console.WriteLine();

            Console.WriteLine("Extension: {0}", extension);

            string filename = Path.GetFileName(fileDir);
            Console.WriteLine("File name: {0}", filename);

            Console.WriteLine(Path.GetFileNameWithoutExtension(fileDir));

            string dirName = Path.GetDirectoryName(fileDir);
            Console.WriteLine("Directory name: {0}", dirName);
        }
    }
}
