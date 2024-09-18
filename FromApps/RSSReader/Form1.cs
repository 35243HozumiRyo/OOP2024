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
        Dictionary<string, string> rssDict;
        List<string> Favorite = new List<string> { };

        public Form1() {
            InitializeComponent();
            Favorite = new List<string>() {
                {"主要" },{"https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
                {"国内" },{"https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                {"国際" },{"https://news.yahoo.co.jp/rss/topics/world.xml"},
                {"経済" },{"https://news.yahoo.co.jp/rss/topics/business.xml"},
                {"エンタメ" },{"https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
                {"スポーツ" },{"https://news.yahoo.co.jp/rss/topics/sports.xml"},
                {"IT" },{"https://news.yahoo.co.jp/rss/topics/it.xml"},
                {"科学" },{"https://news.yahoo.co.jp/rss/topics/science.xml"},
                {"地域" },{"https://news.yahoo.co.jp/rss/topics/local.xml"},
            };
            for (int i = 0; i < Favorite.Count; i++) {
                if (i % 2 == 0) {
                    cbRssUrl.Items.Add(Favorite[i]);
                }
            }
        }

        //URLのお気に入りをコンボボックスへ登録（重複なし）
        private void setCbRssUrl(string Text) {
            if (cbRssUrl.Items.Contains(Text)) {
                MessageBox.Show(Text + "は現在登録済みです",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                cbRssUrl.Items.Add(Text);
                tbRssFavorite.Text = "";
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (cbRssUrl.Text == "") {
                MessageBox.Show("URLが未入力です!!",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {

                if (cbRssUrl.Text.Contains("https://news.yahoo.co.jp/rss/")) {
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
                        cbRssUrl.Text = "";
                    }
                } else {
                    for (int i = 0; i < Favorite.Count; i++) {
                        if (Favorite[i] == cbRssUrl.Text) {
                            lbRssTitle.Items.Clear();
                            using (var wc = new WebClient()) {
                                var c = Favorite[i + 1];
                                var url = wc.OpenRead(Favorite[i + 1]);
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
                                cbRssUrl.Text = "";
                            }
                            return;
                        } else {
                            if( i == Favorite.Count-1) {
                                MessageBox.Show("URLが無効です!!",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            if (lbRssTitle.SelectedItem != null) {
                var selectedTitle = lbRssTitle.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);

                if (selectedItem != null) {
                    webView21.Source = new Uri(selectedItem.Link);
                }
            }
        }

        private void btEntry_Click(object sender, EventArgs e) {
            if (cbRssUrl.Text == "" || tbRssFavorite.Text == "") {
                MessageBox.Show("URLまたはお気に入り名称が未入力です!!",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            } else if(cbRssUrl.Text.Contains("https://news.yahoo.co.jp/rss/")) {
                Favorite.Add(tbRssFavorite.Text);
                Favorite.Add(cbRssUrl.Text);
                setCbRssUrl(tbRssFavorite.Text);
            } else {
                MessageBox.Show("URLが無効です!!",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }

    public class ItemDate {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
