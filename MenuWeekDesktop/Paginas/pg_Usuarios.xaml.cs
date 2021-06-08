using Capa_Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuWeekDesktop.Paginas
{
    /// <summary>
    /// Lógica de interacción para pg_Usuarios.xaml
    /// </summary>
    public partial class pg_Usuarios : Page
    {
        public pg_Usuarios()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgv_Usuarios.ItemsSource = Cls_Usuarios.listadoUsuarios().DefaultView;
        }

        private void AjusteFuentes(object sender, SizeChangedEventArgs e)
        {
            dgv_Usuarios.FontSize = this.ActualHeight * 0.03;
        }
    }
}
