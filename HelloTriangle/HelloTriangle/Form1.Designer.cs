﻿namespace HelloTriangle
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
            this._openGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.simpleOpenGlControl2 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // _openGLControl
            // 
            this._openGLControl.AccumBits = ((byte)(0));
            this._openGLControl.AutoCheckErrors = false;
            this._openGLControl.AutoFinish = false;
            this._openGLControl.AutoMakeCurrent = true;
            this._openGLControl.AutoSwapBuffers = true;
            this._openGLControl.BackColor = System.Drawing.Color.Black;
            this._openGLControl.ColorBits = ((byte)(32));
            this._openGLControl.DepthBits = ((byte)(16));
            this._openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._openGLControl.Location = new System.Drawing.Point(0, 0);
            this._openGLControl.Name = "_openGLControl";
            this._openGLControl.Size = new System.Drawing.Size(284, 262);
            this._openGLControl.StencilBits = ((byte)(0));
            this._openGLControl.TabIndex = 0;
            // 
            // simpleOpenGlControl2
            // 
            this.simpleOpenGlControl2.AccumBits = ((byte)(0));
            this.simpleOpenGlControl2.AutoCheckErrors = false;
            this.simpleOpenGlControl2.AutoFinish = false;
            this.simpleOpenGlControl2.AutoMakeCurrent = true;
            this.simpleOpenGlControl2.AutoSwapBuffers = true;
            this.simpleOpenGlControl2.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl2.ColorBits = ((byte)(32));
            this.simpleOpenGlControl2.DepthBits = ((byte)(16));
            this.simpleOpenGlControl2.Location = new System.Drawing.Point(17, 0);
            this.simpleOpenGlControl2.Name = "simpleOpenGlControl2";
            this.simpleOpenGlControl2.Size = new System.Drawing.Size(8, 8);
            this.simpleOpenGlControl2.StencilBits = ((byte)(0));
            this.simpleOpenGlControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simpleOpenGlControl2);
            this.Controls.Add(this._openGLControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _openGLControl;
        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl2;
    }
}
