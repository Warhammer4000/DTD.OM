namespace DTD.OM.FormsControl.MainTabs
{
    partial class PersonnelTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NewPersonnelButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personnel Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NewPersonnelButton);
            this.panel1.Controls.Add(this.SearchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 60);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.SearchUser;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(497, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 60);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NewPersonnelButton
            // 
            this.NewPersonnelButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.NewUser;
            this.NewPersonnelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewPersonnelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewPersonnelButton.Location = new System.Drawing.Point(0, 0);
            this.NewPersonnelButton.Name = "NewPersonnelButton";
            this.NewPersonnelButton.Size = new System.Drawing.Size(62, 60);
            this.NewPersonnelButton.TabIndex = 1;
            this.NewPersonnelButton.UseVisualStyleBackColor = false;
            this.NewPersonnelButton.Click += new System.EventHandler(this.NewPersonnelButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.NametextBox);
            this.SearchPanel.Controls.Add(this.label3);
            this.SearchPanel.Controls.Add(this.IdTextbox);
            this.SearchPanel.Controls.Add(this.label4);
            this.SearchPanel.Controls.Add(this.DepartmentBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchPanel.Location = new System.Drawing.Point(559, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(301, 60);
            this.SearchPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(54, 3);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(187, 3);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(100, 20);
            this.IdTextbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(91, 29);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentBox.TabIndex = 5;
            // 
            // viewPanel
            // 
            this.viewPanel.AutoScroll = true;
            this.viewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 80);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(860, 462);
            this.viewPanel.TabIndex = 4;
            // 
            // PersonnelTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "PersonnelTab";
            this.Size = new System.Drawing.Size(860, 542);
            this.panel1.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewPersonnelButton;
        private System.Windows.Forms.FlowLayoutPanel SearchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.Panel viewPanel;
    }
}
