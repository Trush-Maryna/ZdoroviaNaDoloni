namespace ZdoroviaNaDoloni
{
    partial class First_Form
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
            components = new System.ComponentModel.Container();
            first_btn = new Button();
            infoBox = new PictureBox();
            timer_img = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)infoBox).BeginInit();
            SuspendLayout();
            // 
            // first_btn
            // 
            first_btn.Cursor = Cursors.Hand;
            first_btn.FlatStyle = FlatStyle.Flat;
            first_btn.Font = new Font("Palace Script MT", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            first_btn.Location = new Point(42, 654);
            first_btn.Name = "first_btn";
            first_btn.Size = new Size(309, 63);
            first_btn.TabIndex = 0;
            first_btn.Text = "Продовжити";
            first_btn.UseVisualStyleBackColor = true;
            first_btn.Click += first_btn_Click;
            // 
            // infoBox
            // 
            infoBox.Location = new Point(0, 0);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(393, 852);
            infoBox.SizeMode = PictureBoxSizeMode.Zoom;
            infoBox.TabIndex = 1;
            infoBox.TabStop = false;
            // 
            // timer_img
            // 
            timer_img.Tick += timer_img_Tick;
            // 
            // First_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 852);
            Controls.Add(first_btn);
            Controls.Add(infoBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "First_Form";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += First_Form_Load;
            ((System.ComponentModel.ISupportInitialize)infoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button first_btn;
        private PictureBox infoBox;
        private System.Windows.Forms.Timer timer_img;
    }
}
