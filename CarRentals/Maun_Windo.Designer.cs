namespace CarRentals
{
    partial class Main_Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehclesListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(452, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehiclesToolStripMenuItem,
            this.mangeRentalsToolStripMenuItem,
            this.aboutDevelopersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehclesListingToolStripMenuItem,
            this.addRemoveVehiclesToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            // 
            // vehclesListingToolStripMenuItem
            // 
            this.vehclesListingToolStripMenuItem.Name = "vehclesListingToolStripMenuItem";
            this.vehclesListingToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.vehclesListingToolStripMenuItem.Text = " Vehicles Listing";
            // 
            // addRemoveVehiclesToolStripMenuItem
            // 
            this.addRemoveVehiclesToolStripMenuItem.Name = "addRemoveVehiclesToolStripMenuItem";
            this.addRemoveVehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.addRemoveVehiclesToolStripMenuItem.Text = "Add/Remove Vehicles";
            // 
            // mangeRentalsToolStripMenuItem
            // 
            this.mangeRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rrentalRecordsToolStripMenuItem});
            this.mangeRentalsToolStripMenuItem.Name = "mangeRentalsToolStripMenuItem";
            this.mangeRentalsToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.mangeRentalsToolStripMenuItem.Text = "Mange Rentals";
            // 
            // rrentalRecordsToolStripMenuItem
            // 
            this.rrentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.rrentalRecordsToolStripMenuItem.Name = "rrentalRecordsToolStripMenuItem";
            this.rrentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.rrentalRecordsToolStripMenuItem.Text = "Rrental Records";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // aboutDevelopersToolStripMenuItem
            // 
            this.aboutDevelopersToolStripMenuItem.Name = "aboutDevelopersToolStripMenuItem";
            this.aboutDevelopersToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.aboutDevelopersToolStripMenuItem.Text = "About Developers";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Maun_Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehclesListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rrentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
    }
}