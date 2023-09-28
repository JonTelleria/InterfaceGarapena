namespace Ariketa2_Zerrenda
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
            textZenb = new TextBox();
            labelZenbakia = new Label();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnItxi = new Button();
            SuspendLayout();
            // 
            // textZenb
            // 
            textZenb.Location = new Point(317, 119);
            textZenb.Margin = new Padding(3, 4, 3, 4);
            textZenb.Name = "textZenb";
            textZenb.Size = new Size(354, 27);
            textZenb.TabIndex = 0;
            // 
            // labelZenbakia
            // 
            labelZenbakia.AutoSize = true;
            labelZenbakia.BackColor = Color.DodgerBlue;
            labelZenbakia.Location = new Point(229, 123);
            labelZenbakia.Name = "labelZenbakia";
            labelZenbakia.Size = new Size(81, 20);
            labelZenbakia.TabIndex = 1;
            labelZenbakia.Text = "1.Zenbakia";
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(122, 397);
            btnHurrengoa.Margin = new Padding(3, 4, 3, 4);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(114, 61);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(384, 397);
            btnGarbitu.Margin = new Padding(3, 4, 3, 4);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(114, 61);
            btnGarbitu.TabIndex = 3;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnItxi
            // 
            btnItxi.Location = new Point(621, 397);
            btnItxi.Margin = new Padding(3, 4, 3, 4);
            btnItxi.Name = "btnItxi";
            btnItxi.Size = new Size(114, 61);
            btnItxi.TabIndex = 4;
            btnItxi.Text = "Itxi";
            btnItxi.UseVisualStyleBackColor = true;
            btnItxi.Click += btnItxi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnItxi);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(labelZenbakia);
            Controls.Add(textZenb);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textZenb;
        private Label labelZenbakia;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnItxi;
    }
}