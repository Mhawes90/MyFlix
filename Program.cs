using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utilities.Movies; // get utilities for MyFlix

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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}


// Utilities namespace
namespace Utilities
{
    /*
    * static class to be used with MyFlix program
    */ 
    static class Movies
    {
        // constants
        private static double DOWNLOAD_PRICE = 1.99;

        // calculates and returns total cost for downloads
        public static double TotalCost(int numMovies)
        {
            return numMovies * DOWNLOAD_PRICE;
        }
    }
    
    /*
    * static class to be used for BreezyViewApartments program
    */ 
    static class BVApt
    {
        // constants
        private static double ONE_BED = 450, TWO_BED = 550, 
            THREE_BED = 700, ADD_BATH = 75, LAKE_VIEW = 50;

        /****************************************************
        * calculates and returns appartment cost            *
        * bool lakeView is true if they want a lake view    *
        *****************************************************/
        public static double ApptCost(int numBed, int numBath, bool lakeView)
        {
            // num to return
            double total = 0;

            total += BedPrice(numBed);

            // counts number of bathrooms and adds to total if needed
            while (numBath > 1)
            {
                total += ADD_BATH; // add additional bathroom cost to total
                numBath--; // decrement number of bathrooms
            } // end loop

            // if lakeView then add to total cost
            if (lakeView)
                total += LAKE_VIEW;

            return total; // return total
        }

        // seperate method for the switch statement to get 
        // cost per number of bedrooms
        private static double BedPrice(int num)
        {
            // num to return
            double price = 0;

            // switch to determine number of beds in apartment
            switch (num)
            {
                case 1: price = ONE_BED; break;
                case 2: price = TWO_BED; break;
                case 3: price = THREE_BED; break;
            }
            return price; // return cost
        }
    }
}
