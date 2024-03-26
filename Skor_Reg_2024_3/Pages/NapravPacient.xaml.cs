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
    /// Логика взаимодействия для NapravPacient.xaml
    /// </summary>
    public partial class NapravPacient : Page
    {
        Place place;
        public NapravPacient(Pacient pacient)
        {
            InitializeComponent();
            place = App.DB.Place.FirstOrDefault(x => x.Pacient.Id == pacient.Id);
            if (place == null)
            {
                place = new Place();
                place.Pacient = pacient;
            }

            ComboDoctors.ItemsSource = App.DB.Doctor.ToList();
            ComboResults.ItemsSource = App.DB.Result.ToList();
            ComboMeropriations.ItemsSource = App.DB.Meropriation.ToList();
            ComboTips.ItemsSource = App.DB.Tip.ToList();
            DataContext = place;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (ComboDoctors.SelectedIndex != -1 && ComboTips.SelectedIndex != -1
                && ComboResults.SelectedIndex != -1 && ComboMeropriations.SelectedIndex != -1
                && NapDate.SelectedDate != null)
            {
                if (place.Id == 0)
                {
                    App.DB.Place.Add(place);
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
