namespace DTD.OM.FormsControl.CustomControls
{
    partial class PersonnelControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Remove = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OfficeEmail = new MetroFramework.Controls.MetroLabel();
            this.PersonalEmail = new MetroFramework.Controls.MetroLabel();
            this.MobileNo = new MetroFramework.Controls.MetroLabel();
            this.NID = new MetroFramework.Controls.MetroLabel();
            this.Department = new MetroFramework.Controls.MetroLabel();
            this.OfficeID = new MetroFramework.Controls.MetroLabel();
            this.Salary = new MetroFramework.Controls.MetroLabel();
            this.JoinDate = new MetroFramework.Controls.MetroLabel();
            this.Designation = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DTD.OM.FormsControl.Properties.Resources.DefaultImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.LightCoral;
            this.Remove.Dock = System.Windows.Forms.DockStyle.Right;
            this.Remove.Location = new System.Drawing.Point(664, 0);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(89, 129);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseCustomBackColor = true;
            this.Remove.UseMnemonic = false;
            this.Remove.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButton2.Location = new System.Drawing.Point(576, 0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 129);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseMnemonic = false;
            this.metroButton2.UseSelectable = true;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLable.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLable.Location = new System.Drawing.Point(3, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(62, 25);
            this.NameLable.TabIndex = 3;
            this.NameLable.Text = "Name";
            this.NameLable.UseCustomBackColor = true;
            this.NameLable.UseCustomForeColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel1.Controls.Add(this.NameLable);
            this.flowLayoutPanel1.Controls.Add(this.OfficeEmail);
            this.flowLayoutPanel1.Controls.Add(this.PersonalEmail);
            this.flowLayoutPanel1.Controls.Add(this.MobileNo);
            this.flowLayoutPanel1.Controls.Add(this.NID);
            this.flowLayoutPanel1.Controls.Add(this.Department);
            this.flowLayoutPanel1.Controls.Add(this.Designation);
            this.flowLayoutPanel1.Controls.Add(this.OfficeID);
            this.flowLayoutPanel1.Controls.Add(this.Salary);
            this.flowLayoutPanel1.Controls.Add(this.JoinDate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 129);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // OfficeEmail
            // 
            this.OfficeEmail.AutoSize = true;
            this.OfficeEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OfficeEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OfficeEmail.ForeColor = System.Drawing.Color.ForestGreen;
            this.OfficeEmail.Location = new System.Drawing.Point(3, 25);
            this.OfficeEmail.Name = "OfficeEmail";
            this.OfficeEmail.Size = new System.Drawing.Size(195, 25);
            this.OfficeEmail.TabIndex = 4;
            this.OfficeEmail.Text = "Name@iquantile.com";
            this.OfficeEmail.UseCustomBackColor = true;
            this.OfficeEmail.UseCustomForeColor = true;
            // 
            // PersonalEmail
            // 
            this.PersonalEmail.AutoSize = true;
            this.PersonalEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PersonalEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PersonalEmail.Location = new System.Drawing.Point(3, 50);
            this.PersonalEmail.Name = "PersonalEmail";
            this.PersonalEmail.Size = new System.Drawing.Size(167, 25);
            this.PersonalEmail.TabIndex = 5;
            this.PersonalEmail.Text = "Name@gmail.com";
            this.PersonalEmail.UseCustomBackColor = true;
            this.PersonalEmail.UseCustomForeColor = true;
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSize = true;
            this.MobileNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MobileNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MobileNo.ForeColor = System.Drawing.Color.SkyBlue;
            this.MobileNo.Location = new System.Drawing.Point(3, 75);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(122, 25);
            this.MobileNo.TabIndex = 6;
            this.MobileNo.Text = "01912995783";
            this.MobileNo.UseCustomBackColor = true;
            this.MobileNo.UseCustomForeColor = true;
            // 
            // NID
            // 
            this.NID.AutoSize = true;
            this.NID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NID.Location = new System.Drawing.Point(3, 100);
            this.NID.Name = "NID";
            this.NID.Size = new System.Drawing.Size(50, 25);
            this.NID.TabIndex = 7;
            this.NID.Text = "NID:";
            this.NID.UseCustomBackColor = true;
            this.NID.UseCustomForeColor = true;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Department.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Department.Location = new System.Drawing.Point(204, 0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(169, 25);
            this.Department.TabIndex = 8;
            this.Department.Text = "Game Department";
            this.Department.UseCustomBackColor = true;
            this.Department.UseCustomForeColor = true;
            // 
            // OfficeID
            // 
            this.OfficeID.AutoSize = true;
            this.OfficeID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OfficeID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OfficeID.Location = new System.Drawing.Point(204, 50);
            this.OfficeID.Name = "OfficeID";
            this.OfficeID.Size = new System.Drawing.Size(36, 25);
            this.OfficeID.TabIndex = 9;
            this.OfficeID.Text = "ID:";
            this.OfficeID.UseCustomBackColor = true;
            this.OfficeID.UseCustomForeColor = true;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Salary.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Salary.Location = new System.Drawing.Point(204, 75);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(70, 25);
            this.Salary.TabIndex = 10;
            this.Salary.Text = "Salary:";
            this.Salary.UseCustomBackColor = true;
            this.Salary.UseCustomForeColor = true;
            // 
            // JoinDate
            // 
            this.JoinDate.AutoSize = true;
            this.JoinDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.JoinDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.JoinDate.Location = new System.Drawing.Point(204, 100);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(153, 25);
            this.JoinDate.TabIndex = 11;
            this.JoinDate.Text = "Join Date:1/1/18";
            this.JoinDate.UseCustomBackColor = true;
            this.JoinDate.UseCustomForeColor = true;
            // 
            // Designation
            // 
            this.Designation.AutoSize = true;
            this.Designation.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Designation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Designation.Location = new System.Drawing.Point(204, 25);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(99, 25);
            this.Designation.TabIndex = 12;
            this.Designation.Text = "Developer";
            this.Designation.UseCustomBackColor = true;
            this.Designation.UseCustomForeColor = true;
            // 
            // PersonnelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonnelControl";
            this.Size = new System.Drawing.Size(753, 129);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton Remove;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel NameLable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel OfficeEmail;
        private MetroFramework.Controls.MetroLabel PersonalEmail;
        private MetroFramework.Controls.MetroLabel MobileNo;
        private MetroFramework.Controls.MetroLabel NID;
        private MetroFramework.Controls.MetroLabel Department;
        private MetroFramework.Controls.MetroLabel OfficeID;
        private MetroFramework.Controls.MetroLabel Salary;
        private MetroFramework.Controls.MetroLabel JoinDate;
        private MetroFramework.Controls.MetroLabel Designation;
    }
}
