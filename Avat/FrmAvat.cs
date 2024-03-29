﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator;
using AvatValidator.Implementation;
using AvatValidator.Interface;
using Avat.Components;
using OfficeOpenXml;
using System.IO;
using Avat.Wrappers;
using AvatValidator.Validators.BlackListValidator.Entities;
using AvatValidator.Validators.TaxPayerValidator.Entities;
using AvatValidator.Sql;
using System.Net;
using Ionic.Zip;
using System.Reflection;

namespace Avat.Forms
{
    public partial class FrmAvat : Form, IValidationObserver
    {
        string FormTitle;
        string ActualFileName;

        KVDPH kvDph = new KVDPH();

        IValidationResult lastValidationResult;
        DataGridViewCellStyle errorStyle;
        DataGridViewCellStyle warningStyle;
        CtrlIdentification identification;
        CtrlValidationResult3 validationResults;
        CtrlFirstRun firstRunCtrl;

        public FrmAvat()
        {
            InitializeComponent();

            identification = new CtrlIdentification(ShowProgress, ShowActualIc);
            identification.BorderStyle = BorderStyle.None;
            identification.Dock = DockStyle.None;
            identification.Margin = new Padding(0, 20, 0, 0);
            panelContent.Controls.Add(identification);

            validationResults = new CtrlValidationResult3();
            validationResults.BorderStyle = BorderStyle.None;
            validationResults.Dock = DockStyle.Fill;
            validationResults.Margin = new Padding(20, 20, 20, 20);
            panelContent.Controls.Add(validationResults);

            firstRunCtrl = new CtrlFirstRun();
            firstRunCtrl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(firstRunCtrl);
            firstRunCtrl.Visible = false;
        }

        Vatfix.Licensing.License licence = null;
        bool LicenceOk = false;
        private void CheckLicence()
        {
            try
            {
                var lic = Vatfix.Licensing.LicenseManager.GetLicense();
                licence = lic;
                //lblHeader2.Text = string.Format("{0} {1} - {2:00}/{3}               ", lic.User.Name, lic.User.Surname, lic.Expiration.Month, lic.Expiration.Year);
                if (DateTime.Now < lic.Expiration)
                {
                    LicenceOk = true;   // az tu je licencia ok
                    lblHeader2.Text = string.Empty;
                }

                foreach (var item in licence.DIC)
                    identification.txtIcDph.Items.Add(item);
            }
            catch (Exception ex)
            {
                //ShowProgress("Problém s licenciou: " + ex.Message);
            }
        }

        void ShowActualIc(string text)
        {
            lblHeader2.Text = string.Format("{0}               ", text);
        }

        bool firstRun = false;
        private void FrmDesignOne_Load(object sender, EventArgs e)
        {
            LayoutHeader();
            this.leftMenu.Renderer = new ToolRenderer(true);
            this.topMenu.Renderer = new OpsToolRenderer();
            this.cornerMenu.Renderer = new OpsToolRenderer();

            CheckLicence();

            this.btnIdent.PerformClick();
            UpdateButtonTexts();

            // inicializacia hlavickoveho textu
            this.FormTitle = this.Text;

            errorStyle = new DataGridViewCellStyle(gridData.DefaultCellStyle);
            errorStyle.BackColor = Color.Red;//FromArgb(255, 100, 100);
            errorStyle.ForeColor = Color.White;
            warningStyle = new DataGridViewCellStyle(gridData.DefaultCellStyle);
            warningStyle.BackColor = MyColors.Yellow;

            // prvy beh je identifikovany pom. existencie DB suboru
            firstRun = !DbProvider.DefDataSourceExist;
            if (firstRun)
            {
                ShowFirstRun(true);
            }
            else
            {
                NewAvat();
            }
            
            CheckSetLicence();

            // stahovanie len v release
#if !DEBUG
            RunImports();
#endif
        }

        private void ShowFirstRun(bool show)
        {
            leftMenu.Visible = !show;
            firstRunCtrl.Visible = show;
            identification.Visible = !show;
            if (show)
            {
                Cursor = Cursors.WaitCursor;
                lblTitle.ForeColor = Color.White;
                panelLine.BackColor = Color.White;
            }
            else
            {
                Cursor = Cursors.Default;
                lblTitle.ForeColor = Color.Black;
                panelLine.BackColor = Color.Gray;
            }
            btnReadXml.Enabled = !show;
            btnSaveXml.Enabled = !show;
            btnOtherOps.Enabled = !show;
            btnCloseNoChanges.Enabled = !show;
            btnCheckAll.Enabled = !show;

            CheckSetLicence();
        }

        private void CheckSetLicence()
        {
            if (!LicenceOk)
            {
                btnSaveXml.Enabled = false;
                btnCheckAll.Enabled = false;
                btnExportToExcel.Enabled = false;
            }
        }

        #region Automaticke importy

        static readonly string ImportFolder = @".\import\";
        static readonly string tpFile = "ds_dphs";
        static readonly string blFile = "ds_dphz";
        static readonly string blFileXml = ImportFolder + blFile + ".xml";
        static readonly string tpFileXml = ImportFolder + tpFile + ".xml";
        static readonly string TmpDatabaseName = "tmp_avat.db";
        static readonly string ImportFilesUrl = @"http://download.vatfix.sk/lists/";
        static readonly string blFileUrl = ImportFilesUrl + blFile + ".zip";
        static readonly string tpFileUrl = ImportFilesUrl + tpFile + ".zip";
        static readonly string tpZip = ImportFolder + tpFile + ".zip";
        static readonly string blZip = ImportFolder + blFile + ".zip";
        static readonly string tpFileXmlProcessed = tpFileXml + ".processed";
        static readonly string blFileXmlProcessed = blFileXml + ".processed";

        private void RunImports()
        {
            var bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_ImportsWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ImportsProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_ImportsCompleted);
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerAsync();
        }

