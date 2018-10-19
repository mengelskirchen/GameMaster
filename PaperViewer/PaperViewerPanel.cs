using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperViewer {

    public partial class PaperViewerPanel : Component {

        private Paper.Paper paper;

        public PaperViewerPanel() {
            InitializeComponent();
        }

        public PaperViewerPanel(Paper.Paper paper) {
            this.paper = paper;
        }

        public PaperViewerPanel(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        public void setPaper(Paper.Paper paper) {
            this.paper = paper;
        }

        public Paper.Paper getPaper() {
            return this.paper;
        }
    }
}
