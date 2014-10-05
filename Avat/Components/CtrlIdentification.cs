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
        Action<string> progress;
        Action<string> icDphChanged;

        public CtrlIdentification()
        {
            InitializeComponent();

            //cbKind.Items.AddRange(Enum.GetNames(typeof(DruhKvType)));
            cbKind.Items.AddRange(GetKindNames());
            cbPeriodType.Items.AddRange(Enum.GetNames(typeof(ItemChoiceType)));
        }

        string[] GetKindNames()
        {
            return new string[] { GetKindText(DruhKvType.X), GetKindText(DruhKvType.R), GetKindText(DruhKvType.O), GetKindText(DruhKvType.D) };
        }

        string GetKindText(DruhKvType type)
        {
            switch (type)
            {
                case DruhKvType.X:
                    return string.Empty;
                case DruhKvType.R:
                    return "Riadny";
                case DruhKvType.O:
                    return "Opravný";
                case DruhKvType.D:
                    return "Dodatočný";
                default:
                    break;
            }

            return Enum.GetName(typeof(DruhKvType), type);
        }

        DruhKvType GetSelectedKind()
        {
            var si = cbKind.SelectedIndex;
            if (si == 0)
                return DruhKvType.X;
            if (si == 1)
                return DruhKvType.R;
            if (si == 2)
                return DruhKvType.O;
            if (si == 3)
                return DruhKvType.D;

            return DruhKvType.X;
        }

        public CtrlIdentification(Action<string> progressListener, Action<string> icDphChanged)
            : this()
        {
            this.progress = progressListener;
            this.icDphChanged = icDphChanged;
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
            
            var probs = problems.Where(p => p.ProblemObject != null && (p.ProblemObject.Equals(identification.IcDphPlatitela) || p.ProblemObject.ToString() == "<icdph>")).ToList();
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

        internal bool HasProblems { get; set; }

        private void SetProblems(Control ctrl, List<IValidationItemResult> probs)
        {
            HasProblems = true;

            if (probs.Any(i => i.ValidationResultState == ResultState.OkWithWarning))
                ctrl.BackColor = MyColors.Yellow;//Color.Orange;
            else
                ctrl.BackColor = Color.Red;//FromArgb(255, 128, 128);

            ctrl.Tag = string.Empty;
            if (probs.Count > 0)
            {
                var tt = new ToolTip();
                tt.AutoPopDelay = 30000;
                var text = string.Join(Environment.NewLine, probs.Select(ir => ir.ResultMessage + " - " + ir.ResultTooltip).ToArray());
                tt.SetToolTip(ctrl, text);
                ctrl.Tag = text;
            }
        }

        public void SetData(Identifikacia data, bool noProblem)
        {
            this.identification = data;

            txtIcDph.Text = data.IcDphPlatitela;
            cbKind.Text = GetKindText(data.Druh);
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
            try
            {
                this.identification.Druh = GetSelectedKind();//(DruhKvType)Enum.Parse(typeof(DruhKvType), cbKind.Text);
            }
            catch (Exception)
            {
                this.identification.Druh = DruhKvType.X;
            }
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

        public void ShowNoProblems()
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

            foreach (Control c in Controls)
                c.Tag = string.Empty;
        }

        private void panelPeriod_Enter(object sender, EventArgs e)
        {
            if (progress == null)
                return;

            var c = sender as Control;
            var tt = (c.Tag ?? "").ToString();
            progress(tt);
        }

        private void txtIcDph_TextChanged(object sender, EventArgs e)
        {
            if (icDphChanged != null)
            {
                var text = txtIcDph.Text;

                var found = Common.GetTaxPayer(txtIcDph.Text.Trim());
                if (found != null)
                    text = string.Format("{0}  -  DIC: {1}  -  {2}  -  {3}", found.Nazov, txtIcDph.Text.Trim(), cbKind.Text, FormatPeriod());
                else if (txtIcDph.Text.Trim().Length > 0)
                    text = string.Format("DIC: {0}  -  {1}  -  {2}", txtIcDph.Text.Trim(), cbKind.Text, FormatPeriod());
                else
                    text = string.Format("{0}  -  {1}", cbKind.Text, FormatPeriod());

                icDphChanged(text);
            }
        }

        private string FormatPeriod()
        {
            var obd = string.Empty;
            if (cbPeriodType.SelectedIndex == 1 && txtPeriod.Value > 0 && txtPeriod.Value < 13)
                obd = Application.CurrentCulture.DateTimeFormat.GetMonthName((int)txtPeriod.Value) + " ";
            else if (cbPeriodType.SelectedIndex == 2 && txtPeriod.Value > 0 && txtPeriod.Value < 5)
                obd = txtPeriod.Value.ToString() + ". štvrťrok ";

            return string.Format("{0}{1}", obd, txtYear.Value);
        }
    }
}
