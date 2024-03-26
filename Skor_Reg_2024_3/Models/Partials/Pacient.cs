using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skor_Reg_2024_3.Models
{
    public partial class Pacient
    {
        public string FullName
        {
            get
            {
                return Surname + " " + Name;
            }
        }
    }
}
