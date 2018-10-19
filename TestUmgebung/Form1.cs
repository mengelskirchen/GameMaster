using PdfSharp.Drawing;
using PdfSharp.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TestUmgebung {
    public partial class Form1 : Form {
        public Form1() {
            //PdfDocument document = PdfReader.Open(Assembly.GetExecutingAssembly().GetManifestResourceStream("TestUmgebung.Properties.Resources.test"));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //PdfDocument document = PdfReader.Open(".\files\test.pdf");
            //gfx = XGraphics.FromPdfPage(document.Pages[0]);
            System.Console.WriteLine("HIER1");
            pagePreview1.SetRenderFunction(Render);
            pagePreview1.Refresh();
            
        }

        private void Render(XGraphics gfx) {
            System.Console.WriteLine("HIER2");
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            gfx.DrawString("Hello, World!", font, XBrushes.Black, new XRect(0, 0, 100, 100), XStringFormat.Center);
        }
    }
}
