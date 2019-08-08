using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control
{
    public partial class GeneralInformationDashboardControl : UserControl
    {
        private static GeneralInformationDashboardControl _instance;

        public static GeneralInformationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GeneralInformationDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private OrganizationInformation organizationInformation;

        public GeneralInformationDashboardControl()
        {
            InitializeComponent();
        }

        private void GeneralInformationDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
            organizationInformation = new OrganizationInformation();
            OganizationInformationShow();
            fillRegionComboBox();        
        }

        public void OganizationInformationShow()
        {           
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From OrganizationInformation"), Connection);
                DataTable OrganizationInfomationTable = new DataTable();
                Adapter.Fill(OrganizationInfomationTable);

                foreach (DataRow row in OrganizationInfomationTable.Rows)
                {
                    organizationInformation.OrganizationName = row["OrganizationName"].ToString();
                    organizationInformation.TaxID = row["TaxID"].ToString();
                    organizationInformation.NumberofEmployess = Convert.ToInt32(row["NumberofEmployees"]);
                    organizationInformation.RgistrationNumber = row["RegistrationNumber"].ToString();
                    organizationInformation.Phone = row["Phone"].ToString();
                    organizationInformation.Fax = row["Fax"].ToString();
                    organizationInformation.Email = row["Email"].ToString();
                    organizationInformation.AddressStreet1 = row["AddressStreet1"].ToString();
                    organizationInformation.AddressStreet2 = row["AddressStreet2"].ToString();
                    organizationInformation.City = row["City"].ToString();
                    organizationInformation.State = row["State"].ToString();
                    organizationInformation.ZipPostalCode = row["ZipCode"].ToString();
                    organizationInformation.Country = row["Country"].ToString();
                    organizationInformation.Note = row["Note"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "User Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            txtOrganizationName.Text = organizationInformation.OrganizationName;
            txtTaxID.Text = organizationInformation.TaxID;
            txtNumberofEmployees.Text = Convert.ToString(organizationInformation.NumberofEmployess);
            txtRegistrationNumber.Text = organizationInformation.RgistrationNumber;
            txtPhone.Text = organizationInformation.Phone;
            txtFax.Text = organizationInformation.Fax;
            txtEmail.Text = organizationInformation.Email;
            txtAddressStreet1.Text = organizationInformation.AddressStreet1;
            txtAddressStreet2.Text = organizationInformation.AddressStreet2;
            txtCity.Text = organizationInformation.City;
            txtState.Text = organizationInformation.State;
            txtZIPPostalCode.Text = organizationInformation.ZipPostalCode;
            comboxCountry.Text = organizationInformation.Country;
            txtNote.Text = organizationInformation.Note;
        }

        public void fillRegionComboBox()
        {
            try
            {
                string _RegionName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From RegionInformation ORDER BY RegionName"), Connection);
                DataTable RegionInfomationTable = new DataTable();
                Adapter.Fill(RegionInfomationTable);

                foreach (DataRow row in RegionInfomationTable.Rows)
                {
                    _RegionName = row["RegionName"].ToString();
                    comboxCountry.Items.Add(_RegionName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Region Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
                comboxCountry.Text = organizationInformation.Country;
            }
        }
    }
}
