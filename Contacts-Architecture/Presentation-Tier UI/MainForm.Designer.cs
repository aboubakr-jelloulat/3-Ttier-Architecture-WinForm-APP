namespace Presentation_Tier_UI
{
    partial class MainForm
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
            this.dvgAllContacts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAllContacts
            // 
            this.dvgAllContacts.AllowUserToAddRows = false;
            this.dvgAllContacts.AllowUserToDeleteRows = false;
            this.dvgAllContacts.AllowUserToOrderColumns = true;
            this.dvgAllContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAllContacts.Location = new System.Drawing.Point(0, 147);
            this.dvgAllContacts.Name = "dvgAllContacts";
            this.dvgAllContacts.ReadOnly = true;
            this.dvgAllContacts.RowHeadersWidth = 51;
            this.dvgAllContacts.RowTemplate.Height = 24;
            this.dvgAllContacts.Size = new System.Drawing.Size(1106, 494);
            this.dvgAllContacts.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 636);
            this.Controls.Add(this.dvgAllContacts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAllContacts;
    }
}