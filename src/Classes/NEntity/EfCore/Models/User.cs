using System;
using System.Collections.Generic;

#nullable disable

namespace EfCore.Models
{
    public partial class User
    {
        public decimal IdUser { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
