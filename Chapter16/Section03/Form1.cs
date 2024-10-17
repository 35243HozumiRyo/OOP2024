using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void bt16_6_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            await Task.Run(() => DoSomething());
            toolStripStatusLabel1.Text = "終了";
        }
        private void DoSomething() {
            Thread.Sleep(50000);
        }
    }
}
