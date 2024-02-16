namespace RWA_Projekt
{
    partial class FrmCashFlow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashFlow));
            this.txtIncomeSum = new System.Windows.Forms.TextBox();
            this.lblIncomeSum = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblExpenseSum = new System.Windows.Forms.Label();
            this.txtExpenseSum = new System.Windows.Forms.TextBox();
            this.lblEuro3 = new System.Windows.Forms.Label();
            this.lblProfitLoss = new System.Windows.Forms.Label();
            this.txtProfitLoss = new System.Windows.Forms.TextBox();
            this.btnIncomeShow = new System.Windows.Forms.Button();
            this.lblAverageIncomes = new System.Windows.Forms.Label();
            this.lblAverageExpenses = new System.Windows.Forms.Label();
            this.txtAverageExpenses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAverageIncomes = new System.Windows.Forms.TextBox();
            this.chrGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expenseReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chrGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReportViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIncomeSum
            // 
            this.txtIncomeSum.Location = new System.Drawing.Point(144, 17);
            this.txtIncomeSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIncomeSum.Name = "txtIncomeSum";
            this.txtIncomeSum.ReadOnly = true;
            this.txtIncomeSum.Size = new System.Drawing.Size(151, 22);
            this.txtIncomeSum.TabIndex = 0;
            // 
            // lblIncomeSum
            // 
            this.lblIncomeSum.AutoSize = true;
            this.lblIncomeSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIncomeSum.ForeColor = System.Drawing.Color.White;
            this.lblIncomeSum.Location = new System.Drawing.Point(15, 18);
            this.lblIncomeSum.Name = "lblIncomeSum";
            this.lblIncomeSum.Size = new System.Drawing.Size(116, 20);
            this.lblIncomeSum.TabIndex = 1;
            this.lblIncomeSum.Text = "Ukupni prihod:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(904, 374);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEuro.ForeColor = System.Drawing.Color.White;
            this.lblEuro.Location = new System.Drawing.Point(301, 47);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(18, 20);
            this.lblEuro.TabIndex = 9;
            this.lblEuro.Text = "€";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEuro2.ForeColor = System.Drawing.Color.White;
            this.lblEuro2.Location = new System.Drawing.Point(301, 78);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(18, 20);
            this.lblEuro2.TabIndex = 12;
            this.lblEuro2.Text = "€";
            // 
            // lblExpenseSum
            // 
            this.lblExpenseSum.AutoSize = true;
            this.lblExpenseSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblExpenseSum.ForeColor = System.Drawing.Color.White;
            this.lblExpenseSum.Location = new System.Drawing.Point(15, 48);
            this.lblExpenseSum.Name = "lblExpenseSum";
            this.lblExpenseSum.Size = new System.Drawing.Size(116, 20);
            this.lblExpenseSum.TabIndex = 11;
            this.lblExpenseSum.Text = "Ukupni trošak:";
            // 
            // txtExpenseSum
            // 
            this.txtExpenseSum.Location = new System.Drawing.Point(144, 47);
            this.txtExpenseSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpenseSum.Name = "txtExpenseSum";
            this.txtExpenseSum.ReadOnly = true;
            this.txtExpenseSum.Size = new System.Drawing.Size(151, 22);
            this.txtExpenseSum.TabIndex = 10;
            // 
            // lblEuro3
            // 
            this.lblEuro3.AutoSize = true;
            this.lblEuro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEuro3.ForeColor = System.Drawing.Color.White;
            this.lblEuro3.Location = new System.Drawing.Point(301, 103);
            this.lblEuro3.Name = "lblEuro3";
            this.lblEuro3.Size = new System.Drawing.Size(18, 20);
            this.lblEuro3.TabIndex = 15;
            this.lblEuro3.Text = "€";
            // 
            // lblProfitLoss
            // 
            this.lblProfitLoss.AutoSize = true;
            this.lblProfitLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblProfitLoss.ForeColor = System.Drawing.Color.White;
            this.lblProfitLoss.Location = new System.Drawing.Point(15, 78);
            this.lblProfitLoss.Name = "lblProfitLoss";
            this.lblProfitLoss.Size = new System.Drawing.Size(122, 20);
            this.lblProfitLoss.TabIndex = 14;
            this.lblProfitLoss.Text = "Dobit / gubitak:";
            // 
            // txtProfitLoss
            // 
            this.txtProfitLoss.Location = new System.Drawing.Point(148, 76);
            this.txtProfitLoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitLoss.Name = "txtProfitLoss";
            this.txtProfitLoss.ReadOnly = true;
            this.txtProfitLoss.Size = new System.Drawing.Size(147, 22);
            this.txtProfitLoss.TabIndex = 13;
            // 
            // btnIncomeShow
            // 
            this.btnIncomeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeShow.ForeColor = System.Drawing.Color.Black;
            this.btnIncomeShow.Location = new System.Drawing.Point(751, 374);
            this.btnIncomeShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncomeShow.Name = "btnIncomeShow";
            this.btnIncomeShow.Size = new System.Drawing.Size(145, 31);
            this.btnIncomeShow.TabIndex = 16;
            this.btnIncomeShow.Text = "Prikaz prihoda";
            this.btnIncomeShow.UseVisualStyleBackColor = true;
            this.btnIncomeShow.Click += new System.EventHandler(this.btnIncomeShow_Click);
            // 
            // lblAverageIncomes
            // 
            this.lblAverageIncomes.AutoSize = true;
            this.lblAverageIncomes.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAverageIncomes.ForeColor = System.Drawing.Color.White;
            this.lblAverageIncomes.Location = new System.Drawing.Point(15, 103);
            this.lblAverageIncomes.Name = "lblAverageIncomes";
            this.lblAverageIncomes.Size = new System.Drawing.Size(130, 20);
            this.lblAverageIncomes.TabIndex = 18;
            this.lblAverageIncomes.Text = "Prosjek prihoda:";
            // 
            // lblAverageExpenses
            // 
            this.lblAverageExpenses.AutoSize = true;
            this.lblAverageExpenses.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAverageExpenses.ForeColor = System.Drawing.Color.White;
            this.lblAverageExpenses.Location = new System.Drawing.Point(15, 130);
            this.lblAverageExpenses.Name = "lblAverageExpenses";
            this.lblAverageExpenses.Size = new System.Drawing.Size(138, 20);
            this.lblAverageExpenses.TabIndex = 19;
            this.lblAverageExpenses.Text = "Prosjek troškova:";
            // 
            // txtAverageExpenses
            // 
            this.txtAverageExpenses.Location = new System.Drawing.Point(159, 130);
            this.txtAverageExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAverageExpenses.Name = "txtAverageExpenses";
            this.txtAverageExpenses.ReadOnly = true;
            this.txtAverageExpenses.Size = new System.Drawing.Size(136, 22);
            this.txtAverageExpenses.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "€";
            // 
            // txtAverageIncomes
            // 
            this.txtAverageIncomes.Location = new System.Drawing.Point(151, 103);
            this.txtAverageIncomes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAverageIncomes.Name = "txtAverageIncomes";
            this.txtAverageIncomes.ReadOnly = true;
            this.txtAverageIncomes.Size = new System.Drawing.Size(144, 22);
            this.txtAverageIncomes.TabIndex = 24;
            // 
            // chrGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chrGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrGraph.Legends.Add(legend1);
            this.chrGraph.Location = new System.Drawing.Point(348, 18);
            this.chrGraph.Margin = new System.Windows.Forms.Padding(4);
            this.chrGraph.Name = "chrGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "sExpenseIncome";
            series1.YValuesPerPoint = 2;
            this.chrGraph.Series.Add(series1);
            this.chrGraph.Size = new System.Drawing.Size(680, 348);
            this.chrGraph.TabIndex = 25;
            // 
            // FrmCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1041, 419);
            this.Controls.Add(this.chrGraph);
            this.Controls.Add(this.txtAverageIncomes);
            this.Controls.Add(this.lblAverageIncomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAverageExpenses);
            this.Controls.Add(this.lblAverageExpenses);
            this.Controls.Add(this.btnIncomeShow);
            this.Controls.Add(this.lblEuro3);
            this.Controls.Add(this.lblProfitLoss);
            this.Controls.Add(this.txtProfitLoss);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblExpenseSum);
            this.Controls.Add(this.txtExpenseSum);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIncomeSum);
            this.Controls.Add(this.txtIncomeSum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1059, 466);
            this.MinimumSize = new System.Drawing.Size(1059, 466);
            this.Name = "FrmCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novčani tok";
            this.Load += new System.EventHandler(this.FrmCashFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseReportViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIncomeSum;
        private System.Windows.Forms.Label lblIncomeSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblExpenseSum;
        private System.Windows.Forms.TextBox txtExpenseSum;
        private System.Windows.Forms.Label lblEuro3;
        private System.Windows.Forms.Label lblProfitLoss;
        private System.Windows.Forms.TextBox txtProfitLoss;
        private System.Windows.Forms.Button btnIncomeShow;
        private System.Windows.Forms.Label lblAverageIncomes;
        private System.Windows.Forms.Label lblAverageExpenses;
        private System.Windows.Forms.TextBox txtAverageExpenses;
        private System.Windows.Forms.BindingSource expenseReportViewBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAverageIncomes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraph;
    }
}