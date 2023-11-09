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

            g.DrawRectangle(new Pen(Brushes.Blue, 5), 50, 50, 50, 50);
            g.DrawEllipse(new Pen(Brushes.Green, 5), 120, 50, 50, 50);
            Point[] points = new Point[]
            {
                new Point(180, 100),
                new Point(230, 100),
                new Point(205, 50)
            };
            g.DrawPolygon(new Pen(Brushes.Red, 5), points);

            g.FillRectangle(new SolidBrush(Color.Blue), 50, 120, 50, 50);
            g.FillEllipse(new SolidBrush(Color.Green), 120, 120, 50, 50);
            Point[] trianglePoints = new Point[]
            {
                 new Point(175, 170),
                 new Point(235, 170),
                 new Point(205, 110)
            };
            g.FillPolygon(new SolidBrush(Color.Red), trianglePoints);

            g.DrawString("Жирный текст", new Font(this.Name, 20, FontStyle.Bold), new SolidBrush(Color.Red), new PointF(50, 190));
            g.DrawString("Курсив", new Font(this.Name, 20, FontStyle.Italic), new SolidBrush(Color.Green), new PointF(50, 230));
            g.DrawString("Подчеркнутый", new Font(this.Name, 20, FontStyle.Underline), new SolidBrush(Color.Blue), new PointF(50, 270));


            g.FillEllipse(new SolidBrush(Color.DeepPink), 380, 90, 350, 150);
            g.DrawString("Panther", new Font("MV Boli", 48, FontStyle.Bold), Brushes.White, 375, 100);
            

            g.Dispose();
        }
    }
}