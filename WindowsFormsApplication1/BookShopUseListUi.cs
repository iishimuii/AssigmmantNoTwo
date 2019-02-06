using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BookShopUseListUi : Form
    {
        public BookShopUseListUi()
        {
            InitializeComponent();
        }

        private void C_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string coustomerName = coustomerNameTextBox.Text;
            string contactNo = contactNoTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            string quantity = quantityTextBox.Text;
            int totalPrices ;

            int qty = Convert.ToInt32(quantityTextBox.Text);

            if (orderComboBox.Text == "Math")
            {          
                totalPrices = qty * 120;           
            }
            else if (orderComboBox.Text == "English")
            {      
                totalPrices = qty * 100;             
            }
            else if (orderComboBox.Text == "Bangla")
            {
            totalPrices = qty * 90;            
            }
            else if (orderComboBox.Text == "Art")
            {            
                totalPrices = qty * 80;         
            }
            else
                totalPrices = 0;

    
           richTextBox.Text ="\t\t\tCustomer Information"+
               "\t\t\t____________________________"+
               "\n\n\tCoustomer Name: " + coustomerName +
               "\n " + "\n\tContact No: " + contactNo +
               "\n " + "\n\tAddress: " + address +
               "\n " + "\n\tOrder: " + order +
               "\n " + "\n\tQuantity: " + quantity +
               "\n " + "\n\tTotal Price: " + totalPrices;  
        }


        List<string> coustomerName = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<string> quantity = new List<string>();
        List<double> totalPrices = new List<double>();

       // string[] coustomerName = new string[10];
        //string[] contactNo = new string[10];
        //string[] address = new string[10];
       // string[] order = new string[10];
       // string[] quantity = new string[10];
               //string[] totalPrices = new string[10];
        //double[] totalPrices = new double[10];

        int i = 0;
        private void DisplayAllButton_Click(object sender, EventArgs e)
        {


            /* coustomerName[i] = coustomerNameTextBox.Text;
             contactNo[i] = contactNoTextBox.Text;
             address[i] = addressTextBox.Text;
             order[i] = orderComboBox.Text;
             quantity[i] = quantityTextBox.Text;*/
            //int priceTemp;
            //totalPrices.Add(totalPriceLabel.Text);
            //totalPrices[i] = totalPriceLabel.Text;

            // int qty = Convert.ToInt32(quantityTextBox.Text);
            // for (int a = i; a == i; a--)
            {
                if (coustomerName.Contains(coustomerNameTextBox.Text) || contactNoTextBox.Text.Length != 11)
                {
                    if (coustomerName.Contains(coustomerNameTextBox.Text))
                        MessageBox.Show(" This Coustomer name is already Exist");
                    else
                        MessageBox.Show("Please Enter 11 Digits");
                }



                else
                {
                    coustomerName.Add(coustomerNameTextBox.Text);
                    contactNo.Add(contactNoTextBox.Text);
                    address.Add(addressTextBox.Text);
                    order.Add(orderComboBox.Text);
                    quantity.Add(quantityTextBox.Text);
                    for (int a = i; a == i; a--)
                    { 
                        //int qty = Convert.ToInt32(quantity);
                        //int qty = Convert.ToInt32(quantityTextBox.Text);
                        if (orderComboBox.Text == "Math")
                        {
                            totalPrices.Add(Convert.ToInt32(quantityTextBox.Text) * 120);
                            //totalPrices = qty * 120;
                            //priceTemp = Convert.ToInt32(quantityTextBox.Text) * 120;
                        }
                        else if (orderComboBox.Text == "English")
                        {
                            totalPrices.Add(Convert.ToInt32(quantityTextBox.Text) * 100);
                            // totalPrices = qty * 100;
                            // priceTemp = Convert.ToInt32(quantityTextBox.Text) * 100;
                        }
                        else if (orderComboBox.Text == "Bangla")
                        {
                            totalPrices.Add(Convert.ToInt32(quantityTextBox.Text) * 90);
                            // totalPrices[i] = qty * 90;
                            // priceTemp = Convert.ToInt32(quantityTextBox.Text) * 90;
                        }
                        else if (orderComboBox.Text == "Art")
                        {
                            totalPrices.Add(Convert.ToInt32(quantityTextBox.Text) * 80);
                            // totalPrices[i] = qty * 80;
                            //priceTemp = Convert.ToInt32(quantityTextBox.Text) * 80;
                        }
                        else
                            totalPrices.Add(Convert.ToInt32(""));

                    // richTextBox.Text = "";
                    //for (int j = 0; j < i; j++)
                    // priceTemp = 0;
                    // totalPrices[a] = Convert.ToString(priceTemp);

                    richTextBox.Text = richTextBox.Text + " \n " + "\t\t\tCustomer Information" +
                  " " +
                  "\n\n\tCoustomer Name: " + coustomerName[a] +
                  "\n " + "\n\tContact No: " + contactNo[a] +
                  "\n " + "\n\tAddress: " + address[a] +
                  "\n " + "\n\tOrder: " + order[a] +
                  "\n " + "\n\tQuantity: " + quantity[a] +
                  "\n " + "\n\tTotal Price: " + totalPrices[a];
                    }
                }
                i++;
            }
        }
    }
}
