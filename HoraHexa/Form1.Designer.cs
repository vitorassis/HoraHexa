﻿namespace HoraHexa
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            lblDec = new Label();
            lblHexa = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Font = new Font("Segoe UI", 20F);
            lblDec.Location = new Point(143, 58);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(90, 37);
            lblDec.TabIndex = 0;
            lblDec.Text = "label1";
            // 
            // lblHexa
            // 
            lblHexa.AutoSize = true;
            lblHexa.Font = new Font("Segoe UI", 20F);
            lblHexa.Location = new Point(143, 160);
            lblHexa.Name = "lblHexa";
            lblHexa.Size = new Size(90, 37);
            lblHexa.TabIndex = 1;
            lblHexa.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 243);
            Controls.Add(lblHexa);
            Controls.Add(lblDec);
            Name = "Form1";
            Text = "Hora Hexa Atual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Label lblDec;
        private Label lblHexa;
    }
}
