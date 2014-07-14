﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Avat.Components
{
    public partial class Progress : Form
    {
        private Action<BackgroundWorker, DoWorkEventArgs, object> action;
        private Action PostAction;
        private BackgroundWorker bw;
        private object UserData;
        private bool ShowOkMessage;

        public Progress(int min, int max, string opName, string startProgress, Action<BackgroundWorker, DoWorkEventArgs, object> action, Action postProcess, object userData, bool cancelEnabled, bool showOkMsg)
        {
            InitializeComponent();

            progressBar.Minimum = min;
            progressBar.Maximum = max;
            lblOp.Text = opName;
            lblProg.Text = startProgress;

            this.action = action;
            this.UserData = userData;
            this.PostAction = postProcess;
            this.ShowOkMessage = showOkMsg;

            btnCancel.Enabled = cancelEnabled;
        }

        public void StartWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            bw.RunWorkerAsync();
            Cursor = Cursors.WaitCursor;
            ShowDialog();
            Cursor = Cursors.Default;
        }

        string ErrorMsg;
        string ErrorTitle;
        MessageBoxButtons ErrorBtns;
        MessageBoxIcon ErrorIcon;
        bool ErrorShowInnerMessage;
        public void SetErrorMessage(string msg, string title, MessageBoxButtons buttons, MessageBoxIcon icon, bool showOrigErrMsg)
        {
            ErrorMsg = msg;
            ErrorTitle = title;
            ErrorBtns = buttons;
            ErrorIcon = icon;
            ErrorShowInnerMessage = ShowOkMessage;
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool doPostProcess = true;

            if (e.Cancelled == true)
            {
                MessageBox.Show(this, "Operácia prerušená používateľom!", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Visible = false;
                Close();
            }
            else if (e.Error != null)
            {
                if (!string.IsNullOrEmpty(ErrorMsg))
                    MessageBox.Show(this, string.Format("{0}{1}", ErrorMsg, ErrorShowInnerMessage ? e.Error.Message : string.Empty), ErrorTitle, ErrorBtns, ErrorIcon);
                else
                    MessageBox.Show(this, "Nastala chyba!" + Environment.NewLine + Environment.NewLine + e.Error.Message, "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorMsg = null;
                this.Visible = false;
                Close();
            }
            else
            {
                if (ShowOkMessage)
                    MessageBox.Show(this, "Operácia ukončená!", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Close();
            }

            if (PostAction != null && doPostProcess)
                PostAction();
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
                lblOp.Text = e.UserState.ToString();
            
            lblProg.Text = e.ProgressPercentage.ToString() + @"%";
            progressBar.Value = e.ProgressPercentage;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            action(worker, e, UserData);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bw != null)
                bw.CancelAsync();
        }
    }
}