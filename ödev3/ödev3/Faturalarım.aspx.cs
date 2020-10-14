using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace ödev3
{
    public partial class Faturalarım : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            int id2 = int.Parse(login.id);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FATURA WHERE MUSTERI_ID='"+id2+"'",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            
        }

        protected void fGorBt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT * FROM FATURA_KALEMI WHERE FATURA_ID='" + fGorTb.Text + "'", con);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            fGv.DataSource = dss;
            fGv.DataBind();
            con.Close();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        protected void fYazBt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT * FROM FATURA_KALEMI WHERE FATURA_ID='" + fGorTb.Text + "'", con);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            fGv.DataSource = dss;
            fGv.DataBind();
            con.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment; filename=Fatura.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            fGv.AllowPaging = false;
            fGv.DataBind();
            //fGv.RenderControl(hw);
            fPa.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
            
        }
    }
}