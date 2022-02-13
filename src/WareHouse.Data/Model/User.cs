using System;
using System.Collections.Generic;

namespace WareHouse.Data.Model
{
    public partial class User
    {
        public int IdUsers { get; set; }
        public string LoginUser { get; set; } = null!;
        public string PasswordUser { get; set; } = null!;
    }
}
