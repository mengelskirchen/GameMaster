namespace TestUmgebung {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pagePreview1 = new PdfSharp.Forms.PagePreview();
            this.pagePreview1.SetRenderFunction(Render);
            this.SuspendLayout();
            // 
            // pagePreview1
            // 
            this.pagePreview1.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.pagePreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePreview1.Location = new System.Drawing.Point(0, 0);
            this.pagePreview1.Name = "pagePreview1";
            this.pagePreview1.PageColor = System.Drawing.Color.GhostWhite;
            this.pagePreview1.PageGraphicsUnit = PdfSharp.Drawing.XGraphicsUnit.Point;
            this.pagePreview1.PageSize = ((PdfSharp.Drawing.XSize)(resources.GetObject("pagePreview1.PageSize")));
            this.pagePreview1.PageSizeF = new System.Drawing.Size(595, 842);
            this.pagePreview1.PageUnit = PdfSharp.Drawing.XGraphicsUnit.Point;
            this.pagePreview1.Size = new System.Drawing.Size(800, 450);
            this.pagePreview1.TabIndex = 0;
            this.pagePreview1.ZoomPercent = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pagePreview1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PdfSharp.Forms.PagePreview pagePreview1;
    }
}

