using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AxelSemana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string contrasena)
        {
            InitializeComponent();
            
            //envio a los label
            lbUsuario.Text = "Bienvenido Usuario: " + usuario;
            //lbContrasena.Text = contrasena;
            //envio cajas de texto
            //txtUsuario.Text = usuario;
            //txtContrasena.Text = contrasena;
        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                if (dato1 > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                    txtDato1.Text = "";

                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }

        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato2 = Convert.ToDouble(txtDato2.Text);
                if (dato2 > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                    txtDato2.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }

        }

        private void txtDato4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato4 = Convert.ToDouble(txtDato4.Text);
                if (dato4 > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                    txtDato4.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }

        }

        private void txtDato5_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                double dato5 = Convert.ToDouble(txtDato5.Text);
                if (dato5 > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos mayores a 10", "OK");
                    txtDato5.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }

        }

        private void btnPromedio_Clicked(object sender, EventArgs e)
        {
            try //almacenar en variables lo que el usuario ingresa en las cajas de texto
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);


                double promedio1 = dato1 * 0.3 + dato2 * 0.2;

                txtDato3.Text = Convert.ToString(promedio1);

                double dato4 = Convert.ToDouble(txtDato4.Text);
                double dato5 = Convert.ToDouble(txtDato5.Text);


                double promedio2 = dato4 * 0.3 + dato5 * 0.2;

                txtDato6.Text = Convert.ToString(promedio2);

                double promedioFinal = promedio1 + promedio2;
                txtResultado.Text = Convert.ToString(promedioFinal);



            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
            double final = Convert.ToDouble(txtResultado.Text);
            if (final >= 7)
            {
                DisplayAlert("Mensaje de Alerta", "Estudiante aprobado", "OK");
            }
            else if (final >= 5 && final <= 6.9)
            {
                DisplayAlert("Mensaje de Alerta", "Estudiante se queda a examen complementario", "OK");

            }
            else
            {
                DisplayAlert("Mensaje de Alerta", "Estudiante No aprobado", "OK");

            }

        }
    }
}