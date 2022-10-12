using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JugandoConWF_MVP_03.Presentador;

namespace JugandoConWF_MVP_03 {
    public partial class Form1 : Form , IView{
        PersonaPresenter personaPresentador = null;
        
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            personaPresentador = new PersonaPresenter(this); // El problema esta aca
        }

        void IView.mostrarDatos(string nombre) {lblNombre.Text = nombre;}

       
    }
}