        void bw_ImportsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var bw = sender as BackgroundWorker;

            try
            {
                if (e.Result != null && e.Result is Exception)
                {
                    ShowProgress((e.Result as Exception).Message);
                    return;
                }

                if (!File.Exists(TmpDatabaseName) || !File.Exists(DbProvider.DefaultDataSource))
                {
                    ShowProgress(string.Empty); // ?? chyba?
                    return;
                }

                if (File.Exists(DbProvider.DefaultDataSource + ".old"))
                    File.Delete(DbProvider.DefaultDataSource + ".old");

                File.Move(DbProvider.DefaultDataSource, DbProvider.DefaultDataSource + ".old");
                File.Move(TmpDatabaseName, DbProvider.DefaultDataSource);

                // aktualizacia a presun uspesne.. premenujeme zdrojove xml na spracovane
                if (File.Exists(tpFileXml))
                {
                    if (File.Exists(tpFileXmlProcessed))
                        File.Delete(tpFileXmlProcessed);
                    File.Move(tpFileXml, tpFileXmlProcessed);
                }
                if (File.Exists(blFileXml))
                {
                    if (File.Exists(blFileXmlProcessed))
                        File.Delete(blFileXmlProcessed);
                    File.Move(blFileXml, blFileXmlProcessed);
                }

                ShowProgress("Databáza je aktuálna.");// ak bez problemov
            }
            catch (Exception)
            {
                ShowProgress("Neočakávaná výnimka!");
            }
            finally
            {
                if (firstRun)
                {
                    firstRun = false;
                    ShowFirstRun(false);
                }
            }
        }

        void bw_ImportsProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ShowProgress((e.UserState ?? string.Empty).ToString(), e.ProgressPercentage);
            if (firstRun)
            {
                firstRunCtrl.progress.Value = e.ProgressPercentage;
                firstRunCtrl.lblPercentage.Text = string.Format("{0}%", e.ProgressPercentage);
            }
        }

        void ShowProgress(string text)
        {
            if (statusProgress.Visible)
            {
                statusProgress.Visible = false;
                statusProgressVal.Visible = false;
            }

            statusText.Text = text;
        }
        
        void ShowProgress(string text, int percent)
        {
            if (!statusProgress.Visible)
            {
                statusProgress.Visible = true;
                statusProgressVal.Visible = true;
            }

            statusText.Text = text;
            statusProgressVal.Text = string.Format("{0}%", percent);
            statusProgress.Value = percent;
        }

        void bw_ImportsWork(object sender, DoWorkEventArgs e)
        {
            e.Result = null;
            var bw = sender as BackgroundWorker;
            if (!Directory.Exists(ImportFolder))
                Directory.CreateDirectory(ImportFolder);

            bw.ReportProgress(0, "Kontrola aktuálnosti databázy..");
            if (DbProvider.DefDataSourceExist && CheckTodaysImport())
            {
                var fi = new FileInfo(DbProvider.DefaultDataSource);
                if (fi.Length > 0)
                {
                    e.Result = new Exception("Databáza je aktuálna.");
                    return;
                }
            }

            bw.ReportProgress(10, "Sťahovanie súborov na import..");
            try
            {
                DownloadDataFiles();
            }
            catch (Exception ex)
            {
                e.Result = new Exception("Sťahovanie súborov zlyhalo!", ex);
                return;
            }

            bw.ReportProgress(45, "Rozbalenie súborov na import..");
            try
            {
                var tmps = Directory.GetFiles(ImportFolder, "*.tmp");
                foreach (var tmp in tmps)
                    File.Delete(tmp);

                UnzipDataFiles();
            }
            catch (Exception ex)
            {
                e.Result = new Exception("Rozbalenie súborov zlyhalo!", ex);
                return;
            }

            bw.ReportProgress(50, "Aktualizácia databázy DIČ..");
            try
            {
                BlackListManager.ImportDataFromXml(blFileXml, TmpDatabaseName, bw);
            }
            catch (Exception ex)
            {
                e.Result = new Exception(string.Format("Ups import platiteľov DPH s dôvodom na zrušenie registrácie neprebehol úspešne: {0}{0}{1}", Environment.NewLine, ex.Message));
                return;
            }

            bw.ReportProgress(75, "Aktualizácia databázy DIČ..");
            try
            {
                TaxPayersManager.ImportDataFromXml(tpFileXml, TmpDatabaseName, bw);
            }
            catch (Exception ex)
            {
                e.Result = new Exception(string.Format("Ups import registrovaných platiteľov DPH neprebehol úspešne: {0}{0}{1}", Environment.NewLine, ex.Message));
                return;
            }

            bw.ReportProgress(99, "Prepínanie schémy..");

            // so switchom DB pockame kym sa nedokonci kontrola
            while (CheckRunning)
                ;

            bw.ReportProgress(100, "Hotovo.");
        }

        // kontrola ci uz dnes prebehlo stiahnutie a import
        private bool CheckTodaysImport()
        {
            if (!File.Exists(blFileXmlProcessed))
                return false;

            var fi = new FileInfo(blFileXmlProcessed);
            //if (fi.LastWriteTime.Date == DateTime.Now.Date)
            if (fi.LastAccessTime.Date == DateTime.Now.Date)
                return true;

            return false;
        }

        private void DownloadDataFiles()
        {
            DownloadFile(blFileUrl, blZip);
            DownloadFile(tpFileUrl, tpZip);
        }

        private void UnzipDataFiles()
        {
            UnzipFile(blZip);
            UnzipFile(tpZip);
        }

        private void UnzipFile(string zip)
        {
            var fi = new FileInfo(zip);

            using (var zipFile = new ZipFile(zip))
            {
                zipFile.ExtractAll(fi.DirectoryName, ExtractExistingFileAction.OverwriteSilently);
            }
        }

        private void DownloadFile(string fileUrl, string destName)
        {
            using (var client = new WebClient())
            {
                client.Proxy = WebRequest.GetSystemWebProxy();
                client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                client.Credentials = CredentialCache.DefaultNetworkCredentials;
                client.DownloadFile(fileUrl, destName);
            }
        }

        #endregion

        private void NewAvat()
        {
            kvDph = new KVDPH();
            kvDph.Identifikacia.Obdobie.Rok = DateTime.Now.Year;
            a1w = new MySortableBindingList<A1Wrapper>();
            a2w = new MySortableBindingList<A2Wrapper>();
            b1w = new MySortableBindingList<B1Wrapper>();
            b2w = new MySortableBindingList<B2Wrapper>();
            b3w = new MySortableBindingList<B3Wrapper>();
            c1w = new MySortableBindingList<C1Wrapper>();
            c2w = new MySortableBindingList<C2Wrapper>();
            d1w = new MySortableBindingList<D1Wrapper>();
            d2w = new MySortableBindingList<D2Wrapper>();

            lastValidationResult = null;
            validationResults.Clear();
            identification.SetData(kvDph.Identifikacia, true);
            ShowIdentification(true);
            UpdateButtonTexts();
            SetFileName("nový.xml");
            SetIcons(null);//def icons
        }

        private void SetFileName(string name)
        {
            this.Text = string.Format("{0} - {1}", FormTitle, name);
        }

        void DisableAllButtons(ToolStripButton except)
        {
            ShowProgress(string.Empty);

            btnIdent.Checked = false;
            btnA1.Checked = false;
            btnA2.Checked = false;
            btnB1.Checked = false;
            btnB2.Checked = false;
            btnB3.Checked = false;
            btnC1.Checked = false;
            btnC2.Checked = false;
            btnD1.Checked = false;
            btnD2.Checked = false;
            btnCheckResults.Checked = false;
            except.Checked = true;

            lblTitle.Text = except.ToolTipText;

            if (except == btnIdent)
            {
                gridData.Visible = false;
                identification.Visible = true;
                validationResults.Visible = false;
            }
            else if (except == btnCheckResults)
            {
                gridData.Visible = false;
                identification.Visible = false;
                validationResults.Visible = true;
            }
            else if (!gridData.Visible)
            {
                gridData.Visible = true;
                identification.Visible = false;
                validationResults.Visible = false;
            }
        }

        private void btnIdent_Click(object sender, EventArgs e)
        {
            ShowIdentification(false);
        }

        private void ShowIdentification(bool noProblems)
        {
            DisableAllButtons(btnIdent);
            //identification.SetData(kvDph.Identifikacia, noProblems);
            gridData.DataSource = null;
            identification.lblIcDph.Focus();
        }

        void ClearGrid<T>()
            where T : IIdHolder
        {
            ItemCounter.Reset();
            /*gridData.DataSource = null;
            gridData.DataSource = new MySortableBindingList<T>();*/
        }

        private void btnCheckResults_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnCheckResults);
            ShowValidationResults(false);
        }

        private void ShowValidationResults(bool refresh)
        {
            DisableAllButtons(btnCheckResults);
            if (refresh)
            {
                validationResults.ShowResult(lastValidationResult);
                var tmp = this.Size;
                this.Size = new Size(tmp.Width + 100, tmp.Height + 1);
                this.Size = tmp;
            }
            gridData.DataSource = null;
            identification.lblIcDph.Focus();
        }

        BindingSource bindingSource = new BindingSource();
        MySortableBindingList<A1Wrapper> a1w = new MySortableBindingList<A1Wrapper>();
        MySortableBindingList<A2Wrapper> a2w = new MySortableBindingList<A2Wrapper>();
        MySortableBindingList<B1Wrapper> b1w = new MySortableBindingList<B1Wrapper>();
        MySortableBindingList<B2Wrapper> b2w = new MySortableBindingList<B2Wrapper>();
        MySortableBindingList<B3Wrapper> b3w = new MySortableBindingList<B3Wrapper>();
        MySortableBindingList<C1Wrapper> c1w = new MySortableBindingList<C1Wrapper>();
        MySortableBindingList<C2Wrapper> c2w = new MySortableBindingList<C2Wrapper>();
        MySortableBindingList<D1Wrapper> d1w = new MySortableBindingList<D1Wrapper>();
        MySortableBindingList<D2Wrapper> d2w = new MySortableBindingList<D2Wrapper>();

        private void btnA1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA1);
            ClearGrid<A1Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A1 != null)
            {
                a1w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = a1w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA2);
            ClearGrid<A2Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A2 != null)
            {
                a2w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = a2w;
                gridData.DataSource = bindingSource;
            }
        }
        private void btnB1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB1);
            ClearGrid<B1Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B1 != null)
            {
                b1w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = b1w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB2);
            ClearGrid<B2Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B2 != null)
            {
                b2w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = b2w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB3);
            ClearGrid<B3Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B3 != null)
            {
                b3w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = b3w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC1);
            ClearGrid<C1Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C1 != null)
            {
                c1w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = c1w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC2);
            ClearGrid<C2Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C2 != null)
            {
                c2w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = c2w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD1);
            ClearGrid<D1Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D1 != null)
            {
                d1w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = d1w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD2);
            ClearGrid<D2Wrapper>();

            //if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D2 != null)
            {
                d2w.ToList().ForEach(w => w.SetId(ItemCounter.Next));
                bindingSource.DataSource = d2w;
                gridData.DataSource = bindingSource;
            }
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetXmlPath();
                if (string.IsNullOrEmpty(path))
                    return;

                SetIcons(null);//def icons
                lastValidationResult = null;
                validationResults.Clear();

                var p = new Progress(0, 100, "Načítanie vstupného súboru", "Načítavam..", ReadXmlProc, XmlRead, path, false, false);
                p.SetErrorMessage("Ups načítanie vstupného súboru neprebehlo úspešne, XML súbor pravdepodobne nezodpovedá XSD schéme pre kontrolný výkaz DPH. Validnosť xml súboru na xsd schému je možné overiť XML validátorom v štandarde W3C.", "Načítanie vstupu", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                p.StartWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Načítanie vstupného súboru neprebehlo úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Načítanie vstupu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void ReadXmlProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            ReadXml(userData.ToString());
            bw.ReportProgress(100);
        }

        /// <summary>
        /// po nacitani XML
        /// </summary>
        void XmlRead()
        {
            if (kvDph != null)
            {
                a1w = new MySortableBindingList<A1Wrapper>(kvDph.Transakcie.A1.Select(a => new A1Wrapper(a)).ToList());
                a2w = new MySortableBindingList<A2Wrapper>(kvDph.Transakcie.A2.Select(a => new A2Wrapper(a)).ToList());
                b1w = new MySortableBindingList<B1Wrapper>(kvDph.Transakcie.B1.Select(a => new B1Wrapper(a)).ToList());
                b2w = new MySortableBindingList<B2Wrapper>(kvDph.Transakcie.B2.Select(a => new B2Wrapper(a)).ToList());
                b3w = new MySortableBindingList<B3Wrapper>(kvDph.Transakcie.B3.Select(a => new B3Wrapper(a)).ToList());
                c1w = new MySortableBindingList<C1Wrapper>(kvDph.Transakcie.C1.Select(a => new C1Wrapper(a)).ToList());
                c2w = new MySortableBindingList<C2Wrapper>(kvDph.Transakcie.C2.Select(a => new C2Wrapper(a)).ToList());
                d1w = new MySortableBindingList<D1Wrapper>(kvDph.Transakcie.D1.Select(a => new D1Wrapper(a)).ToList());
                d2w = new MySortableBindingList<D2Wrapper>(kvDph.Transakcie.D2.Select(a => new D2Wrapper(a)).ToList());

                UpdateButtonTexts();
                identification.SetData(kvDph.Identifikacia, true);
                ShowIdentification(true);
                SetFileName(ActualFileName);
            }
        }

        private void UpdateButtonTexts()
        {
            btnA1.Text = string.Format("A.1. ({0})", a1w.Count);
            btnA2.Text = string.Format("A.2. ({0})", a2w.Count);
            btnB1.Text = string.Format("B.1. ({0})", b1w.Count);
            btnB2.Text = string.Format("B.2. ({0})", b2w.Count);
            btnB3.Text = string.Format("B.3. ({0})", b3w.Count);
            btnC1.Text = string.Format("C.1. ({0})", c1w.Count);
            btnC2.Text = string.Format("C.2. ({0})", c2w.Count);
            btnD1.Text = string.Format("D.1. ({0})", d1w.Count);
            btnD2.Text = string.Format("D.2. ({0})", d2w.Count);
            
            if (lastValidationResult != null)
            {
                var Result = lastValidationResult;

                var c = Result.Count(r => r.ProblemObject is A1);
                if (c > 0)
                    btnA1.Text = string.Format("A.1. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is A2);
                if (c > 0)
                    btnA2.Text = string.Format("A.2. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is B1);
                if (c > 0)
                    btnB1.Text = string.Format("B.1. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is B2);
                if (c > 0)
                    btnB2.Text = string.Format("B.2. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is B3);
                if (c > 0)
                    btnB3.Text = string.Format("B.3. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is C1);
                if (c > 0)
                    btnC1.Text = string.Format("C.1. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is C2);
                if (c > 0)
                    btnC2.Text = string.Format("C.2. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is D1);
                if (c > 0)
                    btnD1.Text = string.Format("D.1. ({0})", Common.FormatErrCount(c));
                c = Result.Count(r => r.ProblemObject is D2);
                if (c > 0)
                    btnD2.Text = string.Format("D.2. ({0})", Common.FormatErrCount(c));
            }
        }

        private bool ReadXml(string path)
        {
            this.kvDph = KVDPH.LoadFromFile(path);

            var found = path.LastIndexOf('\\');
            if (found >= 0)
                ActualFileName = path.Substring(found + 1);
            else
                ActualFileName = path;

            return true;
        }

        private string GetXmlPath()
        {
            var curDir = Environment.CurrentDirectory;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML files|*.xml";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;

            Environment.CurrentDirectory = curDir;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        bool ReadIdent()
        {
            try
            {
                kvDph.Identifikacia = identification.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Načítanie identifikácie skončilo nasledujúcou výnimkou: {0}{0}{1}", Environment.NewLine, ex.Message), "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Nacitanie udajov z UI do KVDPH
        /// </summary>
        /// <returns></returns>
        bool ReadKV(bool checkLicence)
        {
            try
            {
                gridData.CancelEdit();
                kvDph.Identifikacia = identification.GetData();
                if (checkLicence && !licence.DIC.Contains(kvDph.Identifikacia.IcDphPlatitela))
                {
                    MessageBox.Show(this, "Nemožno validovať subjekt, ktorý sa nenachádza v licenčnom súbore!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                kvDph.Transakcie.A1 = a1w.Select(w => w.a1).ToList();
                kvDph.Transakcie.A2 = a2w.Select(w => w.a2).ToList();
                kvDph.Transakcie.B1 = b1w.Select(w => w.b1).ToList();
                kvDph.Transakcie.B2 = b2w.Select(w => w.b2).ToList();
                kvDph.Transakcie.B3 = b3w.Select(w => w.b3).ToList();
                kvDph.Transakcie.C1 = c1w.Select(w => w.c1).ToList();
                kvDph.Transakcie.C2 = c2w.Select(w => w.c2).ToList();
                kvDph.Transakcie.D1 = d1w.Select(w => w.d1).ToList();
                kvDph.Transakcie.D2 = d2w.Select(w => w.d2).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Načítanie výkazu skončilo nasledujúcou výnimkou: {0}{0}{1}", Environment.NewLine, ex.Message), "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        bool CheckRunning = false;
        /// <summary>
        /// Samotna validacia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            /*if (ImportRunning)
            {
                MessageBox.Show(this, "Prebieha prvotná inicializácia databázy subjektov registrovaných pre DPH. Tento proces vás už nebude pri dalších spusteniach aplikácie obmedzovať, je však nevyhnutný pre prvé korektné spustenie aplikácie a môže trvať niekoľko minút (10). Počkajte prosím kým sa inicializácia ukončí. Coffee break", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            if (!ReadKV(true))
                return;

            try
            {
                CheckRunning = true;
                identification.HasProblems = false;
                var p = new Progress(0, 100, "Kontrola výkazu", "Validujem..", ValidationProc, ValidationDone, null, true, false);
                p.SetErrorMessage("Ups kontrola výkazu neprebehla úspešne, nastala neočakávaná chyba, reštartujte prosím aplikáciu a zopakujte kontrolu. Ak chyba pretrváva kontaktuje podporu.", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                p.StartWorker();
            }
            catch (Exception ex)
            {
                CheckRunning = false;
                MessageBox.Show(this, string.Format("Kontrola výkazu neprebehla úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        BackgroundWorker ValidationWorker;
        int counter;
        int total;
        void ValidationProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            ValidationWorker = bw;
            counter = 0;

            var rules = new DefaultValidationSetFactory().ValidationSet;
            var validator = new DefaultValidator();

            // c je pocet validatorov poloziek
            var c = rules.Count(r => r.RuleType == RuleType.A1ItemChecker || r.RuleType == RuleType.A2ItemChecker || r.RuleType == RuleType.B1ItemChecker || r.RuleType == RuleType.B2ItemChecker ||
                r.RuleType == RuleType.B3ItemChecker || r.RuleType == RuleType.C1ItemChecker || r.RuleType == RuleType.C2ItemChecker || r.RuleType == RuleType.D1ItemChecker || r.RuleType == RuleType.D2ItemChecker ||
                r.RuleType == RuleType.GeneralItemChecker);
            // total je celkovy pocet validacii poloziek, ostatne zanedbavame..
            total = c * (kvDph.Transakcie.A1.Count + kvDph.Transakcie.A2.Count + kvDph.Transakcie.B1.Count + kvDph.Transakcie.B2.Count + kvDph.Transakcie.B3.Count +
                kvDph.Transakcie.C1.Count + kvDph.Transakcie.C2.Count + kvDph.Transakcie.D1.Count + kvDph.Transakcie.D2.Count);
            // aktualna validacia
            counter = 0;

            validator.AddObserver(this);
            lastValidationResult = validator.Validate(kvDph, rules);

            ValidationWorker = null;
            bw.ReportProgress(100);
        }

        void ValidationDone()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ValidationDone));
                return;
            }

            CheckRunning = false;

            if (lastValidationResult == null)
            {
                SetIcons(lastValidationResult);
                return;
            }

            identification.SetProblems(lastValidationResult);
            ShowValidationResults(true);
            UpdateButtonTexts();
            SetIcons(lastValidationResult);
        }

        private void SetIcons(IValidationResult lastValidationResult)
        {
            // def farby
            btnA1.Tag = MyColors.LeftToolGray;
            btnA2.Tag = MyColors.LeftToolGray;
            btnB1.Tag = MyColors.LeftToolGray;
            btnB2.Tag = MyColors.LeftToolGray;
            btnB3.Tag = MyColors.LeftToolGray;
            btnC1.Tag = MyColors.LeftToolGray;
            btnC2.Tag = MyColors.LeftToolGray;
            btnD1.Tag = MyColors.LeftToolGray;
            btnD2.Tag = MyColors.LeftToolGray;
            btnIdent.Tag = MyColors.LeftToolGray;
            btnCheckResults.Tag = MyColors.LeftToolGray;

            leftMenu.Invalidate();

            if (lastValidationResult == null)
                return;

            // identifikacia
            if (identification.HasProblems)
                btnIdent.Tag = Color.Red;
            else
                btnIdent.Tag = Color.Green;

            // polozky
            bool prob;
            prob = lastValidationResult.Any(r => r.ProblemObject is A1);
            btnA1.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is A2);
            btnA2.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is B1);
            btnB1.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is B2);
            btnB2.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is B3);
            btnB3.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is C1);
            btnC1.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is C2);
            btnC2.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is D1);
            btnD1.Tag = prob ? Color.Red : Color.Green;
            prob = lastValidationResult.Any(r => r.ProblemObject is D2);
            btnD2.Tag = prob ? Color.Red : Color.Green;

            leftMenu.Invalidate();
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            if (!ReadKV(false))
                return;

            string fName = GetOutXmlFileName();
            if (string.IsNullOrEmpty(fName))
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                kvDph.SaveToFile(fName);

                var found = fName.LastIndexOf('\\');
                if (found >= 0)
                    ActualFileName = fName.Substring(found + 1);
                else
                    ActualFileName = fName;
                SetFileName(ActualFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Počas ukladania súboru došlo k nasledujúcej chybe: " + ex.Message, "Uložiť", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GetOutXmlFileName()
        {
            return GetOutFileName("xml", "XML files|*.xml");
        }

        internal static string GetOutXlsxFileName()
        {
            return GetOutFileName("xlsx", "Excel 2007 files|*.xlsx");
        }

        internal static string GetOutFileName(string defExt, string filter)
        {
            var curDir = Environment.CurrentDirectory;

            var ofd = new SaveFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.CreatePrompt = false;
            ofd.AddExtension = true;
            ofd.DefaultExt = defExt;
            ofd.Filter = filter;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;

            Environment.CurrentDirectory = curDir;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        private void gridData_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = gridData.Rows[e.RowIndex];
            if (row.Tag == null)
                return;

            var problems = row.Tag as List<IValidationItemResult>;
            if (problems.Count == 0)
                return;

            e.ToolTipText = BuildErrorTooltip(problems);
        }

        private string BuildErrorTooltip(List<IValidationItemResult> problems)
        {
            var sb = new StringBuilder();

            foreach (var p in problems)
            {
                if (string.IsNullOrEmpty(p.ResultTooltip))
                    sb.AppendLine(p.ResultMessage);
                else
                    sb.AppendLine(p.ResultMessage + " - " + p.ResultTooltip);
            }

            return sb.ToString().Trim();
        }

        #region IValidationObserver Members

        public ObserverResult NextRule(IValidationRule rule)
        {
            counter++;
            return HandleObserverEvent();
        }

        public ObserverResult OnOk(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnWarning(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnError(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnCriticalError(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        private ObserverResult HandleObserverEvent()
        {

            if (ValidationWorker != null)
            {
                if (counter > total)
                    counter = total;
                if (total > 0)
                    ValidationWorker.ReportProgress(Convert.ToInt32(((double)counter / total) * 100.0));
                if (ValidationWorker.CancellationPending)
                    return ObserverResult.StopValidation;
            }

            return ObserverResult.Continue;
        }

        #endregion

        #region Novy KV

        private void btnNewAvat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Naozaj si prajete začať nový kontrolný výkaz? Všetky neuložené zmeny budú stratené!", "Nový výkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            NewAvat();
        }

        #endregion

        #region Export excel

        /// <summary>
        /// Export do excelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (!ReadKV(false))
                return;

            try
            {
                var fname = GetOutXlsxFileName();
                if (string.IsNullOrEmpty(fname))
                    return;

                var p = new Progress(0, 100, "Export kontrolného výkazu do programu Excel", "Exportujem..", ExportKvProc, ExportDone, fname, true, true);
                p.StartWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Ups export kontrolného výkazu do programu Excel neprebehol úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void ExportDone()
        {
            this.BringToFront();
            this.Focus();
        }

        void ExportKvProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            var path = userData.ToString();

            using (var excel = new ExcelPackage(/*new FileInfo(path)*/))
            {
                var wsIdent = excel.Workbook.Worksheets.Add("Identifikácia");

                // stlpec A - nazvy poloziek
                wsIdent.Cells[1, 1].Value = identification.lblIcDph.Text;
                wsIdent.Cells[2, 1].Value = identification.lblDruh.Text;
                wsIdent.Cells[3, 1].Value = identification.lblObdobie.Text;
                wsIdent.Cells[4, 1].Value = identification.lblNazov.Text;
                wsIdent.Cells[5, 1].Value = identification.lblStat.Text;
                wsIdent.Cells[6, 1].Value = identification.lblObec.Text;
                wsIdent.Cells[7, 1].Value = identification.lblPsc.Text;
                wsIdent.Cells[8, 1].Value = identification.lblUlica.Text;
                wsIdent.Cells[9, 1].Value = identification.lblTelefon.Text;
                wsIdent.Cells[10, 1].Value = identification.lblEmail.Text;
                wsIdent.Column(1).AutoFit();
                var headerCol = wsIdent.Cells[1, 1, 10, 1];
                headerCol.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                headerCol.Style.Fill.BackgroundColor.SetColor(Color.Silver);
                headerCol.Style.Font.Bold = true;

                // stlpec A - nazvy poloziek
                wsIdent.Cells[1, 2].Value = kvDph.Identifikacia.IcDphPlatitela;
                wsIdent.Cells[2, 2].Value = kvDph.Identifikacia.Druh;
                wsIdent.Cells[3, 2].Value = kvDph.Identifikacia.Obdobie.Item + "." + kvDph.Identifikacia.Obdobie.ItemElementName + " " + kvDph.Identifikacia.Obdobie.Rok.ToString();
                wsIdent.Cells[4, 2].Value = kvDph.Identifikacia.Nazov;
                wsIdent.Cells[5, 2].Value = kvDph.Identifikacia.Stat;
                wsIdent.Cells[6, 2].Value = kvDph.Identifikacia.Obec;
                wsIdent.Cells[7, 2].Value = kvDph.Identifikacia.PSC;
                wsIdent.Cells[8, 2].Value = kvDph.Identifikacia.Ulica;
                wsIdent.Cells[9, 2].Value = kvDph.Identifikacia.Tel;
                wsIdent.Cells[10, 2].Value = kvDph.Identifikacia.Email;
                wsIdent.Column(2).AutoFit();
                var dataCol = wsIdent.Cells[1, 2, 10, 2];
                dataCol.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                dataCol.Style.Fill.BackgroundColor.SetColor(Color.Silver);
                dataCol.Style.Font.Color.SetColor(Color.DimGray);

                var ws = excel.Workbook.Worksheets.Add("A1");
                if (!ExportList2<A1Wrapper>(ws, a1w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("A2");
                if (!ExportList2<A2Wrapper>(ws, a2w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("B1");
                if (!ExportList2<B1Wrapper>(ws, b1w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("B2");
                if (!ExportList2<B2Wrapper>(ws, b2w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("B3");
                if (!ExportList2<B3Wrapper>(ws, b3w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("C1");
                if (!ExportList2<C1Wrapper>(ws, c1w, bw))
                {
                    e.Cancel = true;
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("C2");
                if (!ExportList2<C2Wrapper>(ws, c2w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("D1");
                if (!ExportList2<D1Wrapper>(ws, d1w, bw))
                {
                    e.Cancel = true;
                    return;
                }
                ws = excel.Workbook.Worksheets.Add("D2");
                if (!ExportList2<D2Wrapper>(ws, d2w, bw))
                {
                    e.Cancel = true;
                    return;
                }

                excel.SaveAs(new FileInfo(path));
            }
        }

        private bool ExportList2<T1>(ExcelWorksheet ws, IList<T1> aw, BackgroundWorker bw)
            where T1 : class
        {
            bw.ReportProgress(0, "Export položiek " + ws.Name);
            var props = TypeDescriptor.GetProperties(typeof(T1));
            
            double totalCells = props.Count * aw.Count;

            for (int i = 0; i < props.Count; i++)
            {
                var p = props[i];
                ws.Cells[1, i + 1].Value = p.DisplayName;

                var pinf = typeof(T1).GetProperty(p.Name);
                for (int j = 0; j < aw.Count; j++)
                {
                    var val = pinf.GetValue(aw[j], null);
                    if (val != null)
                    {
                        if (val.ToString().ToUpper() == "PRAVDA" ||
                            val.ToString().ToUpper() == "TRUE")
                            val = "Áno";
                        if (val.ToString().ToUpper() == "NEPRAVDA" ||
                            val.ToString().ToUpper() == "FALSE")
                            val = "Nie";
                        ws.Cells[2 + j, i + 1].Value = val;
                    }

                    var progres = ((double)(i * aw.Count + j) / totalCells) * 100.0;
                    bw.ReportProgress(Convert.ToInt32(progres));
                    if (bw.CancellationPending)
                    {
                        bw.CancelAsync();
                        return false;
                    }
                }
            }

            bw.ReportProgress(100, "Nastavujem šírku stĺpcov " + ws.Name);
            for (int i = 0; i < props.Count; i++)
                ws.Column(i + 1).AutoFit();

            var headerRow = ws.Cells[1, 1, 1, props.Count];
            headerRow.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            headerRow.Style.Fill.BackgroundColor.SetColor(Color.Silver);
            headerRow.Style.Font.Bold = true;

            return true;
        }

        bool ExportList<T>(ExcelWorksheet ws, IList<T> data, BackgroundWorker bw)
            where T : class
        {
            bw.ReportProgress(0, "Export položiek " + ws.Name);

            var tmp = ConvertToDatatable<T>(data);
            for (int i = 0; i < tmp.Rows.Count; i++)
            {
                for (int j = 0; j < tmp.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1].Value = (tmp.Rows[i][j] ?? string.Empty).ToString();
                }

                var progres = (((double)i + 1) / (double)tmp.Rows.Count) * 100.0;
                bw.ReportProgress(Convert.ToInt32(progres));
                if (bw.CancellationPending)
                {
                    bw.CancelAsync();
                    return false;
                }
            }

            // header
            bw.ReportProgress(100, "Nastavujem šírku stĺpcov " + ws.Name);
            for (int i = 0; i < tmp.Columns.Count; i++)
            {
                ws.Cells[1, i + 1].Value = tmp.Columns[i].Caption;
                ws.Column(i + 1).AutoFit();
            }

            var headerRow = ws.Cells[1, 1, 1, tmp.Columns.Count];
            headerRow.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            headerRow.Style.Fill.BackgroundColor.SetColor(Color.Silver);
            headerRow.Style.Font.Bold = true;

            return true;
        }

        public static DataTable ConvertToDatatable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            return table;
        }

        #endregion

        private void gridData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.Handled = false;
            if (lastValidationResult == null || lastValidationResult.Count == 0 || e.RowIndex < 0)
                return;

            var r = gridData.Rows[e.RowIndex];
            if (r.DataBoundItem is A1Wrapper)
                CheckErr((r.DataBoundItem as A1Wrapper).a1, r);
            if (r.DataBoundItem is A2Wrapper)
                CheckErr((r.DataBoundItem as A2Wrapper).a2, r);
            if (r.DataBoundItem is B1Wrapper)
                CheckErr((r.DataBoundItem as B1Wrapper).b1, r);
            if (r.DataBoundItem is B2Wrapper)
                CheckErr((r.DataBoundItem as B2Wrapper).b2, r);
            if (r.DataBoundItem is B3Wrapper)
                CheckErr((r.DataBoundItem as B3Wrapper).b3, r);
            if (r.DataBoundItem is C1Wrapper)
                CheckErr((r.DataBoundItem as C1Wrapper).c1, r);
            if (r.DataBoundItem is C2Wrapper)
                CheckErr((r.DataBoundItem as C2Wrapper).c2, r);
            if (r.DataBoundItem is D1Wrapper)
                CheckErr((r.DataBoundItem as D1Wrapper).d1, r);
            if (r.DataBoundItem is D2Wrapper)
                CheckErr((r.DataBoundItem as D2Wrapper).d2, r);
        }

        private void CheckErr(object obj, DataGridViewRow r)
        {
            if (obj == null)
                return;

            var problems = lastValidationResult.Where(vir => vir.ProblemObject == obj).ToList();
            if (problems == null)
                return;

            if (problems.Any(p => p.ValidationResultState == ResultState.OkWithWarning))
                r.DefaultCellStyle = warningStyle;
            else if (problems.Any(p => p.ValidationResultState == ResultState.Error))
                r.DefaultCellStyle = errorStyle;
            r.Tag = problems;
        }

        static int TOP_TRANS = 5;
        private void btnBiznisReport_Click(object sender, EventArgs e)
        {
            if (kvDph == null)
                return;

            ReadKV(false);

            var br = new BiznisReport();

            AnalyzujVyst(ref br.PocVyst, ref br.SumaVyst, ref br.DaneVyst);
            AnalyzujPrij(ref br.PocPrij, ref br.SumaPrij, ref br.DanePrij);
            br.Balance = br.SumaVyst - br.SumaPrij;
            br.PocetBlacklistOdb = VratPocetBlackListOdb();
            br.PocetBlacklistDod = VratPocetBlackListDod();

            // top odberatelske z A1 a A2
            var tmpTransOdb = kvDph.Transakcie.A1.OrderByDescending(a => a.Z).
                    Take(TOP_TRANS).OrderByDescending(a => a.Z).Select(a => new A1Wrapper(a)).ToList();
            tmpTransOdb.AddRange(kvDph.Transakcie.A2.OrderByDescending(a => a.Z).
                    Take(TOP_TRANS).OrderByDescending(a => a.Z).Select(a => new A1Wrapper(a)).ToList());
            br.TopOdberatel = tmpTransOdb.OrderByDescending(a => a.SumaDane).Take(TOP_TRANS).ToList();

            // top dodavatelske z B1 a B2
            var tmpTransDod = kvDph.Transakcie.B1.OrderByDescending(a => a.Z).
                    Take(TOP_TRANS).OrderByDescending(a => a.Z).Select(a => new B1Wrapper(a)).ToList();
            tmpTransDod.AddRange(kvDph.Transakcie.B2.OrderByDescending(a => a.Z).
                    Take(TOP_TRANS).OrderByDescending(a => a.Z).Select(a => new B1Wrapper(a)).ToList());
            br.TopDodavatel = tmpTransDod.OrderByDescending(a => a.SumaDane).Take(TOP_TRANS).ToList();

            var frm = new FrmBiznisReport(br);
            frm.ShowDialog(this);
        }

        private int VratPocetBlackListOdb()
        {
            var objs = new List<string>();

            objs.AddRange(kvDph.Transakcie.A1.Select(a => a.Odb).ToList());
            objs.AddRange(kvDph.Transakcie.A2.Select(a => a.Odb).ToList());
            objs.AddRange(kvDph.Transakcie.C1.Select(a => a.Odb).ToList());

            return CountBlacklist(objs.Distinct().ToList());
        }

        private int VratPocetBlackListDod()
        {
            var objs = new List<string>();

            objs.AddRange(kvDph.Transakcie.B1.Select(a => a.Dod).ToList());
            objs.AddRange(kvDph.Transakcie.B2.Select(a => a.Dod).ToList());
            objs.AddRange(kvDph.Transakcie.C2.Select(a => a.Dod).ToList());

            return CountBlacklist(objs.Distinct().ToList());
        }

        private int CountBlacklist(List<string> list)
        {
            new BlackListEntity();
            list.Remove(null);
            var icList = string.Join(", ", list.Select(s => "\"" + s + "\"").ToArray());
            var q = string.Format("select count(*) from {0} where {1} in ({2})", BlackListEntity.TABLE_NAME, BlackListEntity.IC_DPH, icList);
            var ds = DbProvider.Instance.ExecuteQuery(q);

            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }

        private void AnalyzujVyst(ref int poc, ref decimal suma, ref decimal dane)
        {
            // pocty
            poc += kvDph.Transakcie.A1.Count;
            poc += kvDph.Transakcie.A2.Count;
            poc += kvDph.Transakcie.C1.Count;

            // sumy
            suma += kvDph.Transakcie.A1.Sum(a => a.Z);
            suma += kvDph.Transakcie.A2.Sum(a => a.Z);
            suma += kvDph.Transakcie.C1.Sum(a => a.ZR);

            // dane
            dane += kvDph.Transakcie.A1.Sum(a => a.D);
            //dane += kvDph.Transakcie.A2.Sum(a => a.D);
            dane += kvDph.Transakcie.C1.Sum(a => a.DR);

            // B3?
        }

        private void AnalyzujPrij(ref int poc, ref decimal suma, ref decimal dane)
        {
            // pocty
            poc += kvDph.Transakcie.B1.Count;
            poc += kvDph.Transakcie.B2.Count;
            poc += kvDph.Transakcie.C2.Count;

            // sumy
            suma += kvDph.Transakcie.B1.Sum(a => a.Z);
            suma += kvDph.Transakcie.B2.Sum(a => a.Z);
            suma += kvDph.Transakcie.C2.Sum(a => a.ZR);

            // dane
            dane += kvDph.Transakcie.B1.Sum(a => a.D);
            dane += kvDph.Transakcie.B2.Sum(a => a.D);
            dane += kvDph.Transakcie.C2.Sum(a => a.DR);

            // B3?
        }

        private void gridData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show(this, "Zadaná hodnota nie je validná. Skontrolujte správne zadanie desatinnej bodky resp. čiarky!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmAvat_Resize(object sender, EventArgs e)
        {
            LayoutHeader();
        }

        Padding pad;
        private void LayoutHeader()
        {
            var middle = this.Size.Width / 2;
            //lblHeader.Size = new Size(middle - 25, lblHeader.Size.Height);

            if (pad == null)
                pad = btnCheckAll.Margin;
            pad.Left = middle - 350;
            pad.Top = 6;
            pad.Right = 3;
            pad.Bottom = 5;
            btnCheckAll.Margin = pad;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About(this.licence);
            frm.Show(this);
        }

        private void btnCloseNoChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Naozaj si prajete zatvoriť kontrolný výkaz? Všetky neuložené zmeny budú stratené!", "Zatvoriť bez zmien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            NewAvat();
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //gridData.Rows[e.RowIndex].DataBoundItem
            if (e.RowIndex < 0)
                return;

            var row = gridData.Rows[e.RowIndex];
            if (row.Tag == null)
                return;

            var problems = row.Tag as List<IValidationItemResult>;
            if (problems.Count == 0)
                ShowProgress(string.Empty);
            else
                ShowProgress(BuildErrorTooltip(problems));
        }

        private void gridData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                gridData.InvalidateRow(e.RowIndex);
        }

        private void gridData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateButtonTexts();
        }

        private void gridData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateButtonTexts();
        }

        private void FrmAvat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnAbout.PerformClick();
        }
    }
}
