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
            this.radiusLable = new System.Windows.Forms.Label();
            this.xCenterLable = new System.Windows.Forms.Label();
            this.yCenterLable = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.colorButton.Location = new System.Drawing.Point(748, 12);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(91, 23);
            this.colorButton.TabIndex = 5;
            this.colorButton.Text = "choose color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // radiusLable
            // 
            this.radiusLable.AutoSize = true;
            this.radiusLable.Location = new System.Drawing.Point(785, 44);
            this.radiusLable.Name = "radiusLable";
            this.radiusLable.Size = new System.Drawing.Size(43, 13);
            this.radiusLable.TabIndex = 6;
            this.radiusLable.Text = "Radius:";
            // 
            // xCenterLable
            // 
            this.xCenterLable.AutoSize = true;
            this.xCenterLable.Location = new System.Drawing.Point(781, 70);
            this.xCenterLable.Name = "xCenterLable";
            this.xCenterLable.Size = new System.Drawing.Size(50, 13);
            this.xCenterLable.TabIndex = 7;
            this.xCenterLable.Text = "X center:";
            // 
            // yCenterLable
            // 
            this.yCenterLable.AutoSize = true;
            this.yCenterLable.Location = new System.Drawing.Point(781, 96);
            this.yCenterLable.Name = "yCenterLable";
            this.yCenterLable.Size = new System.Drawing.Size(50, 13);
            this.yCenterLable.TabIndex = 8;
            this.yCenterLable.Text = "Y center:";
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(667, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 9;
            this.lineButton.Text = "draw line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 634);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.yCenterLable);
            this.Controls.Add(this.xCenterLable);
            this.Controls.Add(this.radiusLable);
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
        private System.Windows.Forms.Label radiusLable;
        private System.Windows.Forms.Label xCenterLable;
        private System.Windows.Forms.Label yCenterLable;
        private System.Windows.Forms.Button lineButton;
    }
}

