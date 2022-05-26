using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DogKennelSys
{
    public class Bookings
    {
        private int bookingID;
        private int kennelNo;
        private DateTime arrivalDate;
        private DateTime deptDate;
        private double totalCost;
        private int petID;
        private char status;

        public Bookings()
        {
            this.bookingID = 0;
            this.kennelNo = 0;
            this.arrivalDate = DateTime.Today;
            this.deptDate = DateTime.Today;
            this.totalCost = 0;
            this.petID = 0;
            this.status = 'B';
        }
        public Bookings(int bookingID, int kennelNo, DateTime arrivalDate, DateTime deptDate, double totalCost, int petID, char status)
        {
            this.bookingID = bookingID;
            this.kennelNo = kennelNo;
            this.arrivalDate = arrivalDate;
            this.deptDate = deptDate;
            this.totalCost = totalCost;
            this.petID = petID;
            this.status = status;
        }

        public int BookingID { get => bookingID; set => bookingID = value; }
        public int KennelNo { get => kennelNo; set => kennelNo = value; }
        public DateTime ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public DateTime DeptDate { get => deptDate; set => deptDate = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public int PetID { get => petID; set => petID = value; }
        public char Status { get => status; set => status = value; }

        public static int getNextBookingID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

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

        public static DataSet findCheckIns()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM BOOKINGS WHERE ARRIVAL_DATE = '" + (DateTime.Today.Date.ToString("dd-MMM-yy")) + 
                "' AND STATUS = 'B' ORDER BY BOOKINGID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bookings");

            conn.Close();

            return ds;
        }

        public static DataSet findCheckOuts()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM BOOKINGS WHERE DEPT_DATE = '" + (DateTime.Today.Date.ToString("dd-MMM-yy")) +
                "' AND STATUS = 'I' ORDER BY BOOKINGID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bookings");

            conn.Close();

            return ds;
        }

        public static void checkIn(int bookingID, int kennelNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Bookings SET Status = 'I' WHERE BookingID = " + bookingID;
            String kennelStatus = "UPDATE Kennels SET Status = 'U' WHERE KennelNo = " + kennelNo;


            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleCommand cmd2 = new OracleCommand(kennelStatus, conn);

            conn.Open();

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            conn.Close();
        }

        public static void checkOut(int bookingID, int kennelNo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Bookings SET Status = 'O' WHERE BookingID = " + bookingID;
            String kennelStatus = "UPDATE Kennels SET Status = 'A' WHERE KennelNo = " + kennelNo;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleCommand cmd2 = new OracleCommand(kennelStatus, conn);

            conn.Open();

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            conn.Close();
        }

        public void addBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Bookings VALUES(" +
                this.bookingID + ", " +
                this.kennelNo + ", " +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", this.arrivalDate) + "', 'DD/MM/YYYY'), " +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", this.deptDate) + "', 'DD/MM/YYYY'), " +
                this.totalCost + ", " +
                this.petID + ", '" +
                this.status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findBookings(String accountName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT a.FIRSTNAME, a.LASTNAME, p.PETNAME, b.ARRIVAL_DATE, b.DEPT_DATE, b.bookingID FROM Bookings b INNER JOIN Pets p ON b.petID = p.petID INNER JOIN Accounts a ON p.custID = a.custID WHERE a.LASTNAME LIKE '%" + accountName + "%' AND b.Status NOT LIKE 'O' ORDER BY B.BookingID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bookings");

            conn.Close();

            return ds;
        }

        public static void cancelBooking(int bookingID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM Bookings WHERE bookingID = " + bookingID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findAvailableKennels(String dogSize, String dateCheckIn, String dateCheckOut)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT KennelNo, KennelSize, Cost FROM Kennels WHERE KennelSize = '" + dogSize + "' AND KennelNo NOT IN" +
                "(SELECT KennelNo FROM Bookings WHERE('" + dateCheckIn + "' >= arrival_date AND '" + dateCheckOut + "' <= dept_date) OR" +
                    "('" + dateCheckIn + "' <= arrival_date AND '" + dateCheckOut + "' >= arrival_date AND '" + dateCheckOut + "' <= dept_date) OR" +
                    "('" + dateCheckIn + "' >= arrival_date AND '" + dateCheckIn + "' <= dept_date AND '" + dateCheckOut + "' >= dept_date) OR" +
                    "('" + dateCheckIn + "' <= arrival_date AND '" + dateCheckOut + "' >= dept_date))";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Kennels");

            conn.Close();

            return ds;
        }

        public static double GetBookingCost(int BookingId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "SELECT Cost FROM Bookings WHERE BookingId = " + BookingId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            double totBookingCost = dr.GetDouble(0);

            conn.Close();

            return totBookingCost;
        }
    }
}
