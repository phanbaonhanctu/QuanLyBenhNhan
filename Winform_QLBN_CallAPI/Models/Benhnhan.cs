using System;
using System.Collections.Generic;

namespace Winform_QLBN.Models
{
    internal class Benhnhan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public string? Ppdt { get; set; }
    }
}
