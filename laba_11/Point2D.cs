using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    public class Point2D
    {

        int x;
        int y; //хз??

        private int X
        { 
            get; 
            set; 
        }

        private int Y
        { 
            get; 
            set; 
        }

        //get
        //    {
        //        return x;
        //    }
        //set
        //    {
        //        x = value;
        //        OnPropertyChanged(nameof(X)); ???????? 
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //} ну вобщем это тоже хз не уверен

        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void addX(int x)
        {
            X += x;
        }
        public void addY(int y)
        {
            Y += y;
        }
    }
}
 