using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Paper
{
    public class Paper
    {
        private Rectangle paperSize { get; set; }
        private Dictionary<String, String> paperValues { get; set; }
        private Dictionary<Image, Rectangle> paperImages { get; set; }
        private Dictionary<String, Component> paperFields { get; set; }

        public Paper() {

        }

    }
}
