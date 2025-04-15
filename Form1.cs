using Newtonsoft.Json;
using Satisfactory_Tools.model;

namespace Satisfactory_Tools
{
    public partial class MainForm : Form
    {
        Root _root = new Root();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void squareLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelSquareLayout.Visible = true;
        }

        private void HidePanels()
        {
            panelSquareLayout.Visible = false;
            panelMachineCalculator.Visible = false;
        }

        private void machineCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            var myJsonResponse = File.ReadAllText(Path.Combine(Application.StartupPath, "model\\data.json"));
            _root = JsonConvert.DeserializeObject<Root>(myJsonResponse);

            if (_root != null)
            {
                foreach (var building in _root.Buildings)
                {
                    comboBoxBuildings.Items.Add(building);
                }

                panelMachineCalculator.Visible = true;
            }
        }
        private void comboBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRecipes.Items.Clear();

            foreach (var recipe in ((Building)comboBoxBuildings.Items[comboBoxBuildings.SelectedIndex]).Recipes)
            {
                comboBoxRecipes.Items.Add(recipe);
            }
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
