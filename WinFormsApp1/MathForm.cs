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
                double cal;
                //string result;
                switch (boxOperadores.Text)
                {
                    case ">":
                        if (Convert.ToInt16(BoxN1.Text) > Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
                        break;
                    case "<":
                        if (Convert.ToInt16(BoxN1.Text) < Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
                        break;
                    case ">=":
                        if (Convert.ToInt16(BoxN1.Text) >= Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
                        break;
                    case "<=":
                        if (Convert.ToInt16(BoxN1.Text) <= Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
                        break;
                    case "==":
                        if (Convert.ToInt16(BoxN1.Text) == Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
                        break;
                    case "!=":
                        if (Convert.ToInt16(BoxN1.Text) != Convert.ToInt16(BoxN2.Text))
                        {
                            BoxResult.Text = "true";
                        }
                        else { BoxResult.Text = "false"; }
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
                        //cal = Math.(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text));
                        //BoxResult.Text = Convert.ToString(cal);
                        //Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)
                        break;
                    case "POW":
                        cal = Math.Pow(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text));
                        BoxResult.Text = Convert.ToString(cal);
                        //Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)
                        break;
                    case "LOG":
                        cal = Math.Log(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text));
                        BoxResult.Text = Convert.ToString(cal);
                        //Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)
                        break;
                    case "MIN":
                        cal = Math.Min(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text));
                        BoxResult.Text = Convert.ToString(cal);
                        //Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)
                        break;
                    case "MAX":
                        cal = Math.Max(Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text));
                        BoxResult.Text = Convert.ToString(cal);
                        //Convert.ToDouble(BoxN1.Text), Convert.ToDouble(BoxN2.Text)
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Complete los campos.");
            }
        }

        private void BoxN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
            // solo 1 punto decimal
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
            // solo 1 punto decimal
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