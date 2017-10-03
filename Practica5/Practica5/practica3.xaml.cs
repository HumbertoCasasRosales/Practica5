using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class practica3 : ContentPage
    {
        public practica3()
        {
            InitializeComponent();
        }

        private void mostrarDatos_Clicked(object sender, EventArgs e)
        {
            Datos.Text="Nombre:" + nom.Text + "\nApellidos:" + apellidos.Text + "\nDireccion:" + direcion.Text + "\nTelefono:" + telefono.Text + "\nDatos_Escolares\nCarrera:" + carrera.Text + "\nSemestre:" + semestre.Text + "\nMatricula:" + matricula.Text + "\nDatos_Sociales\nCorreo:" + correo.Text + "\nGitHub:" + git.Text +"";
        }

        private void siguiente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Practica5.Calculadora());
        }
    }
}