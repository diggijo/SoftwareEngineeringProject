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
    public class Pet
    {
        private int petID;
        private String name;
        private DateTime dob;
        private String breed;
        private char size;
        private String colour;
        private char sex;
        private char neutered;
        private int custID;

        public Pet()
        {
            this.PetID = 0;
            this.name = "";
            this.dob = DateTime.Today.AddYears(-1);
            this.breed = "";
            this.size = 'S';
            this.colour = "";
            this.sex = 'M';
            this.neutered = 'Y';
            this.custID = 0;
        }

        public Pet(int petID, string name, DateTime dob, string breed, char size, string colour, char sex, char neutered, int custID)
        {
            this.PetID = petID;
            this.Name = name;
            this.Dob = dob;
            this.Breed = breed;
            this.Size = size;
            this.Colour = colour;
            this.Sex = sex;
            this.Neutered = neutered;
            this.CustID = custID;
        }

        public int PetID { get => petID; set => petID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Breed { get => breed; set => breed = value; }
        public char Size { get => size; set => size = value; }
        public string Colour { get => colour; set => colour = value; }
        public char Sex { get => sex; set => sex = value; }
        public char Neutered { get => neutered; set => neutered = value; }
        public int CustID { get => custID; set => custID = value; }

        public static int getNextPetID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(PetID) FROM Pets";

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

        public void registerDog()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Pets VALUES (" +
                this.petID + ",'" +
                this.Name + "'," +
                "TO_DATE('" + String.Format("{0:dd-MMM-yyyy}", this.dob) + "', 'DD/MM/YYYY'), '" +
                this.breed + "','" +
                this.size + "','" +
                this.colour + "','" +
                this.sex + "','" +
                this.neutered + "'," +
                this.custID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findPets(int custID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT p.* FROM Pets p INNER JOIN Accounts a ON p.custID = a.custID WHERE a.custID = " + custID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Pets");

            conn.Close();

            return ds;
        }
    }
}
