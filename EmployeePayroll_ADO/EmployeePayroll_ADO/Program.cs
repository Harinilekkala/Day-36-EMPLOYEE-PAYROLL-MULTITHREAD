// See https://aka.ms/new-console-template for more information
using System;

namespace EmployeePayroll_ADO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepo getMethod = new EmployeeRepo();
            getMethod.Connectivity();
        }
    }
}

