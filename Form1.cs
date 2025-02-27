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

            PictureBox aperture = new PictureBox();
            aperture.Load(@"C:\Users\SirFoomy\source\repos\Satisfactory-Tools\assets\images\Aperture_Science_indicator_floor_blue-32px.png");
            aperture.Width = 32;
            aperture.Height = 32;

            //aperture.Location = new Point(50, 150);

            panelSquareLayout.Controls.Add(aperture);
            panelSquareLayout.Controls.SetChildIndex(aperture, 50);
        }
    }
}
