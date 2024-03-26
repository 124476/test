using Skor_Reg_2024_3.Models;
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

namespace Skor_Reg_2024_3.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPacient(new Pacient()));
        }

        private void GotBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GotPacient(true));
        }

        private void GosBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GotPacient(false));
        }

        private void NapBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OpenDoctor());
        }
    }
}
