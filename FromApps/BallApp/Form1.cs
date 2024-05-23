using System.Windows.Forms.ComponentModel.Com2Interop;

namespace BallApp {
    public partial class Form1 : Form {

        private int scoreCount = 0;

        //List�R���N�V����
        private List<Obj> balls = new List<Obj>();
        private List<PictureBox> pbs = new List<PictureBox>();

        //�o�[�p
        private Bar bar;
        private PictureBox pbBar;

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {

            this.Text = "BallApp SoccerBall:" + SoccerBall.Count + "TennisBall:" + TennisBall.Count;
            score.Text = "�X�R�A:"+this.scoreCount;
            bar = new Bar(340, 500);
            pbBar = new PictureBox();

            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;


        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++) {
                int ret = balls[i].Move(pbBar, pbs[i]);
                if (ret == 1) {
                    //����ړ�
                    pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                } else if (ret == 2) {
                    //���������{�[���C���X�^���X���폜����
                    balls.RemoveAt(i);
                    pbs[i].Location = new Point(2000, 2000);
                    pbs.RemoveAt(i);
                }else {
                    //�o�[�����蔻��
                    pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                    score.Text = "�X�R�A:" + ++this.scoreCount;
                }
            }
        }

        //�}�E�X�N���b�N�C�x���g�n���h��
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

            this.Text = "BallApp SoccerBall:" + SoccerBall.Count + "TennisBall:" + TennisBall.Count;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyCode);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        private void score_Click(object sender, EventArgs e) {

        }
    }
}
