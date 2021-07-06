
namespace garantiTakip
{
    partial class MDIParent1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verilenHizmetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetTürüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiVeHizmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sektörlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sektörListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sektörEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sektörDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYetkiliRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonAcılanlar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.hizmetToolStripMenuItem,
            this.garantiVeHizmetToolStripMenuItem,
            this.sektörlerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.sonAcılanlar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1220, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(49, 24);
            this.fileMenu.Text = "Cari";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.openToolStripMenuItem.Text = "Yeni Cari Ekle";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveToolStripMenuItem.Text = "Cari Düzenle";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveAsToolStripMenuItem.Text = "Cari Sil";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "Ç&ıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(67, 24);
            this.viewMenu.Text = "Arama";
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // hizmetToolStripMenuItem
            // 
            this.hizmetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verilenHizmetlerToolStripMenuItem,
            this.hizmetTürüEkleToolStripMenuItem,
            this.hizmetToolStripMenuItem1});
            this.hizmetToolStripMenuItem.Name = "hizmetToolStripMenuItem";
            this.hizmetToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hizmetToolStripMenuItem.Text = "Hizmetler";
            // 
            // verilenHizmetlerToolStripMenuItem
            // 
            this.verilenHizmetlerToolStripMenuItem.Name = "verilenHizmetlerToolStripMenuItem";
            this.verilenHizmetlerToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.verilenHizmetlerToolStripMenuItem.Text = "Verilen Hizmetler";
            // 
            // hizmetTürüEkleToolStripMenuItem
            // 
            this.hizmetTürüEkleToolStripMenuItem.Name = "hizmetTürüEkleToolStripMenuItem";
            this.hizmetTürüEkleToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.hizmetTürüEkleToolStripMenuItem.Text = "Hizmet Ekle";
            // 
            // hizmetToolStripMenuItem1
            // 
            this.hizmetToolStripMenuItem1.Name = "hizmetToolStripMenuItem1";
            this.hizmetToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.hizmetToolStripMenuItem1.Text = "Hizmet Düzenle";
            // 
            // garantiVeHizmetToolStripMenuItem
            // 
            this.garantiVeHizmetToolStripMenuItem.Name = "garantiVeHizmetToolStripMenuItem";
            this.garantiVeHizmetToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.garantiVeHizmetToolStripMenuItem.Text = "Garanti ve Hizmet";
            this.garantiVeHizmetToolStripMenuItem.Click += new System.EventHandler(this.garantiVeHizmetToolStripMenuItem_Click);
            // 
            // sektörlerToolStripMenuItem
            // 
            this.sektörlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sektörListesiToolStripMenuItem,
            this.sektörEkleToolStripMenuItem,
            this.sektörDüzenleToolStripMenuItem});
            this.sektörlerToolStripMenuItem.Name = "sektörlerToolStripMenuItem";
            this.sektörlerToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.sektörlerToolStripMenuItem.Text = "Sektörler";
            // 
            // sektörListesiToolStripMenuItem
            // 
            this.sektörListesiToolStripMenuItem.Name = "sektörListesiToolStripMenuItem";
            this.sektörListesiToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.sektörListesiToolStripMenuItem.Text = "Sektör Listesi";
            // 
            // sektörEkleToolStripMenuItem
            // 
            this.sektörEkleToolStripMenuItem.Name = "sektörEkleToolStripMenuItem";
            this.sektörEkleToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.sektörEkleToolStripMenuItem.Text = "Sektör Ekle";
            // 
            // sektörDüzenleToolStripMenuItem
            // 
            this.sektörDüzenleToolStripMenuItem.Name = "sektörDüzenleToolStripMenuItem";
            this.sektörDüzenleToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.sektörDüzenleToolStripMenuItem.Text = "Sektör Düzenle";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariRaporlarıToolStripMenuItem,
            this.müşteriYetkiliRaporlarıToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // cariRaporlarıToolStripMenuItem
            // 
            this.cariRaporlarıToolStripMenuItem.Name = "cariRaporlarıToolStripMenuItem";
            this.cariRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.cariRaporlarıToolStripMenuItem.Text = "Cari  Raporları";
            this.cariRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.cariRaporlarıToolStripMenuItem_Click);
            // 
            // müşteriYetkiliRaporlarıToolStripMenuItem
            // 
            this.müşteriYetkiliRaporlarıToolStripMenuItem.Name = "müşteriYetkiliRaporlarıToolStripMenuItem";
            this.müşteriYetkiliRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.müşteriYetkiliRaporlarıToolStripMenuItem.Text = "Müşteri/ Yetkili  Raporları";
            this.müşteriYetkiliRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.müşteriYetkiliRaporlarıToolStripMenuItem_Click);
            // 
            // sonAcılanlar
            // 
            this.sonAcılanlar.Name = "sonAcılanlar";
            this.sonAcılanlar.Size = new System.Drawing.Size(110, 24);
            this.sonAcılanlar.Text = "Son Açılanlar";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 559);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(1220, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Durum";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripSeparator7});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(14, 24);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 585);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hizmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verilenHizmetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetTürüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem garantiVeHizmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sektörlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sektörListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sektörEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sektörDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonAcılanlar;
        private System.Windows.Forms.ToolStripMenuItem cariRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriYetkiliRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}



