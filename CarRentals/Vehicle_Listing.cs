using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentals
{
    public partial class Vehicle_Listing : Form
    {
        private readonly CarRentalDB5Entities _DB;

        public Vehicle_Listing()
        {
            InitializeComponent();
            _DB = new CarRentalDB5Entities();

        }
       
    }
}
