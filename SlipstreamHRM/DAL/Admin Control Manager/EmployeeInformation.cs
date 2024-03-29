﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.DAL.Admin_Control_Manager
{
    class EmployeeInformation
    {
        private SqlConnection Connection;
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private string _password;
        private string _confirmPassword;
        private string _userName;
        private string _status;
        private string _region;
        private string _employeeID;        

        public EmployeeInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string FirstName
        {
            set
            {
                this._firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string MiddleName
        {
            set
            {
                this._middleName = value;
            }
            get
            {
                return _middleName;
            }
        }

        public string LastName
        {
            set
            {
                this._lastName = value;
            }
            get
            {
                return _lastName;
            }
        }

        public string EmployeeId
        {
            set
            {
                this._employeeID = value;
            }
            get
            {
                return _employeeID;
            }
        }

        public string Password
        {
            set
            {
                this._password = value;
            }
            get
            {
                return _password;
            }
        }

        public string ConfirmPassword
        {
            set
            {
                this._confirmPassword = value;
            }
            get
            {
                return _confirmPassword;
            }
        }

        public string Username
        {
            set
            {
                this._userName = value;
            }
            get
            {
                return _userName;
            }
        }

        public string Status
        {
            set
            {
                this._status = value;
            }
            get
            {
                return _status;
            }
        }
        public string Region
        {
            set
            {
                this._region = value;
            }
            get
            {
                return _region;
            }
        }

        public void AddEmployee()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO EmployeeInformation (Name, EmployeeID) VALUES ('" + (_firstName + " " + _middleName + " " + _lastName) + "','" + _employeeID + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }                                
        }

        public void AddEmployeeWithUsername()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO EmployeeInformation (Name, EmployeeID, EmploymentStatus) VALUES ('" + (_firstName+" " + _middleName+" "+_lastName) + "','" + _employeeID + "','" + _status + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter Adapter1 = new SqlDataAdapter("INSERT INTO UserInformation (Username, EmployeeName, Status, EmpID) VALUES ('" +_userName+ "','" + (_firstName + " " + _middleName + " " + _lastName) + "','" +_status+ "','" + _employeeID + "')", Connection);
                Adapter1.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter Adapter2 = new SqlDataAdapter("INSERT INTO LogInInfo (Username, Password) VALUES ('" + _userName + "','" + _confirmPassword + "')", Connection);
                Adapter2.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }           
        }
    }
}
