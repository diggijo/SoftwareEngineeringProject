using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public class BookingService
    {
        private int bookingID;
        private String serviceCode;
        private double cost;
        public bool validBookingService;
        public BookingService()
        {
            this.BookingID = 0;
            this.ServiceCode = "";
            this.cost = 0;
        }

        public BookingService(int bookingID, String serviceCode, double cost)
        {
            this.BookingID = bookingID;
            this.ServiceCode = serviceCode;
            this.cost = cost;
        }

        public int BookingID { get => bookingID; set => bookingID = value; }
        public string ServiceCode { get => serviceCode; set => serviceCode = value; }
        public double Cost { get => cost; set => cost = value; }

        public void addBookingService()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO BookingServices VALUES (" +
                this.bookingID + ",'" +
                this.serviceCode + "'," +
                this.cost + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                validBookingService = true;
            }
            catch(OracleException ex)
            {
                if(ex.Message.Contains("ORA-00001"))
                {
                    MessageBox.Show("This booking has already availed of this service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            conn.Close();
        }

        public static double GetServiceCosts(int BookingId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "SELECT SUM(Cost) FROM BookingServices WHERE BookingId = " + BookingId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            double totCostServices;

            if (dr.IsDBNull(0))
            {
                totCostServices = 0;
            }
            else
            {
                totCostServices = dr.GetDouble(0);
            }

            conn.Close();

            return totCostServices;
        }
    }
}
