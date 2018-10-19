namespace ParallelProgrammingAssignment1
{
    partial class MainForm
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
            this.cmb_processors = new System.Windows.Forms.ComboBox();
            this.lbl_processors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_processors
            // 
            this.cmb_processors.AccessibleName = "cmb_processors";
            this.cmb_processors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_processors.FormattingEnabled = true;
            this.cmb_processors.Location = new System.Drawing.Point(12, 62);
            this.cmb_processors.Name = "cmb_processors";
            this.cmb_processors.Size = new System.Drawing.Size(177, 24);
            this.cmb_processors.TabIndex = 0;
            // 
            // lbl_processors
            // 
            this.lbl_processors.AutoSize = true;
            this.lbl_processors.Location = new System.Drawing.Point(12, 42);
            this.lbl_processors.Name = "lbl_processors";
            this.lbl_processors.Size = new System.Drawing.Size(135, 17);
            this.lbl_processors.TabIndex = 1;
            this.lbl_processors.Text = "Processors number:";
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_processors);
            this.Controls.Add(this.cmb_processors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParellelProgrammingPrimeNumbers";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_processors;
        private System.Windows.Forms.Label lbl_processors;
    }
}

