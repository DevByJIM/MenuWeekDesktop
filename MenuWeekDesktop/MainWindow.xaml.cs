using Capa_Logica;
using MenuWeekDesktop.Paginas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuWeekDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmMain.Navigate(new pg_Portada());
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = Cls_Usuarios.listadoUsuarios();
        }


        private void btnBarra(object sender, RoutedEventArgs e)
        {
            foreach (ToggleButton btn in gridBarra.Children) btn.IsChecked = false;
            ((ToggleButton)sender).IsChecked = true;

            switch (((ToggleButton)sender).Name)
            {
                case "btnPortada":
                    frmMain.Navigate(new pg_Portada());
                    break;
                case "btnUsuarios":
                    frmMain.Navigate(new pg_Usuarios());
                    break;
                case "btnPlatos":
                    frmMain.Navigate(new pg_Platos());
                    break;
                case "btnIngredientes":
                    frmMain.Navigate(new pg_Ingredientes());
                    break;
                case "btnListas":
                    frmMain.Navigate(new pg_ListaCompra());
                    break;
            }
        }


        private void AjusteFuentes(object sender, SizeChangedEventArgs e)
        {
            lbTitulo.FontSize = this.ActualHeight * 0.1;

            foreach(ToggleButton btn in gridBarra.Children)
            {
                btn.FontSize = this.ActualHeight * 0.026;
            }
        }
    }
}
