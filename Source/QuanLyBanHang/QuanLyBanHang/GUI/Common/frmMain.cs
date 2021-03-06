﻿using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using EntityModel.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI.Common
{
    public partial class frmMain : RibbonForm
    {
        // Timer tmClock;
        public frmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(bbiSkin);
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default["SkinName"].ToString();
        }

        /// <summary>
        /// Hàm dùng chung, dùng để load form vào DocumentManager khi bấm vào menu trên ribbon menu
        /// </summary>
        /// <param name="_xtrForm"></param>
        private void addDocument(DevExpress.XtraEditors.XtraForm _xtrForm)
        {
            if (_xtrForm == null) return;
            BaseDocument document = docManager.GetDocument(_xtrForm);
            if (document != null)
                tbvMain.Controller.Activate(document);
            else
            {
                _xtrForm.Text = _xtrForm.Text.Translation(_xtrForm.Name.Replace("_", ""), _xtrForm.Name);
                _xtrForm.FormClosing += _xtrForm_FormClosing;
                _xtrForm.MdiParent = this;
                _xtrForm.Show();
            }
        }

        private void _xtrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.XtraForm cForm = (DevExpress.XtraEditors.XtraForm)sender;

                foreach (var c in cForm.Controls)
                {
                    if (c is DevExpress.XtraBars.Docking.DockPanel)
                    {
                        DevExpress.XtraBars.Docking.DockPanel dp = c as DevExpress.XtraBars.Docking.DockPanel;
                        foreach (var c1 in dp.Controls)
                        {
                            if (c1 is DevExpress.XtraBars.Docking.ControlContainer)
                            {
                                DevExpress.XtraBars.Docking.ControlContainer cc = (DevExpress.XtraBars.Docking.ControlContainer)c1;
                                foreach (var c2 in cc.Controls)
                                {
                                    if (c2 is DevExpress.XtraLayout.LayoutControl)
                                    {
                                        DevExpress.XtraLayout.LayoutControl lc = (DevExpress.XtraLayout.LayoutControl)c2;
                                        foreach (var c3 in lc.Controls)
                                        {
                                            if (c3 is DevExpress.XtraGrid.GridControl)
                                            {
                                                DevExpress.XtraGrid.GridControl gct = (DevExpress.XtraGrid.GridControl)c3;
                                                foreach (DevExpress.XtraGrid.Views.Grid.GridView grv in gct.ViewCollection)
                                                {
                                                    grv.ActiveFilter.Clear();
                                                    grv.SaveLayout(cForm.Name);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (c is DevExpress.XtraLayout.LayoutControl)
                    {
                        DevExpress.XtraLayout.LayoutControl lc = (DevExpress.XtraLayout.LayoutControl)c;
                        foreach (var c1 in lc.Controls)
                        {
                            if (c1 is DevExpress.XtraGrid.GridControl)
                            {
                                DevExpress.XtraGrid.GridControl gct = (DevExpress.XtraGrid.GridControl)c1;
                                foreach (DevExpress.XtraGrid.Views.Grid.GridView grv in gct.ViewCollection)
                                {
                                    grv.ActiveFilter.Clear();
                                    grv.SaveLayout(cForm.Name);
                                }
                            }
                            if (c1 is DevExpress.XtraTreeList.TreeList)
                            {
                                //((DevExpress.XtraTreeList.TreeList)c).SaveLayout();
                            }
                        }

                    }
                }
                cForm.Dispose();
            }
            catch { }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadDataForm();
        }

        private void loadDataForm()
        {
            ribbon.Hide(); ribbonStatusBar.Hide();

            if (checkConnection())
            {
                clsGeneral.CallWaitForm(this);
                string _sName, _sDatabase, _sUser, _sPass;
                bool _wAu;
                _wAu = Properties.Settings.Default.sWinAu;
                _sName = clsGeneral.Decrypt(Properties.Settings.Default.sServerName);
                _sDatabase = clsGeneral.Decrypt(Properties.Settings.Default.sDBName);
                _sUser = clsGeneral.Decrypt(Properties.Settings.Default.sUserName);
                _sPass = clsGeneral.Decrypt(Properties.Settings.Default.sPassword);

                string _conString = "";
                if (!_wAu)
                    _conString = "data source={0};initial catalog={1};Integrated Security={2};user id={3};password={4};MultipleActiveResultSets=True;App=EntityFramework";
                else
                    _conString = "data source={0};initial catalog={1};Integrated Security={2};MultipleActiveResultSets=True;App=EntityFramework";
                EntityModel.Module.dbConnectString = string.Format(_conString, _sName, _sDatabase, _wAu, _sUser, _sPass);

                try
                {
                    EntityModel.Module.InitDefaultData();
                    clsEntity.InitCollection();
                }
                catch (Exception ex)
                {
                    clsGeneral.CloseWaitForm();
                    clsGeneral.showErrorException(ex, "Exception");
                    Application.Exit();
                }
                clsGeneral.CloseWaitForm();

                if (clsGeneral.curPersonnel.KeyID == 0)
                {
                    frmLogin _frm = new frmLogin();
                    if (_frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel || clsGeneral.curPersonnel == null)
                        Application.Exit();
                    else
                    {
                        if (Properties.Settings.Default.CurrentCulture.Equals("VN"))
                        {
                            System.Globalization.CultureInfo enCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                            System.Threading.Thread.CurrentThread.CurrentCulture = System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN");
                            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat = enCulture.NumberFormat;
                        }
                        clsGeneral.CallWaitForm(this);
                        if (clsEntity.LoadResources())
                        {
                            clsCallForm.InitFormCollection();
                            //tmClock = new Timer();
                            //tmClock.Interval = 1000;
                            //tmClock.Tick += tmClock_Tick;
                            //tmClock.Start();
                            bsiComputerName.Caption = "PC: " + Properties.Settings.Default.ComputerName;
                            bsiDatabaseName.Caption = "Cơ sở dữ liệu: " + _sDatabase;
                            bsiNhanVien.Caption = clsGeneral.curPersonnel.FullName;
                            bsiClock.Caption = "Công ty phần mềm Tin Tấn © 2017";
                            addItemClick();
                            ribbon.Show();
                            ribbonStatusBar.Show();
                            clsGeneral.CloseWaitForm();
                        }
                        else
                            Application.Exit();
                    }
                }
            }
        }

        private bool checkConnection()
        {
            bool bRe = false;
            string _sName, _sDatabase, _sUser, _sPass;
            bool _wAu;
            _wAu = Properties.Settings.Default.sWinAu;
            _sName = clsGeneral.Decrypt(Properties.Settings.Default.sServerName);
            _sDatabase = clsGeneral.Decrypt(Properties.Settings.Default.sDBName);
            _sUser = clsGeneral.Decrypt(Properties.Settings.Default.sUserName);
            _sPass = clsGeneral.Decrypt(Properties.Settings.Default.sPassword);
            using (frmSetting _frm = new frmSetting())
            {
                if (!_frm.checkConnection(_sName, _wAu, _sUser, _sPass))
                    if (_frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        Application.Exit();
                    else
                        bRe = true;
                else
                    bRe = true;
            }
            return bRe;
        }

        private void tmClock_Tick(object sender, EventArgs e)
        {
            bsiNhanVien.Caption = clsGeneral.curPersonnel.FullName;
            //bsiClock.Caption = DateTime.Now.ToString(Properties.Settings.Default.DateFormat + " hh:mm:ss tt");
        }

        private void addItemClick()
        {
            // Duyệt từng page trong ribbon
            foreach (RibbonPage page in ribbon.Pages)
            {
                page.Visible = false;
                page.Text = clsEntity.get_Caption(page.Name, ribbon.Name, page.Text);
                try
                {
                    foreach (RibbonPageGroup group in page.Groups)
                    {
                        group.Visible = false;
                        group.Text = clsEntity.get_Caption(group.Name, page.Name, group.Text);
                        foreach (var item in group.ItemLinks)
                        {
                            if (item is BarButtonItemLink)
                            {
                                BarButtonItemLink bbi = item as BarButtonItemLink;
                                bbi.Item.Caption = clsEntity.get_Caption(bbi.Item.Name, group.Name, bbi.Item.Caption);
                                bbi.Visible = clsEntity.Check_Role(clsGeneral.curPersonnel.eAccount, bbi.Item.Name);
                                if (bbi.Visible && bbi.Item.Name.StartsWith("frm"))
                                {
                                    bbi.Item.ItemClick += bt_ItemClick;
                                    page.Visible = group.Visible = true;
                                }
                                if (bbi.Visible)
                                    page.Visible = group.Visible = true;
                            }

                            if (item is BarEditItemLink)
                            {
                                BarEditItemLink bei = item as BarEditItemLink;
                                bei.Item.Caption = clsEntity.get_Caption(bei.Item.Name, group.Name, bei.Item.Caption);
                                bei.Visible = page.Visible = group.Visible = true;
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void bt_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsGeneral.CallWaitForm(this);
            try
            {
                addDocument(clsCallForm.CreateNewForm(e.Item.Name));
            }
            catch { }
            clsGeneral.CloseWaitForm();
        }

        private void bsiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (clsGeneral.showConfirmMessage("Xác nhận đăng xuất khỏi hệ thống".Translation("msgLogout", this.Name)))
            {
                docManager.View.Controller.CloseAll();
                this.Dispose();
                Application.Restart();
            }
        }

        private void bbiChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmChangePassword _frm = new frmChangePassword())
            {
                _frm.ShowDialog();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["SkinName"] = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
        }

        private void bbiInfomation_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmInfomation _frm = new frmInfomation())
            {
                _frm.ShowDialog();
            }
        }
    }
}