namespace OinarrizkoKalkulagailua
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
            btnGehi = new Button();
            btnKen = new Button();
            btnZati = new Button();
            btnBider = new Button();
            txtZenbakia1 = new TextBox();
            txtZenbakia2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGehi
            // 
            btnGehi.Location = new Point(341, 248);
            btnGehi.Name = "btnGehi";
            btnGehi.Size = new Size(127, 111);
            btnGehi.TabIndex = 0;
            btnGehi.Text = "+";
            btnGehi.UseVisualStyleBackColor = true;
            btnGehi.Click += btnGehi_Click;
            // 
            // btnKen
            // 
            btnKen.Location = new Point(623, 248);
            btnKen.Name = "btnKen";
            btnKen.Size = new Size(127, 111);
            btnKen.TabIndex = 1;
            btnKen.Text = "-";
            btnKen.UseVisualStyleBackColor = true;
            btnKen.Click += btnKen_Click;
            // 
            // btnZati
            // 
            btnZati.Location = new Point(623, 413);
            btnZati.Name = "btnZati";
            btnZati.Size = new Size(127, 111);
            btnZati.TabIndex = 3;
            btnZati.Text = "/";
            btnZati.UseVisualStyleBackColor = true;
            btnZati.Click += btnZati_Click;
            // 
            // btnBider
            // 
            btnBider.Location = new Point(341, 413);
            btnBider.Name = "btnBider";
            btnBider.Size = new Size(127, 111);
            btnBider.TabIndex = 2;
            btnBider.Text = "x";
            btnBider.UseVisualStyleBackColor = true;
            btnBider.Click += btnBider_Click;
            // 
            // txtZenbakia1
            // 
            txtZenbakia1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtZenbakia1.Location = new Point(59, 131);
            txtZenbakia1.Name = "txtZenbakia1";
            txtZenbakia1.Size = new Size(328, 32);
            txtZenbakia1.TabIndex = 4;
            // 
            // txtZenbakia2
            // 
            txtZenbakia2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtZenbakia2.Location = new Point(694, 131);
            txtZenbakia2.Name = "txtZenbakia2";
            txtZenbakia2.Size = new Size(328, 32);
            txtZenbakia2.TabIndex = 5;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 69);
            label1.Name = "label1";
            label1.Size = new Size(219, 41);
            label1.TabIndex = 6;
            label1.Text = "Zenbaki bat:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(694, 69);
            label2.Name = "label2";
            label2.Size = new Size(197, 41);
            label2.TabIndex = 7;
            label2.Text = "Zenbaki bi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(29F, 56F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 587);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtZenbakia2);
            Controls.Add(txtZenbakia1);
            Controls.Add(btnZati);
            Controls.Add(btnBider);
            Controls.Add(btnKen);
            Controls.Add(btnGehi);
            Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(13, 10, 13, 10);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGehi;
        private Button btnKen;
        private Button btnZati;
        private Button btnBider;
        private TextBox txtZenbakia1;
        private TextBox txtZenbakia2;
        private Label label1;
        private Label label2;
    }
}