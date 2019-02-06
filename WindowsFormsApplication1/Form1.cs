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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        string[] coustomerName = new string[10];
        string[] contactNo = new string[10];
        string[] address = new string[10];
        string[] order = new string[10];
        string[] quantity = new string[10];
        //string[] totalPrices = new string[10];
        double[] totalPrices = new double[10];

        int i = 0;
        private void DisplayAllButton_Click(object sender, EventArgs e)
        {
            try
            {
            

             //string coustomerNamess = coustomerNameTextBox.Text;
             //for (int m = 0; m < 7; m++)
            // {coustomerNameColne[m] = coustomerNamess[m] }
           
            coustomerName[i] = coustomerNameTextBox.Text;
            contactNo[i] = contactNoTextBox.Text;
            address[i] = addressTextBox.Text;
            order[i] = orderComboBox.Text;
            quantity[i] = quantityTextBox.Text;

            if (coustomerName[i] == "" || contactNo[i] == "" || address[i] == "" || order[i] == "" || quantity[i] == "")
            {
                MessageBox.Show("Plase fill out field.");
            }
            //for (int a = i; a == i; a--)

                //int priceTemp;

                //  totalPrices[i] = totalPriceLabel.Text;

                //int qty = Convert.ToInt32(quantityTextBox.Text);
            else
            {
                int qty = Convert.ToInt32(quantity[i]);
                if (order[i] == "Math")
                {
                    totalPrices[i] = qty * 120;
                    //priceTemp = Convert.ToInt32(quantityTextBox.Text) * 120;
                }
                else if (order[i] == "English")
                {
                    totalPrices[i] = qty * 100;
                    //priceTemp = Convert.ToInt32(quantityTextBox.Text) * 100;
                }
                else if (order[i] == "Bangla")
                {
                    totalPrices[i] = qty * 90;
                   // priceTemp = Convert.ToInt32(quantityTextBox.Text) * 90;
                }
                else if (order[i] == "Art")
                {
                    totalPrices[i] = qty * 80;
                   // priceTemp = Convert.ToInt32(quantityTextBox.Text) * 80;
                }
                i++;
                richTextBox.Text = "";
                for (int j = 0; j <i; j++)
                   // priceTemp = 0;
               // totalPrices[a] = Convert.ToString(priceTemp);
                richTextBox.Text = richTextBox.Text + " \n " + "\t\t\tCustomer Information" +
              " " +
              "\n\n\tCoustomer Name: " + coustomerName[j] +
              "\n " + "\n\tContact No: " + contactNo[j] +
              "\n " + "\n\tAddress: " + address[j] +
              "\n " + "\n\tOrder: " + order[j] +
              "\n " + "\n\tQuantity: " + quantity[j] +
              "\n " + "\n\tTotal Price: " + totalPrices[j];
            }
           // i++;
            
        }
        catch (Exception arr)
    {
        MessageBox.Show(arr.Message);
    }
        }
 
    }
}
