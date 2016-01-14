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

        public int addDulieuKham(DuLieuKham dlk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_form_ThemDuLieuKham", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ntim", dlk.NhipTim);
            cmd.Parameters.AddWithValue("@cxuc", dlk.CamXuc);
            cmd.Parameters.AddWithValue("@ccao", dlk.ChieuCao);
            cmd.Parameters.AddWithValue("@cnang", dlk.CanNang);
            cmd.Parameters.AddWithValue("@mabenh", dlk.MaBenh);
            cmd.Parameters.Add("@ma", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            int ma = (int)cmd.Parameters["@ma"].Value;
            conn.Close();
            return ma;
        }

        public bool addBacSi(BacSi bs)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_form_ThemBacSi", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ten", bs.TenBacSi);
            cmd.Parameters.AddWithValue("@ns", bs.NgaySinh);
            cmd.Parameters.AddWithValue("@gt", bs.GioiTinh);
            cmd.Parameters.AddWithValue("@email", bs.Email);
            cmd.Parameters.AddWithValue("@dt", bs.DienThoai);
            cmd.Parameters.AddWithValue("@dc", bs.DiaChi);
            cmd.Parameters.AddWithValue("@cn", bs.ChuyenNganh);
            cmd.Parameters.AddWithValue("@bc", bs.BangCap);
            

            cmd.ExecuteNonQuery();
       
            conn.Close();
            return true;
        }

        public bool addTrieuChung(TrieuChung tc, string maVT)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_form_ThemTrieuChung", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenTC", tc.TenTrieuChung);
            cmd.Parameters.AddWithValue("@maViTriBenh", maVT);
         
            cmd.ExecuteNonQuery();

            conn.Close();
            return true;
        }


    }
}
