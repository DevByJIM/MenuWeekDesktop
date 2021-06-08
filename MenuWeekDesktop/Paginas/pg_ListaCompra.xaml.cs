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
    /// Lógica de interacción para pg_ListaCompra.xaml
    /// </summary>
    public partial class pg_ListaCompra : Page
    {
        public pg_ListaCompra()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgv_ListaCompra.ItemsSource = Cls_ListaCompra.listadoListaCompra().DefaultView;
        }

        private void AjusteFuentes(object sender, SizeChangedEventArgs e)
        {
            dgv_ListaCompra.FontSize = this.ActualHeight * 0.02;
        }
    
    }
}
