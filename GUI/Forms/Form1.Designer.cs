namespace GUI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeaderL = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeaderL = new System.Windows.Forms.Label();
            this.cbHeaderL = new System.Windows.Forms.ComboBox();
            this.tlpHeaderR = new System.Windows.Forms.TableLayoutPanel();
            this.cbHeaderR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportViewer = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSideBot = new System.Windows.Forms.Button();
            this.btnSideTop = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.tlpHeader.SuspendLayout();
            this.tlpHeaderL.SuspendLayout();
            this.tlpHeaderR.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.05674F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.94326F));
            this.tlpBase.Controls.Add(this.pb, 0, 0);
            this.tlpBase.Controls.Add(this.tlpHeader, 1, 0);
            this.tlpBase.Controls.Add(this.tlpSide, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpBase.Size = new System.Drawing.Size(1128, 633);
            this.tlpBase.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb.InitialImage")));
            this.pb.Location = new System.Drawing.Point(3, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(130, 88);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.0142F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.9858F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.Controls.Add(this.tlpHeaderL, 0, 0);
            this.tlpHeader.Controls.Add(this.tlpHeaderR, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(139, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpHeader.Size = new System.Drawing.Size(986, 88);
            this.tlpHeader.TabIndex = 1;
            // 
            // tlpHeaderL
            // 
            this.tlpHeaderL.ColumnCount = 2;
            this.tlpHeaderL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.30752F));
            this.tlpHeaderL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.69248F));
            this.tlpHeaderL.Controls.Add(this.labelHeaderL, 0, 0);
            this.tlpHeaderL.Controls.Add(this.cbHeaderL, 1, 0);
            this.tlpHeaderL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderL.Location = new System.Drawing.Point(3, 3);
            this.tlpHeaderL.Name = "tlpHeaderL";
            this.tlpHeaderL.RowCount = 1;
            this.tlpHeaderL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpHeaderL.Size = new System.Drawing.Size(497, 82);
            this.tlpHeaderL.TabIndex = 0;
            // 
            // labelHeaderL
            // 
            this.labelHeaderL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeaderL.AutoSize = true;
            this.labelHeaderL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderL.Location = new System.Drawing.Point(37, 28);
            this.labelHeaderL.Name = "labelHeaderL";
            this.labelHeaderL.Size = new System.Drawing.Size(100, 25);
            this.labelHeaderL.TabIndex = 0;
            this.labelHeaderL.Text = "Productos";
            // 
            // cbHeaderL
            // 
            this.cbHeaderL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHeaderL.BackColor = System.Drawing.SystemColors.Window;
            this.cbHeaderL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHeaderL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeaderL.DropDownWidth = 350;
            this.cbHeaderL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbHeaderL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeaderL.FormattingEnabled = true;
            this.cbHeaderL.Location = new System.Drawing.Point(178, 24);
            this.cbHeaderL.Name = "cbHeaderL";
            this.cbHeaderL.Size = new System.Drawing.Size(316, 33);
            this.cbHeaderL.TabIndex = 1;
            this.cbHeaderL.SelectionChangeCommitted += new System.EventHandler(this.cbHeaderL_SelectionChangeCommitted);
            // 
            // tlpHeaderR
            // 
            this.tlpHeaderR.ColumnCount = 2;
            this.tlpHeaderR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.29906F));
            this.tlpHeaderR.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.70094F));
            this.tlpHeaderR.Controls.Add(this.cbHeaderR, 0, 0);
            this.tlpHeaderR.Controls.Add(this.label1, 0, 0);
            this.tlpHeaderR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderR.Location = new System.Drawing.Point(506, 3);
            this.tlpHeaderR.Name = "tlpHeaderR";
            this.tlpHeaderR.RowCount = 1;
            this.tlpHeaderR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderR.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpHeaderR.Size = new System.Drawing.Size(477, 82);
            this.tlpHeaderR.TabIndex = 1;
            // 
            // cbHeaderR
            // 
            this.cbHeaderR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHeaderR.BackColor = System.Drawing.SystemColors.Window;
            this.cbHeaderR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHeaderR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeaderR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbHeaderR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeaderR.FormattingEnabled = true;
            this.cbHeaderR.Location = new System.Drawing.Point(234, 24);
            this.cbHeaderR.Name = "cbHeaderR";
            this.cbHeaderR.Size = new System.Drawing.Size(219, 33);
            this.cbHeaderR.TabIndex = 2;
            this.cbHeaderR.SelectionChangeCommitted += new System.EventHandler(this.cbHeaderR_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Países";
            // 
            // tlpSide
            // 
            this.tlpSide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpSide.ColumnCount = 1;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSide.Controls.Add(this.btnReportViewer, 0, 3);
            this.tlpSide.Controls.Add(this.btnReport, 0, 2);
            this.tlpSide.Controls.Add(this.btnSideBot, 0, 1);
            this.tlpSide.Controls.Add(this.btnSideTop, 0, 0);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.Location = new System.Drawing.Point(3, 97);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 4;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tlpSide.Size = new System.Drawing.Size(130, 533);
            this.tlpSide.TabIndex = 2;
            this.tlpSide.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpSide_Paint);
            // 
            // btnReportViewer
            // 
            this.btnReportViewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportViewer.BackColor = System.Drawing.Color.Transparent;
            this.btnReportViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportViewer.FlatAppearance.BorderSize = 0;
            this.btnReportViewer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReportViewer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReportViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportViewer.Location = new System.Drawing.Point(3, 408);
            this.btnReportViewer.Name = "btnReportViewer";
            this.btnReportViewer.Size = new System.Drawing.Size(124, 92);
            this.btnReportViewer.TabIndex = 3;
            this.btnReportViewer.Text = "Informe Report Viewer";
            this.btnReportViewer.UseVisualStyleBackColor = false;
            this.btnReportViewer.Click += new System.EventHandler(this.btnReportViewer_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(3, 266);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 92);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Informe Crystal Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSideBot
            // 
            this.btnSideBot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSideBot.BackColor = System.Drawing.Color.Transparent;
            this.btnSideBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideBot.FlatAppearance.BorderSize = 0;
            this.btnSideBot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSideBot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSideBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideBot.Location = new System.Drawing.Point(3, 162);
            this.btnSideBot.Name = "btnSideBot";
            this.btnSideBot.Size = new System.Drawing.Size(124, 50);
            this.btnSideBot.TabIndex = 1;
            this.btnSideBot.Text = "Empleados";
            this.btnSideBot.UseVisualStyleBackColor = false;
            this.btnSideBot.Click += new System.EventHandler(this.btnSideBot_Click);
            // 
            // btnSideTop
            // 
            this.btnSideTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSideTop.BackColor = System.Drawing.Color.Transparent;
            this.btnSideTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideTop.FlatAppearance.BorderSize = 0;
            this.btnSideTop.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSideTop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSideTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideTop.Location = new System.Drawing.Point(3, 37);
            this.btnSideTop.Name = "btnSideTop";
            this.btnSideTop.Size = new System.Drawing.Size(124, 50);
            this.btnSideTop.TabIndex = 0;
            this.btnSideTop.Text = "General";
            this.btnSideTop.UseVisualStyleBackColor = false;
            this.btnSideTop.Click += new System.EventHandler(this.btnSideTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.tlpBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Northwind Dashboard";
            this.tlpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeaderL.ResumeLayout(false);
            this.tlpHeaderL.PerformLayout();
            this.tlpHeaderR.ResumeLayout(false);
            this.tlpHeaderR.PerformLayout();
            this.tlpSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeaderL;
        private System.Windows.Forms.Label labelHeaderL;
        private System.Windows.Forms.ComboBox cbHeaderL;
        private System.Windows.Forms.TableLayoutPanel tlpHeaderR;
        private System.Windows.Forms.ComboBox cbHeaderR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.Button btnSideBot;
        private System.Windows.Forms.Button btnSideTop;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReportViewer;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

