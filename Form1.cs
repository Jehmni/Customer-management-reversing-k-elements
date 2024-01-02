using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Task_b;

namespace task1_c
{
    public partial class Form1 : Form
    {
        private CustomerQueue customerQueue = new CustomerQueue(); // Creates an instance of the CustomerQueue

        public Form1()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim(); // Get the name entered by the user
            int age = int.Parse(txtAge.Text.Trim()); // Get the age entered by the user

            if (name.Length > 0 && age != 0)
            {
                // Checks that a valid name and age were entered
                try
                {
                    customerQueue.Enqueue(name, age); // Call the Enqueue method of CustomerQueue to add the customer
                    UpdateListBox(); // Update the listbox to display the updated queue
                    MessageBox.Show($"Added customer {name} to the database");
                    txtName.Clear();
                    txtAge.Clear();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Customer add: operation failed");
                }
            }
            else
            {
                MessageBox.Show("Please enter a customer's name and age");
            }
            txtName.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = customerQueue.Dequeue(); // Call the Dequeue method of CustomerQueue to remove the customer
                UpdateListBox(); // Update the listbox to display the updated queue
                MessageBox.Show($"Customer with details - {name} deleted from database");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No customer in the database");
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                int k = int.Parse(txtReverse.Text.Trim()); // Get the value of 'k' entered by the user
                customerQueue.Reverse(k); // Reverse the first 'k' elements of the queue
                UpdateListBox(); // Update the listbox to display the updated queue
                label2.Text = k + " Customer details reversed";
                txtReverse.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void UpdateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = customerQueue.GetQueue(); // Calls the GetQueue method of CustomerQueue to populate the listbox
            count.Text = "Number of customers: " + customerQueue.Count().ToString(); // Update the count label
        }
    }
}
