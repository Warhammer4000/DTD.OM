namespace DTD.OM.FormsControl.CustomControls
{
    partial class StatementAllocationControl
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
            this.LogButton = new System.Windows.Forms.Button();
            this.BreakdownButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.NumericUpDown();
            this.Allocated = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StatementLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocated)).BeginInit();
            this.SuspendLayout();
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.SpringGreen;
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogButton.Location = new System.Drawing.Point(546, 0);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 60);
            this.LogButton.TabIndex = 15;
            this.LogButton.Text = "Logs";
            this.LogButton.UseVisualStyleBackColor = false;
            // 
            // BreakdownButton
            // 
            this.BreakdownButton.BackColor = System.Drawing.Color.Salmon;
            this.BreakdownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BreakdownButton.Location = new System.Drawing.Point(471, 0);
            this.BreakdownButton.Name = "BreakdownButton";
            this.BreakdownButton.Size = new System.Drawing.Size(75, 60);
            this.BreakdownButton.TabIndex = 16;
            this.BreakdownButton.Text = "Break Down";
            this.BreakdownButton.UseVisualStyleBackColor = false;
            this.BreakdownButton.Click += new System.EventHandler(this.BreakDownButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.GreenYellow;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Location = new System.Drawing.Point(396, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 60);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.Allocated);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 23);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Left";
            // 
            // Left
            // 
            this.Left.Dock = System.Windows.Forms.DockStyle.Right;
            this.Left.Enabled = false;
            this.Left.Location = new System.Drawing.Point(280, 0);
            this.Left.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Left.Name = "Left";
            this.Left.ReadOnly = true;
            this.Left.Size = new System.Drawing.Size(116, 20);
            this.Left.TabIndex = 7;
            // 
            // Allocated
            // 
            this.Allocated.Dock = System.Windows.Forms.DockStyle.Left;
            this.Allocated.Location = new System.Drawing.Point(88, 0);
            this.Allocated.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Allocated.Name = "Allocated";
            this.Allocated.Size = new System.Drawing.Size(116, 20);
            this.Allocated.TabIndex = 1;
            this.Allocated.ValueChanged += new System.EventHandler(this.Allocated_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Allocated";
            // 
            // StatementLable
            // 
            this.StatementLable.AutoSize = true;
            this.StatementLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatementLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatementLable.Location = new System.Drawing.Point(0, 0);
            this.StatementLable.Name = "StatementLable";
            this.StatementLable.Size = new System.Drawing.Size(93, 24);
            this.StatementLable.TabIndex = 19;
            this.StatementLable.Text = "Statement";
            // 
            // StatementAllocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.StatementLable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BreakdownButton);
            this.Controls.Add(this.LogButton);
            this.Name = "StatementAllocationControl";
            this.Size = new System.Drawing.Size(621, 60);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button BreakdownButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown Left;
        public System.Windows.Forms.NumericUpDown Allocated;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatementLable;
        public System.Windows.Forms.Label label3;
    }
}
