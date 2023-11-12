namespace AppWindows
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
            lblTitle = new Label();
            btnEvaluate = new Button();
            lblHeight = new Label();
            gpboxHeight = new GroupBox();
            numUpDownHeight = new NumericUpDown();
            gpboxWeight = new GroupBox();
            numUpDownWeight = new NumericUpDown();
            lblWeight = new Label();
            lblResult = new Label();
            gpboxHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownHeight).BeginInit();
            gpboxWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownWeight).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleRole = AccessibleRole.TitleBar;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(212, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Body Mass Index (BMI) Calculator";
            lblTitle.Click += label1_Click;
            // 
            // btnEvaluate
            // 
            btnEvaluate.BackColor = Color.FromArgb(128, 64, 64);
            btnEvaluate.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            btnEvaluate.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvaluate.ForeColor = Color.Linen;
            btnEvaluate.Location = new Point(232, 180);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(330, 45);
            btnEvaluate.TabIndex = 1;
            btnEvaluate.Text = "Evaluate";
            btnEvaluate.UseMnemonic = false;
            btnEvaluate.UseVisualStyleBackColor = false;
            btnEvaluate.Click += btnEvalueate_Click;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(12, 21);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 30);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height\n(m)";
            lblHeight.Click += label2_Click;
            // 
            // gpboxHeight
            // 
            gpboxHeight.Controls.Add(numUpDownHeight);
            gpboxHeight.Controls.Add(lblHeight);
            gpboxHeight.Location = new Point(83, 92);
            gpboxHeight.Name = "gpboxHeight";
            gpboxHeight.Size = new Size(296, 60);
            gpboxHeight.TabIndex = 4;
            gpboxHeight.TabStop = false;
            gpboxHeight.Enter += groupBox1_Enter;
            // 
            // numUpDownHeight
            // 
            numUpDownHeight.DecimalPlaces = 3;
            numUpDownHeight.Location = new Point(70, 24);
            numUpDownHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUpDownHeight.Name = "numUpDownHeight";
            numUpDownHeight.Size = new Size(201, 23);
            numUpDownHeight.TabIndex = 7;
            // 
            // gpboxWeight
            // 
            gpboxWeight.Controls.Add(numUpDownWeight);
            gpboxWeight.Controls.Add(lblWeight);
            gpboxWeight.Location = new Point(431, 92);
            gpboxWeight.Name = "gpboxWeight";
            gpboxWeight.Size = new Size(296, 60);
            gpboxWeight.TabIndex = 5;
            gpboxWeight.TabStop = false;
            // 
            // numUpDownWeight
            // 
            numUpDownWeight.DecimalPlaces = 3;
            numUpDownWeight.Location = new Point(75, 25);
            numUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUpDownWeight.Name = "numUpDownWeight";
            numUpDownWeight.Size = new Size(201, 23);
            numUpDownWeight.TabIndex = 8;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(14, 22);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 30);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Weight\n(kg)";
            lblWeight.Click += lblWeight_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.DarkRed;
            lblResult.Location = new Point(83, 287);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(274, 23);
            lblResult.TabIndex = 6;
            lblResult.Text = "Your result: Normal Weight";
            lblResult.Visible = false;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(gpboxWeight);
            Controls.Add(gpboxHeight);
            Controls.Add(btnEvaluate);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gpboxHeight.ResumeLayout(false);
            gpboxHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownHeight).EndInit();
            gpboxWeight.ResumeLayout(false);
            gpboxWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnEvaluate;
        private Label lblHeight;
        private GroupBox gpboxHeight;
        private GroupBox gpboxWeight;
        private Label lblWeight;
        private Label lblResult;
        private NumericUpDown numUpDownHeight;
        private NumericUpDown numUpDownWeight;
    }
}