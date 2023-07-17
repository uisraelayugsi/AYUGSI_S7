using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace AYUGSI_S7.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<database>().GetConnection();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {

            try
            {
                var datosRegistro = new estudiante { Nombre = txtNombre.Text, Usuario = txtUsusario.Text, Contraseña = txtContraseña.Text };
                con.InsertAsync(datosRegistro);
                Navigation.PushAsync(new Login());

            }
            catch (Exception ex )
            {

                DisplayAlert("ERROR",ex.Message, " cerrar");
            }
        }
    }
}