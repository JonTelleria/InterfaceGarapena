namespace Ariketa1_esaldiak_lotu_
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
            txtBox = new TextBox();
            btnEsaldia1 = new Button();
            btnEsaldia2 = new Button();
            btnEsaldia3 = new Button();
            btnEsaldia4 = new Button();
            btnEsaldia5 = new Button();
            btnLotu = new Button();
            btnBorratu = new Button();
            btnItxi = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(152, 54);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(472, 27);
            txtBox.TabIndex = 0;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // btnEsaldia1
            // 
            btnEsaldia1.Location = new Point(80, 137);
            btnEsaldia1.Name = "btnEsaldia1";
            btnEsaldia1.Size = new Size(163, 56);
            btnEsaldia1.TabIndex = 1;
            btnEsaldia1.Text = "Esaldia1";
            btnEsaldia1.UseVisualStyleBackColor = true;
            btnEsaldia1.Click += btnEsaldia1_Click;
            // 
            // btnEsaldia2
            // 
            btnEsaldia2.Location = new Point(322, 137);
            btnEsaldia2.Name = "btnEsaldia2";
            btnEsaldia2.Size = new Size(163, 56);
            btnEsaldia2.TabIndex = 2;
            btnEsaldia2.Text = "Esaldia2";
            btnEsaldia2.UseVisualStyleBackColor = true;
            btnEsaldia2.Click += btnEsaldia2_Click;
            // 
            // btnEsaldia3
            // 
            btnEsaldia3.Location = new Point(578, 137);
            btnEsaldia3.Name = "btnEsaldia3";
            btnEsaldia3.Size = new Size(163, 56);
            btnEsaldia3.TabIndex = 3;
            btnEsaldia3.Text = "Esaldia3";
            btnEsaldia3.UseVisualStyleBackColor = true;
            btnEsaldia3.Click += btnEsaldia3_Click;
            // 
            // btnEsaldia4
            // 
            btnEsaldia4.Location = new Point(80, 242);
            btnEsaldia4.Name = "btnEsaldia4";
            btnEsaldia4.Size = new Size(163, 56);
            btnEsaldia4.TabIndex = 4;
            btnEsaldia4.Text = "Esaldia4";
            btnEsaldia4.UseVisualStyleBackColor = true;
            btnEsaldia4.Click += btnEsaldia4_Click;
            // 
            // btnEsaldia5
            // 
            btnEsaldia5.Location = new Point(322, 242);
            btnEsaldia5.Name = "btnEsaldia5";
            btnEsaldia5.Size = new Size(163, 56);
            btnEsaldia5.TabIndex = 5;
            btnEsaldia5.Text = "Esaldia5";
            btnEsaldia5.UseVisualStyleBackColor = true;
            btnEsaldia5.Click += btnEsaldia5_Click;
            // 
            // btnLotu
            // 
            btnLotu.Location = new Point(578, 242);
            btnLotu.Name = "btnLotu";
            btnLotu.Size = new Size(163, 56);
            btnLotu.TabIndex = 6;
            btnLotu.Text = "Lotu";
            btnLotu.UseVisualStyleBackColor = true;
            btnLotu.Click += btnLotu_Click;
            // 
            // btnBorratu
            // 
            btnBorratu.Location = new Point(152, 364);
            btnBorratu.Name = "btnBorratu";
            btnBorratu.Size = new Size(224, 55);
            btnBorratu.TabIndex = 7;
            btnBorratu.Text = "Borratu";
            btnBorratu.UseVisualStyleBackColor = true;
            btnBorratu.Click += btnBorratu_Click;
            // 
            // btnItxi
            // 
            btnItxi.Location = new Point(422, 364);
            btnItxi.Name = "btnItxi";
            btnItxi.Size = new Size(224, 55);
            btnItxi.TabIndex = 8;
            btnItxi.Text = "Itxi";
            btnItxi.UseVisualStyleBackColor = true;
            btnItxi.Click += btnItxi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnItxi);
            Controls.Add(btnBorratu);
            Controls.Add(btnLotu);
            Controls.Add(btnEsaldia5);
            Controls.Add(btnEsaldia4);
            Controls.Add(btnEsaldia3);
            Controls.Add(btnEsaldia2);
            Controls.Add(btnEsaldia1);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnEsaldia1;
        private Button btnEsaldia2;
        private Button btnEsaldia3;
        private Button btnEsaldia4;
        private Button btnEsaldia5;
        private Button btnLotu;
        private Button btnBorratu;
        private Button btnItxi;
    }
}