namespace DTD.OM.FormsControl.Accounts.SubTab
{
    partial class FundAllocationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthlyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MonthlyPanel);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(736, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 526);
            this.panel1.TabIndex = 1;
            // 
            // MonthlyPanel
            // 
            this.MonthlyPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MonthlyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MonthlyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MonthlyPanel.Location = new System.Drawing.Point(0, 53);
            this.MonthlyPanel.Name = "MonthlyPanel";
            this.MonthlyPanel.Size = new System.Drawing.Size(133, 473);
            this.MonthlyPanel.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 53);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fund Allocation";
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 24);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(736, 502);
            this.ViewPanel.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStatementToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // newStatementToolStripMenuItem
            // 
            this.newStatementToolStripMenuItem.Name = "newStatementToolStripMenuItem";
            this.newStatementToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newStatementToolStripMenuItem.Text = "New Statement";
            this.newStatementToolStripMenuItem.Click += new System.EventHandler(this.newStatementToolStripMenuItem_Click);
            // 
            // FundAllocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FundAllocationControl";
            this.Size = new System.Drawing.Size(869, 526);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.FlowLayoutPanel MonthlyPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newStatementToolStripMenuItem;
    }
}
