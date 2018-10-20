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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dg_result = new System.Windows.Forms.DataGridView();
            this.processors_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bound_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prime_numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_prime = new System.Windows.Forms.TextBox();
            this.lbl_primes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_processors
            // 
            this.cmb_processors.AccessibleName = "cmb_processors";
            this.cmb_processors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_processors.FormattingEnabled = true;
            this.cmb_processors.Location = new System.Drawing.Point(18, 63);
            this.cmb_processors.Name = "cmb_processors";
            this.cmb_processors.Size = new System.Drawing.Size(177, 24);
            this.cmb_processors.TabIndex = 0;
            // 
            // lbl_processors
            // 
            this.lbl_processors.AutoSize = true;
            this.lbl_processors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_processors.Location = new System.Drawing.Point(12, 31);
            this.lbl_processors.Name = "lbl_processors";
            this.lbl_processors.Size = new System.Drawing.Size(187, 25);
            this.lbl_processors.TabIndex = 1;
            this.lbl_processors.Text = "Processors number:";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(18, 404);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(105, 34);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dg_result
            // 
            this.dg_result.AllowUserToAddRows = false;
            this.dg_result.AllowUserToDeleteRows = false;
            this.dg_result.AllowUserToOrderColumns = true;
            this.dg_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processors_number,
            this.bound_number,
            this.start_time,
            this.end_time,
            this.duration,
            this.prime_numbers});
            this.dg_result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dg_result.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_result.Location = new System.Drawing.Point(243, 31);
            this.dg_result.Name = "dg_result";
            this.dg_result.ReadOnly = true;
            this.dg_result.RowTemplate.Height = 24;
            this.dg_result.Size = new System.Drawing.Size(910, 407);
            this.dg_result.TabIndex = 3;
            // 
            // processors_number
            // 
            this.processors_number.HeaderText = "Processors Number";
            this.processors_number.Name = "processors_number";
            this.processors_number.ReadOnly = true;
            // 
            // bound_number
            // 
            this.bound_number.HeaderText = "Prime number limit";
            this.bound_number.Name = "bound_number";
            this.bound_number.ReadOnly = true;
            // 
            // start_time
            // 
            this.start_time.HeaderText = "Start Time";
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            // 
            // end_time
            // 
            this.end_time.HeaderText = "End Time";
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // prime_numbers
            // 
            this.prime_numbers.HeaderText = "Prime numbers found";
            this.prime_numbers.Name = "prime_numbers";
            this.prime_numbers.ReadOnly = true;
            // 
            // txt_prime
            // 
            this.txt_prime.Location = new System.Drawing.Point(17, 132);
            this.txt_prime.Name = "txt_prime";
            this.txt_prime.Size = new System.Drawing.Size(178, 22);
            this.txt_prime.TabIndex = 4;
            this.txt_prime.TextChanged += new System.EventHandler(this.txt_prime_TextChanged);
            // 
            // lbl_primes
            // 
            this.lbl_primes.AutoSize = true;
            this.lbl_primes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primes.Location = new System.Drawing.Point(13, 104);
            this.lbl_primes.Name = "lbl_primes";
            this.lbl_primes.Size = new System.Drawing.Size(171, 25);
            this.lbl_primes.TabIndex = 5;
            this.lbl_primes.Text = "Prime numbers till:";
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.lbl_primes);
            this.Controls.Add(this.txt_prime);
            this.Controls.Add(this.dg_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_processors);
            this.Controls.Add(this.cmb_processors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParellelProgrammingPrimeNumbers";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_processors;
        private System.Windows.Forms.Label lbl_processors;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dg_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn processors_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bound_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn prime_numbers;
        private System.Windows.Forms.TextBox txt_prime;
        private System.Windows.Forms.Label lbl_primes;
    }
}

