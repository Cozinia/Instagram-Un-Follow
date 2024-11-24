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
        private List<string> peopleToUnfollow = new List<string>();
        private int totalCountOfUnfollowers = 0;
        private DataTable dataTablePeopleToUnfollow = new DataTable();
        public Form1()
        {
            InitializeComponent();

            // Add columns to the 
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

                labelPathToFollowers.Text = filePath; // Update the correct label
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);
                    HandleJSONContent handleJSONContent = new HandleJSONContent(jsonContent);
                    followers = handleJSONContent.getFollowersList(); // Correct method call
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

                labelPathToFollowings.Text = filePath; // Update the correct label
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string jsonContent = System.IO.File.ReadAllText(filePath);
                    HandleJSONContent handleJSONContent = new HandleJSONContent(jsonContent);
                    followings = handleJSONContent.getFollowingsList(); // Correct method call
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
            totalCountOfUnfollowers = 0;
            followers.Sort();
            followings.Sort();

            
            HashSet<string> followersSet = new HashSet<string>(followers);

          
            peopleToUnfollow.Clear();
            dataTablePeopleToUnfollow.Rows.Clear();

           
            foreach (var following in followings)
            {
                if (!followersSet.Contains(following))
                {
                    totalCountOfUnfollowers += 1;
                    peopleToUnfollow.Add(following); 

                    string profileLink = $"https://instagram.com/{following}";
                    dataTablePeopleToUnfollow.Rows.Add(following, profileLink); 
                }
            }

            // Update UI elements
            lblTotalCountValue.Text = totalCountOfUnfollowers.ToString();
            dataGridViewPeopleToUnfollow.DataSource = dataTablePeopleToUnfollow;
        }

        private void DataGridViewPeopleToUnfollow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPeopleToUnfollow.Columns[e.ColumnIndex].Name == "Profile Link")
            {
                string url = dataGridViewPeopleToUnfollow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                try
                {
                    string targetUrl = $"{url}";
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = targetUrl,
                        UseShellExecute = true 
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String userToFind = searchBox.Text;
            totalCountOfUnfollowers = 0;
            // Check if there are any users to search
            if (peopleToUnfollow == null || peopleToUnfollow.Count == 0)
            {
                MessageBox.Show("No users available to search. Please generate the list first.");
                return;
            }

            dataGridViewPeopleToUnfollow.DataSource = null;
            dataTablePeopleToUnfollow.Rows.Clear();

            foreach (var person in peopleToUnfollow)
            {
                if (person.IndexOf(userToFind, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    string profileLink = $"https://instagram.com/{person}";
                    dataTablePeopleToUnfollow.Rows.Add(person, profileLink);
                    totalCountOfUnfollowers++;
                }
            }

            dataGridViewPeopleToUnfollow.DataSource = dataTablePeopleToUnfollow;

            dataGridViewPeopleToUnfollow.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewPeopleToUnfollow.Columns["Profile Link"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lblTotalCountValue.Text = totalCountOfUnfollowers.ToString();

            if (dataTablePeopleToUnfollow.Rows.Count == 0)
            {
                MessageBox.Show("No matches found for the entered username.");
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            buttonUnfollowPeople_Click(sender, e);
            searchBox.Text = string.Empty;
        }
    }
}
