namespace ClassAssignment
{
    partial class QuestionThreeForm
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
            this.restButton = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arrayLengthLabel = new System.Windows.Forms.Label();
            this.totalLengthLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.questionTwoLabel = new System.Windows.Forms.Label();
            this.inputArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restButton
            // 
            this.restButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restButton.ForeColor = System.Drawing.Color.Red;
            this.restButton.Location = new System.Drawing.Point(192, 166);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(69, 28);
            this.restButton.TabIndex = 15;
            this.restButton.Text = "Reset";
            this.restButton.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(31, 123);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter a number an click next";
            // 
            // arrayLengthLabel
            // 
            this.arrayLengthLabel.AutoSize = true;
            this.arrayLengthLabel.Location = new System.Drawing.Point(136, 99);
            this.arrayLengthLabel.Name = "arrayLengthLabel";
            this.arrayLengthLabel.Size = new System.Drawing.Size(13, 13);
            this.arrayLengthLabel.TabIndex = 12;
            this.arrayLengthLabel.Text = "0";
            // 
            // totalLengthLabel
            // 
            this.totalLengthLabel.AutoSize = true;
            this.totalLengthLabel.Location = new System.Drawing.Point(149, 99);
            this.totalLengthLabel.Name = "totalLengthLabel";
            this.totalLengthLabel.Size = new System.Drawing.Size(18, 13);
            this.totalLengthLabel.TabIndex = 11;
            this.totalLengthLabel.Text = "/6";
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(34, 166);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(69, 28);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // questionTwoLabel
            // 
            this.questionTwoLabel.AutoSize = true;
            this.questionTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTwoLabel.Location = new System.Drawing.Point(31, 27);
            this.questionTwoLabel.Name = "questionTwoLabel";
            this.questionTwoLabel.Size = new System.Drawing.Size(101, 13);
            this.questionTwoLabel.TabIndex = 9;
            this.questionTwoLabel.Text = "Enter 6 Numbers";
            // 
            // inputArea
            // 
            this.inputArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputArea.Location = new System.Drawing.Point(34, 65);
            this.inputArea.Name = "inputArea";
            this.inputArea.Size = new System.Drawing.Size(139, 31);
            this.inputArea.TabIndex = 8;
            // 
            // QuestionThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 234);
            this.Controls.Add(this.restButton);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayLengthLabel);
            this.Controls.Add(this.totalLengthLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.questionTwoLabel);
            this.Controls.Add(this.inputArea);
            this.Name = "QuestionThreeForm";
            this.Text = "QuestionThreeForm";
            this.Load += new System.EventHandler(this.QuestionThreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restButton;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arrayLengthLabel;
        private System.Windows.Forms.Label totalLengthLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label questionTwoLabel;
        private System.Windows.Forms.TextBox inputArea;
    }
}