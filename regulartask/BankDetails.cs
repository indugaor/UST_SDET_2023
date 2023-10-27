﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetails
    {
        
        public BankDetails()
        {
            Custid = 0;
            Accno = 0;
            Name = string.Empty;
            Status = "Inactive";
               }
        
        public BankDetails(int custid, long accno, string? name, string? status)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = status;
        }
        

        public int Custid { get; set; }
        public long Accno { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }
        public void GetAccDetails(int custid)
        {
            if (Custid == custid)
                Console.WriteLine("Accno: {0}\t Name: {1}\t Status: {2}", Accno, Name, Status);
            else Console.WriteLine("Custid does not exist");
        }
        public void GetAccDetails(long accno)
        {
            if (Accno == accno)
                Console.WriteLine("Accno: {0}\t Name: {1}\t Status: {2}", Accno, Name, Status);
            else Console.WriteLine("Custid does not exist");

        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("Accno: {0}\t Name: {1}\t Status: {2}", Accno, Name, Status);
            else Console.WriteLine("Custid does not exist");

        }
    } 

}
