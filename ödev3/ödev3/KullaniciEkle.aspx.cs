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

    public partial class KullaniciEkle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ykEkleB_Click(object sender, EventArgs e)
        {
            if (ykIdT.Text !=string.Empty && ykAdiT.Text !=string.Empty  && ykSoyadiT.Text !=string.Empty && ykNoT.Text!=string.Empty && ykSifreT.Text!=string.Empty)
            {   
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spEkleMusteri"; //Stored Procedure' ümüzün ismi
                cmd.Parameters.Add("id", SqlDbType.Int).Value = ykIdT.Text; //Stored procedure deki parametrelere
                cmd.Parameters.Add("adi", SqlDbType.VarChar, 15).Value = ykAdiT.Text; // textboxlardan değerleri
                cmd.Parameters.Add("soyadi", SqlDbType.VarChar, 15).Value = ykSoyadiT.Text;
                cmd.Parameters.Add("no", SqlDbType.Char, 11).Value = ykNoT.Text;
                cmd.Parameters.Add("sifre", SqlDbType.Char, 10).Value = ykSifreT.Text;//alıyoruz.
                cmd.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('KAYIT İŞLEMİ BAŞARILI')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('İlgili alanları doldurunuz')", true);
            }
            
        }
    }
}