namespace GalletaFortuna
{
    public partial class Galleta : Form
    {
        public Galleta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fortunas = { "No te tomes la vida demasiado en serio. No saldrás de ella con vida.", "Si comes algo y nadie te ve comerlo, no tiene calorías.",
            "No renuncies a tus sueños... Sigue durmiendo.", "Es una locura amar, a menos de que se ame con locura.", "Tu amor a la música será una parte importante de tu vida."};

            Random random = new Random();
            int index = random.Next(0, fortunas.Length);
            mensaje.Text = fortunas[index];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}