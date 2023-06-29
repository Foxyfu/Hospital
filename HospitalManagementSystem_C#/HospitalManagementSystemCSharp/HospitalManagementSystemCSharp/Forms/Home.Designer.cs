namespace HospitalManagementSystemCSharp
{
    partial class Home
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDeveloperToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1422, 28);
            this.menuStrip3.TabIndex = 168;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.aboutDeveloperToolStripMenuItem.Text = "О разработчике";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.closeApplicationToolStripMenuItem.Text = "Закрыть";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::HospitalManagementSystemCSharp.Properties.Resources._1674613473_top_fon_com_p_prezentatsiya_dlya_medikov_fon_6;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientRegistrationToolStripMenuItem,
            this.patientInformationToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.roomInfoToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.viewCheckoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 833);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientRegistrationToolStripMenuItem
            // 
            this.patientRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRegistrationToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources.health_chart_patient_chart_report_icon_143438__1_;
            this.patientRegistrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientRegistrationToolStripMenuItem.Name = "patientRegistrationToolStripMenuItem";
            this.patientRegistrationToolStripMenuItem.Size = new System.Drawing.Size(263, 829);
            this.patientRegistrationToolStripMenuItem.Text = "Регистрация пациентов";
            this.patientRegistrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientRegistrationToolStripMenuItem.Click += new System.EventHandler(this.patientRegistrationToolStripMenuItem_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources.medical_illness_healthcare_sickness_pacient_temperature_icon_144695__1_;
            this.patientInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(248, 829);
            this.patientInformationToolStripMenuItem.Text = "Информация пациента";
            this.patientInformationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources.Help_43559;
            this.checkoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(142, 829);
            this.checkoutToolStripMenuItem.Text = "Выписка";
            this.checkoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // roomInfoToolStripMenuItem
            // 
            this.roomInfoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources._1jpg_transformed__1_;
            this.roomInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.roomInfoToolStripMenuItem.Name = "roomInfoToolStripMenuItem";
            this.roomInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 829);
            this.roomInfoToolStripMenuItem.Text = "Инф. о номере";
            this.roomInfoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomInfoToolStripMenuItem.Click += new System.EventHandler(this.roomInfoToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources.medical_medicine_doctor_hospital_icon_143393;
            this.addStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(220, 829);
            this.addStaffToolStripMenuItem.Text = "Добавить персонал";
            this.addStaffToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // viewCheckoutToolStripMenuItem
            // 
            this.viewCheckoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCheckoutToolStripMenuItem.Image = global::HospitalManagementSystemCSharp.Properties.Resources.payment_icon_194171;
            this.viewCheckoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewCheckoutToolStripMenuItem.Name = "viewCheckoutToolStripMenuItem";
            this.viewCheckoutToolStripMenuItem.Size = new System.Drawing.Size(322, 829);
            this.viewCheckoutToolStripMenuItem.Text = "Просмотр оформления заказа";
            this.viewCheckoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewCheckoutToolStripMenuItem.Click += new System.EventHandler(this.viewCheckoutToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 833);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home-HMS";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCheckoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
    }
}