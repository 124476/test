using Skor_Reg_2024_3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Skor_Reg_2024_3
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Skor_SQL_2024_REG_2Entities DB = new Skor_SQL_2024_REG_2Entities();
    }
}
