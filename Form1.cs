using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utilities.Movies;

/*
 * MyFlix 
 * - demonstrates the use of controls by using a ListBox in order to
 *      get a users total download cost
 *      
 * Week 12
 * by Mark Hawes
 */

namespace MyFlix
{
    public partial class MainForm : Form
    {
        // estimated cost default text
        private string costDftTxt = "Estimated Cost: ";

        public MainForm()
        {
            InitializeComponent();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void costButton_Click(object sender, EventArgs e)
        {
            // used to store number of selected items in ListBox
            int numSelected = moveListBox.SelectedItems.Count;
            double total = 0; // total cost - always reset to 0

            // uses TotalCost from Utilities class
            total = TotalCost(numSelected);

            // updates costLabel to display proper output/cost
            costLabel.Text = costDftTxt + total.ToString();
        } // end costButton_Click
    }
}
