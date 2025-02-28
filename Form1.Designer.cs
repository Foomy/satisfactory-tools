namespace Satisfactory_Tools
{
    partial class Form1
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
            exitToolStripMenuItem = new ToolStripMenuItem();
            squareLayoutToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            panelSquareLayout = new Panel();
            squareDivisorsLabel = new Label();
            calcSquareRootsButton = new Button();
            numeratorInputTextBox = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            panelSquareLayout.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, squareLayoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1728, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
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
            // panelSquareLayout
            // 
            panelSquareLayout.Controls.Add(squareDivisorsLabel);
            panelSquareLayout.Controls.Add(calcSquareRootsButton);
            panelSquareLayout.Controls.Add(numeratorInputTextBox);
            panelSquareLayout.Controls.Add(label1);
            panelSquareLayout.Location = new Point(12, 31);
            panelSquareLayout.Name = "panelSquareLayout";
            panelSquareLayout.Size = new Size(1704, 995);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 1038);
            Controls.Add(panelSquareLayout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSquareLayout.ResumeLayout(false);
            panelSquareLayout.PerformLayout();
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
    }
}
