namespace ClassAssignment
{
    partial class QuestionFourForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.inputArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Location = new System.Drawing.Point(179, 179);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(69, 28);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // inputArea
            // 
            this.inputArea.Location = new System.Drawing.Point(62, 60);
            this.inputArea.Multiline = true;
            this.inputArea.Name = "inputArea";
            this.inputArea.Size = new System.Drawing.Size(309, 60);
            this.inputArea.TabIndex = 12;
            // 
            // QuestionFourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 261);
            this.Controls.Add(this.inputArea);
            this.Controls.Add(this.CalculateButton);
            this.Name = "QuestionFourForm";
            this.Text = "QuestionFourForm";
            this.Load += new System.EventHandler(this.QuestionFourForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox inputArea;
    }
}