using System;
namespace Paintball
{
    public class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16;

        private int balls = 0;
        
        

        public PaintballGun()
        {
        }

        public int BallsLoaded { get; set; }

        public bool IsEmpty()
        {
            return BallsLoaded == 0;
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
                BallsLoaded = MAGAZINE_SIZE;
            }
            else
            {
                BallsLoaded = balls;
            }
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0)
            {
                return false;
            }

            BallsLoaded--;
            balls--;

            return true;
        }
    }
}
