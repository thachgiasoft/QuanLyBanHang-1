﻿namespace QuanLyBanHang.GUI.Common
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiClock = new DevExpress.XtraBars.BarStaticItem();
            this.bsiNhanVien = new DevExpress.XtraBars.BarStaticItem();
            this.frmPersonnel_List = new DevExpress.XtraBars.BarButtonItem();
            this.frmAccount_List = new DevExpress.XtraBars.BarButtonItem();
            this.bsiPCName = new DevExpress.XtraBars.BarStaticItem();
            this.bsiComputerName = new DevExpress.XtraBars.BarStaticItem();
            this.bsiDatabaseName = new DevExpress.XtraBars.BarStaticItem();
            this.frmPermission = new DevExpress.XtraBars.BarButtonItem();
            this.bsiDBName = new DevExpress.XtraBars.BarStaticItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSkin = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbiInfomation = new DevExpress.XtraBars.BarButtonItem();
            this.rbpAccount = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgStaff = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpConfig = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgSkin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dlafSkin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.docManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tbvMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMdiChildButtons = false;
            this.ribbon.ApplicationCaption = "Quản lý bán hàng";
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bsiClock,
            this.bsiNhanVien,
            this.frmPersonnel_List,
            this.frmAccount_List,
            this.bsiPCName,
            this.bsiComputerName,
            this.bsiDatabaseName,
            this.frmPermission,
            this.bsiDBName,
            this.bbiChangePassword,
            this.bbiSkin,
            this.bbiInfomation});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 218;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.bsiNhanVien);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpAccount,
            this.rbpConfig});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1008, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bsiClock
            // 
            this.bsiClock.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiClock.Id = 22;
            this.bsiClock.Name = "bsiClock";
            this.bsiClock.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiNhanVien
            // 
            this.bsiNhanVien.Caption = "Tên nhân viên";
            this.bsiNhanVien.Id = 75;
            this.bsiNhanVien.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bsiNhanVien.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bsiNhanVien.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiNhanVien.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiNhanVien.Name = "bsiNhanVien";
            this.bsiNhanVien.TextAlignment = System.Drawing.StringAlignment.Near;
            this.bsiNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bsiNhanVien_ItemClick);
            // 
            // frmPersonnel_List
            // 
            this.frmPersonnel_List.Caption = "Nhân viên";
            this.frmPersonnel_List.Id = 111;
            this.frmPersonnel_List.ImageOptions.LargeImage = global::QuanLyBanHang.Properties.Resources.BOResume_32x32;
            this.frmPersonnel_List.Name = "frmPersonnel_List";
            // 
            // frmAccount_List
            // 
            this.frmAccount_List.Caption = "Tài khoản";
            this.frmAccount_List.Id = 112;
            this.frmAccount_List.ImageOptions.LargeImage = global::QuanLyBanHang.Properties.Resources.BOUser_32x32;
            this.frmAccount_List.Name = "frmAccount_List";
            // 
            // bsiPCName
            // 
            this.bsiPCName.Id = 115;
            this.bsiPCName.Name = "bsiPCName";
            this.bsiPCName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiComputerName
            // 
            this.bsiComputerName.Caption = "Tên máy:";
            this.bsiComputerName.Id = 117;
            this.bsiComputerName.Name = "bsiComputerName";
            this.bsiComputerName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiDatabaseName
            // 
            this.bsiDatabaseName.Caption = "Cơ sở dữ liệu:";
            this.bsiDatabaseName.Id = 119;
            this.bsiDatabaseName.Name = "bsiDatabaseName";
            this.bsiDatabaseName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // frmPermission
            // 
            this.frmPermission.Caption = "Phân quyền";
            this.frmPermission.Id = 120;
            this.frmPermission.ImageOptions.LargeImage = global::QuanLyBanHang.Properties.Resources.CheckButtons_32x32;
            this.frmPermission.Name = "frmPermission";
            // 
            // bsiDBName
            // 
            this.bsiDBName.Id = 129;
            this.bsiDBName.Name = "bsiDBName";
            this.bsiDBName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiChangePassword
            // 
            this.bbiChangePassword.Caption = "Đổi mật khẩu";
            this.bbiChangePassword.Id = 136;
            this.bbiChangePassword.ImageOptions.LargeImage = global::QuanLyBanHang.Properties.Resources.BOPermission_32x32;
            this.bbiChangePassword.Name = "bbiChangePassword";
            this.bbiChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePassword_ItemClick);
            // 
            // bbiSkin
            // 
            this.bbiSkin.Id = 215;
            this.bbiSkin.Name = "bbiSkin";
            // 
            // bbiInfomation
            // 
            this.bbiInfomation.Caption = "Thông tin chung";
            this.bbiInfomation.Id = 216;
            this.bbiInfomation.ImageOptions.LargeImage = global::QuanLyBanHang.Properties.Resources.information;
            this.bbiInfomation.Name = "bbiInfomation";
            this.bbiInfomation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInfomation_ItemClick);
            // 
            // rbpAccount
            // 
            this.rbpAccount.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgStaff});
            this.rbpAccount.Name = "rbpAccount";
            this.rbpAccount.Text = "Tài khoản";
            // 
            // rbgStaff
            // 
            this.rbgStaff.ItemLinks.Add(this.frmPersonnel_List);
            this.rbgStaff.ItemLinks.Add(this.frmAccount_List);
            this.rbgStaff.ItemLinks.Add(this.frmPermission);
            this.rbgStaff.ItemLinks.Add(this.bbiChangePassword);
            this.rbgStaff.Name = "rbgStaff";
            this.rbgStaff.Text = "Nhân viên";
            // 
            // rbpConfig
            // 
            this.rbpConfig.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgSkin});
            this.rbpConfig.Name = "rbpConfig";
            this.rbpConfig.Text = "Thiết lập";
            // 
            // rbgSkin
            // 
            this.rbgSkin.ItemLinks.Add(this.bbiInfomation);
            this.rbgSkin.ItemLinks.Add(this.bbiSkin);
            this.rbgSkin.Name = "rbgSkin";
            this.rbgSkin.Text = "Mặc định";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiClock);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiComputerName);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiPCName);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiDatabaseName, true);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiDBName);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 417);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1008, 32);
            // 
            // dlafSkin
            // 
            this.dlafSkin.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // docManager
            // 
            this.docManager.MdiParent = this;
            this.docManager.MenuManager = this.ribbon;
            this.docManager.View = this.tbvMain;
            this.docManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tbvMain});
            // 
            // tbvMain
            // 
            this.tbvMain.RootContainer.Element = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlafSkin;
        private DevExpress.XtraBars.Docking2010.DocumentManager docManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tbvMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpAccount;
        private DevExpress.XtraBars.BarStaticItem bsiClock;
        private DevExpress.XtraBars.BarStaticItem bsiNhanVien;
        private DevExpress.XtraBars.BarButtonItem frmPersonnel_List;
        private DevExpress.XtraBars.BarButtonItem frmAccount_List;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgStaff;
        private DevExpress.XtraBars.BarStaticItem bsiPCName;
        private DevExpress.XtraBars.BarStaticItem bsiComputerName;
        private DevExpress.XtraBars.BarStaticItem bsiDatabaseName;
        private DevExpress.XtraBars.BarButtonItem frmPermission;
        private DevExpress.XtraBars.BarStaticItem bsiDBName;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem bbiSkin;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpConfig;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgSkin;
        private DevExpress.XtraBars.BarButtonItem bbiInfomation;
       
    }
}