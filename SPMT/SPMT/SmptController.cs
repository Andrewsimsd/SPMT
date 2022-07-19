using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMT
{
    /// <summary>
    /// Singleton controller to handle the business logic.
    /// </summary>
    public sealed class SmptController
    {
        private static SmptController _instance;
        private string TickerFilePath;
        public DataTable TickersDataTable;

        /// <summary>
        /// Default constructor
        /// </summary>
        private SmptController()
        {
            //Hard coded for now. TODO parameterize
            this.TickerFilePath = @"C:\Users\Andrew\Documents\GitHub\SPMT\Resources\Tickers.csv";
            ReadTickerFile(TickerFilePath);
        }

        /// <summary>
        /// Method to return the current instance or create a new one if one hasn't been created yet.
        /// </summary>
        /// <returns></returns>
        public static SmptController GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SmptController();
            }
            return _instance;
        }

        private void ReadTickerFile(string filePath)
        {
            // Create a new DataTable.
            this.TickersDataTable = new DataTable("TickersDataTable");

            DataColumn column;
            DataRow row;

            // Create Ticker DataColumn
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Ticker";
            column.ReadOnly = true;
            column.Unique = true;
            this.TickersDataTable.Columns.Add(column);

            // Create company name column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CompanyName";
            column.AutoIncrement = false;
            column.Caption = "Company Name";
            column.ReadOnly = false;
            column.Unique = false;
            this.TickersDataTable.Columns.Add(column);

            // Make the Ticker column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = this.TickersDataTable.Columns["Ticker"];
            this.TickersDataTable.PrimaryKey = PrimaryKeyColumns;

            // Read in the tickers csv file
            using (StreamReader sr = new StreamReader(filePath))
            {
                string currentLine;
                int lineNumber = 0;
                // currentLine will be null when the StreamReader reaches the end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    //skip header
                    if (lineNumber == 0)
                    {
                        lineNumber++;
                        continue;
                    }
                    string[] elements = currentLine.Split(',');
                    row = this.TickersDataTable.NewRow();
                    row["Ticker"] = elements[0];
                    row["CompanyName"] = elements[1];
                    this.TickersDataTable.Rows.Add(row);
                    lineNumber++;
                }
            }

            
        }

    }
}
