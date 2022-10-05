using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace QUANLYBANHANG_00340
{
    public partial class USER : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\App_Web_QUANLYBANHANG\App_Web_QUANLYBANHANG\App_Data\dbQUANLYBANHANG.mdf;Integrated Security=True";
            cn.Open();
            string SQL = "SELECT * FROM tbDANHMUC";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbDANHMUC = new DataTable();
            adp.Fill(tbDANHMUC);
            Repeater1.DataSource = tbDANHMUC;
            Repeater1.DataBind();
            cn.Close();
        }
    }
}