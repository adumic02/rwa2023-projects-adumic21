namespace RWA_Projekt
{
    partial class FrmIncomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncomes));
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIncomeEntry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.Location = new System.Drawing.Point(12, 12);
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.Size = new System.Drawing.Size(285, 306);
            this.dgvIncomes.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(204, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIncomeEntry
            // 
            this.btnIncomeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnIncomeEntry.Location = new System.Drawing.Point(12, 324);
            this.btnIncomeEntry.Name = "btnIncomeEntry";
            this.btnIncomeEntry.Size = new System.Drawing.Size(100, 25);
            this.btnIncomeEntry.TabIndex = 2;
            this.btnIncomeEntry.Text = "Unesi prihod";
            this.btnIncomeEntry.UseVisualStyleBackColor = true;
            this.btnIncomeEntry.Click += new System.EventHandler(this.btnIncomeEntry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RWA_Projekt.Properties.Resources.kedunoe38h8nrn9mig963g5ia8;
            this.pictureBox1.Location = new System.Drawing.Point(-142, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.btnIncomeEntry);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvIncomes);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 400);
            this.MinimumSize = new System.Drawing.Size(325, 400);
            this.Name = "FrmIncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz prihoda";
            this.Load += new System.EventHandler(this.FrmIncomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncomes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIncomeEntry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}