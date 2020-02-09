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
    public partial class Add_Car_Rental : Form
    {
        private readonly CarRentalDB5Entities CarRentalDB5Entities1;

        public Add_Car_Rental()
        {
            InitializeComponent();
            CarRentalDB5Entities1 = new CarRentalDB5Entities();



        }



        private void label_Submit_Click(object sender, EventArgs e)
        {// Long / Old way of displaying multiple items in a text box
            /*  MessageBox.Show($"Thank You !!!!!  Your Rental Submission was Successful Mr/Mrs. :  {TB_Customer.Text}.  " +
                  $"The Car You selected is:  {CB_Car_List.Text}  " +
                  $"The Car Owner is: {TB_Owners.Text}  " +
                  $"The Rentals date is from the:  {DateRented.Text}  " +
                  $"Until {Date_Returned.Text}.  " +
                  $" The transaction ID is: {TB_ID.Text}.  ");*/

            var customerName = TB_Customer.Text;
            var ownerName = TB_Owners_Name.Text;
            var dateout = DateRented.Value;
            var dateIn = Date_Returned.Value;
            var ID = TB_ID.Text;
            var carBrand = CB_Car_List.SelectedItem.ToString();
            double cost = Convert.ToDouble(TB_Cost.Text);
            var isValid = true;


            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carBrand))
            {
                isValid = false;

                MessageBox.Show("Please enter missing fields");
            }
            if (dateout > dateIn)
            {
                isValid = false;

                MessageBox.Show("The Date u Selected is Invalid");
            }
            if (isValid)
            {
                var rentalRecords = new CarRentalDB5Entities();
                
               

                MessageBox.Show($"Thank You For Choseing McIntosh Rentals Mr / Mrs. : {customerName}\n\r" +
                    $"The Car You selected is: { carBrand}\n\r" +
                    $"The Car Owner is: {ownerName}\n\r" +
                    $"Rental date Starts: {dateout}\n\r" +
                    $"Rental Date Ends: {dateIn}\n\r" +
                    $"Rental Cost is :{cost}\n\r" +
                    $"Transaction Id#: {ID}\n\r" +
                    $"Thank You For Choseing  McIntosh Rentals!!!!!!!!!!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = CarRentalDB5Entities1.Type_Of_Car.ToList();
            CB_Car_List.DisplayMember = "Name";
            CB_Car_List.ValueMember = "ID";
            CB_Car_List.DataSource = cars;
        }

        private void Lunch_Window_Click(object sender, EventArgs e)
        {

            Main_Window mainWindow = new Main_Window();
            //display object created
            mainWindow.Show();

                 
        }

    }
}

