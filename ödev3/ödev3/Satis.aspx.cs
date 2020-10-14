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
    public partial class Satis : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT MARKA_ID,MARKA_AD FROM MARKA", con);
                SqlDataReader dr = komut.ExecuteReader();
                masDDL.DataSource = dr;
                masDDL.DataValueField = "MARKA_ID";
                masDDL.DataTextField = "MARKA_AD";
                masDDL.DataBind();
                dr.Close();

                SqlCommand komut2 = new SqlCommand("SELECT MODEL_ID,MODEL_AD FROM MODEL WHERE MARKA_ID IN(SELECT MARKA_ID FROM MARKA WHERE MARKA_ID=" + masDDL.SelectedItem.Value + ")", con);
                SqlDataReader dr2 = komut2.ExecuteReader();
                mosDDL.DataSource = dr2;
                mosDDL.DataValueField = "MODEL_ID";
                mosDDL.DataTextField = "MODEL_AD";
                mosDDL.DataBind();
                dr2.Close();

                SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + mosDDL.SelectedItem.Value + ")", con);
                SqlDataReader dr3 = komut3.ExecuteReader();
                pasDDL.DataSource = dr3;
                pasDDL.DataValueField = "PARCA_ID";
                pasDDL.DataTextField = "PARCA_AD";
                pasDDL.DataBind();
                dr3.Close();
                con.Close();

                con.Open();
                SqlCommand komut5 = new SqlCommand("SELECT FİYAT FROM PARCA WHERE PARCA_ID='" + pasDDL.SelectedValue + "'", con);
                SqlDataReader dr5 = komut5.ExecuteReader();
                dr5.Read();
                fiyatTb.Text = dr5["FİYAT"].ToString();
                con.Close();

            }

        }

        protected void masDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut2 = new SqlCommand("SELECT MODEL_ID,MODEL_AD FROM MODEL WHERE MARKA_ID IN(SELECT MARKA_ID FROM MARKA WHERE MARKA_ID=" + masDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr2 = komut2.ExecuteReader();
            mosDDL.DataSource = dr2;
            mosDDL.DataValueField = "MODEL_ID";
            mosDDL.DataTextField = "MODEL_AD";
            mosDDL.DataBind();
            dr2.Close();
            SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + mosDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr3 = komut3.ExecuteReader();
            pasDDL.DataSource = dr3;
            pasDDL.DataValueField = "PARCA_ID";
            pasDDL.DataTextField = "PARCA_AD";
            pasDDL.DataBind();
            dr3.Close();
            con.Close();
            con.Open();
            SqlCommand komut5 = new SqlCommand("SELECT FİYAT FROM PARCA WHERE PARCA_ID='" + pasDDL.SelectedValue + "'", con);
            SqlDataReader dr5 = komut5.ExecuteReader();
            dr5.Read();
            fiyatTb.Text = dr5["FİYAT"].ToString();
            con.Close();

        }
        protected void mosDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut3 = new SqlCommand("SELECT PARCA_ID,PARCA_AD FROM PARCA WHERE MODEL_ID IN(SELECT MODEL_ID FROM MODEL WHERE MODEL_ID=" + mosDDL.SelectedItem.Value + ")", con);
            SqlDataReader dr3 = komut3.ExecuteReader();
            pasDDL.DataSource = dr3;
            pasDDL.DataValueField = "PARCA_ID";
            pasDDL.DataTextField = "PARCA_AD";
            pasDDL.DataBind();
            dr3.Close();
            con.Close();

            con.Open();
            SqlCommand komut5 = new SqlCommand("SELECT FİYAT FROM PARCA WHERE PARCA_ID='" + pasDDL.SelectedValue + "'", con);
            SqlDataReader dr5 = komut5.ExecuteReader();
            dr5.Read();
            fiyatTb.Text = dr5["FİYAT"].ToString();
            con.Close();

        }

        protected void satBt_Click(object sender, EventArgs e)
        {
            con.Open();
            if (satTb.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO FATURA_KALEMI VALUES ('" + satTb.Text + "',(SELECT FİYAT FROM PARCA WHERE PARCA_ID='" + pasDDL.SelectedValue + "'),'" + pasDDL.SelectedValue + "',(SELECT TOP 1 FATURA_ID FROM FATURA ORDER BY F_TARİH DESC))", con);
                SqlDataReader dr = komut.ExecuteReader();
                con.Close();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Satışınız gerçekleşmiştir.')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Lütfen adet giriniz.')", true);
            }
        }

        protected void pasDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut5 = new SqlCommand("SELECT FİYAT FROM PARCA WHERE PARCA_ID='"+pasDDL.SelectedValue+"'", con);
            SqlDataReader dr5 = komut5.ExecuteReader();
            dr5.Read();
            fiyatTb.Text = dr5["FİYAT"].ToString();
            con.Close();
        }
    }
}