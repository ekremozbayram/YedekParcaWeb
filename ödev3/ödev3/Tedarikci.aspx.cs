using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace ödev3
{
    public partial class Tedarikci : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-E57UI6R; Database=YedekParcaS; Integrated Security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PT.PARCA_ID,P.PARCA_AD,PT.TEDARIKCI_ID,T.FIRMA_ADI,T.T_NO,T.IL FROM PARCA_TEDARIK PT,PARCA P, TEDARIKCI T WHERE P.PARCA_ID=PT.PARCA_ID AND PT.TEDARIKCI_ID=T.TEDARIKCI_ID", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tgGrd.DataSource = ds;
            tgGrd.DataBind();
            con.Close();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        protected void ptIndır_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment; filename=Tedarikçi.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            tgGrd.AllowPaging = false;
            tgGrd.DataBind();
            //fGv.RenderControl(hw);
            tgGrd.RenderControl(hw);
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