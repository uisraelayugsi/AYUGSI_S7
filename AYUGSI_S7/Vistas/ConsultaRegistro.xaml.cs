using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;

namespace AYUGSI_S7.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class ConsultaRegistro : ContentPage
    {
        private SQLiteAsyncConnection con;
        private ObservableCollection<estudiante> tabla;

        public ConsultaRegistro()
        {
            InitializeComponent();
            con = DependencyService.Get<database>().GetConnection();
           
        }
        public async void mostrar()
        {
            var resultado = await con.Table<estudiante>().ToListAsync();
            tabla = new ObservableCollection<estudiante>(resultado);
            listaEstudiantes.ItemsSource = tabla;




        }

        private void listaEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

          

        }

   
    }
}