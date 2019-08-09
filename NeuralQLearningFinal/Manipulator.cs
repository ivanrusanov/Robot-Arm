using System;
using System.Drawing;

namespace NeuralQLearningFinal
{
    class Manipulator
    {
        int[] angleA;
        int[] angleB;
        int angleDiscretization = 20;
        int lengthA;
        int lengthB;
        Point targetPoint;
        private Point A;
        private Point B;

        Random rnd = new Random();

        public Manipulator(int x, int y)
        {
            this.angleA = new int[angleDiscretization];
            this.angleA[0] = 1;
            this.angleB = new int[angleDiscretization];
            this.angleB[0] = 1;
            this.lengthA = 30;
            this.lengthB = 30;
            this.targetPoint = new Point(x, y);
        }

        public void DoAction(int action)
        {
            int current;
            switch (action)
            {
                case 0:
                    current = Array.IndexOf(angleA, 1);
                    if (current == angleA.Length - 1)
                    {
                        angleA[current] = 0;
                        angleA[0] = 1;
                    }
                    else
                    {
                        angleA[current] = 0;
                        angleA[current + 1] = 1;
                    }
                    break;
                case 1:
                    current = Array.IndexOf(angleA, 1);
                    if (current == 0)
                    {
                        angleA[current] = 0;
                        angleA[angleA.Length - 1] = 1;
                    }
                    else
                    {
                        angleA[current] = 0;
                        angleA[current - 1] = 1;
                    }
                    break;
                case 2:
                    current = Array.IndexOf(angleB, 1);
                    if (current == angleB.Length - 1)
                    {
                        angleB[current] = 0;
                        angleB[0] = 1;
                    }
                    else
                    {
                        angleB[current] = 0;
                        angleB[current + 1] = 1;
                    }
                    break;
                case 3:
                    current = Array.IndexOf(angleB, 1);
                    if (current == 0)
                    {
                        angleB[current] = 0;
                        angleB[angleB.Length - 1] = 1;
                    }
                    else
                    {
                        angleB[current] = 0;
                        angleB[current - 1] = 1;
                    }
                    break;
            }
            RefreshPoints();
        }

        public double GetDistance()
        {
            RefreshPoints();
            return Math.Sqrt((B.X - targetPoint.X) * (B.X - targetPoint.X) + (B.Y - targetPoint.Y) * (B.Y - targetPoint.Y));
        }

        private void RefreshPoints()
        {
            double angleAinDeg = (360 / angleDiscretization) * Array.IndexOf(angleA, 1);
            double angleBinDeg = (360 / angleDiscretization) * Array.IndexOf(angleB, 1);
            A.X = (int)(lengthA * Math.Cos(angleAinDeg * Math.PI / 180));
            A.Y = (int)(lengthA * Math.Sin(angleAinDeg * Math.PI / 180));
            B.X = (int)(lengthB * Math.Cos(angleAinDeg * Math.PI / 180) + lengthB * Math.Cos((angleAinDeg + angleBinDeg) * Math.PI / 180));
            B.Y = (int)(lengthA * Math.Sin(angleAinDeg * Math.PI / 180) + lengthB * Math.Sin((angleAinDeg + angleBinDeg) * Math.PI / 180));
        }

        public void SetAngles(int vA, int vB)
        {
            this.angleA = new int[angleDiscretization];
            this.angleA[vA] = 1;
            this.angleB = new int[angleDiscretization];
            this.angleB[vB] = 1;
        }

        public void RandomState()
        {
            SetAngles(rnd.Next(angleDiscretization), rnd.Next(angleDiscretization));
            RefreshPoints();
        }

        public int AngleDiscretization
        {
            get { return angleDiscretization; }
        }

        public int[] AngleA
        {
            get { return angleA; }
        }

        public int[] AngleB
        {
            get { return angleB; }
        }

        public int AngleAIndex
        {
            get { return Array.IndexOf(angleA, 1); }
        }

        public int AngleBIndex
        {
            get { return Array.IndexOf(angleB, 1); }
        }

        public Point GetTargetPoint
        {
            get { return targetPoint; }
        }

        public Point GetPointA
        {
            get
            {
                RefreshPoints();
                return A;
            }
        }

        public Point GetPointB
        {
            get
            {
                RefreshPoints();
                return B;
            }
        }

        public Point Target
        {
            get
            {
                return targetPoint;
            }
            set
            {
                targetPoint = value;
            }
        }
    }
}
