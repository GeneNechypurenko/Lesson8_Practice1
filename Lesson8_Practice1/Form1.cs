namespace Lesson8_Practice1
{



    //Нарисовать круг, прямоугольник и треугольник, используя карандаш.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] points = new Point[] { new Point(180, 100), new Point(230, 100), new Point(205, 50) };
            g.DrawRectangle(new Pen(Brushes.Blue, 5), 50, 50, 50, 50);
            g.DrawEllipse(new Pen(Brushes.Green, 5), 120, 50, 50, 50);
            g.DrawPolygon(new Pen(Brushes.Red, 5), points);
            g.Dispose();
        }
    }
}