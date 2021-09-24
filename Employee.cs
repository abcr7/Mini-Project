using System;
using System.Data.SqlClient;
namespace AppraisalFunction
{
    public class Employee
    {
        public string constr;
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;

        public static void CreateConnection()
        {
            string constr = "Data Source=DESKTOP-V0H434T\\SQLEXPRESS; Initial Catalog=TCompany ; Integrated Security= true";
            con = new SqlConnection();
            con.ConnectionString = constr;

        }
        public static void InsertData(int EmployeeId, string EmployeeName, string Gender, string ContactNo, string DepartmentId, string DepartmentName, string CurrentRole, string NewRole, int AppraisalNo)
        {
            con.Open();
            string query = "insert into Employee values ('" + EmployeeId + "','" + EmployeeName+ "','" + Gender + "'," + ContactNo + ",'" + DepartmentId + "','"+DepartmentName+"','"+CurrentRole+"','"+NewRole+"','"+AppraisalNo+"')";
            cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} Record Inserted Successfully", r);
            con.Close();

        }
        public static void DisplayData()
        {
            con.Open();
            string query = "Select * from Employee";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("EmployeeId\t EmployeeName\t Gender\t ContactNo\t DepartmentId\t DepartmentName\t CurrentRole\t NewRole\t AppraisalNo");
            while (dr.Read())
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t {7}\t {8} ", dr["EmployeeId"], dr["EmployeeName"], dr["Gender"], dr["ContactNo"], dr["DepartmentId"], dr["DepartmentName"], dr["CurrentRole"], dr["NewRole"], dr["AppraisalNo"]);
            }
            dr.Close();
            con.Close();
        }
        public static void HigherAppraisalData()
        {
            con.Open();
            string query = "Select EmployeeId, EmployeeName, DepartmentId, DepartmentName, CurrentRole From Employee Where AppraisalNo=2";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("empid\t empname\t did\t dname\t cr");
            while (dr.Read())
            {
                Console.WriteLine("{0} \t   {1}   \t   {2}   \t   {3}  \t  {4} ", dr["EmployeeId"], dr["EmployeeName"], dr["DepartmentId"], dr["DepartmentName"],dr["CurrentRole"]);
            }
            dr.Close();
            con.Close();
        }
        public static void UpdateData(string NewRole, int id, int AppraisalNo)
        {
            con.Open();
            string query = "update Employee Set CurrentRole='" + NewRole + "',NewRole='" + NewRole + "', ApparaisalNo='" + AppraisalNo + "'Where EmployeeId='" + id + "'";
            cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} Record Updated", r);
            con.Close();
        }
        public static void DeleteData(int id)
        {
            con.Open();
            string query = "Delete From Employee Where EmployeeId='" + id + "' ";
            cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} Row,s Affected", r);
            Console.WriteLine("{0} Row,s Affected", r);
            con.Close();
        }
    }
}

