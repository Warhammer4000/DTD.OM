namespace DTD.OM.FormsControl.MainTabs
{
    partial class AccountsTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FundButton = new System.Windows.Forms.Button();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FundButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // FundButton
            // 
            this.FundButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FundButton.Location = new System.Drawing.Point(0, 0);
            this.FundButton.Name = "FundButton";
            this.FundButton.Size = new System.Drawing.Size(95, 52);
            this.FundButton.TabIndex = 1;
            this.FundButton.Text = "Fund Allocation";
            this.FundButton.UseVisualStyleBackColor = true;
            this.FundButton.Click += new System.EventHandler(this.FundButton_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 54);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(879, 490);
            this.ViewPanel.TabIndex = 1;
            // 
            // AccountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AccountsTab";
            this.Size = new System.Drawing.Size(879, 544);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FundButton;
        private System.Windows.Forms.Panel ViewPanel;
    }
}
