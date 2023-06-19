namespace BMICalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textcmft = new System.Windows.Forms.TextBox();
            this.textinch = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelNormalBMI = new System.Windows.Forms.Label();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelBMI2 = new System.Windows.Forms.Label();
            this.BMILabel2 = new System.Windows.Forms.Label();
            this.labelBMI1 = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxkg = new System.Windows.Forms.TextBox();
            this.SavingPlan = new System.Windows.Forms.GroupBox();
            this.FutureValue = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.FuturValueLbl1 = new System.Windows.Forms.Label();
            this.FutureValueLbl2 = new System.Windows.Forms.Label();
            this.SavingPlanLbl1 = new System.Windows.Forms.Label();
            this.SavingPlanLbl2 = new System.Windows.Forms.Label();
            this.SavingPlantxtbx1 = new System.Windows.Forms.TextBox();
            this.SavingPlantxtbx2 = new System.Windows.Forms.TextBox();
            this.FutureValueLbl11 = new System.Windows.Forms.Label();
            this.FutureValueLbl22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SavingPlan.SuspendLayout();
            this.FutureValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(35, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textName.Location = new System.Drawing.Point(162, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(224, 40);
            this.textName.TabIndex = 1;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeight.Location = new System.Drawing.Point(35, 81);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(62, 20);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height";
            // 
            // textcmft
            // 
            this.textcmft.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcmft.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textcmft.Location = new System.Drawing.Point(162, 81);
            this.textcmft.Name = "textcmft";
            this.textcmft.Size = new System.Drawing.Size(108, 40);
            this.textcmft.TabIndex = 3;
            // 
            // textinch
            // 
            this.textinch.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textinch.Location = new System.Drawing.Point(276, 81);
            this.textinch.Name = "textinch";
            this.textinch.Size = new System.Drawing.Size(110, 40);
            this.textinch.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCalculate.Location = new System.Drawing.Point(536, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 37);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNormalBMI
            // 
            this.labelNormalBMI.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelNormalBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNormalBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormalBMI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNormalBMI.Location = new System.Drawing.Point(467, 355);
            this.labelNormalBMI.Name = "labelNormalBMI";
            this.labelNormalBMI.Size = new System.Drawing.Size(296, 75);
            this.labelNormalBMI.TabIndex = 10;
            this.labelNormalBMI.Text = "label1";
            this.labelNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxUnit.Controls.Add(this.rbtnImperial);
            this.groupBoxUnit.Controls.Add(this.rbtnMetric);
            this.groupBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxUnit.Location = new System.Drawing.Point(467, 25);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(296, 209);
            this.groupBoxUnit.TabIndex = 11;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(24, 91);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(181, 29);
            this.rbtnImperial.TabIndex = 13;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (ft,lbs)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(24, 40);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(175, 29);
            this.rbtnMetric.TabIndex = 12;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric(kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxResults.Controls.Add(this.labelBMI2);
            this.groupBoxResults.Controls.Add(this.BMILabel2);
            this.groupBoxResults.Controls.Add(this.labelBMI1);
            this.groupBoxResults.Controls.Add(this.BMILabel);
            this.groupBoxResults.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxResults.Location = new System.Drawing.Point(15, 261);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(440, 169);
            this.groupBoxResults.TabIndex = 12;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results for";
            // 
            // labelBMI2
            // 
            this.labelBMI2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBMI2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMI2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBMI2.Location = new System.Drawing.Point(206, 100);
            this.labelBMI2.Name = "labelBMI2";
            this.labelBMI2.Size = new System.Drawing.Size(228, 49);
            this.labelBMI2.TabIndex = 13;
            this.labelBMI2.Text = "label1";
            this.labelBMI2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BMILabel2
            // 
            this.BMILabel2.AutoSize = true;
            this.BMILabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BMILabel2.Location = new System.Drawing.Point(30, 100);
            this.BMILabel2.Name = "BMILabel2";
            this.BMILabel2.Size = new System.Drawing.Size(174, 25);
            this.BMILabel2.TabIndex = 12;
            this.BMILabel2.Text = "Weight Category";
            // 
            // labelBMI1
            // 
            this.labelBMI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBMI1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMI1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBMI1.Location = new System.Drawing.Point(206, 36);
            this.labelBMI1.Name = "labelBMI1";
            this.labelBMI1.Size = new System.Drawing.Size(228, 45);
            this.labelBMI1.TabIndex = 11;
            this.labelBMI1.Text = "label";
            this.labelBMI1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelBMI1.Click += new System.EventHandler(this.labelBMI1_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BMILabel.Location = new System.Drawing.Point(30, 55);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(101, 25);
            this.BMILabel.TabIndex = 10;
            this.BMILabel.Text = "Your BMI";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelWeight.Location = new System.Drawing.Point(32, 140);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 20);
            this.labelWeight.TabIndex = 13;
            this.labelWeight.Text = "Weight";
            // 
            // textBoxkg
            // 
            this.textBoxkg.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxkg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxkg.Location = new System.Drawing.Point(162, 140);
            this.textBoxkg.Name = "textBoxkg";
            this.textBoxkg.Size = new System.Drawing.Size(108, 40);
            this.textBoxkg.TabIndex = 14;
            // 
            // SavingPlan
            // 
            this.SavingPlan.BackColor = System.Drawing.Color.Violet;
            this.SavingPlan.Controls.Add(this.SavingPlantxtbx2);
            this.SavingPlan.Controls.Add(this.SavingPlantxtbx1);
            this.SavingPlan.Controls.Add(this.SavingPlanLbl2);
            this.SavingPlan.Controls.Add(this.SavingPlanLbl1);
            this.SavingPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingPlan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SavingPlan.Location = new System.Drawing.Point(26, 42);
            this.SavingPlan.Name = "SavingPlan";
            this.SavingPlan.Size = new System.Drawing.Size(374, 164);
            this.SavingPlan.TabIndex = 15;
            this.SavingPlan.TabStop = false;
            this.SavingPlan.Text = "Saving Plan";
            // 
            // FutureValue
            // 
            this.FutureValue.BackColor = System.Drawing.Color.DarkOrchid;
            this.FutureValue.Controls.Add(this.FutureValueLbl22);
            this.FutureValue.Controls.Add(this.FutureValueLbl11);
            this.FutureValue.Controls.Add(this.FutureValueLbl2);
            this.FutureValue.Controls.Add(this.FuturValueLbl1);
            this.FutureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FutureValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FutureValue.Location = new System.Drawing.Point(26, 279);
            this.FutureValue.Name = "FutureValue";
            this.FutureValue.Size = new System.Drawing.Size(374, 150);
            this.FutureValue.TabIndex = 16;
            this.FutureValue.TabStop = false;
            this.FutureValue.Text = "Future Value";
            // 
            // OKButton
            // 
            this.OKButton.ForeColor = System.Drawing.Color.DarkMagenta;
            this.OKButton.Location = new System.Drawing.Point(142, 220);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(153, 41);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Calculate";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FuturValueLbl1
            // 
            this.FuturValueLbl1.AutoSize = true;
            this.FuturValueLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuturValueLbl1.Location = new System.Drawing.Point(18, 37);
            this.FuturValueLbl1.Name = "FuturValueLbl1";
            this.FuturValueLbl1.Size = new System.Drawing.Size(116, 20);
            this.FuturValueLbl1.TabIndex = 0;
            this.FuturValueLbl1.Text = "Amount Paid:";
            this.FuturValueLbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FutureValueLbl2
            // 
            this.FutureValueLbl2.AutoSize = true;
            this.FutureValueLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FutureValueLbl2.Location = new System.Drawing.Point(18, 103);
            this.FutureValueLbl2.Name = "FutureValueLbl2";
            this.FutureValueLbl2.Size = new System.Drawing.Size(128, 20);
            this.FutureValueLbl2.TabIndex = 1;
            this.FutureValueLbl2.Text = "Final Balance: ";
            // 
            // SavingPlanLbl1
            // 
            this.SavingPlanLbl1.AutoSize = true;
            this.SavingPlanLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingPlanLbl1.Location = new System.Drawing.Point(18, 46);
            this.SavingPlanLbl1.Name = "SavingPlanLbl1";
            this.SavingPlanLbl1.Size = new System.Drawing.Size(138, 20);
            this.SavingPlanLbl1.TabIndex = 0;
            this.SavingPlanLbl1.Text = "Monthly Deposit";
            this.SavingPlanLbl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // SavingPlanLbl2
            // 
            this.SavingPlanLbl2.AutoSize = true;
            this.SavingPlanLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingPlanLbl2.Location = new System.Drawing.Point(18, 110);
            this.SavingPlanLbl2.Name = "SavingPlanLbl2";
            this.SavingPlanLbl2.Size = new System.Drawing.Size(120, 20);
            this.SavingPlanLbl2.TabIndex = 1;
            this.SavingPlanLbl2.Text = "Period (years)";
            // 
            // SavingPlantxtbx1
            // 
            this.SavingPlantxtbx1.Location = new System.Drawing.Point(175, 46);
            this.SavingPlantxtbx1.Name = "SavingPlantxtbx1";
            this.SavingPlantxtbx1.Size = new System.Drawing.Size(171, 26);
            this.SavingPlantxtbx1.TabIndex = 2;
            // 
            // SavingPlantxtbx2
            // 
            this.SavingPlantxtbx2.Location = new System.Drawing.Point(175, 110);
            this.SavingPlantxtbx2.Name = "SavingPlantxtbx2";
            this.SavingPlantxtbx2.Size = new System.Drawing.Size(171, 26);
            this.SavingPlantxtbx2.TabIndex = 3;
            // 
            // FutureValueLbl11
            // 
            this.FutureValueLbl11.BackColor = System.Drawing.Color.Violet;
            this.FutureValueLbl11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FutureValueLbl11.Location = new System.Drawing.Point(175, 25);
            this.FutureValueLbl11.Name = "FutureValueLbl11";
            this.FutureValueLbl11.Size = new System.Drawing.Size(171, 45);
            this.FutureValueLbl11.TabIndex = 2;
            this.FutureValueLbl11.Text = "label5";
            this.FutureValueLbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FutureValueLbl22
            // 
            this.FutureValueLbl22.BackColor = System.Drawing.Color.Violet;
            this.FutureValueLbl22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FutureValueLbl22.Location = new System.Drawing.Point(175, 90);
            this.FutureValueLbl22.Name = "FutureValueLbl22";
            this.FutureValueLbl22.Size = new System.Drawing.Size(171, 47);
            this.FutureValueLbl22.TabIndex = 3;
            this.FutureValueLbl22.Text = "label6";
            this.FutureValueLbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Controls.Add(this.OKButton);
            this.groupBox1.Controls.Add(this.FutureValue);
            this.groupBox1.Controls.Add(this.SavingPlan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(819, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 446);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Savings Calculator";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBoxResults);
            this.groupBox2.Controls.Add(this.groupBoxUnit);
            this.groupBox2.Controls.Add(this.labelNormalBMI);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 447);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMI Calculator";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox3.Controls.Add(this.textBoxkg);
            this.groupBox3.Controls.Add(this.labelWeight);
            this.groupBox3.Controls.Add(this.textinch);
            this.groupBox3.Controls.Add(this.textcmft);
            this.groupBox3.Controls.Add(this.labelHeight);
            this.groupBox3.Controls.Add(this.textName);
            this.groupBox3.Controls.Add(this.labelName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(14, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 209);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "MainForm";
            this.Text = "BMI Calculator and Savings Plan by";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.SavingPlan.ResumeLayout(false);
            this.SavingPlan.PerformLayout();
            this.FutureValue.ResumeLayout(false);
            this.FutureValue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textcmft;
        private System.Windows.Forms.TextBox textinch;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelNormalBMI;
        private System.Windows.Forms.GroupBox groupBoxUnit;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelBMI2;
        private System.Windows.Forms.Label BMILabel2;
        private System.Windows.Forms.Label labelBMI1;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxkg;
        private System.Windows.Forms.GroupBox SavingPlan;
        private System.Windows.Forms.GroupBox FutureValue;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox SavingPlantxtbx2;
        private System.Windows.Forms.TextBox SavingPlantxtbx1;
        private System.Windows.Forms.Label SavingPlanLbl2;
        private System.Windows.Forms.Label SavingPlanLbl1;
        private System.Windows.Forms.Label FutureValueLbl22;
        private System.Windows.Forms.Label FutureValueLbl11;
        private System.Windows.Forms.Label FutureValueLbl2;
        private System.Windows.Forms.Label FuturValueLbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

