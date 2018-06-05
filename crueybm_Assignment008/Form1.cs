/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/19/2017
 * Assignment: 008
 * Description: This program collects three input fields from a user, and then runs the gathered variables through
 * Zeller's Algorithm to determine the day of the week that they were born.  The date is then populated to a TextBox.
 * At this point, the user can reset the inputs to start over.  A list of celebrities is also provided for some examples,
 * and clicking on a celebrity's name will populate the inputs as well as display a picture of said celebrity.
 * Citation: https://stackoverflow.com/questions/24764353/load-picturebox-image-in-c-sharp-from-file-in-relative-path
 * Citation: https://stackoverflow.com/questions/12646287/image-scaling-of-picture-box
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace crueybm_Assignment008
{

    public partial class frmZeller : Form
    {
        int a;                                  //declares int a
        int b;                                  //declares int b
        ArrayList celeb = new ArrayList();      //declares and instantiates ArrayList "celeb"
        string cel = "";                        //Declares string cel and sets it to an empty string

        public frmZeller()
        {
            InitializeComponent();
            this.pbCelebrity.SizeMode = PictureBoxSizeMode.Zoom;    //fits images to picturebox
            celeb.Add("Calbert Cheaney");       //Adds Calbert Cheaney to ArrayList
            celeb.Add("Grace Hopper");          //Adds Grace Hopper to ArrayList
            celeb.Add("Douglas Adams");         //Adds Douglas Adams to ArrayList
            celeb.Add("John Wayne");            //Adds John Wayne to ArrayList
            celeb.Add("Artemis");               //Adds Artemis to ArrayList
            for (int i = 0; i < celeb.Count; i++)   //Starts a for-loop that adds the array items to lbCelebrity
            {
                lbCelebrity.Items.Add(celeb[i]);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Limits tbYear to only take numerical input
            {
                e.Handled = true;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDate.Items.Clear();                           //Clears existing items from cbDate
            string mon = cbMonth.SelectedItem.ToString();   //Creates a string from the selected month
            int len = 0;                                    //Declares int that determines the length of the month
            
            switch (mon)                                    //Switch statement to set variable data for int b and int len
            {
                case "January":                             //Case January sets int b to 13 per algorithm
                    b = 13;
                    len = 31;
                    break;
                case "February":                            //Case February sets int b to 14 per algorithm
                    b = 14;
                    len = 29;
                    break;
                case "March":
                    b = 3;
                    len = 31;
                    break;
                case "April":
                    b = 4;
                    len = 30;
                    break;
                case "May":
                    b = 5;
                    len = 31;
                    break;
                case "June":
                    b = 6;
                    len = 30;
                    break;
                case "July":
                    b = 7;
                    len = 31;
                    break;
                case "August":
                    b = 8;
                    len = 31;
                    break;
                case "September":
                    b = 9;
                    len = 30;
                    break;
                case "October":
                    b = 10;
                    len = 31;
                    break;
                case "November":
                    b = 11;
                    len = 30;
                    break;
                case "December":
                    b = 12;
                    len = 31;
                    break;
            }

            for (int i = 1; i < len + 1; i++)   //For-loop that sets the contents of cbDate to var len
            {
                cbDate.Items.Add(i);
            }

        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(cbDate.SelectedItem);   //sets int a to the selected item from cbDate
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tbResult.Clear();                       //Clears text from tbResult
            int c = Convert.ToInt32(tbYear.Text);   //Accepts input from tbYear and converts it to an int
            string final = Zeller(a, b, c);         //Creates string final and calls upon method Zeller for the result
            tbResult.Text = final;                  //Sets tbResult to the returned string from Zeller
        }

        private string Zeller(int q, int m, int y)  //Declares method Zeller, which accepts three integers as arguments
        {
            string warning = "This is not a leap year.";    //Creates a warning for when a user selects February 29th on a non leap year.
            string date = "";                       //Creates an empty string for later use
            int h;                                  //Declares int h for later use
            if (m == 14 && q == 29)                 //An if-statement to catch invalid leap year entry
            {
                if (y % 4 != 0)                     //If year mod 4 doesn't equal 0, return the warning string
                {
                    return warning;
                }
            }
            if (m > 12)                             //If month is greater than 12 (Jan = 13 or Feb = 14 per algorithm)
            {
                y--;                                //Adjust year to year -1
            } 
            int k = (y % 100);                      //Declares int k to equal year mod 100
            int j = (y / 100);                      //Declares int j to equal year / 100
            int total = q;                          //Declares int total to equal q
            total += (13 * (m + 1)) / 5;            //Adds given equation to int total
            total += (k + (k / 4));                 //Adds given equation to int total
            total += (j / 4) + (5 * j);             //Adds given equation to int total
            h = (total % 7);                        //Sets int h to total mod 7
            switch (h)                              //Starts a switch statement for int h, to set string date to a day of the week
            {
                case 0:
                    date = "Saturday";
                    break;
                case 1:
                    date = "Sunday";
                    break;
                case 2:
                    date = "Monday";
                    break;
                case 3:
                    date = "Tuesday";
                    break;
                case 4:
                    date = "Wednesday";
                    break;
                case 5:
                    date = "Thursday";
                    break;
                case 6:
                    date = "Friday";
                    break;

            }
            return date;                            //Returns string date for the method

        }

        private void btnReset_Click(object sender, EventArgs e) //Handles button click for reset
        {
            cbMonth.SelectedIndex = 0;              //Sets cbMonth to index 0
            cbDate.SelectedIndex = 0;               //Sets cbDate to index 0
            tbYear.Clear();                         //Clears tbYear
            tbResult.Clear();                       //Clears tbResult
            lbCelebrity.ClearSelected();            //Clears selected item from lbCelebrity
            pbCelebrity.Image = null;               //Sets pbCelebrity to null/no picture
        }

        private void lbCelebrity_SelectedIndexChanged(object sender, EventArgs e)   //Handles an index being selected in lbCelebrity
        {
            if (lbCelebrity.Text == "Calbert Cheaney")  //If statement for Calbert Cheaney to set the month, date, year, and picturebox
            {
                cbMonth.SelectedItem = "July";
                cbDate.SelectedItem = 17;
                tbYear.Text = "1971";
                pbCelebrity.ImageLocation = @"..\..\images\ccheaney.jpg";
                int c = Convert.ToInt32(tbYear.Text);
                cel = Zeller(a, b, c);
                tbResult.Text = cel;
            } else if (lbCelebrity.Text == "Grace Hopper")  //Else-if statement for Grace Hopper to set the month, date, year, and picturebox
            {
                cbMonth.SelectedItem = "December";
                cbDate.SelectedItem = 9;
                tbYear.Text = "1906";
                pbCelebrity.ImageLocation = @"..\..\images\ghopper.jpg";
                int c = Convert.ToInt32(tbYear.Text);
                cel = Zeller(a, b, c);
                tbResult.Text = cel;
            } else if (lbCelebrity.Text == "Douglas Adams") //Else-if statement for Douglas Adams to set the month, date, year, and picturebox
            {
                cbMonth.SelectedItem = "March";
                cbDate.SelectedItem = 11;
                tbYear.Text = "1952";
                pbCelebrity.ImageLocation = @"..\..\images\dadams.jpg";
                int c = Convert.ToInt32(tbYear.Text);
                cel = Zeller(a, b, c);
                tbResult.Text = cel;
            } else if (lbCelebrity.Text == "John Wayne")    //Else-if statement for John Wayne to set the month, date, year, and picturebox
            {
                cbMonth.SelectedItem = "May";
                cbDate.SelectedItem = 26;
                tbYear.Text = "1907";
                pbCelebrity.ImageLocation = @"..\..\images\jwayne.jpg";
                int c = Convert.ToInt32(tbYear.Text);
                cel = Zeller(a, b, c);
                tbResult.Text = cel;
            } else if (lbCelebrity.Text == "Artemis")       //Else-if statement for Artemis to set the month, date, year, and picturebox
            {
                cbMonth.SelectedItem = "July";
                cbDate.SelectedItem = 4;
                tbYear.Text = "2012";
                pbCelebrity.ImageLocation = @"..\..\images\artemis.jpg";
                int c = Convert.ToInt32(tbYear.Text);
                cel = Zeller(a, b, c);
                tbResult.Text = cel;
            }
        }

        private void pbCelebrity_SizeModeChanged(object sender, EventArgs e)
        {
            this.pbCelebrity.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
