using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_Net
{
    public class Rental
    {
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal RentalAmount { get; set; }
    }
}
