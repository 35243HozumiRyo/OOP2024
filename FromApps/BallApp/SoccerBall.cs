using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall:Obj{
        public static int Count {  get; set; } 

        public SoccerBall(double xp, double yp)
            :base(xp-25,yp-25, @"Picture\soccer_ball.png") {

            Random r = new Random();    
            MoveX = r.Next(-10,10);//移動量設定
            MoveY = r.Next(-10,10);

            Count++;
        }

        //移動メソッド(抽象メソッド)
        public override int Move(PictureBox pbBar,PictureBox pbBall) {
            int ret = 1;
            Rectangle rBar = new Rectangle(pbBar.Location.X,pbBar.Location.Y,pbBar.Width,pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);


            if (PosX > 750 || PosX < 0) {
                MoveX =- MoveX;
            }

            if(PosY < 0 ){
                MoveY =- MoveY;
            }

            if (PosY > 600) {
                ret = 2;
            }

            if (rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
                PosX += MoveX;
                PosY += MoveY;
                ret = 3;
            }

            PosX += MoveX;
            PosY += MoveY;

            return ret;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
