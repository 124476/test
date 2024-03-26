using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skor_Reg_2024_3.Models
{
    public partial class Doctor
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
