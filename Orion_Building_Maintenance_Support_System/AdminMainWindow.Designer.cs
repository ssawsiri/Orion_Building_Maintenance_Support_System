
namespace Orion_Building_Maintenance_Support_System
{
    partial class AdminMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFoodCourtSales = new System.Windows.Forms.Button();
            this.btnSvcAgreement = new System.Windows.Forms.Button();
            this.btnMainPlan = new System.Windows.Forms.Button();
            this.btnPPM = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnTechnicalDrawings = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnFoodCourtSales);
            this.panel1.Controls.Add(this.btnSvcAgreement);
            this.panel1.Controls.Add(this.btnMainPlan);
            this.panel1.Controls.Add(this.btnPPM);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnTechnicalDrawings);
            this.panel1.Controls.Add(this.btnCreateUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 60);
            this.panel3.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTitle.Controls.Add(this.panelDropDown);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(808, 60);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown.Controls.Add(this.lblUsername);
            this.panelDropDown.Controls.Add(this.btnChangePassword);
            this.panelDropDown.Controls.Add(this.btnLogOut);
            this.panelDropDown.Controls.Add(this.btnUser);
            this.panelDropDown.Location = new System.Drawing.Point(552, 0);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(172, 143);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(172, 60);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(172, 60);
            this.panelDropDown.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(127, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(0, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(145)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(3, 106);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(169, 32);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(145)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(3, 69);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(169, 32);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(808, 501);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(130, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(42, 60);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(726, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 60);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(769, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFoodCourtSales
            // 
            this.btnFoodCourtSales.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodCourtSales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFoodCourtSales.FlatAppearance.BorderSize = 0;
            this.btnFoodCourtSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFoodCourtSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodCourtSales.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodCourtSales.ForeColor = System.Drawing.Color.Black;
            this.btnFoodCourtSales.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodCourtSales.Image")));
            this.btnFoodCourtSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodCourtSales.Location = new System.Drawing.Point(0, 397);
            this.btnFoodCourtSales.Name = "btnFoodCourtSales";
            this.btnFoodCourtSales.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnFoodCourtSales.Size = new System.Drawing.Size(200, 50);
            this.btnFoodCourtSales.TabIndex = 10;
            this.btnFoodCourtSales.Text = "        Food Court Sales";
            this.btnFoodCourtSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodCourtSales.UseVisualStyleBackColor = false;
            this.btnFoodCourtSales.Click += new System.EventHandler(this.btnFoodCourtSales_Click);
            // 
            // btnSvcAgreement
            // 
            this.btnSvcAgreement.BackColor = System.Drawing.Color.Transparent;
            this.btnSvcAgreement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSvcAgreement.FlatAppearance.BorderSize = 0;
            this.btnSvcAgreement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSvcAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcAgreement.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSvcAgreement.ForeColor = System.Drawing.Color.Black;
            this.btnSvcAgreement.Image = ((System.Drawing.Image)(resources.GetObject("btnSvcAgreement.Image")));
            this.btnSvcAgreement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSvcAgreement.Location = new System.Drawing.Point(0, 341);
            this.btnSvcAgreement.Name = "btnSvcAgreement";
            this.btnSvcAgreement.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnSvcAgreement.Size = new System.Drawing.Size(200, 50);
            this.btnSvcAgreement.TabIndex = 9;
            this.btnSvcAgreement.Text = "        Svc. Agreement";
            this.btnSvcAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSvcAgreement.UseVisualStyleBackColor = false;
            this.btnSvcAgreement.Click += new System.EventHandler(this.btnSvcAgreement_Click);
            // 
            // btnMainPlan
            // 
            this.btnMainPlan.BackColor = System.Drawing.Color.Transparent;
            this.btnMainPlan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMainPlan.FlatAppearance.BorderSize = 0;
            this.btnMainPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPlan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPlan.ForeColor = System.Drawing.Color.Black;
            this.btnMainPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnMainPlan.Image")));
            this.btnMainPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPlan.Location = new System.Drawing.Point(0, 285);
            this.btnMainPlan.Name = "btnMainPlan";
            this.btnMainPlan.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnMainPlan.Size = new System.Drawing.Size(200, 50);
            this.btnMainPlan.TabIndex = 8;
            this.btnMainPlan.Text = "        Main. Plan";
            this.btnMainPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPlan.UseVisualStyleBackColor = false;
            this.btnMainPlan.Click += new System.EventHandler(this.btnMainPlan_Click);
            // 
            // btnPPM
            // 
            this.btnPPM.BackColor = System.Drawing.Color.Transparent;
            this.btnPPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPPM.FlatAppearance.BorderSize = 0;
            this.btnPPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPPM.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPM.ForeColor = System.Drawing.Color.Black;
            this.btnPPM.Image = ((System.Drawing.Image)(resources.GetObject("btnPPM.Image")));
            this.btnPPM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPM.Location = new System.Drawing.Point(0, 229);
            this.btnPPM.Name = "btnPPM";
            this.btnPPM.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnPPM.Size = new System.Drawing.Size(200, 50);
            this.btnPPM.TabIndex = 7;
            this.btnPPM.Text = "        PPM";
            this.btnPPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPPM.UseVisualStyleBackColor = false;
            this.btnPPM.Click += new System.EventHandler(this.btnPPM_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 173);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnInventory.Size = new System.Drawing.Size(200, 50);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "        Inventories";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnTechnicalDrawings
            // 
            this.btnTechnicalDrawings.BackColor = System.Drawing.Color.Transparent;
            this.btnTechnicalDrawings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTechnicalDrawings.FlatAppearance.BorderSize = 0;
            this.btnTechnicalDrawings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTechnicalDrawings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicalDrawings.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicalDrawings.ForeColor = System.Drawing.Color.Black;
            this.btnTechnicalDrawings.Image = ((System.Drawing.Image)(resources.GetObject("btnTechnicalDrawings.Image")));
            this.btnTechnicalDrawings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTechnicalDrawings.Location = new System.Drawing.Point(0, 117);
            this.btnTechnicalDrawings.Name = "btnTechnicalDrawings";
            this.btnTechnicalDrawings.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnTechnicalDrawings.Size = new System.Drawing.Size(200, 50);
            this.btnTechnicalDrawings.TabIndex = 5;
            this.btnTechnicalDrawings.Text = "        Technical Draw";
            this.btnTechnicalDrawings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTechnicalDrawings.UseVisualStyleBackColor = false;
            this.btnTechnicalDrawings.Click += new System.EventHandler(this.btnTechnicalDrawings_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateUser.Image")));
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.Location = new System.Drawing.Point(0, 61);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnCreateUser.Size = new System.Drawing.Size(200, 50);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "        Create User";
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminMainWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.AdminMainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnPPM;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTechnicalDrawings;
        private System.Windows.Forms.Button btnMainPlan;
        private System.Windows.Forms.Button btnSvcAgreement;
        private System.Windows.Forms.Button btnFoodCourtSales;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUsername;
    }
}