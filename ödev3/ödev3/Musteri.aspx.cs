using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace ödev3
{
    public partial class Musteri : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MUSTERI_ID,M_ADI,M_SOYADI,M_NO FROM MUSTERI", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            mgGrd.DataSource = ds;
            mgGrd.DataBind();
            con.Close();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        protected void ındırBt_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment; filename=Müşteriler.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            mgGrd.AllowPaging = false;
            mgGrd.DataBind();
            //fGv.RenderControl(hw);
            mgGrd.RenderControl(hw);
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