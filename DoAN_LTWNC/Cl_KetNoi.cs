using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTWNC
{
    class Cl_KetNoi
    {
        private SqlConnection con;
        private  string Strcon;
        public Cl_KetNoi()
        {
            con = null;
            Strconnetion = @"";
        }
        public Cl_KetNoi(string strcon)
        {
            con = null;
            Strconnetion = "@" +strcon;
        }
        public SqlConnection Con { get { return con; } set {con = value; }}

        public string Strconnetion { get { return Strcon; } set { Strcon = value; } }
        public void OpenConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = Strconnetion;
            if (Con.State == ConnectionState.Open)
                Con.Close();
            Con.Open();
        }
        public void CloseConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            Con.Dispose();

        }
        public void Update_Dalete_Insert(string s)
        {
            SqlCommand com = new SqlCommand(s, Con);
            com.ExecuteNonQuery();
        }
        public int GetCount(string s)
        {
            SqlCommand com = new SqlCommand(s, Con);
            return (int)com.ExecuteScalar();
        }
        public DataTable DataTable(string s)
        {
            SqlDataAdapter adap = new SqlDataAdapter(s, Con);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }

    }
}
