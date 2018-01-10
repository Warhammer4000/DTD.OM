namespace DTD.OM.FormsApplication.DashBoard
{
    partial class AdminDashboard
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HrButton = new System.Windows.Forms.Button();
            this.ExpenseButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.OperationsButton = new System.Windows.Forms.Button();
            this.AccountingButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1146, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.380665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.61934F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1146, 640);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ViewPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 606);
            this.panel1.TabIndex = 0;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(146, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(994, 606);
            this.ViewPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.HrButton);
            this.panel2.Controls.Add(this.ExpenseButton);
            this.panel2.Controls.Add(this.ReportButton);
            this.panel2.Controls.Add(this.OperationsButton);
            this.panel2.Controls.Add(this.AccountingButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 606);
            this.panel2.TabIndex = 0;
            // 
            // HrButton
            // 
            this.HrButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HrButton.Location = new System.Drawing.Point(0, 240);
            this.HrButton.Name = "HrButton";
            this.HrButton.Size = new System.Drawing.Size(142, 60);
            this.HrButton.TabIndex = 4;
            this.HrButton.Text = "HR";
            this.HrButton.UseVisualStyleBackColor = false;
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpenseButton.Location = new System.Drawing.Point(0, 180);
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.Size = new System.Drawing.Size(142, 60);
            this.ExpenseButton.TabIndex = 3;
            this.ExpenseButton.Text = "Expense";
            this.ExpenseButton.UseVisualStyleBackColor = false;
            // 
            // ReportButton
            // 
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.Location = new System.Drawing.Point(0, 120);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(142, 60);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = false;
            // 
            // OperationsButton
            // 
            this.OperationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OperationsButton.Location = new System.Drawing.Point(0, 60);
            this.OperationsButton.Name = "OperationsButton";
            this.OperationsButton.Size = new System.Drawing.Size(142, 60);
            this.OperationsButton.TabIndex = 1;
            this.OperationsButton.Text = "Operations";
            this.OperationsButton.UseVisualStyleBackColor = false;
            // 
            // AccountingButton
            // 
            this.AccountingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountingButton.Location = new System.Drawing.Point(0, 0);
            this.AccountingButton.Name = "AccountingButton";
            this.AccountingButton.Size = new System.Drawing.Size(142, 60);
            this.AccountingButton.TabIndex = 0;
            this.AccountingButton.Text = "Accounting";
            this.AccountingButton.UseVisualStyleBackColor = false;
            this.AccountingButton.Click += new System.EventHandler(this.AccountingButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1051, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "AdminDashboard";
            this.Text = "Office Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExpenseButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button OperationsButton;
        private System.Windows.Forms.Button AccountingButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HrButton;
    }
}