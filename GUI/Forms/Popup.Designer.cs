namespace GUI.Forms
{
    partial class Popup
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
            this.infoName = new System.Windows.Forms.Label();
            this.infoCalle = new System.Windows.Forms.Label();
            this.infoLoc = new System.Windows.Forms.Label();
            this.infoTlf = new System.Windows.Forms.Label();
            this.infoMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoName.Location = new System.Drawing.Point(78, 63);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(152, 25);
            this.infoName.TabIndex = 0;
            this.infoName.Text = "Northwind SL";
            // 
            // infoCalle
            // 
            this.infoCalle.AutoSize = true;
            this.infoCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCalle.Location = new System.Drawing.Point(80, 134);
            this.infoCalle.Name = "infoCalle";
            this.infoCalle.Size = new System.Drawing.Size(122, 20);
            this.infoCalle.TabIndex = 1;
            this.infoCalle.Text = "Calle Falsa, 123";
            // 
            // infoLoc
            // 
            this.infoLoc.AutoSize = true;
            this.infoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLoc.Location = new System.Drawing.Point(79, 166);
            this.infoLoc.Name = "infoLoc";
            this.infoLoc.Size = new System.Drawing.Size(319, 20);
            this.infoLoc.TabIndex = 2;
            this.infoLoc.Text = "00000 Donostia-San Sebastián GIPUZKOA";
            this.infoLoc.Click += new System.EventHandler(this.infoLoc_Click);
            // 
            // infoTlf
            // 
            this.infoTlf.AutoSize = true;
            this.infoTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTlf.Location = new System.Drawing.Point(79, 229);
            this.infoTlf.Name = "infoTlf";
            this.infoTlf.Size = new System.Drawing.Size(123, 20);
            this.infoTlf.TabIndex = 3;
            this.infoTlf.Text = "Tlf. 900 000 000";
            this.infoTlf.Click += new System.EventHandler(this.infoTlf_Click);
            // 
            // infoMail
            // 
            this.infoMail.AutoSize = true;
            this.infoMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMail.Location = new System.Drawing.Point(79, 261);
            this.infoMail.Name = "infoMail";
            this.infoMail.Size = new System.Drawing.Size(197, 20);
            this.infoMail.TabIndex = 4;
            this.infoMail.Text = "northwind@northwind.com";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 395);
            this.Controls.Add(this.infoMail);
            this.Controls.Add(this.infoTlf);
            this.Controls.Add(this.infoLoc);
            this.Controls.Add(this.infoCalle);
            this.Controls.Add(this.infoName);
            this.Name = "Popup";
            this.Text = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoName;
        private System.Windows.Forms.Label infoCalle;
        private System.Windows.Forms.Label infoLoc;
        private System.Windows.Forms.Label infoTlf;
        private System.Windows.Forms.Label infoMail;
    }
}