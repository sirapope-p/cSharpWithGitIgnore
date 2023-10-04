using System.Data;
using System.Data.SqlClient;

namespace CsharpWithGitIgnore
{
    public partial class Form1 : Form
    {
        public int showData(string sql, string conn, DataGridView dtgv)
        {
            int intAllRow = 0;

            SqlConnection Conn = new SqlConnection(conn);
            Conn.Open();
            SqlCommand Comm = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(Comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "Carton_Temp");
            intAllRow = ds.Tables["Carton_Temp"].Rows.Count;
            dtgv.DataSource = ds;
            dtgv.DataMember = "Carton_Temp";
            dtgv.Refresh();
            da.Dispose();
            ds.Dispose();
            Comm.Dispose();
            Conn.Close();
            return intAllRow;   //เรียกจากที่นี้ต้องมี Return หากไม่มีการเปลี่ยนแปลงค่าก็แค่ return imt 0 ออกไปตาม default value
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strConn = Properties.Settings.Default.strConn;
            string strSql = "SELECT * FROM Carton";

            showData(strSql, strConn, dgvFound);
        }
    }
}