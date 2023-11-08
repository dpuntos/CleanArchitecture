using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class Log : BaseEntity
    {
        public DateTime date { get; set; }
        public string? message { get; set; }
        public string? level { get; set; }
        public string? username { get; set; }
        public string? application { get; set; }
        public string? host { get; set; }
        public string? port { get; set; }
    }
}
