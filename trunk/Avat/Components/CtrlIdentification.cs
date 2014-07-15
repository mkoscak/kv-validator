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
        Color origColorMandatory;
        Color origColorNoMandatory;

        public CtrlIdentification()
        {
            InitializeComponent();

            cbKind.Items.AddRange(Enum.GetNames(typeof(DruhKvType)));
            cbPeriodType.Items.AddRange(Enum.GetNames(typeof(ItemChoiceType)));
        }

        private void CtrlIdentification_Load(object sender, EventArgs e)
        {
            this.origColorMandatory = txtIcDph.BackColor;
            this.origColorNoMandatory = txtPsc.BackColor;
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
            ShowNoProblems();
            var probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.IcDphPlatitela) || p.ProblemObject.ToString() == "<icdph>") ).ToList();
            if (probs.Count > 0)
                SetProblems(txtIcDph, probs);

            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.Nazov) || p.ProblemObject.ToString() == "<nazov>")).ToList();
            if (probs.Count > 0)
                SetProblems(txtName, probs);

            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.GetType() == typeof(DruhKvType)).ToList();
            if (probs.Count > 0)
                SetProblems(cbKind, probs);

            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject == identification.Obdobie || p.ProblemObject.ToString() == "<obdobie>")).ToList();
            if (probs.Count > 0)
            {
                SetProblems(txtPeriod, probs);
                SetProblems(cbPeriodType, probs);
                SetProblems(txtYear, probs);
            }
            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.Obdobie.Item) || p.ProblemObject.ToString() == "<period>")).ToList();
            if (probs.Count > 0)
                SetProblems(txtPeriod, probs);
            probs = problems.Where(p => p.ProblemObject != null && p.ProblemObject.Equals(identification.Obdobie.ItemElementName)).ToList();
            if (probs.Count > 0)
                SetProblems(cbPeriodType, probs);
            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.Obdobie.Rok) || p.ProblemObject.ToString() == "<rok>")).ToList();
            if (probs.Count > 0)
                SetProblems(txtYear, probs);

            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.Stat) || p.ProblemObject.ToString() == "<stat>")).ToList();
            if (probs.Count > 0)
                SetProblems(txtState, probs);

            probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.Obec) || p.ProblemObject.ToString() == "<obec>")).ToList();
            if (probs.Count > 0)
                SetProblems(txtCity, probs);
        }

        private void SetProblems(Control ctrl, List<IValidationItemResult> probs)
        {
            if (probs.Any(i => i.ValidationResultState == ResultState.OkWithWarning))
                ctrl.BackColor = Color.Orange;
            else
                ctrl.BackColor = Color.FromArgb(255, 128, 128);

            if (probs.Count > 0)
                new ToolTip().SetToolTip(ctrl, string.Join(Environment.NewLine, probs.Select(ir => ir.ResultMessage + " - " + ir.ResultTooltip).ToArray()));
        }

        public void SetData(Identifikacia data, bool noProblem)
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

            if (noProblem)
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
            txtIcDph.BackColor = origColorMandatory;
            cbKind.BackColor = origColorMandatory;
            txtPeriod.BackColor = origColorMandatory;
            cbPeriodType.BackColor = origColorMandatory;
            txtYear.BackColor = origColorMandatory;
            txtName.BackColor = origColorMandatory;
            txtState.BackColor = origColorMandatory;
            txtCity.BackColor = origColorMandatory;
            txteMail.BackColor = origColorNoMandatory;
            txtPhone.BackColor = origColorNoMandatory;
            txtPsc.BackColor = origColorNoMandatory;
            txtAddress.BackColor = origColorNoMandatory;
        }
    }
}
