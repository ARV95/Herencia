using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 01;
            heroe1.Nombre = "Superman";
            heroe1.Poderes = "Super fuerza";

            var heroe2 = new Heroe();
            heroe2.Id = 01;
            heroe2.Nombre = "Batman";
            heroe2.Poderes = "Sin poder";

            var heroe3 = new Heroe();
            heroe3.Id = 01;
            heroe3.Nombre = " Flash ";
            heroe3.Poderes = "Velocidad";

            var villano1 = new Villano();
            villano1.Id = 02;
            villano1.Nombre = " Ultron ";
            villano1.Poderes = " Control mental ";

            var villano2 = new Villano();
            villano2.Id = 02;
            villano2.Nombre = "Darkseid";
            villano2.Poderes = " Inteligencia sobrenatural ";

            var villano3 = new Villano();
            villano3.Id = 02;
            villano3.Nombre = " Dormammu";
            villano3.Poderes = " Inmortal y teletransportacion";


        }
    }
}
