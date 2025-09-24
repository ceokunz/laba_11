using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    public class Square : IShape
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;
        public Square(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
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
        public Point2D getP4()
        {
            return p4;
        }
        public void addX(int X)
        {
            p1.addX(X);
            p2.addX(X);
            p3.addX(X);
            p4.addX(X);
        }
        public void addY(int Y)
        {
            p1.addY(Y);
            p2.addY(Y);
            p3.addY(Y);
            p4.addY(Y);
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
            window.DrawSquare(this);
        }
    
    }
}
