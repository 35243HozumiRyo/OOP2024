using System.ComponentModel;
using System.Drawing.Text;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioBottonMaker(),
                NarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
        }

        private CarReport.MakerGroup GetRadioBottonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            if (rbImport.Checked)
                return CarReport.MakerGroup.輸入車;
            if (rbOther.Checked)
                return CarReport.MakerGroup.その他;

            return CarReport.MakerGroup.その他;
        }
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.トヨタ:
                    break;
                case CarReport.MakerGroup.日産:
                    break;
                case CarReport.MakerGroup.ホンダ:
                    break;
                case CarReport.MakerGroup.スバル:
                    break;
                case CarReport.MakerGroup.輸入車:
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns[5].Visible = false;
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["記録者"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["MaKer"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["車名"].Value;
            pbPicture.Text = (string)dgvCarReport.CurrentRow.Cells["レポート"].Value;
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
        }

        private void btModfyReport_Click(object sender, EventArgs e) {

            dgvCarReport.Refresh();//データグリッドビューの更新
        }
    }
}
