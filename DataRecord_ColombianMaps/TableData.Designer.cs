namespace DataRecord_ColombianMaps
{
    partial class TableData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableData));
            this.label1 = new System.Windows.Forms.Label();
            this.DataMap = new System.Windows.Forms.DataGridView();
            this.importData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listDepartaments = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Filt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DataMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(432, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataMap
            // 
            this.DataMap.AllowUserToAddRows = false;
            this.DataMap.AllowUserToDeleteRows = false;
            this.DataMap.AllowUserToOrderColumns = true;
            this.DataMap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ubuntu Light", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataMap.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataMap.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataMap.Location = new System.Drawing.Point(25, 176);
            this.DataMap.Name = "DataMap";
            this.DataMap.ReadOnly = true;
            this.DataMap.Size = new System.Drawing.Size(530, 256);
            this.DataMap.TabIndex = 1;
           
            // 
            // importData
            // 
            this.importData.Location = new System.Drawing.Point(25, 457);
            this.importData.Name = "importData";
            this.importData.Size = new System.Drawing.Size(91, 30);
            this.importData.TabIndex = 2;
            this.importData.Text = "Import";
            this.importData.UseVisualStyleBackColor = true;
            this.importData.Click += new System.EventHandler(this.importData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(363, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click in import button to load from external data";
            // 
            // listDepartaments
            // 
            this.listDepartaments.BackColor = System.Drawing.SystemColors.Window;
            this.listDepartaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDepartaments.DropDownWidth = 289;
            this.listDepartaments.Enabled = false;
            this.listDepartaments.Font = new System.Drawing.Font("Ubuntu Light", 9F, System.Drawing.FontStyle.Italic);
            this.listDepartaments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listDepartaments.FormattingEnabled = true;
            this.listDepartaments.Location = new System.Drawing.Point(166, 144);
            this.listDepartaments.Name = "listDepartaments";
            this.listDepartaments.Size = new System.Drawing.Size(304, 24);
            this.listDepartaments.Sorted = true;
            this.listDepartaments.TabIndex = 4;
            this.listDepartaments.Visible = false;
            this.listDepartaments.TextChanged += new System.EventHandler(this.listDepartaments_TextChanged);
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Font = new System.Drawing.Font("Ubuntu Light", 9F);
            this.Filter.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Filter.Location = new System.Drawing.Point(23, 147);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(137, 16);
            this.Filter.TabIndex = 5;
            this.Filter.Text = "Filter by departament: ";
            this.Filter.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu Light", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departaments and Municipalities of Colombia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Filt
            // 
            this.Filt.Enabled = false;
            this.Filt.Location = new System.Drawing.Point(476, 142);
            this.Filt.Name = "Filt";
            this.Filt.Size = new System.Drawing.Size(79, 26);
            this.Filt.TabIndex = 7;
            this.Filt.Text = "Filter";
            this.Filt.UseVisualStyleBackColor = true;
            this.Filt.Visible = false;
            this.Filt.Click += new System.EventHandler(this.Filt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.Diagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Diagram.Legends.Add(legend1);
            this.Diagram.Location = new System.Drawing.Point(575, 176);
            this.Diagram.Name = "Diagram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Diagram.Series.Add(series1);
            this.Diagram.Size = new System.Drawing.Size(404, 256);
            this.Diagram.TabIndex = 8;
            this.Diagram.Text = "chart1";
            this.Diagram.Visible = false;
            // 
            // TableData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1002, 523);
            this.Controls.Add(this.Diagram);
            this.Controls.Add(this.Filt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.listDepartaments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importData);
            this.Controls.Add(this.DataMap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ubuntu Light", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TableData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colombia\'s Regions";
            this.Load += new System.EventHandler(this.TableData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataMap;
        private System.Windows.Forms.Button importData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listDepartaments;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Filt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diagram;
    }
}

