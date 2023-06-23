namespace SegProj
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
            lblInput = new Label();
            lblOutput = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblThreshold = new Label();
            txtboxThreshold = new TextBox();
            label1 = new Label();
            lblX1 = new Label();
            lblY1 = new Label();
            lblX2 = new Label();
            lblY2 = new Label();
            textBoxX1 = new TextBox();
            txtboxY1 = new TextBox();
            txtboxX2 = new TextBox();
            txtboxY2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(25, 32);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(35, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(355, 32);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(45, 15);
            lblOutput.TabIndex = 1;
            lblOutput.Text = "Output";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 412);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
  
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(355, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(357, 412);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblThreshold
            // 
            lblThreshold.AutoSize = true;
            lblThreshold.Location = new Point(967, 92);
            lblThreshold.Name = "lblThreshold";
            lblThreshold.Size = new Size(51, 15);
            lblThreshold.TabIndex = 4;
            lblThreshold.Text = "Ngưỡng";
            // 
            // txtboxThreshold
            // 
            txtboxThreshold.Location = new Point(891, 110);
            txtboxThreshold.Name = "txtboxThreshold";
            txtboxThreshold.Size = new Size(211, 23);
            txtboxThreshold.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(869, 178);
            label1.Name = "label1";
            label1.Size = new Size(253, 15);
            label1.TabIndex = 6;
            label1.Text = "Chọn vùng ảnh để tính vecto trung binh mau :";
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Location = new Point(837, 232);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(20, 15);
            lblX1.TabIndex = 7;
            lblX1.Text = "X1";
            // 
            // lblY1
            // 
            lblY1.AutoSize = true;
            lblY1.Location = new Point(837, 302);
            lblY1.Name = "lblY1";
            lblY1.Size = new Size(20, 15);
            lblY1.TabIndex = 8;
            lblY1.Text = "Y1";
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(1007, 232);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(20, 15);
            lblX2.TabIndex = 9;
            lblX2.Text = "X2";
            // 
            // lblY2
            // 
            lblY2.AutoSize = true;
            lblY2.Location = new Point(1007, 307);
            lblY2.Name = "lblY2";
            lblY2.Size = new Size(20, 15);
            lblY2.TabIndex = 10;
            lblY2.Text = "Y2";
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(863, 229);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 11;
            // 
            // txtboxY1
            // 
            txtboxY1.Location = new Point(863, 299);
            txtboxY1.Name = "txtboxY1";
            txtboxY1.Size = new Size(100, 23);
            txtboxY1.TabIndex = 12;
            // 
            // txtboxX2
            // 
            txtboxX2.Location = new Point(1033, 229);
            txtboxX2.Name = "txtboxX2";
            txtboxX2.Size = new Size(100, 23);
            txtboxX2.TabIndex = 13;
            // 
            // txtboxY2
            // 
            txtboxY2.Location = new Point(1033, 302);
            txtboxY2.Name = "txtboxY2";
            txtboxY2.Size = new Size(100, 23);
            txtboxY2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(945, 387);
            button1.Name = "button1";
            button1.Size = new Size(120, 94);
            button1.TabIndex = 15;
            button1.Text = "Phân đoạn ảnh segmentation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 512);
            Controls.Add(button1);
            Controls.Add(txtboxY2);
            Controls.Add(txtboxX2);
            Controls.Add(txtboxY1);
            Controls.Add(textBoxX1);
            Controls.Add(lblY2);
            Controls.Add(lblX2);
            Controls.Add(lblY1);
            Controls.Add(lblX1);
            Controls.Add(label1);
            Controls.Add(txtboxThreshold);
            Controls.Add(lblThreshold);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    

        #endregion

        private Label lblInput;
        private Label lblOutput;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblThreshold;
        private TextBox txtboxThreshold;
        private Label label1;
        private Label lblX1;
        private Label lblY1;
        private Label lblX2;
        private Label lblY2;
        private TextBox textBoxX1;
        private TextBox txtboxY1;
        private TextBox txtboxX2;
        private TextBox txtboxY2;
        private Button button1;
    }
}