//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conference
{
    using System;
    using System.Collections.Generic;
    
    public partial class records
    {
        public int conf_id { get; set; }
        public int user_id { get; set; }
        public string topic { get; set; }
    
        public virtual conf conf { get; set; }
        public virtual users users { get; set; }
    }
}
