using System.Diagnostics.Eventing.Reader;

namespace Pag13Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cmbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int result = 0;


            if (cmbOp.Text == "+")
            {
                result = n2 + n1;

            }

            else if (cmbOp.Text == "-")
            {

                result = n2 - n1;

            }


            if (cmbOp.Text == "x")
            {

                result = n1 * n2;

            }

            else
            {
                if (txtNum1.Text == "0" || txtNum2.Text == "0")
                {
                    result = n1 / n2;
                }
            }

            txtResult.Text = result.ToString();
        }
    }
}
