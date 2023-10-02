using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public partial class MathForm : Form
    {
        public MathForm()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxOperadores.Text)
                {
                    case ">":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) > Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case "<":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) < Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case ">=":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) >= Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case "<=":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) <= Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case "==":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) == Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case "!=":
                        BoxResult.Text = Convert.ToInt64(BoxN1.Text) != Convert.ToInt64(BoxN2.Text) ? "true" : "false";
                        break;
                    case "+":
                        BoxResult.Text = Convert.ToString(Convert.ToDouble(BoxN1.Text) + Convert.ToDouble(BoxN2.Text));
                        break;
                    case "-":
                        BoxResult.Text = Convert.ToString(Convert.ToDouble(BoxN1.Text) - Convert.ToDouble(BoxN2.Text));
                        break;
                    case "*":
                        BoxResult.Text = Convert.ToString(Convert.ToDouble(BoxN1.Text) * Convert.ToDouble(BoxN2.Text));
                        break;
                    case "/":
                        BoxResult.Text = Convert.ToString(Convert.ToDouble(BoxN1.Text) / Convert.ToDouble(BoxN2.Text));
                        break;
                    case "PI":
                        BoxResult.Text = Convert.ToString(Math.PI);
                        break;
                    case "POW":
                        BoxResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)));
                        break;
                    case "LOG":
                        BoxResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)));
                        break;
                    case "MIN":
                        BoxResult.Text = Convert.ToString(Math.Min(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)));
                        break;
                    case "MAX":
                        BoxResult.Text = Convert.ToString(Math.Max(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)));
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los campos.");
            }
        }

        private void BoxN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BoxN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void boxOperadores_TextChanged(object sender, EventArgs e)
        {
            if (boxOperadores.Text == "PI")
            {
                label2.Visible = false;
                label3.Visible = false;
                BoxN1.Visible = false;
                BoxN2.Visible = false;
            }
            else
            {
                label2.Visible = true;
                label3.Visible = true;
                BoxN1.Visible = true;
                BoxN2.Visible = true;
            }
            BoxN1.Clear();
            BoxN2.Clear();
            BoxResult.Clear();
            btnCalcular.Enabled = true;
        }
    }
}