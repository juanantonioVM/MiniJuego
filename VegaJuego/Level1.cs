using System.Diagnostics;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarPersonajes()
        {
            //Lienzo, coordenaX, coordenaY, salud, escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
            Debug.WriteLine("[X" + Player.Caja.Location.X + " ,Y" + Player.Caja.Location.Y + "]");
        }
    }
}