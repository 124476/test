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
    /// Логика взаимодействия для OpenDoctor.xaml
    /// </summary>
    public partial class OpenDoctor : Page
    {
        public OpenDoctor()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = App.DB.Doctor.FirstOrDefault(x => x.Surname == Login.Text);
            if (doctor != null)
            {
                NavigationService.Navigate(new OknoDoctor());
            }
            else
            {
                MessageBox.Show("Такой пациент не найден!");
            }
        }
    }
}
