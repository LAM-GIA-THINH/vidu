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
    public partial class page_DANHSACHSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\QUANLYBANHANG_00340\QUANLYBANHANG_00340\App_Data\dbDANHMUC.mdf;Integrated Security=True";
            cn.Open();
            string SQL = "SELECT * FROM tbSANPHAM";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbSANPHAM = new DataTable();
            adp.Fill(tbSANPHAM);
            DataList1.DataSource = tbSANPHAM;
            DataList1.DataBind();
            DataList1.RepeatColumns = 4;
            cn.Close();
        }
    }
}