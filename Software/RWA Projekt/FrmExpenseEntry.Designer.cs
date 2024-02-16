namespace RWA_Projekt
{
    partial class FrmExpenseEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenseEntry));
            this.lblExpenseTag = new System.Windows.Forms.Label();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboExpenseTag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblExpenseTag
            // 
            this.lblExpenseTag.AutoSize = true;
            this.lblExpenseTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblExpenseTag.ForeColor = System.Drawing.Color.White;
            this.lblExpenseTag.Location = new System.Drawing.Point(11, 13);
            this.lblExpenseTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpenseTag.Name = "lblExpenseTag";
            this.lblExpenseTag.Size = new System.Drawing.Size(96, 16);
            this.lblExpenseTag.TabIndex = 0;
            this.lblExpenseTag.Text = "Oznaka troška:";
            // 
            // lblExpenseAmount
            // 
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblExpenseAmount.ForeColor = System.Drawing.Color.White;
            this.lblExpenseAmount.Location = new System.Drawing.Point(11, 38);
            this.lblExpenseAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(87, 16);
            this.lblExpenseAmount.TabIndex = 3;
            this.lblExpenseAmount.Text = "Visina troška:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(102, 38);
            this.txtExpenseAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(220, 20);
            this.txtExpenseAmount.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(11, 64);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Opis:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(53, 62);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 84);
            this.txtDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(250, 150);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(163, 150);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboExpenseTag
            // 
            this.cboExpenseTag.FormattingEnabled = true;
            this.cboExpenseTag.Items.AddRange(new object[] {
            "1 - Hrana i piće",
            "2 - Kupovina",
            "3 - Dugovanja i potraživanja",
            "4 - Mjesečna članstva",
            "5 - Nezgode"});
            this.cboExpenseTag.Location = new System.Drawing.Point(112, 12);
            this.cboExpenseTag.Name = "cboExpenseTag";
            this.cboExpenseTag.Size = new System.Drawing.Size(210, 21);
            this.cboExpenseTag.TabIndex = 14;
            // 
            // FrmExpenseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(334, 186);
            this.Controls.Add(this.cboExpenseTag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.lblExpenseAmount);
            this.Controls.Add(this.lblExpenseTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 225);
            this.MinimumSize = new System.Drawing.Size(350, 225);
            this.Name = "FrmExpenseEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog troška";
            this.Load += new System.EventHandler(this.FrmExpenseEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpenseTag;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboExpenseTag;
    }
}