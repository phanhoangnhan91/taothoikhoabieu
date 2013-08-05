namespace TaoTKB
{
    partial class tkb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tkb));
            this.SuspendLayout();
            // 
            // tkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 398);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tkb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời khóa biểu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tkb_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tkb_ControlAdded);
            this.MouseEnter += new System.EventHandler(this.tkb_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

