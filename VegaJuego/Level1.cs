using System.Diagnostics;
using System.Media;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        SoundPlayer musica;
        Boolean HaySonido = false;
        public Level1(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa(onOff);
        }

        private void IniciarOpcionesDelMapa(CheckBox onOff)
        {
            if (onOff.Checked == true)
            {
                musica = new SoundPlayer(global::VegaJuego.Properties.Resources.sonido);
                musica.PlayLooping();
                HaySonido = true;
            }
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
        }

        private void IniciarPersonajes()
        {
            //Lienzo, coordenaX, coordenaY, salud, escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
            Debug.WriteLine("[X" + Player.Caja.Location.X + " ,Y" + Player.Caja.Location.Y + "]");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;

            if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                Player.Salud = Player.Salud - 1;
            }
            Enemigo1.mover();

            if (Player.Salud <= 0)
            {
                this.Hide();
                if (HaySonido == true)
                {
                    musica.Stop();
                }
                Final End = new Final();
                //Paramos el temporizador
                MovEnemigos.Stop();
                End.Show();
            }
        }

        private void Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}