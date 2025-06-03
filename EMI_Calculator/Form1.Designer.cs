namespace EMI_Calculator
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
            label2 = new Label();
            Principle = new TextBox();
            Rate = new TextBox();
            label3 = new Label();
            Tenure = new TextBox();
            label4 = new Label();
            button1 = new Button();
            Output1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 50);
            label1.TabIndex = 0;
            label1.Text = "EMI Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(202, 113);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Principle";
            // 
            // Principle
            // 
            Principle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Principle.Location = new Point(298, 110);
            Principle.MaxLength = 10;
            Principle.Name = "Principle";
            Principle.Size = new Size(282, 33);
            Principle.TabIndex = 2;
            // 
            // Rate
            // 
            Rate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rate.Location = new Point(298, 165);
            Rate.MaxLength = 3;
            Rate.Name = "Rate";
            Rate.Size = new Size(282, 33);
            Rate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(142, 168);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 3;
            label3.Text = "Rate Of Interest";
            // 
            // Tenure
            // 
            Tenure.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tenure.Location = new Point(298, 221);
            Tenure.MaxLength = 3;
            Tenure.Name = "Tenure";
            Tenure.Size = new Size(282, 33);
            Tenure.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(170, 224);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 5;
            label4.Text = "Loan Tenure";
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(298, 365);
            button1.Name = "button1";
            button1.Size = new Size(231, 61);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Output1
            // 
            Output1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Output1.Location = new Point(298, 303);
            Output1.Name = "Output1";
            Output1.ReadOnly = true;
            Output1.Size = new Size(282, 33);
            Output1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(159, 306);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 9;
            label5.Text = "Monthly EMI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Output1);
            Controls.Add(button1);
            Controls.Add(Tenure);
            Controls.Add(label4);
            Controls.Add(Rate);
            Controls.Add(label3);
            Controls.Add(Principle);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Principle;
        private TextBox Rate;
        private Label label3;
        private TextBox Tenure;
        private Label label4;
        private Button button1;
        private TextBox Output1;
        private Label label5;
        private Label label6;
        private TextBox Output2;
    }
}
