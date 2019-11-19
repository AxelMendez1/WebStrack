using System;
using System.Collections.Generic;

namespace WebStrack.Models
{
    public partial class Students
    {
        public int StudentId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
    }
}
