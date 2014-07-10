using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator;
using AvatValidator.Interface;

namespace Avat.Components
{
    public partial class CtrlIdentification : UserControl
    {
        Color origColor;

        public CtrlIdentification()
        {
            InitializeComponent();

            cbKind.Items.AddRange(Enum.GetNames(typeof(DruhKvType)));
            cbPeriodType.Items.AddRange(Enum.GetNames(typeof(ItemChoiceType)));
        }

        private void CtrlIdentification_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 54, 54);

            this.origColor = lblIcDph.ForeColor;
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
            DefColors();
            var probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.Equals(identification.IcDphPlatitela)).ToList();
            if (probs.Count > 0)
                SetProblems(lblIcDph, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.Equals(identification.Nazov)).ToList();
            if (probs.Count > 0)
                SetProblems(lblNazov, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.GetType() == typeof(DruhKvType)).ToList();
            if (probs.Count > 0)
                SetProblems(lblDruh, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject == identification.Obdobie).ToList();
            if (probs.Count > 0)
                SetProblems(lblObdobie, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.Equals(identification.Stat)).ToList();
            if (probs.Count > 0)
                SetProblems(lblStat, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.Equals(identification.Obec)).ToList();
            if (probs.Count > 0)
                SetProblems(lblObec, probs);
        }

        private void DefColors()
        {
            lblIcDph.ForeColor = origColor;
            lblDruh.ForeColor = origColor;
            lblEmail.ForeColor = origColor;
            lblNazov.ForeColor = origColor;
            lblObdobie.ForeColor = origColor;
            lblObec.ForeColor = origColor;
            lblPsc.ForeColor = origColor;
            lblStat.ForeColor = origColor;
            lblTelefon.ForeColor = origColor;
            lblUlica.ForeColor = origColor;
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
            cbKind.Text = data.Druh.ToString();
            txtPeriod.Text = data.Obdobie.Item.ToString();
            cbPeriodType.Text = data.Obdobie.ItemElementName.ToString();
            txtYear.Text = data.Obdobie.Rok.ToString();
            txtName.Text = data.Nazov;
            txtState.Text = data.Stat;
            txtCity.Text = data.Obec;
            txtPsc.Text = data.PSC;
            txtAddress.Text = data.Ulica + data.Cislo;
            txtPhone.Text = data.Tel;
            txteMail.Text = data.Email;

            ShowNoProblems();
        }

        public Identifikacia GetData()
        {
            ReadForm();

            return this.identification;
        }

        private void ReadForm()
        {
            this.identification = new Identifikacia();
            this.identification.IcDphPlatitela = txtIcDph.Text;
            this.identification.Druh = (DruhKvType)Enum.Parse(typeof(DruhKvType), cbKind.Text);
            this.identification.Obdobie.Item = Convert.ToInt32(txtPeriod.Text);
            this.identification.Obdobie.ItemElementName = (ItemChoiceType)Enum.Parse(typeof(ItemChoiceType), cbPeriodType.Text);
            this.identification.Obdobie.Rok = Convert.ToInt32(txtYear.Text);
            this.identification.Nazov = txtName.Text;
            this.identification.Stat = txtState.Text;
            this.identification.Obec = txtCity.Text;
            this.identification.PSC = txtPsc.Text;
            this.identification.Ulica = txtAddress.Text;
            this.identification.Tel = txtPhone.Text;
            this.identification.Email = txteMail.Text;
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
