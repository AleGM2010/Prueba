using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugandoConWF_MVP_03.Presentador {
    class PersonaPresenter {

        private Modelo.Persona persona; // Como esta en otra carpeta , la busca en "Modelo".
        private IView view;
            
        public PersonaPresenter(IView view) {
            this.view = view;
            
              // El problema esta aca 
            this.view.mostrarDatos(persona.Nombre);
        }




    }
}
