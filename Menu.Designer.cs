namespace ClassAssignment
{
    partial class Menu
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
            this.questionOneButton = new System.Windows.Forms.Button();
            this.questionTwoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionOneButton
            // 
            this.questionOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionOneButton.Location = new System.Drawing.Point(56, 100);
            this.questionOneButton.Name = "questionOneButton";
            this.questionOneButton.Size = new System.Drawing.Size(214, 23);
            this.questionOneButton.TabIndex = 0;
            this.questionOneButton.Text = "Question 1";
            this.questionOneButton.UseVisualStyleBackColor = true;
            this.questionOneButton.Click += new System.EventHandler(this.questionOneButton_Click);
            // 
            // questionTwoButton
            // 
            this.questionTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionTwoButton.Location = new System.Drawing.Point(56, 143);
            this.questionTwoButton.Name = "questionTwoButton";
            this.questionTwoButton.Size = new System.Drawing.Size(214, 23);
            this.questionTwoButton.TabIndex = 1;
            this.questionTwoButton.Text = "Question 2";
            this.questionTwoButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.questionTwoButton);
            this.Controls.Add(this.questionOneButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button questionOneButton;
        private System.Windows.Forms.Button questionTwoButton;
    }
}