namespace RWA_Projekt
{
    partial class FrmActivityEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivityEntry));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.txtActivityTag = new System.Windows.Forms.TextBox();
            this.lblActivityTag = new System.Windows.Forms.Label();
            this.lblActivityTypeName = new System.Windows.Forms.Label();
            this.txtExpenseTypeName = new System.Windows.Forms.TextBox();
            this.cboExpenseType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(158, 84);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(240, 84);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblExpenseType.ForeColor = System.Drawing.Color.White;
            this.lblExpenseType.Location = new System.Drawing.Point(9, 12);
            this.lblExpenseType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(81, 16);
            this.lblExpenseType.TabIndex = 14;
            this.lblExpenseType.Text = "Vrsta troška:";
            // 
            // txtActivityTag
            // 
            this.txtActivityTag.Location = new System.Drawing.Point(128, 36);
            this.txtActivityTag.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityTag.Name = "txtActivityTag";
            this.txtActivityTag.Size = new System.Drawing.Size(185, 20);
            this.txtActivityTag.TabIndex = 15;
            // 
            // lblActivityTag
            // 
            this.lblActivityTag.AutoSize = true;
            this.lblActivityTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblActivityTag.ForeColor = System.Drawing.Color.White;
            this.lblActivityTag.Location = new System.Drawing.Point(9, 37);
            this.lblActivityTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivityTag.Name = "lblActivityTag";
            this.lblActivityTag.Size = new System.Drawing.Size(115, 16);
            this.lblActivityTag.TabIndex = 16;
            this.lblActivityTag.Text = "Oznaka aktivnosti:";
            // 
            // lblActivityTypeName
            // 
            this.lblActivityTypeName.AutoSize = true;
            this.lblActivityTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblActivityTypeName.ForeColor = System.Drawing.Color.White;
            this.lblActivityTypeName.Location = new System.Drawing.Point(9, 61);
            this.lblActivityTypeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivityTypeName.Name = "lblActivityTypeName";
            this.lblActivityTypeName.Size = new System.Drawing.Size(103, 16);
            this.lblActivityTypeName.TabIndex = 17;
            this.lblActivityTypeName.Text = "Naziv aktivnosti:";
            // 
            // txtExpenseTypeName
            // 
            this.txtExpenseTypeName.Location = new System.Drawing.Point(116, 60);
            this.txtExpenseTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpenseTypeName.Name = "txtExpenseTypeName";
            this.txtExpenseTypeName.Size = new System.Drawing.Size(197, 20);
            this.txtExpenseTypeName.TabIndex = 18;
            // 
            // cboExpenseType
            // 
            this.cboExpenseType.FormattingEnabled = true;
            this.cboExpenseType.Location = new System.Drawing.Point(94, 11);
            this.cboExpenseType.Margin = new System.Windows.Forms.Padding(2);
            this.cboExpenseType.Name = "cboExpenseType";
            this.cboExpenseType.Size = new System.Drawing.Size(219, 21);
            this.cboExpenseType.TabIndex = 19;
            // 
            // FrmActivityEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(329, 121);
            this.Controls.Add(this.cboExpenseType);
            this.Controls.Add(this.txtExpenseTypeName);
            this.Controls.Add(this.lblActivityTypeName);
            this.Controls.Add(this.lblActivityTag);
            this.Controls.Add(this.txtActivityTag);
            this.Controls.Add(this.lblExpenseType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 160);
            this.MinimumSize = new System.Drawing.Size(345, 160);
            this.Name = "FrmActivityEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog troška";
            this.Load += new System.EventHandler(this.FrmActivityEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.TextBox txtActivityTag;
        private System.Windows.Forms.Label lblActivityTag;
        private System.Windows.Forms.Label lblActivityTypeName;
        private System.Windows.Forms.TextBox txtExpenseTypeName;
        private System.Windows.Forms.ComboBox cboExpenseType;
    }
}