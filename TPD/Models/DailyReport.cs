using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPD.Models
{

    public class DailyReport
    {
        public int Id { get; set; }
        [Required]
        public int WeatherId { get; set; }

        /*
        public ICollection<VendorSale> VendorSalesReport { get; set; }
        [Required]
        public ICollection<Ticket> TicketSalesReport { get; set; }
        [Required]
        public ICollection<AttractionVisit> AttractionVisitsReport { get; set; }
        public ICollection<Maintenance> MaintenanceList { get; set; }
        */
        [Required]
        public Weather Weather { get; set; }
    }
}