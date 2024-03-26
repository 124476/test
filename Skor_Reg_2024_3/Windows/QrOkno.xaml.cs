using MessagingToolkit.QRCode.Codec;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Skor_Reg_2024_3.Windows
{
    /// <summary>
    /// Логика взаимодействия для QrOkno.xaml
    /// </summary>
    public partial class QrOkno : Window
    {
        public QrOkno(string QrText)
        {
            InitializeComponent();
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap bitmap = encoder.Encode(QrText);
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Position = 0;

                var imageBitmap = new BitmapImage();
                imageBitmap.BeginInit();
                imageBitmap.StreamSource = ms;
                imageBitmap.CacheOption = BitmapCacheOption.OnLoad;
                imageBitmap.EndInit();

                QrI.Source = imageBitmap;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog() { Filter = "*.png; | *.png;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var file = File.Create(dialog.FileName);
                file.Close();

                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                BitmapSource bitmapSource = (BitmapSource)QrI.Source;
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
                using (MemoryStream ms = new MemoryStream())
                {
                    encoder.Save(ms);
                    File.WriteAllBytes(dialog.FileName, ms.ToArray());
                }
            }
        }
    }
}
