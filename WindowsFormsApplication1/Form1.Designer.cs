namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circleButton = new System.Windows.Forms.Button();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.xCenterTextBox = new System.Windows.Forms.TextBox();
            this.yCenterTextBox = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 569);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(845, 12);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "drow circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(834, 41);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 2;
            // 
            // xCenterTextBox
            // 
            this.xCenterTextBox.Location = new System.Drawing.Point(834, 67);
            this.xCenterTextBox.Name = "xCenterTextBox";
            this.xCenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.xCenterTextBox.TabIndex = 3;
            // 
            // yCenterTextBox
            // 
            this.yCenterTextBox.Location = new System.Drawing.Point(834, 93);
            this.yCenterTextBox.Name = "yCenterTextBox";
            this.yCenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.yCenterTextBox.TabIndex = 4;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(828, 381);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(91, 23);
            this.colorButton.TabIndex = 5;
            this.colorButton.Text = "choose color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 571);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.yCenterTextBox);
            this.Controls.Add(this.xCenterTextBox);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.TextBox xCenterTextBox;
        private System.Windows.Forms.TextBox yCenterTextBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

