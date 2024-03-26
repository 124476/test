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
    /// Логика взаимодействия для GospitalPacient.xaml
    /// </summary>
    public partial class GospitalPacient : Page
    {
        Gospital gospital;
        public GospitalPacient(Pacient pacient)
        {
            InitializeComponent();
            gospital = App.DB.Gospital.FirstOrDefault(x => x.Pacient.Id == pacient.Id);
            if (gospital == null)
            {
                gospital = new Gospital();
                gospital.IsCan = false;
                gospital.Pacient = pacient;
            }

            if (gospital.IsCan == false)
            {
                StackPrich.Visibility = Visibility.Hidden;
            }
            else
            {
                StackPrich.Visibility = Visibility.Visible;
            }
            ComboOtdels.ItemsSource = App.DB.Otdel.ToList();
            ComboYslovies.ItemsSource = App.DB.Yslovie.ToList();
            ComboDiagnozs.ItemsSource = App.DB.Diagnoz.ToList();
            DataContext = gospital;
        }

        private void CheckCan_Click(object sender, RoutedEventArgs e)
        {
            if (gospital.IsCan == false)
            {
                StackPrich.Visibility = Visibility.Hidden;
            }
            else
            {
                StackPrich.Visibility = Visibility.Visible;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (gospital.Chel != null && ComboDiagnozs.SelectedIndex != -1
                && ComboOtdels.SelectedIndex != -1 && ComboYslovies.SelectedIndex != -1
                && DateStart.SelectedDate != null && DateEnd.SelectedDate != null)
            {
                if (gospital.Id == 0)
                {
                    App.DB.Gospital.Add(gospital);
                }
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
