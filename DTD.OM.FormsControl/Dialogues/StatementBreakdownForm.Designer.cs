using System.Windows.Forms;

namespace DTD.OM.FormsControl.Dialogues
{
    partial class StatementBreakdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementBreakdownForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthLable = new System.Windows.Forms.Label();
            this.YearLable = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Allocation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dailyThreashold = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocation)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyThreashold)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            this.panel5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DayBox);
            this.panel1.Controls.Add(this.MonthLable);
            this.panel1.Controls.Add(this.YearLable);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Allocation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 24);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day";
            // 
            // DayBox
            // 
            this.DayBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(456, 0);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(60, 21);
            this.DayBox.TabIndex = 6;
            this.DayBox.SelectedIndexChanged += new System.EventHandler(this.DayBox_SelectedIndexChanged);
            // 
            // MonthLable
            // 
            this.MonthLable.AutoSize = true;
            this.MonthLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLable.Location = new System.Drawing.Point(516, 0);
            this.MonthLable.Name = "MonthLable";
            this.MonthLable.Size = new System.Drawing.Size(42, 20);
            this.MonthLable.TabIndex = 5;
            this.MonthLable.Text = "May,";
            // 
            // YearLable
            // 
            this.YearLable.AutoSize = true;
            this.YearLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.YearLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLable.Location = new System.Drawing.Point(558, 0);
            this.YearLable.Name = "YearLable";
            this.YearLable.Size = new System.Drawing.Size(45, 20);
            this.YearLable.TabIndex = 4;
            this.YearLable.Text = "2018";
            // 
            // Left
            // 
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Enabled = false;
            this.Left.Location = new System.Drawing.Point(251, 0);
            this.Left.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Left.Name = "Left";
            this.Left.ReadOnly = true;
            this.Left.Size = new System.Drawing.Size(120, 20);
            this.Left.TabIndex = 3;
            this.Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Left.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left";
            // 
            // Allocation
            // 
            this.Allocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.Allocation.Enabled = false;
            this.Allocation.Location = new System.Drawing.Point(92, 0);
            this.Allocation.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Allocation.Name = "Allocation";
            this.Allocation.ReadOnly = true;
            this.Allocation.Size = new System.Drawing.Size(120, 20);
            this.Allocation.TabIndex = 1;
            this.Allocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Allocation.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allocation";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dailyThreashold);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 25);
            this.panel3.TabIndex = 2;
            // 
            // dailyThreashold
            // 
            this.dailyThreashold.Dock = System.Windows.Forms.DockStyle.Left;
            this.dailyThreashold.Location = new System.Drawing.Point(177, 0);
            this.dailyThreashold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.dailyThreashold.Name = "dailyThreashold";
            this.dailyThreashold.Size = new System.Drawing.Size(120, 20);
            this.dailyThreashold.TabIndex = 3;
            this.dailyThreashold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dailyThreashold.ThousandsSeparator = true;
            this.dailyThreashold.ValueChanged += new System.EventHandler(this.dailyThreashold_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Today\'s Threashold";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Total);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 23);
            this.panel4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // Total
            // 
            this.Total.Dock = System.Windows.Forms.DockStyle.Right;
            this.Total.Enabled = false;
            this.Total.Location = new System.Drawing.Point(483, 0);
            this.Total.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(120, 20);
            this.Total.TabIndex = 4;
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.ThousandsSeparator = true;
            this.Total.ValueChanged += new System.EventHandler(this.Total_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.ViewPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(20, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(603, 334);
            this.panel5.TabIndex = 8;
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(599, 330);
            this.ViewPanel.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // StatementBreakdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 486);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatementBreakdownForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyThreashold)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            this.panel5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.Label MonthLable;
        private System.Windows.Forms.Label YearLable;
        private System.Windows.Forms.NumericUpDown Left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Allocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown dailyThreashold;
        private System.Windows.Forms.Label label4;
        private Panel panel4;
        private Label label6;
        private NumericUpDown Total;
        private Panel panel5;
        private Panel ViewPanel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newItemToolStripMenuItem;
    }
}