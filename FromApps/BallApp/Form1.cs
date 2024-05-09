using System.Windows.Forms.ComponentModel.Com2Interop;

namespace BallApp {
    public partial class Form1 : Form {

        private List<Obj>balls = new List<Obj>();
        private List<PictureBox>pbs = new List<PictureBox>();


        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            
            this.Text = "BallApp SoccerBall:"+SoccerBall.Count+"TennisBall:"+TennisBall.Count;
        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++) {
                balls[i].Move();
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox();   //�摜��\������R���g���[��
            Obj ball;
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

            balls.Add(ball);
            pbs.Add(pb);
        }
    }
}

