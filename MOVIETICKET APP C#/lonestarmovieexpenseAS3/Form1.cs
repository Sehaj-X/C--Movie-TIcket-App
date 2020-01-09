using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lonestarmovieexpenseAS3
{
    public partial class Form1 : Form
    {
        double intialtotal = 0.0;
        double tprice = 0.0;
        int numoftickets = 5;// TO Change No. Of Tickets Please Change The Value of numoftickets variable 
        public Form1()
        {
           

           InitializeComponent();

            AddTickets(numoftickets , ticketlistbox);
           
            movielistbox.Items.Add("Avengers:End Game");
            movielistbox.Items.Add("Batman v Superman: Dawn of Justice");
            movielistbox.Items.Add("Jason Bourne");

            showtimelistbox.Items.Add("10.00am");
            showtimelistbox.Items.Add("3.00pm");
            showtimelistbox.Items.Add("7.00pm");
            showtimelistbox.Items.Add("11.30pm(8% discount)");
            
        }

        private double CalculateGst(double intialtotals)
        {
            return (intialtotal*0.05);
        }
        private double CalculatePst(double intialtotals)
        {
            return (intialtotal * 0.05);
            
        }
        private void WarnCustomerBluPurchase()
        {
            if ((avengersIWchk.Checked) || (wonderwomenchk.Checked) || (bournelegacychk.Checked)||(bournetrilogychk.Checked))

            {
                warnbluraytxt.BackColor = Color.Red;
                warnbluraytxt.ForeColor = Color.Yellow;
                warnbluraytxt.Text = "You have Blu Ray Purchase";
            }
        }

        private double CalculateMovieBluRay()
        {
            double totalbluraycost = 0;
           

            if ((avengersIWchk.Checked) || (wonderwomenchk.Checked) || (bournelegacychk.Checked))
            {
                totalbluraycost = 9.99;


            }
            if (bournetrilogychk.Checked)
            {
                totalbluraycost = totalbluraycost + 21.99;

            }
            return (totalbluraycost);

        }
        
        private bool CheckOk()
        {
            bool checkerror=true;
            if(movielistbox.SelectedIndex==-1)
            {
                
                MessageBox.Show("Did not select a movie", "Movie Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                checkerror = false;
            }
            if(showtimelistbox.SelectedIndex == -1)
            {
                
                MessageBox.Show("Did not select a show time", "Movie Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                checkerror = false;
            }
            if(childradiobtn.Checked)
            {
                if(movielistbox.SelectedIndex==1 )
                {
                    
                    MessageBox.Show("Children NOT allowed for R rated movies", "Movie Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    checkerror = false;
                }
                if(showtimelistbox.SelectedIndex==3)
                {
                   
                    MessageBox.Show("11.30pm show time only for adults", "Movie Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    checkerror = false;
                }
            }
            
            return (checkerror);
        }
        private double CalculateTickets()
        {
            double total = 0;
            switch (ticketlistbox.SelectedIndex)
            { 

             case 0:
                total = total + tprice;
                break;
             case 1:
                total = total + tprice * 2;
                break;
             case 2:
                total = total + tprice * 3;
                break;
             case 3:
                total = total + tprice * 4;
                break;
             case 4:
                total = total + tprice * 5;
                break;
            }
      
            return (total);

        }
        private void DisplayOverallData()
        {
            string details;
            details = "";
            details=(movielistbox.SelectedItem +" @ "+ showtimelistbox.SelectedItem) ;

           details=details+"\r\n"+ (ticketlistbox.SelectedItem + " @ " + CalculateTickets().ToString("n2"));
            if(avengersIWchk.Checked)
            {
            
               details = details+"\r\n"+"Blu Ray: The Avengers Infinity War";
                
            }
            if (wonderwomenchk.Checked)
            {
                details = details+"\r\n"+"Blu Ray: Wonder Women";
            }
            if (bournelegacychk.Checked)
            {
                details = "Blu Ray: Bourne Legacy\t";
            }
            if (bournetrilogychk.Checked )
            {
                details = details + "\r\n" + "Blu Ray:Bourne Trilogy($21.99)";
            }

            moviepurchasedetail.Text = details;

        }
        private void DisplayRating(string rate)
        {
            if(rate=="PG")
            {
                ratingtxtbox.BackColor = Color.Green;
                ratingtxtbox.ForeColor = Color.White;
            }
            if (rate == "R")
            {
                ratingtxtbox.BackColor = Color.Red;
                ratingtxtbox.ForeColor = Color.Yellow;
            }
            if (rate == "G")
            {
                ratingtxtbox.BackColor = Color.Blue;
                ratingtxtbox.ForeColor = Color.Yellow;
            }
        }
        private void ResetListBoxes()
        {
            ticketlistbox.SelectedIndex= 0 ;
            adultradiobtn.Checked = true;
            movielistbox.SelectedItem = null;
            showtimelistbox.SelectedItem = null;
           
            
            ratingtxtbox.Text = "";
            warnbluraytxt.Text = "";

        }
        private void ClearBluRayCheckBoxes()
        {
            avengersIWchk.Checked = false;
            wonderwomenchk.Checked = false;
            bournelegacychk.Checked = false;
            bournetrilogychk.Checked = false;

        }
        private void ClearTotals()
        {
            subtotal.Text = "";
            gsttxt.Text = "";
            psttxt.Text = "";
            totaltxt.Text = "";
            moviepurchasedetail.Text = "";
        }
        private Boolean Checkforinteger(TextBox creditcardtxt)
        {
            int creditnumber;
            if (int.TryParse(creditcardtxt.Text, out creditnumber))
            {
                return (true);
            }
            else
            {
                return (false);

            }


        }
        private void AddTickets(int noftickets, ListBox ticketlistbox)
        {
            int i = 1;
            while(noftickets>0)
            {
                ticketlistbox.Items.Add(i + " ticket(s)");
                i++;
                noftickets--;

            } 
        }
        private void RemoveBluRayMovie()
        {

                bluraybox.Visible =false ;
            
                avengersIWchk.Visible = false;
            
                wonderwomenchk.Visible = false;
            
                bournelegacychk.Visible = false;
                bournetrilogychk.Visible = false;
                warnbluraytxt.Text = "";
            
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            intialtotal = 0.0;
            tprice = 0.0;
            bool error= CheckOk(); 
            if(error==true)
            {
                if (adultradiobtn.Checked)
                {
                    tprice = 11.99;
                }
                if (childradiobtn.Checked)
                {
                    tprice = 7.99;
                }
                if (showtimelistbox.SelectedIndex == 3)
                {
                    tprice = tprice - (0.08 * tprice);

                }
                intialtotal =CalculateTickets() + CalculateMovieBluRay();
                double gst, pst;
                subtotaltxt.Text = intialtotal.ToString("n2");
                gst = CalculateGst(intialtotal);
                gsttxt.Text = gst.ToString("n2");
                pst = CalculatePst(intialtotal);
                psttxt.Text = pst.ToString("n2");
                intialtotal = intialtotal + gst + pst;
                totaltxt.Text = intialtotal.ToString("n2");
                
              
                DisplayOverallData();
                
            }
            else
            {
                ClearTotals();
                moviepurchasedetail.Text = "";

            }
            

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            RemoveBluRayMovie();
            ResetListBoxes();
            ClearTotals();
            ClearBluRayCheckBoxes();
            ratingtxtbox.BackColor = DefaultBackColor;
            warnbluraytxt.BackColor = DefaultBackColor;

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (Checkforinteger(creditcardtxt) == true)
            {
                MessageBox.Show("thank You $"+intialtotal+" has been changed to your card");
            }
            if (Checkforinteger(creditcardtxt) == false)
            {

                MessageBox.Show("credit card MUST be an integer", "Credit Card Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if ((subtotal.Text == "") || (total.Text == ""))
            {

                MessageBox.Show("Total cannot br blank", "Credit Card Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (nametxt.Text==null)
            {

                MessageBox.Show("Name cannot be blank", "Credit Card Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void movielistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            warnbluraytxt.Text = "";
            if (movielistbox.SelectedIndex >= 0)
            {
                bluraybox.Visible = true;

            }
            if (movielistbox.SelectedIndex == 0)
            {
                avengersIWchk.Visible = true;

                wonderwomenchk.Visible = false;

                bournelegacychk.Visible = false;
                bournetrilogychk.Visible = false;
            }
            if (movielistbox.SelectedIndex == 1)
            {
                wonderwomenchk.Visible = true;
                avengersIWchk.Visible = false;

                bournelegacychk.Visible = false;
                bournetrilogychk.Visible = false;

            }
            if (movielistbox.SelectedIndex == 2)
            {
                bournelegacychk.Visible = true;
                bournetrilogychk.Visible = true;

                avengersIWchk.Visible = false;

                wonderwomenchk.Visible = false;
                
            }
            string rating = "";
            if (movielistbox.SelectedIndex == 0)
            {
                rating = "PG";
            }
            if (movielistbox.SelectedIndex == 1)
            {
                rating = "R";
            }
            if (movielistbox.SelectedIndex == 2)
            {
                rating = "G";
            }
            DisplayRating(rating);
            ratingtxtbox.Text = rating;
            WarnCustomerBluPurchase();
        }
    }
}
