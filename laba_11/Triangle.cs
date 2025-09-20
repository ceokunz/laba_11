using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    public class Triangle : IShape
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public Point2D getP1()
        {
            return p1;
        }
        public Point2D getP2()
        {
            return p2;
        }
        public Point2D getP3()
        {
            return p3;
        }
        public void addX(int x)
        {
            p1.addX(x);
            p2.addX(x);
            p3.addX(x);//
        }

        public void addY(int y)
        {
            p1.addY(y);
            p2.addY(y);
            p3.addY(y);
        }

        public void MoveX(int dx)
        {
            addX(dx);
        }

        public void MoveY(int dy)
        {
            addY(dy);
        }

        public void Draw(MainWindow window)
        {
            window.DrawTriangle(this);
        }

    }
}

