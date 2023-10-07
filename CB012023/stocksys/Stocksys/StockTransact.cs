using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocksys
{
    internal class StockTransact
    {
        // Private fields to store the values of properties
        private string stockCode;
        private string stockName;
        private int stockQuantity;
        private DateTime dateTime;
        private string transactionType;

        // Public properties to access the private fields
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        public string StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        // Constructor to initialize the object
        public StockTransact(string stockCode, string stockName, int stockQuantity, DateTime dateTime, string transactionType)
        {
            this.stockCode = stockCode;
            this.stockName = stockName;
            this.stockQuantity = stockQuantity;
            this.dateTime = dateTime;
            this.transactionType = transactionType;
        }
    }
}