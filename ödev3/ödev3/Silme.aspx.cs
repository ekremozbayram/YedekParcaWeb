using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ödev3
{
    public partial class Silme : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT * FROM FATURA", con);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            GridView1.DataSource = dss;
            GridView1.DataBind();
            con.Close();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CALISAN_ID,C_ADI,C_SOYADI,C_TNO FROM CALISAN", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }

        protected void fSilBt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM FATURA WHERE FATURA_ID='" + fSilTb.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT * FROM FATURA", con);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            GridView1.DataSource = dss;
            GridView1.DataBind();
            con.Close();
        }

        protected void cSilBt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM CALISAN WHERE CALISAN_ID='" + cSilTb.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            con.Close();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CALISAN_ID,C_ADI,C_SOYADI,C_TNO FROM CALISAN", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }
    }
}