namespace Bell_Vouncher_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            nookMilesInput = new TextBox();
            label2 = new Label();
            calculateButton = new Button();
            resetButton = new Button();
            bellsResult = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            exitButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("FinkHeavy", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(535, 92);
            label1.TabIndex = 0;
            label1.Text = "\U0001fa99Bell Vouncher Calculator\U0001fa99";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nookMilesInput
            // 
            nookMilesInput.BackColor = SystemColors.Window;
            nookMilesInput.Font = new Font("FinkHeavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nookMilesInput.Location = new Point(12, 156);
            nookMilesInput.Name = "nookMilesInput";
            nookMilesInput.PlaceholderText = "Miles Amount...";
            nookMilesInput.Size = new Size(535, 35);
            nookMilesInput.TabIndex = 1;
            nookMilesInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("FinkHeavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(535, 32);
            label2.TabIndex = 2;
            label2.Text = "Enter the amount of Nook Miles you have:";
            // 
            // calculateButton
            // 
            calculateButton.AutoSize = true;
            calculateButton.Dock = DockStyle.Fill;
            calculateButton.Font = new Font("FinkHeavy", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateButton.Location = new Point(3, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(261, 57);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate!";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // resetButton
            // 
            resetButton.AutoSize = true;
            resetButton.Dock = DockStyle.Fill;
            resetButton.Font = new Font("FinkHeavy", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(270, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(262, 57);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset!";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // bellsResult
            // 
            bellsResult.BackColor = Color.Transparent;
            bellsResult.Font = new Font("FinkHeavy", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bellsResult.Location = new Point(12, 274);
            bellsResult.Name = "bellsResult";
            bellsResult.Size = new Size(535, 125);
            bellsResult.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(calculateButton, 0, 0);
            tableLayoutPanel1.Controls.Add(resetButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 197);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(535, 63);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("FinkHeavy", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlText;
            exitButton.Location = new Point(12, 414);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(535, 45);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(559, 471);
            Controls.Add(exitButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(bellsResult);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nookMilesInput);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bell Voucher Calculator";
            TransparencyKey = Color.Turquoise;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nookMilesInput;
        private Label label2;
        private Button calculateButton;
        private Button resetButton;
        private Label bellsResult;
        private TableLayoutPanel tableLayoutPanel1;
        private Button exitButton;
    }
}
