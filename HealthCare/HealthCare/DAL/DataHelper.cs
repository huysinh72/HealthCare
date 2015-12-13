using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.DTO;

namespace HealthCare.DAL
{
    public class DataHelper
    {
        private static SqlConnection conn;

        public DataHelper()
        {
            string cnnString = System.Configuration.ConfigurationSettings.AppSettings["HealthCare_ConnectionString"].ToString();
            conn = new SqlConnection(cnnString);
        }

        public DataTable executeQuery(string query)
        {
            DataTable table = new DataTable();
            SqlCommand commd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(commd);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                throw new Exception("Execute query eror:" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        public void executeNonQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Execute non query eror:" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void executeNonQueryAddNguoiDung(NguoiDung nd)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@tenDN", nd.TenDangNhap);
            comm.Parameters.AddWithValue("@mk", nd.MatKhau);
            comm.Parameters.AddWithValue("@ten", nd.TenNguoiDung);
            comm.Parameters.AddWithValue("@ns", nd.NgaySinh);
            comm.Parameters.AddWithValue("@gt", nd.GioiTinh);
            comm.Parameters.AddWithValue("@email", nd.Email);
            comm.Parameters.AddWithValue("@dt", nd.DienThoai);
            comm.CommandText = "sp_form_ThemNguoiDung";
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Execute non query eror:" + e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
                if (comm != null)
                    comm.Dispose();
            }
        } 
    }
}
