//author: Aaron Kim
//purpose: to make a cash register to calculate the total, and print a receipt of the order
//sept,29/2021


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
            
    public partial class SushiDojo : Form
    {
        //declare a number value into variable    
        double Cprice = 4.75;
        double Sprice = 5.25;
        double ACprice = 4.25;

        double tax = 0.13;
        double taxofitem;
        //declare a global variable to store information
        double cali;
        double scali;
        double avocuc;
        //declare variable for the subtotal of each price 
        double subtotalC;
        double subtotalS;
        double subtotalAC;
        double subtotal;

        double total;

        double tendered;
        double change;
        //global variable for the sound player
        SoundPlayer alertplayer = new SoundPlayer(Properties.Resources.printer);
        SoundPlayer chaching = new SoundPlayer(Properties.Resources.chaching);
        
        public SushiDojo()
        {
            InitializeComponent();
        }


           
        private void button1_Click(object sender, EventArgs e)
        {
            //tries this code 
            try {
                //makes the textbox into a numbered value text box
                cali = Convert.ToInt32(caliRollText.Text);
                scali = Convert.ToInt32(sCaliRollText.Text);
                avocuc = Convert.ToInt32(avoCucRollText.Text);
                //finds the price of each item
                subtotalC = cali * Cprice;
                subtotalS = scali * Sprice;
                subtotalAC = avocuc * ACprice;
                subtotal = subtotalAC + subtotalC + subtotalS;
                //finds the tax of the item
                taxofitem = subtotal * tax;
                //finds the final price
                total = taxofitem + subtotal;
                //writes subtotal, tax, total value on program
                subtotalPriceLabel.Text = $"{subtotal.ToString("C")}";
                taxPriceLabel.Text = $"{taxofitem.ToString("C")}";
                totalPriceLabel.Text = $"{total.ToString("C")}";
            }
           //if code doesn't work in the try section, catch and release the value below
            catch
            {
                subtotalPriceLabel.Text = "Input Error, Try Again";
            }
            //makes the label and buttons visible
            subTotalLabel.Visible = true;
            taxLabel.Visible = true;
            totalLabel.Visible = true;
            tenderedLabel.Visible = true;
            tenderedText.Visible = true;
            tenderedButton.Visible = true;
            tenderedButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToInt32(tenderedText.Text);

            change = tendered - total;

            changePriceLabel.Text = $"{change.ToString("C")}";
           
            changeLabel.Visible = true;
            changePriceLabel.Visible = true;
            receiptButton.Visible = true;
            receiptButton.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printedReceiptLabel.Visible = true;
            //turns sound player on
            alertplayer.Play();
            //prints on program Sushi Dojo
            printedReceiptLabel.Text = $"\n\n                          The Sushi Dojo";
            //refreshes and waits for 1 second
            Refresh();
            Thread.Sleep(1000);
            
            alertplayer.Play();

            printedReceiptLabel.Text += $"\n\n   Order Number #1724";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   September 29, 2021";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n\n   California Roll                                 x{cali} @ {Cprice}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   Spicy California Roll                        x{scali} @ {Sprice}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   Avocado and Cucumber Roll           x{avocuc} @ {ACprice}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n\n   Subtotal                                                {subtotal.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   Tax                                                        {taxofitem.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   Total                                                      {total.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n\n   Tendered                                               {tendered.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            alertplayer.Play();

            printedReceiptLabel.Text += $"\n   Change                                                  {change.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            chaching.Play();

            printedReceiptLabel.Text += "\n\n   Have A Nice Day!!!";

            newOrderButton.Visible = true;
            newOrderButton.Enabled = true;

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            caliRollText.Text = "";//
            sCaliRollText.Text = "";
            avoCucRollText.Text = "";

            subtotalPriceLabel.Text = "";
            taxPriceLabel.Text = "";
            totalPriceLabel.Text = "";

            changePriceLabel.Text = "";

            tenderedText.Text = "";

            printedReceiptLabel.Text = "";
        }
    }
}
