﻿namespace KaixoMundua
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
            btnKaixo = new Button();
            btnItxi = new Button();
            SuspendLayout();
            // 
            // btnKaixo
            // 
            btnKaixo.BackColor = SystemColors.Window;
            btnKaixo.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaixo.ForeColor = SystemColors.Highlight;
            btnKaixo.Location = new Point(112, 213);
            btnKaixo.Name = "btnKaixo";
            btnKaixo.Size = new Size(183, 85);
            btnKaixo.TabIndex = 0;
            btnKaixo.Text = "Kaixo";
            btnKaixo.UseVisualStyleBackColor = false;
            btnKaixo.Click += btnKaixo_Click;
            // 
            // btnItxi
            // 
            btnItxi.BackColor = SystemColors.Window;
            btnItxi.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnItxi.ForeColor = SystemColors.Highlight;
            btnItxi.Location = new Point(477, 213);
            btnItxi.Name = "btnItxi";
            btnItxi.Size = new Size(183, 85);
            btnItxi.TabIndex = 1;
            btnItxi.Text = "Itxi";
            btnItxi.UseVisualStyleBackColor = false;
            btnItxi.Click += btnItxi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnItxi);
            Controls.Add(btnKaixo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKaixo;
        private Button btnItxi;
    }
}