//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skor_Reg_2024_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gospital
    {
        public int Id { get; set; }
        public string Chel { get; set; }
        public Nullable<int> OtdelId { get; set; }
        public Nullable<int> YslovieId { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<bool> IsCan { get; set; }
        public string Prich { get; set; }
        public Nullable<int> PacientId { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
    
        public virtual Otdel Otdel { get; set; }
        public virtual Pacient Pacient { get; set; }
        public virtual Yslovie Yslovie { get; set; }
    }
}
