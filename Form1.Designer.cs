namespace Calculator1._1
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
            VirtualLabel = new Label();
            MainLabel = new Label();
            ResultLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonReset = new Button();
            buttonDot = new Button();
            buttonDegree = new Button();
            buttonSquare = new Button();
            buttonMultiplication = new Button();
            buttonDivision = new Button();
            buttonAddition = new Button();
            buttonSubtraction = new Button();
            buttonResult = new Button();
            SuspendLayout();
            // 
            // VirtualLabel
            // 
            VirtualLabel.AutoSize = true;
            VirtualLabel.Location = new Point(319, 9);
            VirtualLabel.Name = "VirtualLabel";
            VirtualLabel.Size = new Size(0, 20);
            VirtualLabel.TabIndex = 0;
            // 
            // MainLabel
            // 
            MainLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainLabel.BackColor = Color.FromArgb(128, 255, 255);
            MainLabel.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabel.ForeColor = Color.Navy;
            MainLabel.Image = Properties.Resources.glass;
            MainLabel.ImageAlign = ContentAlignment.MiddleLeft;
            MainLabel.Location = new Point(30, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(525, 146);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "0";
            MainLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ResultLabel.BackColor = Color.Transparent;
            ResultLabel.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ResultLabel.ForeColor = Color.Gray;
            ResultLabel.Image = Properties.Resources.glass;
            ResultLabel.ImageAlign = ContentAlignment.MiddleLeft;
            ResultLabel.Location = new Point(30, 155);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(525, 54);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "0";
            ResultLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.button;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 449);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = Properties.Resources.button;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(141, 449);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImage = Properties.Resources.button;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(253, 449);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImage = Properties.Resources.button;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(30, 339);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImage = Properties.Resources.button;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(141, 339);
            button5.Name = "button5";
            button5.Size = new Size(80, 80);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.BackgroundImage = Properties.Resources.button;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(253, 339);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.BackgroundImage = Properties.Resources.button;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(30, 231);
            button7.Name = "button7";
            button7.Size = new Size(80, 80);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.BackgroundImage = Properties.Resources.button;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(141, 231);
            button8.Name = "button8";
            button8.Size = new Size(80, 80);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.BackgroundImage = Properties.Resources.button;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(253, 231);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // button0
            // 
            button0.BackColor = Color.Black;
            button0.BackgroundImage = Properties.Resources.button;
            button0.BackgroundImageLayout = ImageLayout.Stretch;
            button0.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(141, 561);
            button0.Name = "button0";
            button0.Size = new Size(80, 80);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click_1;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Black;
            buttonReset.BackgroundImage = Properties.Resources.button;
            buttonReset.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReset.Font = new Font("Ink Free", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.ForeColor = Color.FromArgb(192, 0, 0);
            buttonReset.Location = new Point(30, 561);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(80, 80);
            buttonReset.TabIndex = 13;
            buttonReset.Text = "ac";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.Black;
            buttonDot.BackgroundImage = Properties.Resources.button;
            buttonDot.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDot.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDot.Location = new Point(253, 561);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(80, 80);
            buttonDot.TabIndex = 14;
            buttonDot.Text = ",";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click_1;
            // 
            // buttonDegree
            // 
            buttonDegree.BackColor = Color.Black;
            buttonDegree.BackgroundImage = Properties.Resources.button;
            buttonDegree.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDegree.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDegree.Location = new Point(475, 231);
            buttonDegree.Name = "buttonDegree";
            buttonDegree.Size = new Size(80, 80);
            buttonDegree.TabIndex = 20;
            buttonDegree.Text = "x^";
            buttonDegree.UseVisualStyleBackColor = false;
            buttonDegree.Click += buttonDegree_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.BackColor = Color.Black;
            buttonSquare.BackgroundImage = Properties.Resources.button;
            buttonSquare.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSquare.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSquare.Location = new Point(363, 231);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(80, 80);
            buttonSquare.TabIndex = 19;
            buttonSquare.Text = "√";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.BackColor = Color.Black;
            buttonMultiplication.BackgroundImage = Properties.Resources.button;
            buttonMultiplication.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMultiplication.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMultiplication.Location = new Point(475, 339);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(80, 80);
            buttonMultiplication.TabIndex = 18;
            buttonMultiplication.Text = "*";
            buttonMultiplication.TextAlign = ContentAlignment.BottomCenter;
            buttonMultiplication.UseVisualStyleBackColor = false;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.Black;
            buttonDivision.BackgroundImage = Properties.Resources.button;
            buttonDivision.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDivision.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDivision.Location = new Point(363, 339);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(80, 80);
            buttonDivision.TabIndex = 17;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.BackColor = Color.Black;
            buttonAddition.BackgroundImage = Properties.Resources.button;
            buttonAddition.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddition.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddition.Location = new Point(475, 449);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(80, 80);
            buttonAddition.TabIndex = 16;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = false;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // buttonSubtraction
            // 
            buttonSubtraction.BackColor = Color.Black;
            buttonSubtraction.BackgroundImage = Properties.Resources.button;
            buttonSubtraction.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSubtraction.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubtraction.Location = new Point(363, 449);
            buttonSubtraction.Name = "buttonSubtraction";
            buttonSubtraction.Size = new Size(80, 80);
            buttonSubtraction.TabIndex = 15;
            buttonSubtraction.Text = "-";
            buttonSubtraction.UseVisualStyleBackColor = false;
            buttonSubtraction.Click += buttonSubtraction_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Black;
            buttonResult.BackgroundImage = Properties.Resources.button;
            buttonResult.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResult.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResult.Location = new Point(363, 561);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(192, 80);
            buttonResult.TabIndex = 21;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.metall;
            ClientSize = new Size(582, 653);
            Controls.Add(ResultLabel);
            Controls.Add(buttonResult);
            Controls.Add(buttonDegree);
            Controls.Add(buttonSquare);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonDivision);
            Controls.Add(buttonAddition);
            Controls.Add(buttonSubtraction);
            Controls.Add(buttonDot);
            Controls.Add(buttonReset);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MainLabel);
            Controls.Add(VirtualLabel);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VirtualLabel;
        private Label MainLabel;
        private Label ResultLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonReset;
        private Button buttonDot;
        private Button buttonDegree;
        private Button buttonSquare;
        private Button buttonMultiplication;
        private Button buttonDivision;
        private Button buttonAddition;
        private Button buttonSubtraction;
        private Button buttonResult;
    }
}