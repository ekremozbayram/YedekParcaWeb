using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ödev3
{
    public partial class Calisan : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT MARKA_ID,MARKA_AD FROM MARKA", con);
                SqlDataReader dr = komut.ExecuteReader();
                maDDL.DataSource = dr;
                maDDL.DataValueField = "MARKA_ID";
                maDDL.DataTextField = "MARKA_AD";
                maDDL.DataBind();
                dr.Close();

                SqlCommand komut2 = new SqlCommand("SELECT MODEL_ID,MODEL_AD FROM MODEL WHERE MARKA_ID IN(SELECT MARKA_ID FROM MARKA WHERE MARKA_ID=" + maDDL.SelectedItem.Value + ")", con);
                SqlDataReader dr2 = komut2.ExecuteReader();
                moDDL.DataSource = dr2;
                moDDL.DataValueField = "MODEL_ID";
                moDDL.DataTextField = "MODEL_AD";
                moDDL.DataBind();
                dr2.Close();

                SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + moDDL.SelectedItem.Value + ")", con);
                SqlDataReader dr3 = komut3.ExecuteReader();
                paDDL.DataSource = dr3;
                paDDL.DataValueField = "PARCA_ID";
                paDDL.DataTextField = "PARCA_AD";
                paDDL.DataBind();
                dr3.Close();
                con.Close();
            }
        }
        protected void maDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut2 = new SqlCommand("SELECT MODEL_ID,MODEL_AD FROM MODEL WHERE MARKA_ID IN(SELECT MARKA_ID FROM MARKA WHERE MARKA_ID=" + maDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr2 = komut2.ExecuteReader();
            moDDL.DataSource = dr2;
            moDDL.DataValueField = "MODEL_ID";
            moDDL.DataTextField = "MODEL_AD";
            moDDL.DataBind();
            dr2.Close();
            SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + moDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr3 = komut3.ExecuteReader();
            paDDL.DataSource = dr3;
            paDDL.DataValueField = "PARCA_ID";
            paDDL.DataTextField = "PARCA_AD";
            paDDL.DataBind();
            dr3.Close();
            con.Close();
        }

        protected void moDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + moDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr3 = komut3.ExecuteReader();
            paDDL.DataSource = dr3;
            paDDL.DataValueField = "PARCA_ID";
            paDDL.DataTextField = "PARCA_AD";
            paDDL.DataBind();
            dr3.Close();
            con.Close();
        }

        protected void sGuRb_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT STOK FROM PARCA WHERE PARCA_ID=" + paDDL.SelectedItem.Value+"", con);
            SqlDataReader dr = komut.ExecuteReader();
            
            con.Close();
        }

        protected void gunBt_Click(object sender, EventArgs e)
        {
            con.Open();
            if(sGuRb.Checked==true)
            {
                SqlCommand komut = new SqlCommand("UPDATE PARCA SET STOK="+gunTb.Text+" WHERE PARCA_ID="+paDDL.SelectedItem.Value+"",con);
                SqlDataReader dr = komut.ExecuteReader();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('GÜNCELLEME İŞLEMİNİZ GERÇEKLEŞMİŞTİR.')", true);
                dr.Close();
                
            }
            else if(fGuRb.Checked==true)
            {
                SqlCommand komut = new SqlCommand("UPDATE PARCA SET FİYAT=" + gunTb.Text + " WHERE PARCA_ID=" + paDDL.SelectedItem.Value + "", con);
                SqlDataReader dr = komut.ExecuteReader();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('GÜNCELLEME İŞLEMİNİZ GERÇEKLEŞMİŞTİR.')", true);
                dr.Close();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('GÜNCELLEME İSTEDİĞİNİZ BÖLÜMÜ SEÇİNİZ.')", true);
            }
            con.Close();
        }
    }
}