﻿namespace memzy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.effect_1 = new System.Windows.Forms.Timer(this.components);
            this.effect_2 = new System.Windows.Forms.Timer(this.components);
            this.effect_3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // effect_1
            // 
            this.effect_1.Interval = 300;
            this.effect_1.Tick += new System.EventHandler(this.effect_1_Tick);
            // 
            // effect_2
            // 
            this.effect_2.Interval = 500;
            this.effect_2.Tick += new System.EventHandler(this.effect_2_Tick);
            // 
            // effect_3
            // 
            this.effect_3.Interval = 600;
            this.effect_3.Tick += new System.EventHandler(this.effect_3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer effect_1;
        private System.Windows.Forms.Timer effect_2;
        private System.Windows.Forms.Timer effect_3;
    }
}

