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
            this.ChartButton = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.BreakdownButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.NumericUpDown();
            this.Allocated = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StatementTextBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocated)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartButton
            // 
            this.ChartButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChartButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.chart2;
            this.ChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChartButton.Location = new System.Drawing.Point(383, 0);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(57, 62);
            this.ChartButton.TabIndex = 25;
            this.ChartButton.UseVisualStyleBackColor = false;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // Excel
            // 
            this.Excel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Excel.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.file;
            this.Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Excel.Location = new System.Drawing.Point(440, 0);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(57, 62);
            this.Excel.TabIndex = 22;
            this.Excel.UseVisualStyleBackColor = false;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // BreakdownButton
            // 
            this.BreakdownButton.BackColor = System.Drawing.Color.White;
            this.BreakdownButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.development;
            this.BreakdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BreakdownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BreakdownButton.Location = new System.Drawing.Point(497, 0);
            this.BreakdownButton.Name = "BreakdownButton";
            this.BreakdownButton.Size = new System.Drawing.Size(63, 62);
            this.BreakdownButton.TabIndex = 16;
            this.BreakdownButton.UseVisualStyleBackColor = false;
            this.BreakdownButton.Click += new System.EventHandler(this.BreakDownButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.close;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveButton.Location = new System.Drawing.Point(560, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(63, 62);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.White;
            this.LogButton.BackgroundImage = global::DTD.OM.FormsControl.Properties.Resources.log;
            this.LogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogButton.Location = new System.Drawing.Point(320, 0);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(63, 62);
            this.LogButton.TabIndex = 29;
            this.LogButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.Allocated);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 23);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Left";
            // 
            // Left
            // 
            this.Left.Dock = System.Windows.Forms.DockStyle.Right;
            this.Left.Enabled = false;
            this.Left.Location = new System.Drawing.Point(204, 0);
            this.Left.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Left.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.Left.Name = "Left";
            this.Left.ReadOnly = true;
            this.Left.Size = new System.Drawing.Size(116, 20);
            this.Left.TabIndex = 7;
            this.Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Left.ThousandsSeparator = true;
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
            this.Allocated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Allocated.ThousandsSeparator = true;
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
            // StatementTextBox
            // 
            this.StatementTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StatementTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StatementTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatementTextBox.FormattingEnabled = true;
            this.StatementTextBox.Location = new System.Drawing.Point(0, 0);
            this.StatementTextBox.Name = "StatementTextBox";
            this.StatementTextBox.Size = new System.Drawing.Size(121, 21);
            this.StatementTextBox.TabIndex = 31;
            this.StatementTextBox.SelectedIndexChanged += new System.EventHandler(this.StatementTextBox_SelectedIndexChanged);
            this.StatementTextBox.TextChanged += new System.EventHandler(this.StatementTextBox_SelectedIndexChanged);
            // 
            // StatementAllocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StatementTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.BreakdownButton);
            this.Controls.Add(this.RemoveButton);
            this.DoubleBuffered = true;
            this.Name = "StatementAllocationControl";
            this.Size = new System.Drawing.Size(623, 62);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BreakdownButton;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown Left;
        public System.Windows.Forms.NumericUpDown Allocated;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox StatementTextBox;
        public System.Windows.Forms.Button RemoveButton;
    }
}
