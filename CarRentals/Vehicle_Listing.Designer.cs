namespace CarRentals
{
    partial class Vehicle_Listing
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
            this.GV_CarLIst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CarLIst)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_CarLIst
            // 
            this.GV_CarLIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CarLIst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_CarLIst.Location = new System.Drawing.Point(0, 0);
            this.GV_CarLIst.Name = "GV_CarLIst";
            this.GV_CarLIst.RowHeadersWidth = 51;
            this.GV_CarLIst.RowTemplate.Height = 24;
            this.GV_CarLIst.Size = new System.Drawing.Size(800, 450);
            this.GV_CarLIst.TabIndex = 0;
            // 
            // Vehicle_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GV_CarLIst);
            this.Name = "Vehicle_Listing";
            this.Text = "Vehicle_Listing";
            ((System.ComponentModel.ISupportInitialize)(this.GV_CarLIst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_CarLIst;
    }
}