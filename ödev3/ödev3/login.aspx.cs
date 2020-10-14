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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string id;
        protected void kGirisB_Click(object sender, EventArgs e)
        {

            id = kAdiTb.Text;
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MUSTERI WHERE MUSTERI_ID='" + kAdiTb.Text + "' AND M_SIFRE='" + kSifreTb.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr != null && dr.HasRows)
            {
                Page.Response.Redirect("Satis.aspx");
                dr.Close();

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bilgilerinizi Kontrol ediniz..')", true);
                dr.Close();
            }

            SqlCommand komut2 = new SqlCommand("INSERT INTO FATURA (MUSTERI_ID,F_TARİH)  VALUES ('" + kAdiTb.Text + "','" + DateTime.Now + "')", con);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Close();
            


            con.Close();
            
        }

        protected void cGirisB_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM CALISAN WHERE CALISAN_ID='" + cAdiTb.Text + "' AND C_SIFRE='" + cSifreTb.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr != null && dr.HasRows)
            {
                Page.Response.Redirect("Calisan.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bilgilerinizi Kontrol ediniz..')", true);
            }
            con.Close();
        }
    }
}