//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class record
    {
        public int conf_id { get; set; }
        public int user_id { get; set; }
        public string topic { get; set; }
    
        public virtual cuser cuser { get; set; }
        public virtual Сonference Сonference { get; set; }
    }
}
