namespace user_interface
{
    partial class FormFahrplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFahrplan));
            this.cbo_from = new System.Windows.Forms.ComboBox();
            this.cbo_to = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.dtP_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_from
            // 
            this.cbo_from.FormattingEnabled = true;
            this.cbo_from.Location = new System.Drawing.Point(151, 130);
            this.cbo_from.Name = "cbo_from";
            this.cbo_from.Size = new System.Drawing.Size(372, 33);
            this.cbo_from.TabIndex = 0;
            // 
            // cbo_to
            // 
            this.cbo_to.FormattingEnabled = true;
            this.cbo_to.Location = new System.Drawing.Point(798, 130);
            this.cbo_to.Name = "cbo_to";
            this.cbo_to.Size = new System.Drawing.Size(372, 33);
            this.cbo_to.TabIndex = 1;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(146, 102);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(50, 25);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "Von";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(793, 102);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(62, 25);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "Nach";
            // 
            // dtP_date
            // 
            this.dtP_date.Location = new System.Drawing.Point(151, 246);
            this.dtP_date.Name = "dtP_date";
            this.dtP_date.Size = new System.Drawing.Size(372, 31);
            this.dtP_date.TabIndex = 4;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(146, 218);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(74, 25);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Datum";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(558, 218);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(48, 25);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Zeit";
            // 
            // FormFahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2828, 1124);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dtP_date);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.cbo_to);
            this.Controls.Add(this.cbo_from);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFahrplan";
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_from;
        private System.Windows.Forms.ComboBox cbo_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.DateTimePicker dtP_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
    }
}

