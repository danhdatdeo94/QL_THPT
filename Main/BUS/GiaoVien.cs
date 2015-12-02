﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class GiaoVien
    {
        public DataTable Show()
        {
            string sql = "select gv.MaGV, gv.HoTen, gv.GT, gv.NgaySinh, gv.DiaChi, gv.Luong, gv.SDT, mh.TenMon from tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public void ADDGiaoVien(string HoTen, string GT, DateTime NgaySinh, string DiaChi, int SDT, int Luong, string MaMon)
        {
            string sql = "ADD_GV";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@Luong", Luong);
            cmd.Parameters.AddWithValue("@MaMon", MaMon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Sua 
        public void Sua_GV(string MaGV, string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string Mon)
        {
            string sql = "Sua_GV";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@Luong", Luong);
            cmd.Parameters.AddWithValue("@MaMon", Mon);
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void Xoa_GV(string MaGV)
        {
            string sql = "Xoa_GV";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable LayThongTinMonHoc()
        {
            string sql = "SELECT * FROM tblMonHoc";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}