using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DogKennelSys
{
    public class Sales
    {
        private int saleId;
        private DateTime saleDate;
        private double totalAmount;
        private double serviceAmount;

        public Sales()
        {
            this.saleId = 0;
            this.saleDate = DateTime.Today;
            this.totalAmount = 0;
            this.serviceAmount = 0;
        }
        public Sales(int saleId, DateTime saleDate, double totalAmount, double serviceAmount)
        {
            this.saleId = saleId;
            this.saleDate = saleDate;
            this.totalAmount = totalAmount;
            this.serviceAmount = serviceAmount;
        }

        public int SaleId { get => saleId; set => saleId = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public double ServiceAmount { get => serviceAmount; set => serviceAmount = value; }

        public static int getNextSaleID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(SaleID) FROM Sales";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;

            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }

        public void addSale()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Sales VALUES(" +
                saleId + "," +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", this.saleDate) + "', 'DD/MM/YYYY'), " +
                totalAmount + "," + 
                serviceAmount + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getYearlyRevenue(String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT EXTRACT(MONTH FROM SaleDATE), SUM(Total_Amount) FROM Sales WHERE SaleDate LIKE '%" +
                Year + "' GROUP BY EXTRACT(MONTH FROM SaleDATE) ORDER BY EXTRACT(MONTH FROM SaleDATE)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "RA");

            conn.Close();

            return ds;

        }

        public static DataSet getServiceAnalysis(String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT EXTRACT(MONTH FROM SaleDATE), SUM(Services_Amount) FROM Sales WHERE SaleDate LIKE '%" +
                Year + "' GROUP BY EXTRACT(MONTH FROM SaleDATE) ORDER BY EXTRACT(MONTH FROM SaleDATE)";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "YS");

            conn.Close();

            return ds;

        }
    }
}
