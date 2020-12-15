using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.DAL
{
    public class EmployeeDAL
    {
        private static SqlConnection conn = DBConnection.GetConnection();
        public static Boolean Login(string username, string password)
        {
            conn.Open();
            string sql = "select count(*) from Employee where Username='"+ username +"' and Password='"+ DBConnection.HashPassword(password)+"'";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            if(dt.Rows[0][0].ToString().Equals("1"))
                return true;
            return false;
            
        }
        public static DataTable getAllEmployee()
        {
            conn.Open();
            string sql = "select * from Employee";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static bool Trung(string username)
        {
            conn.Open();
            string sql = "select count(*) from Employee where Username='" + username +"'";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            int countrow = int.Parse(dt.Rows[0][0].ToString());
            if (countrow > 0)
                return true;
            return false;
        }
        public static void addEmployee(Employee employee)
        {
            conn.Open();
            string username = employee.username;
            string firstname = employee.firstname;
            string lastname = employee.lastname;
            string gender = employee.gender;
            string address = employee.address;
            int role = employee.role;
            DateTime dob = employee.birthday;
            string password = employee.password;
            DateTime joindate = employee.joindate;

            string sql = @"INSERT INTO Employee ( [username], [password], [firstname], [lastname], [gender],[birthday],[address], [joindate], [role]) VALUES" +
            "('" + username + "','" + password + "',N'" + firstname + "',N'" + lastname +
            "','" + gender + "','" + dob + "',N'" + address + "','" + joindate + "'," + role + ")";
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void editEmployee(Employee employee)
        {
            conn.Open();
            string username = employee.username;
            string firstname = employee.firstname;
            string lastname = employee.lastname;
            string gender = employee.gender;
            string address = employee.address;
            int role = employee.role;
            DateTime dob = employee.birthday;
            DateTime joindate = employee.joindate;
            string sql = @"UPDATE Employee SET FirstName = N'"+ firstname
                                              + "', LastName = N'"+ lastname
                                              + "', Gender = '"+ gender
                                              + "', Birthday = '"+ dob
                                              + "', Address = N'"+ address
                                              + "', JoinDate = '"+ joindate
                                              + "', Role_ID = "+ role
                            +" WHERE Username = '"+ username +"'";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
