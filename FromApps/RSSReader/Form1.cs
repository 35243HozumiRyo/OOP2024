﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSSReader {
    public partial class a : Form {

        public a() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                var xtitles = xdoc.Root.Descendants("item").Select(item => item.Element("title").Value);
                var links = xdoc.Root.Descendants("item").Select(item => item.Element("link").Value);
                foreach (var title in xtitles ) {
                    lbRssTitle.Items.Add(title);
                    lbRssTitle.Items.Add(links);
                }
            }
        }
    }
}
