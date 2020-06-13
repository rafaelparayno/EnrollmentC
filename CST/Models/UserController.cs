﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class UserController
    {
        crudFile cs = new crudFile();
        public UserController()
        {


        }

        public void addUser(string accid,
                        string username,
                        string firstname, 
                        string lastname,
                        string middleName,
                        string role,
                        string dateCreated)
        {
            string password = "";
            password = GeneratePassword(8);

            string sql = String.Format(@"Insert into useraccounts(acc_id,Username,Firstname,Middlename,Lastname,role,Password,create_at,status,isPaswordChanged) 
                                        VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','Offline',0)",
                        accid, username, firstname, middleName, lastname, role, password, dateCreated);

            cs.ExecuteQuery(sql);
        }

        public void updateUser(string accid,
                        string username,
                        string firstname,
                        string lastname,
                        string middleName,
                        string role)
        {
            string sql = String.Format(@"UPDATE useraccounts SET Username = '{0}', Firstname = '{1}', Middlename = '{2}',Lastname = '{3}',role = '{4}' WHERE acc_id = '{5}'",
                                       username, firstname, middleName, lastname, role, accid);

            cs.ExecuteQuery(sql);
        }

        public void deleteUser(string accid)
        {
            string sql = String.Format(@"DELETE FROM useraccounts WHERE acc_id = '{0}'", accid);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridUser(ref DataGridView dg)
        {

            string sql = "SELECT acc_id,Firstname,Middlename,Lastname,Username,Password, Role,Status,create_at,isPaswordChanged  FROM useraccounts useraccounts WHERE Status = 'Offline'";

            cs.FillDataGrid(sql, ref dg);
        }

        public void searchGrid(string condition,string searchKeys,ref DataGridView dg)
        {


            string sql = String.Format(@"SELECT acc_id,Firstname,Middlename,Lastname,Username,Password, Role,Status,create_at,isPaswordChanged FROM useraccounts WHERE {0} LIKE '%{1}%' AND Status = 'Offline'", condition, searchKeys);

            cs.FillDataGrid(sql, ref dg);
        }

        public void ResetPassword(string accid)
        {
            string newPass = GeneratePassword(8);
            string sql = String.Format(@"UPDATE useraccounts SET Password = '{0}',isPaswordChanged = 0 WHERE acc_id = '{1}'", newPass, accid);

            cs.ExecuteQuery(sql);

            MessageBox.Show("New Password \n" + newPass);

        }

        public void ChangedPass(string accid,string password)
        {
      
            string sql = String.Format(@"UPDATE useraccounts SET Password = '{0}',isPaswordChanged = 1 WHERE acc_id = '{1}'", password, accid);

            cs.ExecuteQuery(sql);
   
        }

        public bool isSameUser(string username)
        {
            bool isSame = false;

            string sql = String.Format(@"SELECT * FROM useraccounts WHERE Username = '{0}'", username);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);


            if (reader.HasRows)
            {
                isSame = true;
            }

            cs.CloseConnection();

            return isSame; 

        }


        private string GeneratePassword(int length)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
    }
}
