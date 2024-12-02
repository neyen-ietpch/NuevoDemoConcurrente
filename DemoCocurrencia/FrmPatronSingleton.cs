using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCocurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConeccion = Singleton.Intancia;
            cadenaConeccion.cadenaconeccion = TxtCadenaConeccion.Text;
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConeccion = Singleton.Intancia;
            LblCadenaConeccionRecuperar.Text = cadenaConeccion.cadenaconeccion;
        }
    }
}
