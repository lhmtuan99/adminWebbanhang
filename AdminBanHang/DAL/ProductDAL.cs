using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AdminBanHang.DTO;

namespace AdminBanHang.DAL
{
    class ProductDAL
    {
        public static DataTable GetAllProduct()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Product, Type, Company where Product.Company_ID = Company.Id and Type.Id = Company.Type_Id";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static List<Types> GetAllType()
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Type";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Types> list = new List<Types>();
                foreach (DataRow item in dt.Rows)
                {
                    Types type = new Types();
                    type.Id = item.Field<int>("Id");
                    type.TypeName = item.Field<string>("TypeName");
                    list.Add(type);
                }
                conn.Close();
                return list;
            }    
        }

        public static List<Company> GetAllCompany()
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Company";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Company> list = new List<Company>();
                foreach (DataRow item in dt.Rows)
                {
                    Company company = new Company();
                    company.Id = item.Field<int>("Id");
                    company.CompanyName = item.Field<string>("CompanyName");
                    list.Add(company);
                }
                conn.Close();
                return list;
            }
        }

        public static List<Company> GetCompany(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Company WHERE Id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Company> list = new List<Company>();
                foreach (DataRow item in dt.Rows)
                {
                    Company company = new Company();
                    company.Id = item.Field<int>("Id");
                    company.CompanyName = item.Field<string>("CompanyName");
                    list.Add(company);
                }
                conn.Close();
                return list;
            }
        }
        public static List<Types> GetTypes(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select * from Type WHERE id=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Types> types = new List<Types>();
                foreach (DataRow item in dt.Rows)
                {
                    Types type = new Types();
                    type.Id = item.Field<int>("id");
                    type.TypeName = item.Field<string>("TypeName");
                    types.Add(type);
                }
                conn.Close();
                return types;
            }
        }

        public static string pathImage(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "select Image from product where Id="+id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                return dt.Rows[0][0].ToString();
            }    
        }
        public static void AddProduct(Product product)
        {
            using(SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string productname = product.productname;
                string image = product.image;
                int amount = product.amount;
                int price = product.price;
                string detail = product.detail;
                int company_id = product.companyid;

                string sql = @"INSERT INTO Product VALUES" +
                                "(N'" + productname + "'," + company_id + "," + amount + "," + price +
                                ",N'" + detail + "',N'" + image +"')";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }    
        } 
        public static void EditProduct(Product product, int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string productname = product.productname;
                string image = product.image;
                int amount = product.amount;
                int price = product.price;
                string detail = product.detail.Replace("'","\"");
                int company_id = product.companyid;
                string sql = @"UPDATE Product SET Productname = N'" + productname
                                                  + "', Company_ID = " + company_id
                                                  + ", Amount = " + amount
                                                  + ", Price = " + price
                                                  + ", Detail = N'" + detail
                                                  + "', Image = N'" + image
                            + "' WHERE Id =" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }    
        }
        public static void EditProduct(int amount, int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "";
                sql = "select amount from Product where Id = " + id;
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                int sl = int.Parse(dt.Rows[0][0].ToString()) - amount;
                sql = @"UPDATE Product SET Amount = " + sl
                            + " WHERE Id =" + id;
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void DeleteProduct(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Product WHERE Id= " + id;
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }    
        }
        public static DataTable Search(int idtype, int idcom, string text)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string t, c;
                if (idtype == 0) t = "";
                else t = idtype.ToString();
                if (idcom == 0) c = "";
                else c = idcom.ToString();
                string sql = "select * from Product, Type, Company where Product.Company_ID = Company.Id and Type.Id = Company.Type_Id" +
                                " and Type.Id like N'%" + t + "%'  " +
                                " and Company.Id like N'%" + c + "%' " +
                                " and Product.ProductName like N'%"+ text +"%'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }    
    }
}
