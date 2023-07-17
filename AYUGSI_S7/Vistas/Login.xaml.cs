using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSI_S7.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        private SQLiteAsyncConnection con;
        public Login()
        {
            InitializeComponent();
            con = DependencyService.Get<database>().GetConnection();
        }

        public static IEnumerable<estudiante> select_where(SQLiteConnection db, string usuario, string contraseña)
        {
            return db.Query<estudiante>("select * from estudiante where Usuario = ? and Contraseña =?", usuario, contraseña);
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            try
            {
                var ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "base.db3");
                var db = new SQLiteConnection(ruta);
                db.CreateTable<estudiante>();
                IEnumerable<estudiante> resultado = select_where(db, txtUsusario.Text, txtContraseña.Text);
                if (resultado.Count() > 0)
                {
                    Navigation.PushAsync(new ConsultaRegistro());
                }
                else {
                    DisplayAlert("eroro", " incorecto", " cerrar");
                
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}