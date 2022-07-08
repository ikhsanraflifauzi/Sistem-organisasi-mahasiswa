
namespace UAS
{
    partial class Dashborad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashborad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtUser = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapatKoordinasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaRapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanRapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasilRapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.rapatToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtUser,
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // dtUser
            // 
            this.dtUser.Name = "dtUser";
            this.dtUser.Size = new System.Drawing.Size(124, 22);
            this.dtUser.Text = "Data User";
            this.dtUser.Click += new System.EventHandler(this.dtUser_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // rapatToolStripMenuItem
            // 
            this.rapatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapatKoordinasiToolStripMenuItem,
            this.agendaRapatToolStripMenuItem});
            this.rapatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rapatToolStripMenuItem.Name = "rapatToolStripMenuItem";
            this.rapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.rapatToolStripMenuItem.Text = "Rapat";
            // 
            // rapatKoordinasiToolStripMenuItem
            // 
            this.rapatKoordinasiToolStripMenuItem.Name = "rapatKoordinasiToolStripMenuItem";
            this.rapatKoordinasiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rapatKoordinasiToolStripMenuItem.Text = "Program Kerja";
            this.rapatKoordinasiToolStripMenuItem.Click += new System.EventHandler(this.rapatKoordinasiToolStripMenuItem_Click);
            // 
            // agendaRapatToolStripMenuItem
            // 
            this.agendaRapatToolStripMenuItem.Name = "agendaRapatToolStripMenuItem";
            this.agendaRapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaRapatToolStripMenuItem.Text = "Agenda rapat";
            this.agendaRapatToolStripMenuItem.Click += new System.EventHandler(this.agendaRapatToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanRapatToolStripMenuItem,
            this.hasilRapatToolStripMenuItem});
            this.laporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // laporanRapatToolStripMenuItem
            // 
            this.laporanRapatToolStripMenuItem.Name = "laporanRapatToolStripMenuItem";
            this.laporanRapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.laporanRapatToolStripMenuItem.Text = "Laporan Rapat";
            this.laporanRapatToolStripMenuItem.Click += new System.EventHandler(this.laporanRapatToolStripMenuItem_Click);
            // 
            // hasilRapatToolStripMenuItem
            // 
            this.hasilRapatToolStripMenuItem.Name = "hasilRapatToolStripMenuItem";
            this.hasilRapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hasilRapatToolStripMenuItem.Text = "hasil Rapat";
            this.hasilRapatToolStripMenuItem.Click += new System.EventHandler(this.hasilRapatToolStripMenuItem_Click);
            // 
            // Dashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 404);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashborad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Text = "Sisdator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashborad_FormClosed);
            this.Load += new System.EventHandler(this.Dashborad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapatKoordinasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaRapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dtUser;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanRapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasilRapatToolStripMenuItem;
    }
}