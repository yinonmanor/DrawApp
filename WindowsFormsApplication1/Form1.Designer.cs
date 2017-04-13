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
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lineButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.polygonTextBox = new System.Windows.Forms.TextBox();
            this.currveButton = new System.Windows.Forms.Button();
            this.currveTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 529);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(629, 12);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "עיגול";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(35, 12);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(91, 23);
            this.colorButton.TabIndex = 5;
            this.colorButton.Text = "בחר צבע";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(732, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 9;
            this.lineButton.Text = "קו";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.Location = new System.Drawing.Point(525, 12);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(75, 23);
            this.polygonButton.TabIndex = 10;
            this.polygonButton.Text = "מצולע משוכלל";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // polygonTextBox
            // 
            this.polygonTextBox.Location = new System.Drawing.Point(524, 46);
            this.polygonTextBox.Name = "polygonTextBox";
            this.polygonTextBox.Size = new System.Drawing.Size(76, 20);
            this.polygonTextBox.TabIndex = 11;
            // 
            // currveButton
            // 
            this.currveButton.Location = new System.Drawing.Point(419, 12);
            this.currveButton.Name = "currveButton";
            this.currveButton.Size = new System.Drawing.Size(82, 23);
            this.currveButton.TabIndex = 12;
            this.currveButton.Text = "עקומת בזייה";
            this.currveButton.UseVisualStyleBackColor = true;
            this.currveButton.Click += new System.EventHandler(this.currveButton_Click);
            // 
            // currveTextBox
            // 
            this.currveTextBox.Location = new System.Drawing.Point(419, 46);
            this.currveTextBox.Name = "currveTextBox";
            this.currveTextBox.Size = new System.Drawing.Size(82, 20);
            this.currveTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 634);
            this.Controls.Add(this.currveTextBox);
            this.Controls.Add(this.currveButton);
            this.Controls.Add(this.polygonTextBox);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.colorButton);
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
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.TextBox polygonTextBox;
        private System.Windows.Forms.Button currveButton;
        private System.Windows.Forms.TextBox currveTextBox;
    }
}

