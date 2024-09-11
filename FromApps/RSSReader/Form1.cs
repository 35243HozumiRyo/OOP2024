using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSSReader {


    public partial class Form1 : Form {
        List<ItemDate> items;
        List<string> Favorite = new List<string> { };

        public Form1() {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //お気に入りの初期値を決定
            
        }

        //URLの履歴をコンボボックスへ登録（重複なし）
        private void setCbRssUrl(string Text) {
            if ( !cbRssUrl.Items.Contains(Text))
                cbRssUrl.Items.Add(Text);
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (cbRssUrl.Text == "") {
                tsslMessage.Text = "URLが未入力です";
            } else {

                if(cbRssUrl.Text.Contains("https://news.yahoo.co.jp/rss/")) {
                    lbRssTitle.Items.Clear();
                    using (var wc = new WebClient()) {

                        var url = wc.OpenRead(cbRssUrl.Text);
                        var xdoc = XDocument.Load(url);

                        items = xdoc.Root.Descendants("item").Select(item => new ItemDate {
                            Title = item.Element("title").Value,
                            Link = item.Element("link").Value,
                        }).ToList();
                        foreach (var item in items) {
                            lbRssTitle.Items.Add(item.Title);
                            //Console.WriteLine();
                            //lbRssTitle.Items.Add(item.Link);
                        }
                    }
                } else{
                    for(int i = 0; i < Favorite.Count; i++) {
                        if (Favorite[i] == cbRssUrl.Text) {
                            lbRssTitle.Items.Clear();
                            using (var wc = new WebClient()) {
                                var c = Favorite[i + 1];
                                var url = wc.OpenRead(Favorite[i+1]);
                                var xdoc = XDocument.Load(url);

                                items = xdoc.Root.Descendants("item").Select(item => new ItemDate {
                                    Title = item.Element("title").Value,
                                    Link = item.Element("link").Value,
                                }).ToList();
                                foreach (var item in items) {
                                    lbRssTitle.Items.Add(item.Title);
                                    //Console.WriteLine();
                                    //lbRssTitle.Items.Add(item.Link);
                                }
                            }
                        }
                    }
                }


                
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webBrowser1.Navigate(items[lbRssTitle.SelectedIndex].Link);
        }

        private void btEntry_Click(object sender, EventArgs e) {
            if (cbRssUrl.Text == "") {
                tsslMessage.Text = "URLが未入力です";
                return;
            }
            Favorite.Add(tbRssFavorite.Text);
            Favorite.Add(cbRssUrl.Text);
            setCbRssUrl(tbRssFavorite.Text);
        }
        private void Form_Resize(object sender, EventArgs e) {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            btGet.Left = this.ClientSize.Width - btGet.Width;
            cbRssUrl.Width = btGet.Left - cbRssUrl.Left;
        }
    }

    public class ItemDate {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
