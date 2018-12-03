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
            this.btn_searchconnection = new System.Windows.Forms.Button();
            this.btn_showstationfrom = new System.Windows.Forms.Button();
            this.btn_showstationto = new System.Windows.Forms.Button();
            this.lbl_SBFAHRPLAN = new System.Windows.Forms.Label();
            this.dgV_connections = new System.Windows.Forms.DataGridView();
            this.dgV_column_departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_column_platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_connections)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_from
            // 
            this.cbo_from.FormattingEnabled = true;
            this.cbo_from.Location = new System.Drawing.Point(22, 190);
            this.cbo_from.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_from.Name = "cbo_from";
            this.cbo_from.Size = new System.Drawing.Size(372, 33);
            this.cbo_from.TabIndex = 0;
            // 
            // cbo_to
            // 
            this.cbo_to.FormattingEnabled = true;
            this.cbo_to.Location = new System.Drawing.Point(668, 190);
            this.cbo_to.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_to.Name = "cbo_to";
            this.cbo_to.Size = new System.Drawing.Size(372, 33);
            this.cbo_to.TabIndex = 1;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(16, 162);
            this.lbl_from.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(50, 25);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "Von";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(662, 162);
            this.lbl_to.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(62, 25);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "Nach";
            // 
            // btn_searchconnection
            // 
            this.btn_searchconnection.BackColor = System.Drawing.Color.Red;
            this.btn_searchconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_searchconnection.ForeColor = System.Drawing.Color.White;
            this.btn_searchconnection.Location = new System.Drawing.Point(668, 233);
            this.btn_searchconnection.Margin = new System.Windows.Forms.Padding(6);
            this.btn_searchconnection.Name = "btn_searchconnection";
            this.btn_searchconnection.Size = new System.Drawing.Size(372, 69);
            this.btn_searchconnection.TabIndex = 8;
            this.btn_searchconnection.Text = "Verbindung suchen -->";
            this.btn_searchconnection.UseVisualStyleBackColor = false;
            this.btn_searchconnection.Click += new System.EventHandler(this.btn_searchconnection_Click);
            // 
            // btn_showstationfrom
            // 
            this.btn_showstationfrom.Location = new System.Drawing.Point(408, 190);
            this.btn_showstationfrom.Margin = new System.Windows.Forms.Padding(6);
            this.btn_showstationfrom.Name = "btn_showstationfrom";
            this.btn_showstationfrom.Size = new System.Drawing.Size(98, 40);
            this.btn_showstationfrom.TabIndex = 9;
            this.btn_showstationfrom.Text = "Suche\r\n";
            this.btn_showstationfrom.UseVisualStyleBackColor = true;
            this.btn_showstationfrom.Click += new System.EventHandler(this.btn_showstationfrom_Click);
            // 
            // btn_showstationto
            // 
            this.btn_showstationto.Location = new System.Drawing.Point(1054, 190);
            this.btn_showstationto.Margin = new System.Windows.Forms.Padding(6);
            this.btn_showstationto.Name = "btn_showstationto";
            this.btn_showstationto.Size = new System.Drawing.Size(98, 40);
            this.btn_showstationto.TabIndex = 10;
            this.btn_showstationto.Text = "Suche\r\n";
            this.btn_showstationto.UseVisualStyleBackColor = true;
            this.btn_showstationto.Click += new System.EventHandler(this.btn_showstationto_Click);
            // 
            // lbl_SBFAHRPLAN
            // 
            this.lbl_SBFAHRPLAN.AutoSize = true;
            this.lbl_SBFAHRPLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_SBFAHRPLAN.Location = new System.Drawing.Point(352, 62);
            this.lbl_SBFAHRPLAN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SBFAHRPLAN.Name = "lbl_SBFAHRPLAN";
            this.lbl_SBFAHRPLAN.Size = new System.Drawing.Size(464, 63);
            this.lbl_SBFAHRPLAN.TabIndex = 11;
            this.lbl_SBFAHRPLAN.Text = "Der SBB Fahrplan";
            // 
            // dgV_connections
            // 
            this.dgV_connections.AllowUserToAddRows = false;
            this.dgV_connections.AllowUserToDeleteRows = false;
            this.dgV_connections.AllowUserToOrderColumns = true;
            this.dgV_connections.AllowUserToResizeColumns = false;
            this.dgV_connections.AllowUserToResizeRows = false;
            this.dgV_connections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgV_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_connections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgV_column_departure,
            this.dgV_column_from,
            this.dgV_column_to,
            this.dgV_column_duration,
            this.cbo_column_platform});
            this.dgV_connections.Location = new System.Drawing.Point(22, 353);
            this.dgV_connections.Name = "dgV_connections";
            this.dgV_connections.ReadOnly = true;
            this.dgV_connections.RowTemplate.Height = 33;
            this.dgV_connections.Size = new System.Drawing.Size(1130, 294);
            this.dgV_connections.TabIndex = 12;
            this.dgV_connections.Visible = false;
            // 
            // dgV_column_departure
            // 
            this.dgV_column_departure.HeaderText = "Abfahrt";
            this.dgV_column_departure.Name = "dgV_column_departure";
            this.dgV_column_departure.ReadOnly = true;
            // 
            // dgV_column_from
            // 
            this.dgV_column_from.HeaderText = "Von";
            this.dgV_column_from.Name = "dgV_column_from";
            this.dgV_column_from.ReadOnly = true;
            // 
            // dgV_column_to
            // 
            this.dgV_column_to.HeaderText = "Nach";
            this.dgV_column_to.Name = "dgV_column_to";
            this.dgV_column_to.ReadOnly = true;
            // 
            // dgV_column_duration
            // 
            this.dgV_column_duration.HeaderText = "Dauer";
            this.dgV_column_duration.Name = "dgV_column_duration";
            this.dgV_column_duration.ReadOnly = true;
            // 
            // cbo_column_platform
            // 
            this.cbo_column_platform.HeaderText = "Gleis";
            this.cbo_column_platform.Name = "cbo_column_platform";
            this.cbo_column_platform.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Station Table anzeigen -->";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgV_connections);
            this.Controls.Add(this.lbl_SBFAHRPLAN);
            this.Controls.Add(this.btn_showstationto);
            this.Controls.Add(this.btn_showstationfrom);
            this.Controls.Add(this.btn_searchconnection);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.cbo_to);
            this.Controls.Add(this.cbo_from);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgV_connections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_from;
        private System.Windows.Forms.ComboBox cbo_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Button btn_searchconnection;
        private System.Windows.Forms.Button btn_showstationfrom;
        private System.Windows.Forms.Button btn_showstationto;
        private System.Windows.Forms.Label lbl_SBFAHRPLAN;
        private System.Windows.Forms.DataGridView dgV_connections;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbo_column_platform;
        private System.Windows.Forms.Button button1;
    }
}

