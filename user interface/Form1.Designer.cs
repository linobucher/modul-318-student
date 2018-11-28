namespace user_interface
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cbo_from = new System.Windows.Forms.ComboBox();
            this.cbo_to = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.btn_showconnection = new System.Windows.Forms.Button();
            this.btn_showstationfrom = new System.Windows.Forms.Button();
            this.btn_showstationto = new System.Windows.Forms.Button();
            this.lbl_SBFAHRPLAN = new System.Windows.Forms.Label();
            this.lbo_connections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbo_from
            // 
            this.cbo_from.FormattingEnabled = true;
            this.cbo_from.Location = new System.Drawing.Point(11, 99);
            this.cbo_from.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_from.Name = "cbo_from";
            this.cbo_from.Size = new System.Drawing.Size(188, 21);
            this.cbo_from.TabIndex = 0;
            // 
            // cbo_to
            // 
            this.cbo_to.FormattingEnabled = true;
            this.cbo_to.Location = new System.Drawing.Point(334, 99);
            this.cbo_to.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_to.Name = "cbo_to";
            this.cbo_to.Size = new System.Drawing.Size(188, 21);
            this.cbo_to.TabIndex = 1;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(8, 84);
            this.lbl_from.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(26, 13);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "Von";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(331, 84);
            this.lbl_to.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(33, 13);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "Nach";
            // 
            // btn_showconnection
            // 
            this.btn_showconnection.BackColor = System.Drawing.Color.Red;
            this.btn_showconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_showconnection.ForeColor = System.Drawing.Color.White;
            this.btn_showconnection.Location = new System.Drawing.Point(334, 145);
            this.btn_showconnection.Name = "btn_showconnection";
            this.btn_showconnection.Size = new System.Drawing.Size(188, 34);
            this.btn_showconnection.TabIndex = 8;
            this.btn_showconnection.Text = "Verbindung suchen -->";
            this.btn_showconnection.UseVisualStyleBackColor = false;
            this.btn_showconnection.Click += new System.EventHandler(this.btn_showconnection_Click);
            // 
            // btn_showstationfrom
            // 
            this.btn_showstationfrom.Location = new System.Drawing.Point(204, 99);
            this.btn_showstationfrom.Name = "btn_showstationfrom";
            this.btn_showstationfrom.Size = new System.Drawing.Size(49, 21);
            this.btn_showstationfrom.TabIndex = 9;
            this.btn_showstationfrom.Text = "Suche\r\n";
            this.btn_showstationfrom.UseVisualStyleBackColor = true;
            this.btn_showstationfrom.Click += new System.EventHandler(this.btn_showstationfrom_Click);
            // 
            // btn_showstationto
            // 
            this.btn_showstationto.Location = new System.Drawing.Point(527, 99);
            this.btn_showstationto.Name = "btn_showstationto";
            this.btn_showstationto.Size = new System.Drawing.Size(49, 21);
            this.btn_showstationto.TabIndex = 10;
            this.btn_showstationto.Text = "Suche\r\n";
            this.btn_showstationto.UseVisualStyleBackColor = true;
            this.btn_showstationto.Click += new System.EventHandler(this.btn_showstationto_Click);
            // 
            // lbl_SBFAHRPLAN
            // 
            this.lbl_SBFAHRPLAN.AutoSize = true;
            this.lbl_SBFAHRPLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_SBFAHRPLAN.Location = new System.Drawing.Point(176, 32);
            this.lbl_SBFAHRPLAN.Name = "lbl_SBFAHRPLAN";
            this.lbl_SBFAHRPLAN.Size = new System.Drawing.Size(233, 31);
            this.lbl_SBFAHRPLAN.TabIndex = 11;
            this.lbl_SBFAHRPLAN.Text = "Der SBB Fahrplan";
            // 
            // lbo_connections
            // 
            this.lbo_connections.FormattingEnabled = true;
            this.lbo_connections.Location = new System.Drawing.Point(11, 192);
            this.lbo_connections.Name = "lbo_connections";
            this.lbo_connections.Size = new System.Drawing.Size(565, 199);
            this.lbo_connections.TabIndex = 12;
            this.lbo_connections.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 416);
            this.Controls.Add(this.lbo_connections);
            this.Controls.Add(this.lbl_SBFAHRPLAN);
            this.Controls.Add(this.btn_showstationto);
            this.Controls.Add(this.btn_showstationfrom);
            this.Controls.Add(this.btn_showconnection);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.cbo_to);
            this.Controls.Add(this.cbo_from);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_from;
        private System.Windows.Forms.ComboBox cbo_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Button btn_showconnection;
        private System.Windows.Forms.Button btn_showstationfrom;
        private System.Windows.Forms.Button btn_showstationto;
        private System.Windows.Forms.Label lbl_SBFAHRPLAN;
        private System.Windows.Forms.ListBox lbo_connections;
    }
}

