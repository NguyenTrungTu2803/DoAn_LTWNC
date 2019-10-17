using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_user_pass
{
    public class ChangeConnec
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string DataSource;

        public string DataSource1
        {
            get { return DataSource; }
            set { DataSource = value; }
        }
        private string InitialCatalog;

        public string InitialCatalog1
        {
            get { return InitialCatalog; }
            set { InitialCatalog = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        //Integrated Security=True
        public void ConnecString(string _name, string _dt, string _in, string _pass, string _id) {
            name = _name; DataSource = _dt; InitialCatalog = _in; pass = _pass; id = _id;
        }
        public void ConnectionString(string _name, string _dt, string _in) {
            name = _name; DataSource = _dt; InitialCatalog = _in;
        }
        //-----------------------------------------------------
        private SqlConnection con;
        private  string Strcon;
        public ChangeConnec()
        {
            con = null;
            Strconnetion = @Properties.Settings.Default.QL_NhanVien.ToString();
        }
        public ChangeConnec(string strcon)
        {
            con = null;
            Strconnetion = strcon;
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
