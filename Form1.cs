namespace Satisfactory_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void squareLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSquareLayout.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcSquareRootsButton_Click(object sender, EventArgs e)
        {
            var numerator = Convert.ToInt32(numeratorInputTextBox.Text);
            var squareLayout = new SquareLayout();
            var squareRootDivisors = squareLayout.GetSquareRootDivisors(numerator);

            squareDivisorsLabel.Text = squareDivisorsLabel.Text.Replace("{input}", numeratorInputTextBox.Text);
            squareDivisorsLabel.Text = squareDivisorsLabel.Text.Replace("{divisors}", String.Join(", ", squareRootDivisors));

            foreach (int sqrtDiv in squareRootDivisors) 
            {
                
            }


            SftPictureBox aperture = this.drawPicture(new Point(50, 150));

            SftPictureBox aperture2 = aperture.Clone();
            aperture2.Location = new Point(50 + aperture.Width, 150);
            panelSquareLayout.Controls.Add(aperture2);
        }

        private SftPictureBox drawPicture(Point where)
        {
            SftPictureBox aperture = new SftPictureBox();

            aperture.Load(Path.Combine(Application.StartupPath, @"assets\images\Aperture_Science_indicator_floor_blue-32px.png"));
            aperture.Width = 32;
            aperture.Height = 32;
            aperture.Margin = new Padding(5, 0, 0, 0);
            aperture.Location = where;

            panelSquareLayout.Controls.Add(aperture);

            return aperture;
        }
    }
}
