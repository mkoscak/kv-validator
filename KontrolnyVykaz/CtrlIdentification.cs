using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KVValidator;
using KVValidator.Interface;

namespace KontrolnyVykaz
{
    public partial class CtrlIdentification : UserControl
    {
        public CtrlIdentification()
        {
            InitializeComponent();
        }

        private void CtrlIdentification_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 54, 54);
        }

        Identifikacia identification;
        IValidationResult problems;

        public void SetProblems(IValidationResult problems)
        {
            this.problems = problems;
            ShowProblems();
        }

        private void ShowProblems()
        {
            var probs = problems.Where(p => p.ProblemObject == identification.IcDphPlatitela).ToList();
            if (probs.Count > 0)
                SetProblems(lblIcDph, probs);

            probs = problems.Where(p => p.ProblemObject == identification.Nazov).ToList();
            if (probs.Count > 0)
                SetProblems(lblNazov, probs);

            /*probs = problems.Where(p => p.ProblemObject == identification.Druh).ToList();
            if (probs.Count > 0)
                SetProblems(lblDruh, probs);*/

            probs = problems.Where(p => p.ProblemObject == identification.Obdobie).ToList();
            if (probs.Count > 0)
                SetProblems(lblObdobie, probs);

            probs = problems.Where(p => p.ProblemObject == identification.Stat).ToList();
            if (probs.Count > 0)
                SetProblems(lblStat, probs);

            probs = problems.Where(p => p.ProblemObject == identification.Obec).ToList();
            if (probs.Count > 0)
                SetProblems(lblObec, probs);
        }

        private void SetProblems(Label txtBox, List<IValidationItemResult> probs)
        {
            txtBox.ForeColor = Color.Red;
            if (probs.Count > 0)
                new ToolTip().SetToolTip(txtBox, probs[0].ResultMessage);
        }

        public void SetData(Identifikacia data)
        {
            this.identification = data;

            txtIcDph.Text = data.IcDphPlatitela;
            txtKind.Text = data.Druh.ToString();
            txtPeriod.Text = data.Obdobie.Rok + ", " + data.Obdobie.Item + ". " + data.Obdobie.ItemElementName.ToString();
            txtName.Text = data.Nazov;
            txtState.Text = data.Stat;
            txtCity.Text = data.Obec;
            txtPsc.Text = data.PSC;
            txtAddress.Text = data.Ulica + data.Cislo;
            txtPhone.Text = data.Tel;
            txteMail.Text = data.Email;

            ShowNoProblems();
        }

        private void ShowNoProblems()
        {
            lblIcDph.ForeColor = Color.Gray;
            lblDruh.ForeColor = Color.Gray;
            lblObdobie.ForeColor = Color.Gray;
            lblNazov.ForeColor = Color.Gray;
            lblStat.ForeColor = Color.Gray;
            lblObec.ForeColor = Color.Gray;
            lblEmail.ForeColor = Color.Gray;
            lblTelefon.ForeColor = Color.Gray;
            lblPsc.ForeColor = Color.Gray;
            lblUlica.ForeColor = Color.Gray;
        }
    }
}
