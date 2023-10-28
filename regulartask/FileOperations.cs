using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi=new
            FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter str=fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("hello There");
            str.WriteLine("Hi");
            Console.WriteLine("Written");
        
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample2.txt",FileMode.CreateNew,FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            Console.WriteLine("Enter the text which" + "you want to write to the file");
            string str=Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str=sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fi2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample2.txt");
            fi1.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\temp1"+"Smaple.txt");
            fi2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\temp2"+"Sample2.txt");
        }
        
        public void DeleteFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            fi1.Delete();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\"+"Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.LastWriteTime);
        }
        
    }
}
