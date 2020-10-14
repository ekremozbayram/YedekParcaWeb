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
    public partial class EKLE : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cEkleBt_Click(object sender, EventArgs e)
        {
            if (cEIdTb.Text != string.Empty && cEAdTb.Text != string.Empty && cESoyTb.Text != string.Empty && cETelTb.Text != string.Empty && cESifTb.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand();
                string id3 = cEIdTb.Text;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spEkleCalisan"; //Stored Procedure' ümüzün ismi
                cmd.Parameters.Add("id", SqlDbType.Int).Value = cEIdTb.Text; //Stored procedure deki parametrelere
                cmd.Parameters.Add("adi", SqlDbType.VarChar, 15).Value = cEAdTb.Text; // textboxlardan değerleri
                cmd.Parameters.Add("soyadi", SqlDbType.VarChar, 15).Value = cESoyTb.Text;
                cmd.Parameters.Add("no", SqlDbType.Char, 11).Value = cETelTb.Text;
                cmd.Parameters.Add("sifre", SqlDbType.Char, 10).Value = cESifTb.Text;//alıyoruz.
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO CALISAN_MARKA VALUES ('" + Convert.ToInt32(id3) + "','"+mIdTb.Text+"')", con);
                SqlDataReader dr = komut.ExecuteReader();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('KAYIT İŞLEMİ BAŞARILI')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('İlgili Alanları doldurunuz.')", true);
            }
        }

        protected void pEkleBt_Click(object sender, EventArgs e)
        {
            if (pEIdTb.Text != string.Empty && pEAdTb.Text != string.Empty && pEStTb.Text != string.Empty && pEFiTb.Text != string.Empty && pEMıdTb.Text != string.Empty && tIdTb.Text!=string.Empty)
            {
                SqlCommand cmd = new SqlCommand();
                string id2 = pEIdTb.Text;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spEkleParca"; //Stored Procedure' ümüzün ismi
                cmd.Parameters.Add("id", SqlDbType.Int).Value = pEIdTb.Text; //Stored procedure deki parametrelere
                cmd.Parameters.Add("adi", SqlDbType.VarChar, 25).Value = pEAdTb.Text; // textboxlardan değerleri
                cmd.Parameters.Add("stok", SqlDbType.Int).Value = pEStTb.Text;
                cmd.Parameters.Add("fiyat", SqlDbType.Int).Value = pEFiTb.Text;
                cmd.Parameters.Add("mid", SqlDbType.Int).Value = pEMıdTb.Text;//alıyoruz.
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO PARCA_TEDARIK VALUES ('"+tIdTb.Text+ "','" + Convert.ToInt32(id2) + "')", con);
                SqlDataReader dr = komut.ExecuteReader();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('KAYIT İŞLEMİ BAŞARILI')", true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('İlgili Alanları doldurunuz.')", true);
            }
        }
    }
}