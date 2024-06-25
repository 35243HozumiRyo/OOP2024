namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dtDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;

            TimeSpan diff = today - dtpBirthday.Value;

            //dtDisp.Text = "ÅZÅZì˙ñ⁄";

            dtDisp.Text = diff.ToString();
        }

        private void dtDisp_TextChanged(object sender, EventArgs e) {

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            dtDisp.Text = nudDay.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
