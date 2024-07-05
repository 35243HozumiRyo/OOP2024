using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Runtime.Serialization.Formatters.Binary;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ��������͂ł�";
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioBottonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
            listCarReports.Add(carReport);
            dgvCarReport.ClearSelection();

            InputItemAllClear();
        }

        private void InputItemAllClear() {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            SetRadioButtonMaker(CarReport.MakerGroup.NONE);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void SetCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private CarReport.MakerGroup GetRadioBottonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.���Y;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;
            if (rbImport.Checked)
                return CarReport.MakerGroup.�A����;
            if (rbOther.Checked)
                return CarReport.MakerGroup.���̑�;

            return CarReport.MakerGroup.���̑�;
        }

        private void SetRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.NONE:
                    MakerGroupNone();
                    break;
                case CarReport.MakerGroup.�g���^:
                    break;
                case CarReport.MakerGroup.���Y:
                    break;
                case CarReport.MakerGroup.�z���_:
                    break;
                case CarReport.MakerGroup.�X�o��:
                    break;
                case CarReport.MakerGroup.�A����:
                    break;
                case CarReport.MakerGroup.���̑�:
                    break;
                default:
                    break;
            }
        }

        private void MakerGroupNone() {
            rbToyota.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbImport.Checked = false;
            rbOther.Checked = false;
            rbNissan.Checked = false;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
            dgvCarReport.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns[5].Visible = false;
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.CurrentCell == null)
                || (!dgvCarReport.CurrentRow.Selected)) return;

            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            pbPicture.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["picture"].Value;

        }

        //�폜�{�^��
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.CurrentCell == null)
                || (!dgvCarReport.CurrentRow.Selected)) return;

            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
        }

        //�C���{�^��
        private void btModfyReport_Click(object sender, EventArgs e) {
            if ((listCarReports.Count == 0)
                || (!dgvCarReport.CurrentRow.Selected)) return;

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ��������͂ł�";
                return;
            }

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioBottonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = pbPicture.Text;

            dgvCarReport.Refresh();//�f�[�^�O���b�h�r���[�̍X�V

            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
        }

        //�L�^�҂̃e�L�X�g���ҏW���ꂽ��
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }

        //�Ԗ��̃e�L�X�g���ҏW���ꂽ��
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }

        //�ۑ��{�^��
        private void btReportSave_Click(object sender, EventArgs e) {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }
                }
                catch (Exception) {

                    throw;
                }
            }
        }

        private void btReportOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(ofdPicFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = listCarReports;
                    }
                }
                catch (Exception) {

                    throw;
                }
            }
        }
    }
}
