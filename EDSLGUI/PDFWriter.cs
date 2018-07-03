using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace EDSLGUI
{
    class PDFWriter
    {
        public void Write(string toWrite)
        {
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "This is a title";

            PdfPage page = doc.AddPage();
            XGraphics drawer = XGraphics.FromPdfPage(page);
            
            XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(drawer);
            tf.DrawString(toWrite, font, XBrushes.Black,
                new XRect(0, 0, page.Width, 20),
                XStringFormats.TopLeft);

            const string filename = "TestDocument.pdf";
            doc.Save(filename);
            
        }
    }
}
