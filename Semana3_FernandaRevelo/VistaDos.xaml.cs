using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3_FernandaRevelo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaDos : ContentPage
    {
        public VistaDos(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;

        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double Seg1 = Convert.ToDouble(txtValorUno.Text);
                double examen1 = Convert.ToDouble(txtValorDos.Text);

                double Seg2 = Convert.ToDouble(txtValorTres.Text);
                double examen2 = Convert.ToDouble(txtValorCuatro.Text);

                //Operacion
                double parcial1 = (Seg1 * 0.3) + (examen1 * 0.2);
                double parcial2 = (Seg2 * 0.3) + (examen2 * 0.2);

                double final = parcial1 + parcial2;


                //Visualizacion el resultado en pantalla 
                txtResultado1.Text = parcial1.ToString();
                txtResultado2.Text = parcial2.ToString();
                txtFinal.Text = final.ToString();


                if (final >= 7)
                {
                    DisplayAlert("Resultado De Notas", "Aprobado", "Salir");
                }
                else if (final >= 5 && final <= 6.99)
                {
                    DisplayAlert("Resultado De Notas", "Complementario", "Salir");
                }
                else
                {
                    DisplayAlert("Resultado De Notas", "Reprobado", "Salir");
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje De Alerta", ex.Message, "Salir");
            }


        }
    }
}