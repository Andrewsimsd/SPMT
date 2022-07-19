using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPMT.View
{
    public partial class SecurityLookupForm : Form
    {
        private SmptController controller;
        private DataView myView;

        public SecurityLookupForm()
        {
            InitializeComponent();
            this.controller = SmptController.GetInstance();

            // TEST CODE
            //Creates a DataView from our table's default view
            myView = controller.TickersDataTable.DefaultView;

            //Assigns the DataView to the grid
            dataGridView1.DataSource = myView;
        }

        //The purpose of this method is to take the text from the search
        //box, split it up into words, and then create and assign a filter
        //statement that will do a LIKE comparison on each of the selected
        //search fields. Each word's filter statement is AND'ed together
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string outputInfo = "";
            string[] keyWords = tbSearch.Text.Split(' ');

            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(Ticker LIKE '%" + word + "%' OR CompanyName LIKE '%" +
                         word + "%')";
                }
                else
                {
                    outputInfo += " AND (Ticker LIKE '%" + word + "%' OR CompanyName LIKE '%" +
                         word + "%')";
                }
            }

            //Applies the filter to the DataView
            myView.RowFilter = outputInfo;
        }
    }
}
