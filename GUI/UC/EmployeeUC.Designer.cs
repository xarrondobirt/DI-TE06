namespace GUI.UC
{
    partial class EmployeeUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpEmployeeUC = new System.Windows.Forms.TableLayoutPanel();
            this.chartEmployeeUC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpEmployeeRUC = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmployeeUCBot = new System.Windows.Forms.Label();
            this.labelEmployeeUCMiddle = new System.Windows.Forms.Label();
            this.employeeImg = new System.Windows.Forms.PictureBox();
            this.tlpEmployeeUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeUC)).BeginInit();
            this.tlpEmployeeRUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEmployeeUC
            // 
            this.tlpEmployeeUC.ColumnCount = 2;
            this.tlpEmployeeUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.42513F));
            this.tlpEmployeeUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.57487F));
            this.tlpEmployeeUC.Controls.Add(this.chartEmployeeUC, 0, 0);
            this.tlpEmployeeUC.Controls.Add(this.tlpEmployeeRUC, 1, 0);
            this.tlpEmployeeUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeUC.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployeeUC.Name = "tlpEmployeeUC";
            this.tlpEmployeeUC.RowCount = 1;
            this.tlpEmployeeUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmployeeUC.Size = new System.Drawing.Size(1162, 684);
            this.tlpEmployeeUC.TabIndex = 0;
            // 
            // chartEmployeeUC
            // 
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.Title = "Empleados";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            chartArea1.AxisY.Title = "Número de ventas";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            chartArea1.Name = "ChartArea1";
            this.chartEmployeeUC.ChartAreas.Add(chartArea1);
            this.chartEmployeeUC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEmployeeUC.Legends.Add(legend1);
            this.chartEmployeeUC.Location = new System.Drawing.Point(3, 3);
            this.chartEmployeeUC.Name = "chartEmployeeUC";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.CustomProperties = "BarLabelStyle=Left";
            series1.Legend = "Legend1";
            series1.Name = "Mejores vendedores";
            this.chartEmployeeUC.Series.Add(series1);
            this.chartEmployeeUC.Size = new System.Drawing.Size(731, 678);
            this.chartEmployeeUC.TabIndex = 0;
            this.chartEmployeeUC.Text = "chart1";
            // 
            // tlpEmployeeRUC
            // 
            this.tlpEmployeeRUC.BackColor = System.Drawing.Color.White;
            this.tlpEmployeeRUC.ColumnCount = 1;
            this.tlpEmployeeRUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeRUC.Controls.Add(this.labelEmployeeUCBot, 0, 2);
            this.tlpEmployeeRUC.Controls.Add(this.labelEmployeeUCMiddle, 0, 1);
            this.tlpEmployeeRUC.Controls.Add(this.employeeImg, 0, 0);
            this.tlpEmployeeRUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeRUC.Location = new System.Drawing.Point(740, 3);
            this.tlpEmployeeRUC.Name = "tlpEmployeeRUC";
            this.tlpEmployeeRUC.RowCount = 3;
            this.tlpEmployeeRUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.89381F));
            this.tlpEmployeeRUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42183F));
            this.tlpEmployeeRUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68437F));
            this.tlpEmployeeRUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmployeeRUC.Size = new System.Drawing.Size(419, 678);
            this.tlpEmployeeRUC.TabIndex = 1;
            this.tlpEmployeeRUC.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpEmployeeRUC_Paint);
            // 
            // labelEmployeeUCBot
            // 
            this.labelEmployeeUCBot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeUCBot.AutoSize = true;
            this.labelEmployeeUCBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeUCBot.Location = new System.Drawing.Point(176, 622);
            this.labelEmployeeUCBot.Name = "labelEmployeeUCBot";
            this.labelEmployeeUCBot.Size = new System.Drawing.Size(66, 25);
            this.labelEmployeeUCBot.TabIndex = 2;
            this.labelEmployeeUCBot.Text = "Cargo";
            // 
            // labelEmployeeUCMiddle
            // 
            this.labelEmployeeUCMiddle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmployeeUCMiddle.AutoSize = true;
            this.labelEmployeeUCMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeUCMiddle.Location = new System.Drawing.Point(131, 533);
            this.labelEmployeeUCMiddle.Name = "labelEmployeeUCMiddle";
            this.labelEmployeeUCMiddle.Size = new System.Drawing.Size(156, 25);
            this.labelEmployeeUCMiddle.TabIndex = 1;
            this.labelEmployeeUCMiddle.Text = "Nombre Apellido";
            // 
            // employeeImg
            // 
            this.employeeImg.BackColor = System.Drawing.Color.White;
            this.employeeImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeImg.Location = new System.Drawing.Point(3, 3);
            this.employeeImg.Name = "employeeImg";
            this.employeeImg.Size = new System.Drawing.Size(413, 494);
            this.employeeImg.TabIndex = 3;
            this.employeeImg.TabStop = false;
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpEmployeeUC);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(1162, 684);
            this.tlpEmployeeUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeUC)).EndInit();
            this.tlpEmployeeRUC.ResumeLayout(false);
            this.tlpEmployeeRUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEmployeeUC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeUC;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeRUC;
        private System.Windows.Forms.Label labelEmployeeUCBot;
        private System.Windows.Forms.Label labelEmployeeUCMiddle;
        private System.Windows.Forms.PictureBox employeeImg;
    }
}
