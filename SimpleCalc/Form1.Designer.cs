namespace SimpleCalc
{
    partial class 簡単計算プログラム
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
            this.components = new System.ComponentModel.Container();
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.plusLabel1 = new System.Windows.Forms.Label();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.equalLabel1 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // input1TextBox
            // 
            this.input1TextBox.Location = new System.Drawing.Point(71, 54);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(150, 31);
            this.input1TextBox.TabIndex = 0;
            // 
            // plusLabel1
            // 
            this.plusLabel1.AutoSize = true;
            this.plusLabel1.Location = new System.Drawing.Point(227, 57);
            this.plusLabel1.Name = "plusLabel1";
            this.plusLabel1.Size = new System.Drawing.Size(24, 25);
            this.plusLabel1.TabIndex = 1;
            this.plusLabel1.Text = "+";
            // 
            // input2TextBox
            // 
            this.input2TextBox.Location = new System.Drawing.Point(257, 54);
            this.input2TextBox.Name = "input2TextBox";
            this.input2TextBox.Size = new System.Drawing.Size(150, 31);
            this.input2TextBox.TabIndex = 2;
            // 
            // equalLabel1
            // 
            this.equalLabel1.AutoSize = true;
            this.equalLabel1.Location = new System.Drawing.Point(413, 57);
            this.equalLabel1.Name = "equalLabel1";
            this.equalLabel1.Size = new System.Drawing.Size(24, 25);
            this.equalLabel1.TabIndex = 3;
            this.equalLabel1.Text = "=";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(443, 54);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(150, 31);
            this.answerTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(71, 119);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(522, 34);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "計算する";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.CalcButton_Click);
            // 
            // 簡単計算プログラム
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 756);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.equalLabel1);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.plusLabel1);
            this.Controls.Add(this.input1TextBox);
            this.Name = "簡単計算プログラム";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input1TextBox;
        private Label plusLabel1;
        private TextBox input2TextBox;
        private Label equalLabel1;
        private TextBox answerTextBox;
        private Button CalcButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}