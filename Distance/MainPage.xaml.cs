namespace Distance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcularDistancia_Clicked(object sender, EventArgs e)
        {
            double ax = Convert.ToDouble(Ax.Text);
            double ay = Convert.ToDouble(Ay.Text);
            double az = Convert.ToDouble(Az.Text);

            double bx = Convert.ToDouble(Bx.Text);
            double by = Convert.ToDouble(By.Text);
            double bz = Convert.ToDouble(Bz.Text);

            double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(by - ay, 2));

            // lbResultado.Text = Convert.ToString(distance);
            lbResultado.Text = $"{distance:F4}";
            // lbResultado.Text = String.Format("{0;f2}");
        }
        private void btCalcularBhaskara_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double c = Convert.ToDouble(C.Text);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            lbResultadoX1.Text = $"{x1:F2}";
            lbResultadoX2.Text = $"{x2:F2}";
        }
    }
    }