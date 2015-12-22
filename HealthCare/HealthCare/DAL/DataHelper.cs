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

        public void executeNonQueryAddBenhNhan(BenhNhan bn)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@tenDN", bn.TenDangNhap);
            comm.Parameters.AddWithValue("@mk", bn.MatKhau);
            comm.Parameters.AddWithValue("@ten", bn.TenNguoiDung);
            comm.Parameters.AddWithValue("@ns", bn.NgaySinh);
            comm.Parameters.AddWithValue("@gt", bn.GioiTinh);
            comm.Parameters.AddWithValue("@email", bn.Email);
            comm.Parameters.AddWithValue("@dt", bn.DienThoai);
            comm.Parameters.AddWithValue("@diaChi", bn.DiaChi);
            comm.CommandText = "sp_form_ThemBenhNhan";
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

        public DataTable executeQueryFindNguoiThan(string ten, string bn)
        {
            DataTable table = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@name", ten);
            comm.Parameters.AddWithValue("@tenDN", bn);
            comm.CommandText = "sp_form_TimNguoiThan";
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(table);
            }
            catch (Exception e)
            {
                throw new Exception("Execute query eror:" + e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
                if (comm != null)
                    comm.Dispose();
            }
            return table;
        }

        public void executeNonQueryAddNguoiThan(string bn, string nt)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@benhNhan", bn);
            comm.Parameters.AddWithValue("@nguoiThan", nt);
            comm.CommandText = "sp_form_ThemNguoiThan";
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
