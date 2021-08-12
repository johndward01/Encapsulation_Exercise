using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Exercise_01_Answers
{
    class PII_Info
    {
        // BONUS
        // TODO: Create 1 private readonly field _secret of type string
        private readonly string _secret;



        // TODO: Create 4 private fields
        private int _userID;
        private string _privateKey;
        private decimal _walletBalance;
        private bool _isAuthenticated;



        // BONUS
        // TODO: Assign a value to the field
        public PII_Info(string secret)
        {
            _secret = secret;
        }



        // TODO: Create 2 private auto-implemented properties
        private string UserName { get; set; }
        private string Password { get; set; }



        #region// TODO: Create 4 public methods to get (read) those fields
        public int GetUserID()
        {
            return _userID;
        }

        public string GetEncryptedString()
        {
            return _privateKey;
        }

        public decimal GetBalance()
        {
            return _walletBalance;
        }

        public bool GetAuthenticatedStatus()
        {
            return _isAuthenticated;
        }

        #endregion



        #region// TODO: Create 4 public methods to set (write) those fields
        public void SetUserID(int userID)
        {
            _userID = userID;
        }

        public void SetEncryptedString(string encryptedString)
        {
            _privateKey = encryptedString;
        }

        public void SetBalance(decimal balance)
        {
            _walletBalance = balance;
        }

        public void SetAuthenticatedStatus(bool authenticatedStatus)
        {
            _isAuthenticated = authenticatedStatus;
        }

        #endregion



        // TODO: Create 1 method called SetInfo() which sets the private properties
        public void SetInfo(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }




        // TODO: Create 1 method called InformationReport() which creatively displays all the values 
        public void InformationReport()
        {
            Console.Write($"Username: {UserName}\n" +
                          $"Password: {Password}\n" +
                          $"User ID: {_userID}\n" +
                          $"Private Key: {_privateKey}\n" +
                          $"Wallet Balance: {string.Format(_walletBalance.ToString())}\n" +
                          $"Is Authenticated: {_isAuthenticated}\n\n" +
                          $"SECRET: {_secret}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
