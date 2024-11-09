using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace DotNetCore.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public string UserId { get; set; }
        public int StokcId { get; set; }
        public User User { get; set; }
        public Stock Stock { get; set; }
    }
}