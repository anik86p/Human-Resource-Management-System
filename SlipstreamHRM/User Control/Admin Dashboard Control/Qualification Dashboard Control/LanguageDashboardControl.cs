using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    public partial class LanguageDashboardControl : UserControl
    {
        private static LanguageDashboardControl _instance;
        
        public static LanguageDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LanguageDashboardControl();
                return _instance;
            }
        }
        private SqlConnection Connection;
        private LanguageInformation languageInformation;
        private LanguageDashboardControl languageDashboardControl;

        public LanguageDashboardControl()
        {
            InitializeComponent();
        }

        private void XX_c(object sender, EventArgs e)
        {
            LanguageDataShow();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
            MessageBox.Show("fuck up ");
        }

        

        public void LanguageDataShow()
        {
            try
            {
                MessageBox.Show("fuck up in show");
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Language as 'Language' FROM LanguageInformation", Connection);
                DataTable RegionInfoTable1 = new DataTable();
                Adapter.Fill(RegionInfoTable1);
                LanguageDataGridView.DataSource = RegionInfoTable1;
                LanguageDataGridView.Columns[0].Width = 880;
                LanguageDataGridView.BackgroundColor = Color.White;
                LanguageDataGridView.BorderStyle = BorderStyle.Fixed3D;
                LanguageDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                LanguageDataGridView.AllowUserToAddRows = false;
                LanguageDataGridView.AllowUserToDeleteRows = false;
                LanguageDataGridView.AllowUserToOrderColumns = true;
                LanguageDataGridView.ReadOnly = true;
                LanguageDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LanguageDataGridView.MultiSelect = false;
                LanguageDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                LanguageDataGridView.AllowUserToResizeColumns = false;
                LanguageDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                LanguageDataGridView.AllowUserToResizeRows = false;
                LanguageDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                LanguageDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                LanguageDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                LanguageDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                LanguageDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                LanguageDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                LanguageDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                LanguageDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                LanguageDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Skill Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
        // Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\anik\Documents\anik.mdf;Integrated Security=True;Connect Timeout=30");
        private void New_CLick(object sender, EventArgs e)
        {

            languageInformation = new LanguageInformation();
           
            LanguageDataShow();
            MessageBox.Show("fuck up cc");

        }
       
       

      

       

     

        
    }
}
