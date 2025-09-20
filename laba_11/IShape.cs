using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    internal interface IShape
    {
        void MoveX(int dx);
        void MoveY(int dy);
        void Draw(MainWindow window);
    }
}
