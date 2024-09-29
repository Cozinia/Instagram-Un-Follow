using InstagramUnfollow.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramUnfollow
{
    public partial class Form1 : Form
    {
        private List<string> followers { get; set; }
        private List<string> followings { get; set; }
        private DataTable dataTablePeopleToUnfollow = new DataTable();
        public Form1()
        {
            InitializeComponent();

            // Add columns to the DataTable
            dataTablePeopleToUnfollow.Columns.Add("ID", typeof(int));
            dataTablePeopleToUnfollow.Columns.Add("Username", typeof(string));
            dataTablePeopleToUnfollow.Columns.Add("Profile Link", typeof(string));

            dataGridViewPeopleToUnfollow.DataSource = dataTablePeopleToUnfollow;

            dataGridViewPeopleToUnfollow.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 

            dataGridViewPeopleToUnfollow.Columns["Profile Link"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Add CellDoubleClick event handler
            dataGridViewPeopleToUnfollow.CellDoubleClick += DataGridViewPeopleToUnfollow_CellDoubleClick;

        }

        private void buttonUploadFollowers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            string filePath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                labelPathToFollowers.Text = filePath;
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);
                    HandleJSONContent handleJSONContent = new HandleJSONContent(jsonContent);
                    followers = handleJSONContent.getFollowersList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a JSON file first.");
            }
        }

        private void buttonUploadFollowings_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            string filePath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                labelPathToFollowings.Text = filePath;
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);
                   HandleJSONContent handleJSONContent = new HandleJSONContent(jsonContent);
                    followings = handleJSONContent.getFollowingsList();
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a JSON file first.");
            }
        }

        private void buttonUnfollowPeople_Click(object sender, EventArgs e)
        {
           
            followers.Sort();
            followings.Sort();
            int id = 0;
            // optimize lookup
            HashSet<string> followersSet = new HashSet<string>(followers);

            
            StringBuilder peopleToUnfollow = new StringBuilder();

           
            foreach (var following in followings)
            {
                if (!followersSet.Contains(following))
                {
                    id++;
                    string profileLink = $"http://instagram.com/{following}";
                    dataTablePeopleToUnfollow.Rows.Add(id, following, profileLink); 
                    
                }
            }

            //Load this every time changes have been made regarding uploading a new file
            dataGridViewPeopleToUnfollow.DataSource = dataTablePeopleToUnfollow;
        }

        private void DataGridViewPeopleToUnfollow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 2) 
            {
               
                string url = dataGridViewPeopleToUnfollow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                
                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link: " + ex.Message);
                }
            }
        }
    }
}
