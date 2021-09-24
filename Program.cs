using System;
using AppraisalFunction;

namespace AppraisalHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            int empid, appno, i, ch;
            string empname, gen, cn, did, dname, cr, nr;
            //Console.WriteLine("Confirm Your Validation");
            //Console.Write("UserName: ");
            //string UserName = Console.ReadLine();
            //Console.Write("Pass: ");
            //string PassWord = Console.ReadLine();
            Employee.CreateConnection();
            Console.WriteLine("Connection Successful");
            Console.WriteLine("         Welcome to T-Company        ");
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 to check the details of an employee");
            Console.WriteLine("2 to add new data");
            Console.WriteLine("3 to update the data");
            Console.WriteLine("4 to higherappraisal employee's data");
            Console.WriteLine("5 to delete the data");
            Console.WriteLine("Press Y to continue");
            do
            {
                Console.WriteLine("Enter Your Choice");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        
                        Employee.DisplayData();
                        break;
                    case 2:

                        Console.WriteLine("Enter Your Details");
                        Console.Write("Enter EmployeeId : ");
                        empid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter EmployeeName : ");
                        empname = Console.ReadLine();
                        Console.Write("Enter Gender : ");
                        gen = Console.ReadLine();
                        Console.Write("Enter ContactNo : ");
                        cn = Console.ReadLine();
                        Console.Write("Enter DepartmentId : ");
                        did = Console.ReadLine();
                        Console.Write("Enter DepartmentName : ");
                        dname = Console.ReadLine();
                        Console.Write("Enter CurrentRole : ");
                        cr = Console.ReadLine();
                        Console.Write("Enter NewRole : ");
                        nr = Console.ReadLine();
                        Console.Write("Enter AppraisalNo : ");
                        appno = Convert.ToInt32(Console.ReadLine());
                        Employee.InsertData(empid, empname, gen, cn, did, dname, cr, nr, appno);
                        break;
                    case 3:

                        Console.Write("Enter EmployeeId : ");
                        empid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter NewRole : ");
                        nr = Console.ReadLine();
                        Console.Write("Enter AppraisalNo : ");
                        appno = Convert.ToInt32(Console.ReadLine());
                        Employee.UpdateData(nr,empid, appno);
                        break;
                    case 4:

                        Console.WriteLine("Employees List Who Are Intern Now Managers");
                        Employee.HigherAppraisalData();
                        break;
                    case 5:

                        Console.Write("Enter EmployeeId : ");
                        empid =Convert.ToInt32(Console.ReadLine());
                        Employee.DeleteData(empid);
                        break;
                }
                Console.Write("Want To Revisit The Data Press Y :");
                ch = Convert.ToInt32(Console.ReadLine());
            }
            while (ch == 'Y');
            Console.Read();

        }
    }
}
