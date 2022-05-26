using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace DogKennelSys
{
    public class Account
    {
        public bool accountValid = false;
        public bool phoneError = false;
        public bool emailError = false;
        private int custID;
        private String firstName;
        private String lastName;
        private DateTime dob;
        private String street;
        private String town;
        private String county;
        private String eirCode;
        private String phoneNo;
        private String email;
        public static bool phoneTaken;
        public static bool emailTaken;
        public static bool validUpdate;

        public Account()
        {
            this.custID = 0;
            this.firstName = "";
            this.lastName = "";
            this.dob = DateTime.Today.AddYears(-16);
            this.street = "";
            this.town = "";
            this.county = "";
            this.eirCode = "";
            this.phoneNo = "";
            this.email = "";
        }
        public Account(int custID, string firstName, string lastName, DateTime dob, string street, string town, string county, string eirCode, string phoneNo, string email)
        {
            this.custID = custID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.street = street;
            this.town = town;
            this.county = county;
            this.eirCode = eirCode;
            this.phoneNo = phoneNo;
            this.email = email;
        }

        public int CustID { get => custID; set => custID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Street { get => street; set => street = value; }
        public string Town { get => town; set => town = value; }
        public string County { get => county; set => county = value; }
        public string EirCode { get => eirCode; set => eirCode = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }

        public static int getNextCustID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(CustID) FROM Accounts";

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

        public void addAccount()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Accounts VALUES (" +
                this.custID + ",'" +
                this.firstName + "','" +
                this.lastName + "'," +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", this.dob) + "', 'DD/MM/YYYY'), '" +
                this.street + "','" +
                this.town + "','" +
                this.county + "','" +
                this.eirCode + "','" +
                this.phoneNo + "','" +
                this.email +"')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully!", "Account Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accountValid = true;
            }

            catch (OracleException ex)
            {
                if (ex.Message.Contains("C008107")) //These change everytime I re-run the script.
                {
                    MessageBox.Show("This phone number is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneError = true;
                }

                else if (ex.Message.Contains("C008108")) //These change everytime I re-run the script.
                {
                    MessageBox.Show("This e-mail is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailError = true;
                }

                else
                {
                    MessageBox.Show("Phone or Email is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailError = true;
                    phoneError = true;
                }
            }

            conn.Close();
        }

        public static DataSet findAccounts(String accountName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Accounts WHERE LASTNAME LIKE '%" + accountName + "%' ORDER BY FIRSTNAME";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Accounts");

            conn.Close();

            return ds;
        }

        public static void updateAccount(int custID, string firstName, string lastName, DateTime dob, string street, string town, string county, string eirCode, string phoneNo, string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Accounts SET FirstName = '" + firstName + "', LastName = '" +
                lastName + "', DOB = " +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", dob) + "', 'DD/MM/YYYY'), " + "Street = '" +
                street + "', Town = '" +
                town + "', County = '" +
                county + "', Eircode = '" +
                eirCode + "', Phone = '" + 
                phoneNo + "', Email = '" + 
                email + "' WHERE CustID = " + custID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account.validUpdate = true;
            }

            catch (OracleException ex)
            {
                if (ex.Message.Contains("C007898"))
                {
                    MessageBox.Show("This phone number is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Account.phoneTaken = true;
                }

                if (ex.Message.Contains("C007899"))
                {
                    MessageBox.Show("This e-mail is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Account.emailTaken = true;
                }
            }

            conn.Close();
        }
    }
}
