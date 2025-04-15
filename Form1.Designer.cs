namespace Satisfactory_Tools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            editDataToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            squareLayoutToolStripMenuItem = new ToolStripMenuItem();
            machineCalculatorToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            panelSquareLayout = new Panel();
            squareDivisorsLabel = new Label();
            calcSquareRootsButton = new Button();
            numeratorInputTextBox = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panelMachineCalculator = new Panel();
            labelRecipe = new Label();
            comboBoxRecipes = new ComboBox();
            labelMachine = new Label();
            comboBoxBuildings = new ComboBox();
            menuStrip1.SuspendLayout();
            panelSquareLayout.SuspendLayout();
            panelMachineCalculator.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, squareLayoutToolStripMenuItem, machineCalculatorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1349, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editDataToolStripMenuItem, exitToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // editDataToolStripMenuItem
            // 
            editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            editDataToolStripMenuItem.Size = new Size(154, 26);
            editDataToolStripMenuItem.Text = "Edit Data";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(154, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // squareLayoutToolStripMenuItem
            // 
            squareLayoutToolStripMenuItem.Name = "squareLayoutToolStripMenuItem";
            squareLayoutToolStripMenuItem.Size = new Size(117, 24);
            squareLayoutToolStripMenuItem.Text = "Square Layout";
            squareLayoutToolStripMenuItem.Click += squareLayoutToolStripMenuItem_Click;
            // 
            // machineCalculatorToolStripMenuItem
            // 
            machineCalculatorToolStripMenuItem.Name = "machineCalculatorToolStripMenuItem";
            machineCalculatorToolStripMenuItem.Size = new Size(150, 24);
            machineCalculatorToolStripMenuItem.Text = "Machine Calculator";
            machineCalculatorToolStripMenuItem.Click += machineCalculatorToolStripMenuItem_Click;
            // 
            // panelSquareLayout
            // 
            panelSquareLayout.AutoSize = true;
            panelSquareLayout.Controls.Add(squareDivisorsLabel);
            panelSquareLayout.Controls.Add(calcSquareRootsButton);
            panelSquareLayout.Controls.Add(numeratorInputTextBox);
            panelSquareLayout.Controls.Add(label1);
            panelSquareLayout.Dock = DockStyle.Fill;
            panelSquareLayout.Location = new Point(0, 28);
            panelSquareLayout.Name = "panelSquareLayout";
            panelSquareLayout.Size = new Size(1349, 863);
            panelSquareLayout.TabIndex = 1;
            panelSquareLayout.Visible = false;
            // 
            // squareDivisorsLabel
            // 
            squareDivisorsLabel.AutoSize = true;
            squareDivisorsLabel.Location = new Point(27, 101);
            squareDivisorsLabel.Name = "squareDivisorsLabel";
            squareDivisorsLabel.Size = new Size(295, 20);
            squareDivisorsLabel.TabIndex = 8;
            squareDivisorsLabel.Text = "The Square Divisior of {input} are: {divisors}";
            // 
            // calcSquareRootsButton
            // 
            calcSquareRootsButton.Location = new Point(281, 56);
            calcSquareRootsButton.Name = "calcSquareRootsButton";
            calcSquareRootsButton.Size = new Size(94, 29);
            calcSquareRootsButton.TabIndex = 7;
            calcSquareRootsButton.Text = "calculate";
            calcSquareRootsButton.UseVisualStyleBackColor = true;
            calcSquareRootsButton.Click += calcSquareRootsButton_Click;
            // 
            // numeratorInputTextBox
            // 
            numeratorInputTextBox.Location = new Point(27, 56);
            numeratorInputTextBox.Name = "numeratorInputTextBox";
            numeratorInputTextBox.Size = new Size(248, 27);
            numeratorInputTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(211, 20);
            label1.TabIndex = 4;
            label1.Text = "Please enter a positive integer:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panelMachineCalculator
            // 
            panelMachineCalculator.AutoSize = true;
            panelMachineCalculator.Controls.Add(labelRecipe);
            panelMachineCalculator.Controls.Add(comboBoxRecipes);
            panelMachineCalculator.Controls.Add(labelMachine);
            panelMachineCalculator.Controls.Add(comboBoxBuildings);
            panelMachineCalculator.Dock = DockStyle.Fill;
            panelMachineCalculator.Location = new Point(0, 28);
            panelMachineCalculator.Name = "panelMachineCalculator";
            panelMachineCalculator.Size = new Size(1349, 863);
            panelMachineCalculator.TabIndex = 9;
            panelMachineCalculator.Visible = false;
            // 
            // labelRecipe
            // 
            labelRecipe.AutoSize = true;
            labelRecipe.Location = new Point(244, 23);
            labelRecipe.Name = "labelRecipe";
            labelRecipe.Size = new Size(57, 20);
            labelRecipe.TabIndex = 3;
            labelRecipe.Text = "Recipe:";
            // 
            // comboBoxRecipes
            // 
            comboBoxRecipes.FormattingEnabled = true;
            comboBoxRecipes.Location = new Point(244, 57);
            comboBoxRecipes.Name = "comboBoxRecipes";
            comboBoxRecipes.Size = new Size(196, 28);
            comboBoxRecipes.TabIndex = 2;
            // 
            // labelMachine
            // 
            labelMachine.AutoSize = true;
            labelMachine.Location = new Point(27, 23);
            labelMachine.Name = "labelMachine";
            labelMachine.Size = new Size(67, 20);
            labelMachine.TabIndex = 1;
            labelMachine.Text = "Building:";
            // 
            // comboBoxBuildings
            // 
            comboBoxBuildings.FormattingEnabled = true;
            comboBoxBuildings.Location = new Point(27, 57);
            comboBoxBuildings.Name = "comboBoxBuildings";
            comboBoxBuildings.Size = new Size(196, 28);
            comboBoxBuildings.TabIndex = 0;
            comboBoxBuildings.SelectedIndexChanged += comboBoxBuildings_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 891);
            Controls.Add(panelMachineCalculator);
            Controls.Add(panelSquareLayout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Satisfactory Tools";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSquareLayout.ResumeLayout(false);
            panelSquareLayout.PerformLayout();
            panelMachineCalculator.ResumeLayout(false);
            panelMachineCalculator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem squareLayoutToolStripMenuItem;
        private FontDialog fontDialog1;
        private Panel panelSquareLayout;
        private TextBox numeratorInputTextBox;
        private Label label1;
        private Button calcSquareRootsButton;
        private Label squareDivisorsLabel;
        private ImageList imageList1;
        private ToolStripMenuItem machineCalculatorToolStripMenuItem;
        private Panel panelMachineCalculator;
        private Label labelRecipe;
        private ComboBox comboBoxRecipes;
        private Label labelMachine;
        private ComboBox comboBoxBuildings;
        private ToolStripMenuItem editDataToolStripMenuItem;
    }
}
