using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.Entities
{
    public class WasteConsumer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string First_Name { get; set; }

        [StringLength(100)]
        public string Last_Name { get; set; }

        public long Phone_No { get; set; }

        public DateTime Purchased_at { get; set; }

    }
}
