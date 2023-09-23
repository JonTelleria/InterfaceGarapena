namespace Ariketa2
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
            lbZenbakia = new Label();
            tbEmaitza = new TextBox();
            btnHurrengoa = new Button();
            btIrten = new Button();
            btnGarbitu = new Button();
            SuspendLayout();
            // 
            // lbZenbakia
            // 
            lbZenbakia.AutoSize = true;
            lbZenbakia.BackColor = SystemColors.MenuHighlight;
            lbZenbakia.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbZenbakia.Location = new Point(92, 63);
            lbZenbakia.Name = "lbZenbakia";
            lbZenbakia.Size = new Size(119, 30);
            lbZenbakia.TabIndex = 0;
            lbZenbakia.Text = "Zenbakia 1";
            lbZenbakia.Click += lbZenbakia_Click;
            // 
            // tbEmaitza
            // 
            tbEmaitza.Location = new Point(217, 63);
            tbEmaitza.Name = "tbEmaitza";
            tbEmaitza.Size = new Size(467, 27);
            tbEmaitza.TabIndex = 1;
            tbEmaitza.TextChanged += tbEmaitza_TextChanged;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(113, 165);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(112, 48);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btIrten
            // 
            btIrten.Location = new Point(549, 165);
            btIrten.Name = "btIrten";
            btIrten.Size = new Size(115, 48);
            btIrten.TabIndex = 3;
            btIrten.Text = "Irten";
            btIrten.UseVisualStyleBackColor = true;
            btIrten.Click += btIrten_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(331, 165);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(109, 48);
            btnGarbitu.TabIndex = 4;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 261);
            Controls.Add(btnGarbitu);
            Controls.Add(btIrten);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbEmaitza);
            Controls.Add(lbZenbakia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion




        private Label lbZenbakia;
        private TextBox tbEmaitza;
        private Button btnHurrengoa;
        private Button btIrten;
        private Button btnGarbitu;
    }
}