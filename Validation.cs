using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DogKennelSys
{
    public class Validation
    {
        public static bool validEircode(String Eircode)
        {
            Regex pattern = new Regex("(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$"); //https://stackoverflow.com/questions/33391412/validation-for-irish-eircode 9th Feb 2022


            if (pattern.IsMatch(Eircode))
            {
                return true;
            }
            else
                return false;
        }

        public static bool validEmail(String email)
        {
            Regex pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); //https://stackoverflow.com/questions/5342375/regex-email-validation 9th Feb 2022

            if (pattern.IsMatch(email))
            {
                return true;
            }
            else
                return false;
        }

        public static bool validPhone(String phone)
        {
            int invalidChar = 0;

            
            if (phone.Length == 10 && phone[0] == '0' && phone[1] == '8')
            {
                for (int i = 0; i < phone.Length; i++)
                {
                    if (!Char.IsDigit(phone[i]))
                    {
                        invalidChar++;
                    }
                }
            }
            else
                return false;

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool validName(String name)
        {
            int invalidChar = 0;

            for(int i=0; i<name.Length; i++)
            {
                if(!Char.IsLetter(name[i]) && name[i] != '-' && name[i] != ' ' && name[i] != '.')
                {
                        invalidChar++;
                }
            }

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool validAddress(String address)
        {
            int invalidChar = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (!Char.IsLetter(address[i]) && address[i] != '-'  && address[i] != ' ' && address[i] != '.' && !Char.IsDigit(address[i]))
                {
                    invalidChar++;
                }
            }

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool validCounty(String county)
        {
            String[] counties = {"ANTRIM", "ARMAGH", "CARLOW", "CAVAN", "CLARE", "CORK", "DERRY", "DONEGAL", "DOWN", "DUBLIN", "FERMANAGH", "GALWAY", "KERRY", "KILDARE", "KILKENNY", "LAOIS", "LEITRIM", "LIMERICK", "LONGFORD", "LOUTH", "MAYO", "MEATH", "MONAGHAN", "OFFALY", "ROSCOMMON", "SLIGO", "TIPPERARY", "TYRONE", "WATERFORD", "WESTMEATH", "WEXFORD", "WICKLOW"};

            if (Array.Exists(counties, element => element == county))
            {
                return true;
            }
            else
                return false;
            
        }

        public static bool validServiceCode(String serviceCode)
        {
            int invalidChar = 0;

            if (serviceCode.Length == 3)
            {
                for (int i = 0; i < serviceCode.Length; i++)
                {
                    if (!Char.IsLetter(serviceCode[i]))
                    {
                        invalidChar++;
                    }
                }
            }
            else
                return false;

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool validRate(String rate)
        {
            int invalidChar = 0;


            if (rate.Length > 0 && rate.Length <= 5)
            {
                for (int i = 0; i < rate.Length; i++)
                {
                    if (!Char.IsDigit(rate[i]) && rate[rate.Length - 3] != '.')
                    {
                        invalidChar++;
                    }
                }
            }
            else
                return false;

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool validColour(String colour)
        {
            int invalidChar = 0;

            for (int i = 0; i < colour.Length; i++)
            {
                if (!Char.IsLetter(colour[i]) && colour[i] != '/' && colour[i] != ' ' && colour[i] != '&')
                {
                    invalidChar++;
                }
            }

            if (invalidChar >= 1)
                return false;
            else
                return true;
        }

        public static bool isEmpty(String input)
        {
            if (input.Equals(""))
                return true;
            else
                return false;
        }

        public static void invalidMsg(String label, TextBox textBox)
        {
            MessageBox.Show("Invalid " + label, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
        }

        public static void emptyMsg(String label, TextBox textBox)
        {
            MessageBox.Show(label + " field cannot be left empty", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox.Focus();
        }
    }
}
