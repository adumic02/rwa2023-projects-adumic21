namespace RWA_Projekt
{
    partial class FrmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.btnExpenseEntry = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnCashFlow = new System.Windows.Forms.Button();
            this.btnActivityEntry = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExpenseEntry
            // 
            this.btnExpenseEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExpenseEntry.Location = new System.Drawing.Point(715, 402);
            this.btnExpenseEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpenseEntry.Name = "btnExpenseEntry";
            this.btnExpenseEntry.Size = new System.Drawing.Size(122, 30);
            this.btnExpenseEntry.TabIndex = 0;
            this.btnExpenseEntry.Text = "Unesi trošak";
            this.btnExpenseEntry.UseVisualStyleBackColor = true;
            this.btnExpenseEntry.Click += new System.EventHandler(this.btnExpenseEntry_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvExpenses.Location = new System.Drawing.Point(13, 46);
            this.dgvExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.RowTemplate.Height = 24;
            this.dgvExpenses.Size = new System.Drawing.Size(823, 352);
            this.dgvExpenses.TabIndex = 1;
            // 
            // btnCashFlow
            // 
            this.btnCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCashFlow.Location = new System.Drawing.Point(13, 402);
            this.btnCashFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCashFlow.Name = "btnCashFlow";
            this.btnCashFlow.Size = new System.Drawing.Size(111, 30);
            this.btnCashFlow.TabIndex = 3;
            this.btnCashFlow.Text = "Statistika";
            this.btnCashFlow.UseVisualStyleBackColor = true;
            this.btnCashFlow.Click += new System.EventHandler(this.btnCashFlow_Click);
            // 
            // btnActivityEntry
            // 
            this.btnActivityEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnActivityEntry.Location = new System.Drawing.Point(569, 402);
            this.btnActivityEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivityEntry.Name = "btnActivityEntry";
            this.btnActivityEntry.Size = new System.Drawing.Size(140, 30);
            this.btnActivityEntry.TabIndex = 7;
            this.btnActivityEntry.Text = "Nova aktivnost";
            this.btnActivityEntry.UseVisualStyleBackColor = true;
            this.btnActivityEntry.Click += new System.EventHandler(this.btnActivityEntry_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(87, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 27);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSearch.Location = new System.Drawing.Point(299, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.LightCoral;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(11, 15);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(68, 20);
            this.lblMonth.TabIndex = 11;
            this.lblMonth.Text = "Mjesec:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClearSearch.Location = new System.Drawing.Point(407, 10);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(136, 30);
            this.btnClearSearch.TabIndex = 12;
            this.btnClearSearch.Text = "Očisti kriterij";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGenerateReport.Location = new System.Drawing.Point(130, 402);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(170, 30);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Generiraj izvješće";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RWA_Projekt.Properties.Resources.kedunoe38h8nrn9mig963g5ia8;
            this.pictureBox1.Location = new System.Drawing.Point(216, -33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRefresh.Location = new System.Drawing.Point(736, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(849, 441);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnActivityEntry);
            this.Controls.Add(this.btnCashFlow);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.btnExpenseEntry);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(867, 488);
            this.MinimumSize = new System.Drawing.Size(867, 488);
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz troškova";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpenseEntry;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnCashFlow;
        private System.Windows.Forms.Button btnActivityEntry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}