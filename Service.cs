using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public class Service
    {
        private String description;
        private String code;
        private decimal rate;
        private char status;

        public Service()
        {
            this.code = "";
            this.description = "";
            this.rate = 0;
            this.status = 'A';
        }

        public Service(string code, string description, decimal rate, char status)
        {
            this.code = code;
            this.description = description;
            this.rate = rate;
            this.status = status;
        }

        public string Description { get => description; set => description = value; }
        public string Code { get => code; set => code = value; }
        public decimal Rate { get => rate; set => rate = value; }
        public char Status { get => status; set => status = value; }

        public void addService()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Services VALUES (" + "'" +
                this.code + "','" +
                this.description + "'," +
                this.rate + ",'" + 
                this.status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (OracleException)
            {
                MessageBox.Show("Service Code must be unique", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void withdrawService(string serviceCode)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Services SET Status = 'W' WHERE Service_Code = '" + serviceCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findServices()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Services WHERE Status = 'A'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Services");

            conn.Close();

            return ds;
        }
    }
}
