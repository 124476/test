using Microsoft.Win32;
using Skor_Reg_2024_3.Models;
using Skor_Reg_2024_3.Windows;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для RegisterPacient.xaml
    /// </summary>
    public partial class RegisterPacient : Page
    {
        Pacient contextPacient;
        public RegisterPacient(Pacient pacient)
        {
            InitializeComponent();
            contextPacient = pacient;
            DataContext = pacient;
            if (contextPacient.Id == 0)
            {
                GotQr.Visibility = Visibility.Hidden;
            }
            ComboPols.ItemsSource = App.DB.Pol.ToList();
        }

        private void GotPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = "*.png; | *.png;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextPacient.Photo = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextPacient;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (contextPacient.Surname != null && contextPacient.Name != null && contextPacient.Otech != null
                && contextPacient.Phone != null && contextPacient.Adress != null && contextPacient.Email != null
                && contextPacient.Card != null && contextPacient.NumSeria != null && contextPacient.Polis != null
                && DateStart.SelectedDate != null && DateEnd.SelectedDate != null && DatePolis.SelectedDate != null
                && DateBorn.SelectedDate != null && DateNext.SelectedDate != null && ComboPols.SelectedIndex != -1)
            {
                if (contextPacient.Id == 0)
                {
                    App.DB.Pacient.Add(contextPacient);
                }
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void GotQr_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new QrOkno(contextPacient.Id.ToString());
            dialog.ShowDialog();
        }
    }
}
