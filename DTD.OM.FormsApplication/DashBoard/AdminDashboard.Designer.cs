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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.PersonnelButton = new System.Windows.Forms.Button();
            this.AccountingButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(20, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 37);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PersonnelButton);
            this.panel2.Controls.Add(this.AccountingButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(20, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 430);
            this.panel2.TabIndex = 4;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(92, 97);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(801, 430);
            this.ViewPanel.TabIndex = 5;
            // 
            // PersonnelButton
            // 
            this.PersonnelButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PersonnelButton.BackgroundImage = global::DTD.OM.FormsApplication.Properties.Resources.User;
            this.PersonnelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonnelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonnelButton.Location = new System.Drawing.Point(0, 66);
            this.PersonnelButton.Name = "PersonnelButton";
            this.PersonnelButton.Size = new System.Drawing.Size(72, 67);
            this.PersonnelButton.TabIndex = 1;
            this.PersonnelButton.UseVisualStyleBackColor = false;
            this.PersonnelButton.Click += new System.EventHandler(this.PersonnelButton_Click);
            // 
            // AccountingButton
            // 
            this.AccountingButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AccountingButton.BackgroundImage = global::DTD.OM.FormsApplication.Properties.Resources.maths;
            this.AccountingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountingButton.Location = new System.Drawing.Point(0, 0);
            this.AccountingButton.Name = "AccountingButton";
            this.AccountingButton.Size = new System.Drawing.Size(72, 66);
            this.AccountingButton.TabIndex = 0;
            this.AccountingButton.UseVisualStyleBackColor = false;
            this.AccountingButton.Click += new System.EventHandler(this.AccountingButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Red;
            this.LogOutButton.BackgroundImage = global::DTD.OM.FormsApplication.Properties.Resources.arrows;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogOutButton.Location = new System.Drawing.Point(837, 0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(36, 37);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 569);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AccountingButton;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button PersonnelButton;
    }
}