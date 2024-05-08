namespace BallApp {
    public partial class Form1 : Form {
        Obj ball;
        PictureBox pb;

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ball.Move();
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            pb = new PictureBox();   //�摜��\������R���g���[��
            pb.Size = new Size(50, 50);

            if (e.Button == MouseButtons.Left) {
                ball = new SoccerBall(e.X, e.Y);
            } else {
                ball = new TennisBall(e.X, e.Y);
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();
        }
    }
}

