using System;
namespace Paintball
{
    public class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16;

        private int balls = 0;
        private int ballsLoaded = 0;
        

        public PaintballGun()
        {
        }

        public int BallsLoaded
        {
            get
            {
                return ballsLoaded;
            }

            set
            {
                ballsLoaded = value;
            }
        }

        public bool IsEmpty()
        {
            return ballsLoaded == 0;
        }

        public int Balls
        {
            get
            {
                return balls;
            }

            set
            {
                if (value > 0)
                {
                    balls = value;
                }

                Reload();
            }
        }

        public void Reload()
        {
            if (balls > MAGAZINE_SIZE)
            {
                ballsLoaded = MAGAZINE_SIZE;
            }
            else
            {
                ballsLoaded = balls;
            }
        }

        public bool Shoot()
        {
            if (ballsLoaded == 0)
            {
                return false;
            }

            ballsLoaded--;
            balls--;

            return true;
        }
    }
}
