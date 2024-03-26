using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using Skor_Reg_2024_3.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для GotPacient.xaml
    /// </summary>
    public partial class GotPacient : Page
    {
        bool IsGos;
        public GotPacient(bool isGos)
        {
            InitializeComponent();
            IsGos = isGos;
        }

        private void GotText_Click(object sender, RoutedEventArgs e)
        {
            Refrash();
        }

        private void Refrash()
        {
            Pacient pacient = App.DB.Pacient.FirstOrDefault(x => x.Id.ToString() == QrText.Text);
            if (pacient != null)
            {
                if (IsGos)
                {
                    NavigationService.Navigate(new RegisterPacient(pacient));
                }
                else
                {
                    NavigationService.Navigate(new GospitalPacient(pacient));
                }
            }
            else
            {
                MessageBox.Show("Такой пациент не найден!");
            }
        }

        private void GotQr_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = "*.png; | *.png;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var imageBytes = File.ReadAllBytes(dialog.FileName);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    var imageBitmap = new BitmapImage();
                    imageBitmap.BeginInit();
                    imageBitmap.StreamSource = ms;
                    imageBitmap.CacheOption = BitmapCacheOption.OnLoad;
                    imageBitmap.EndInit();

                    using(MemoryStream mss = new MemoryStream(imageBytes))
                    {
                        QRCodeDecoder decoder = new QRCodeDecoder();
                        Bitmap bitmap = new Bitmap(mss);
                        QrText.Text = decoder.Decode(new QRCodeBitmapImage(bitmap));
                        Refrash();
                    }
                }
            }
        }
    }
}
