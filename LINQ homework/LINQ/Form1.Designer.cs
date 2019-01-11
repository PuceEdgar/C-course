namespace LINQ
{
    partial class frmEmployeeGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CandJfilter = new System.Windows.Forms.Button();
            this.IorEfilter = new System.Windows.Forms.Button();
            this.AgeFilter = new System.Windows.Forms.Button();
            this.SameLetterFilter = new System.Windows.Forms.Button();
            this.LengthFilter = new System.Windows.Forms.Button();
            this.ValueFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvEmployees.Location = new System.Drawing.Point(453, 16);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvEmployees.Size = new System.Drawing.Size(1048, 473);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderByName.Location = new System.Drawing.Point(17, 16);
            this.btnOrderByName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(185, 37);
            this.btnOrderByName.TabIndex = 1;
            this.btnOrderByName.Text = "Order By Name";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            this.btnOrderByName.Click += new System.EventHandler(this.btnOrderByName_Click);
            // 
            // CandJfilter
            // 
            this.CandJfilter.Location = new System.Drawing.Point(36, 91);
            this.CandJfilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CandJfilter.Name = "CandJfilter";
            this.CandJfilter.Size = new System.Drawing.Size(119, 62);
            this.CandJfilter.TabIndex = 2;
            this.CandJfilter.Text = "CandJfilter";
            this.CandJfilter.UseVisualStyleBackColor = true;
            this.CandJfilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // IorEfilter
            // 
            this.IorEfilter.Location = new System.Drawing.Point(256, 91);
            this.IorEfilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IorEfilter.Name = "IorEfilter";
            this.IorEfilter.Size = new System.Drawing.Size(119, 62);
            this.IorEfilter.TabIndex = 2;
            this.IorEfilter.Text = "IorEfilter";
            this.IorEfilter.UseVisualStyleBackColor = true;
            this.IorEfilter.Click += new System.EventHandler(this.IorEfilter_Click);
            // 
            // AgeFilter
            // 
            this.AgeFilter.Location = new System.Drawing.Point(36, 283);
            this.AgeFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgeFilter.Name = "AgeFilter";
            this.AgeFilter.Size = new System.Drawing.Size(119, 62);
            this.AgeFilter.TabIndex = 2;
            this.AgeFilter.Text = "LengthFilter";
            this.AgeFilter.UseVisualStyleBackColor = true;
            this.AgeFilter.Click += new System.EventHandler(this.AgeFilter_Click);
            // 
            // SameLetterFilter
            // 
            this.SameLetterFilter.Location = new System.Drawing.Point(256, 283);
            this.SameLetterFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SameLetterFilter.Name = "SameLetterFilter";
            this.SameLetterFilter.Size = new System.Drawing.Size(119, 62);
            this.SameLetterFilter.TabIndex = 2;
            this.SameLetterFilter.Text = "ValueFilter";
            this.SameLetterFilter.UseVisualStyleBackColor = true;
            this.SameLetterFilter.Click += new System.EventHandler(this.SameLetterFilter_Click);
            // 
            // LengthFilter
            // 
            this.LengthFilter.Location = new System.Drawing.Point(36, 180);
            this.LengthFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LengthFilter.Name = "LengthFilter";
            this.LengthFilter.Size = new System.Drawing.Size(119, 62);
            this.LengthFilter.TabIndex = 2;
            this.LengthFilter.Text = "AgeFilter";
            this.LengthFilter.UseVisualStyleBackColor = true;
            this.LengthFilter.Click += new System.EventHandler(this.LengthFilter_Click);
            // 
            // ValueFilter
            // 
            this.ValueFilter.Location = new System.Drawing.Point(256, 180);
            this.ValueFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValueFilter.Name = "ValueFilter";
            this.ValueFilter.Size = new System.Drawing.Size(129, 62);
            this.ValueFilter.TabIndex = 2;
            this.ValueFilter.Text = "SameLetterFilter";
            this.ValueFilter.UseVisualStyleBackColor = true;
            this.ValueFilter.Click += new System.EventHandler(this.ValueFilter_Click);
            // 
            // frmEmployeeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 503);
            this.Controls.Add(this.ValueFilter);
            this.Controls.Add(this.LengthFilter);
            this.Controls.Add(this.SameLetterFilter);
            this.Controls.Add(this.AgeFilter);
            this.Controls.Add(this.IorEfilter);
            this.Controls.Add(this.CandJfilter);
            this.Controls.Add(this.btnOrderByName);
            this.Controls.Add(this.dgvEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmployeeGrid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CandJfilter;
        private System.Windows.Forms.Button IorEfilter;
        private System.Windows.Forms.Button AgeFilter;
        private System.Windows.Forms.Button SameLetterFilter;
        private System.Windows.Forms.Button LengthFilter;
        private System.Windows.Forms.Button ValueFilter;
    }
}

