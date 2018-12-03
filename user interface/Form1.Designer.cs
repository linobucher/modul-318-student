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
            this.cbo_From = new System.Windows.Forms.ComboBox();
            this.cbo_To = new System.Windows.Forms.ComboBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_SearchConnection = new System.Windows.Forms.Button();
            this.btn_ShowStationFrom = new System.Windows.Forms.Button();
            this.btn_ShowStationTo = new System.Windows.Forms.Button();
            this.lbl_SBBFahrplan = new System.Windows.Forms.Label();
            this.dgV_Connections = new System.Windows.Forms.DataGridView();
            this.dgV_column_departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_column_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_column_platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ShowStationTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Connections)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_From
            // 
            this.cbo_From.FormattingEnabled = true;
            this.cbo_From.Location = new System.Drawing.Point(22, 190);
            this.cbo_From.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_From.Name = "cbo_From";
            this.cbo_From.Size = new System.Drawing.Size(372, 33);
            this.cbo_From.TabIndex = 1;
            // 
            // cbo_To
            // 
            this.cbo_To.FormattingEnabled = true;
            this.cbo_To.Location = new System.Drawing.Point(668, 190);
            this.cbo_To.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_To.Name = "cbo_To";
            this.cbo_To.Size = new System.Drawing.Size(372, 33);
            this.cbo_To.TabIndex = 2;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(16, 162);
            this.lbl_From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(50, 25);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "Von";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(662, 162);
            this.lbl_To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(62, 25);
            this.lbl_To.TabIndex = 3;
            this.lbl_To.Text = "Nach";
            // 
            // btn_SearchConnection
            // 
            this.btn_SearchConnection.BackColor = System.Drawing.Color.Red;
            this.btn_SearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_SearchConnection.ForeColor = System.Drawing.Color.White;
            this.btn_SearchConnection.Location = new System.Drawing.Point(668, 233);
            this.btn_SearchConnection.Margin = new System.Windows.Forms.Padding(6);
            this.btn_SearchConnection.Name = "btn_SearchConnection";
            this.btn_SearchConnection.Size = new System.Drawing.Size(372, 69);
            this.btn_SearchConnection.TabIndex = 0;
            this.btn_SearchConnection.TabStop = false;
            this.btn_SearchConnection.Text = "Verbindung suchen -->";
            this.btn_SearchConnection.UseVisualStyleBackColor = false;
            this.btn_SearchConnection.Click += new System.EventHandler(this.btn_searchconnection_Click);
            // 
            // btn_ShowStationFrom
            // 
            this.btn_ShowStationFrom.Location = new System.Drawing.Point(408, 190);
            this.btn_ShowStationFrom.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ShowStationFrom.Name = "btn_ShowStationFrom";
            this.btn_ShowStationFrom.Size = new System.Drawing.Size(98, 40);
            this.btn_ShowStationFrom.TabIndex = 0;
            this.btn_ShowStationFrom.TabStop = false;
            this.btn_ShowStationFrom.Text = "Suche\r\n";
            this.btn_ShowStationFrom.UseVisualStyleBackColor = true;
            this.btn_ShowStationFrom.Click += new System.EventHandler(this.btn_showstationfrom_Click);
            // 
            // btn_ShowStationTo
            // 
            this.btn_ShowStationTo.Location = new System.Drawing.Point(1054, 190);
            this.btn_ShowStationTo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ShowStationTo.Name = "btn_ShowStationTo";
            this.btn_ShowStationTo.Size = new System.Drawing.Size(98, 40);
            this.btn_ShowStationTo.TabIndex = 0;
            this.btn_ShowStationTo.TabStop = false;
            this.btn_ShowStationTo.Text = "Suche\r\n";
            this.btn_ShowStationTo.UseVisualStyleBackColor = true;
            this.btn_ShowStationTo.Click += new System.EventHandler(this.btn_showstationto_Click);
            // 
            // lbl_SBBFahrplan
            // 
            this.lbl_SBBFahrplan.AutoSize = true;
            this.lbl_SBBFahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_SBBFahrplan.Location = new System.Drawing.Point(352, 62);
            this.lbl_SBBFahrplan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_SBBFahrplan.Name = "lbl_SBBFahrplan";
            this.lbl_SBBFahrplan.Size = new System.Drawing.Size(464, 63);
            this.lbl_SBBFahrplan.TabIndex = 11;
            this.lbl_SBBFahrplan.Text = "Der SBB Fahrplan";
            // 
            // dgV_Connections
            // 
            this.dgV_Connections.AllowUserToAddRows = false;
            this.dgV_Connections.AllowUserToDeleteRows = false;
            this.dgV_Connections.AllowUserToOrderColumns = true;
            this.dgV_Connections.AllowUserToResizeColumns = false;
            this.dgV_Connections.AllowUserToResizeRows = false;
            this.dgV_Connections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgV_Connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_Connections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgV_column_departure,
            this.dgV_column_from,
            this.dgV_column_to,
            this.dgV_column_duration,
            this.cbo_column_platform});
            this.dgV_Connections.GridColor = System.Drawing.SystemColors.Control;
            this.dgV_Connections.Location = new System.Drawing.Point(22, 311);
            this.dgV_Connections.Name = "dgV_Connections";
            this.dgV_Connections.ReadOnly = true;
            this.dgV_Connections.RowTemplate.Height = 33;
            this.dgV_Connections.Size = new System.Drawing.Size(1130, 336);
            this.dgV_Connections.TabIndex = 0;
            this.dgV_Connections.TabStop = false;
            this.dgV_Connections.Visible = false;
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
            // btn_ShowStationTable
            // 
            this.btn_ShowStationTable.BackColor = System.Drawing.Color.Maroon;
            this.btn_ShowStationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_ShowStationTable.ForeColor = System.Drawing.Color.White;
            this.btn_ShowStationTable.Location = new System.Drawing.Point(22, 233);
            this.btn_ShowStationTable.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ShowStationTable.Name = "btn_ShowStationTable";
            this.btn_ShowStationTable.Size = new System.Drawing.Size(372, 69);
            this.btn_ShowStationTable.TabIndex = 0;
            this.btn_ShowStationTable.TabStop = false;
            this.btn_ShowStationTable.Text = "Station Table anzeigen -->";
            this.btn_ShowStationTable.UseVisualStyleBackColor = false;
            this.btn_ShowStationTable.Click += new System.EventHandler(this.btn_ShowStationTable_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 659);
            this.Controls.Add(this.btn_ShowStationTable);
            this.Controls.Add(this.dgV_Connections);
            this.Controls.Add(this.lbl_SBBFahrplan);
            this.Controls.Add(this.btn_ShowStationTo);
            this.Controls.Add(this.btn_ShowStationFrom);
            this.Controls.Add(this.btn_SearchConnection);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.cbo_To);
            this.Controls.Add(this.cbo_From);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Connections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_From;
        private System.Windows.Forms.ComboBox cbo_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button btn_SearchConnection;
        private System.Windows.Forms.Button btn_ShowStationFrom;
        private System.Windows.Forms.Button btn_ShowStationTo;
        private System.Windows.Forms.Label lbl_SBBFahrplan;
        private System.Windows.Forms.DataGridView dgV_Connections;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgV_column_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbo_column_platform;
        private System.Windows.Forms.Button btn_ShowStationTable;
    }
}

