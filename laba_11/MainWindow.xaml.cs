using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private Triangle tr;
        private Rectangle rc;

        public MainWindow()
        {
            InitializeComponent();
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p4 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

            tr = new Triangle(p1, p2, p3);
            rc = new Rectangle(p1, p2, p3, p4);
        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            Line line = new Line();
            line.Stroke = Brushes.LightPink;
            line.StrokeThickness = 3;

            line.X1 = p1.getX();
            line.Y1 = p1.getY();
            line.X2 = p2.getX();
            line.Y2 = p2.getY();

            Scene.Children.Add(line);
        }
        public void DrawTriangle(Triangle tr)
        {
            DrawLine(tr.getP1(), tr.getP2());
            DrawLine(tr.getP2(), tr.getP3());
            DrawLine(tr.getP3(), tr.getP1());
        }

        public void ClearScene()
        {
            Scene.Children.Clear();
        }

        public void DrawRectangle(Rectangle rc)
        {
            DrawLine(rc.getP1(), rc.getP2());
            DrawLine(rc.getP2(), rc.getP3());
            DrawLine(rc.getP3(), rc.getP4());
            DrawLine(rc.getP4(), rc.getP1());
        }

        private void DrawTriangle1(object sender, RoutedEventArgs e)
        {
            DrawTriangle(tr);
        }

        private void DrawRectangle(object sender, RoutedEventArgs e)
        {
            DrawRectangle(rc);
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double i = e.OldValue - e.NewValue;
            Scene.Children.Clear();
            rc.addX((int)(i * -100));
            DrawRectangle(rc);

        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double i = e.OldValue - e.NewValue;
            Scene.Children.Clear();
            rc.addY((int)(i*-100));
            DrawRectangle(rc);

        }

        
    }
        
}