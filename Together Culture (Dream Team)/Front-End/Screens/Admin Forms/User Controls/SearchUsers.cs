﻿using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Together_Culture__Dream_Team_.Back_End.Src.Main;
using Together_Culture__Dream_Team_.Front_End.Screens.Admin_Forms.User_Controls;

namespace Together_Culture__Dream_Team_.Front_End.Src.User_Controls
{
    public partial class SearchUsers : UserControl
    {
        private DataTable userDataTable;
        ActionsSearchUsers ActionsSearchUsers = new ActionsSearchUsers();
        FilterSearchUsers FilterSearchUsers = new FilterSearchUsers();

        private bool isFilterSearchUsersVisible = false;
        private bool isActionsSearchUsersVisible = false;

        public SearchUsers()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            AddCheckBoxColumn();

            // Subscribe to the FilterApplied event from FilterSearchUsers
            FilterSearchUsers.FilterApplied += FilterSearchUsers_FilterApplied;
        }

        // Event handler for FilterApplied from FilterSearchUsers
        private void FilterSearchUsers_FilterApplied(object sender, EventArgs e)
        {
            // Check if the filter is sorting by name and if it's ascending or descending
            bool isAscending = FilterSearchUsers.IsAscending;

            // Apply the sort to the DataGridView based on the selected radio button
            SortDataGridView(isAscending);
        }

        private void SortDataGridView(bool isAscending)
        {
            if (userDataTable != null)
            {
                string sortOrder = isAscending ? "ASC" : "DESC";
                userDataTable.DefaultView.Sort = $"last_name {sortOrder}";
                dataGridView1.DataSource = userDataTable.DefaultView;
            }
            else
            {
                MessageBox.Show("No data available to sort.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showActionsSearchUsers(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            actionsPanel.Controls.Clear();
            actionsPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void showFilterSearchUsersVisible(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            filterPanel.Controls.Clear();
            filterPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ActionsSearchUsersBtn_Click(object sender, EventArgs e)
        {
            if (!isActionsSearchUsersVisible)
            {
                //show the actions mmenu bar
                actionsPanel.Visible = true;
                showActionsSearchUsers(ActionsSearchUsers);
                isActionsSearchUsersVisible = true;
                BringToFront();
            }
            else
            {
                //hide the actions bar
                actionsPanel.Controls.Clear();
                actionsPanel.Visible = false;
                isActionsSearchUsersVisible = false;
            }
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (!isFilterSearchUsersVisible)
            {
                //show the filter menu bar
                filterPanel.Visible = true;
                showFilterSearchUsersVisible(FilterSearchUsers);
                isFilterSearchUsersVisible = true;
                BringToFront();
            }
            else
            {
                //hide the filter panel
                filterPanel.Controls.Clear();
                filterPanel.Visible = false;
                isFilterSearchUsersVisible = false;
            }
        }

        private void ActionsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!isActionsSearchUsersVisible)
            {
                actionsPanel.Visible = false;
            }
        }

        private void FilterPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!isFilterSearchUsersVisible)
            {
                filterPanel.Visible = false;
            }
        }

        private void SearchUsersTxtBx_MouseClic(object sender, MouseEventArgs e)
        {
            // Only clear the placeholder text if it's the default
            if (searchUsersTxtBx.Text == "Search users...")
            {
                searchUsersTxtBx.Text = "";
                searchUsersTxtBx.ForeColor = System.Drawing.Color.Black; // Change text color to black when editing
            }
        }

        private void SearchUsersTxtBx_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the user has left it empty
            if (string.IsNullOrEmpty(searchUsersTxtBx.Text))
            {
                //searchUsersTxtBx.Text = "Search users....";
                searchUsersTxtBx.ForeColor = System.Drawing.Color.Gray; // Change color back to gray
            }
        }

        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure DataGridView contains rows
            if (dataGridView1.Rows.Count > 0)
            {
                bool selectAll = selectAllCheckBox.Checked;


                // Iterate through rows and set checkbox state
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = selectAll; // Check or Uncheck based on Select All state
                    }
                }
            }
        }

        private void AddCheckBoxColumn()
        {
            // Add a checkbox column if not already present
            if (!dataGridView1.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Select",
                    Name = "Select",
                    Width = 50
                };
                dataGridView1.Columns.Insert(0, checkBoxColumn);
            }
        }


        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked column is the checkbox column
            if (e.ColumnIndex == dataGridView1.Columns["Select"].Index)
            {
                // Check if all rows are selected or not
                bool allChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Select"].Value == null || !(bool)row.Cells["Select"].Value)
                    {
                        allChecked = false;
                        break;
                    }
                }

                // Update the "Select All" checkbox state
                selectAllCheckBox.CheckedChanged -= SelectAllCheckBox_CheckedChanged; // Temporarily unsubscribe
                selectAllCheckBox.Checked = allChecked;
                selectAllCheckBox.CheckedChanged += SelectAllCheckBox_CheckedChanged; // Re-subscribe
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (DatabaseConnect database = new DatabaseConnect())
                {
                    database.Open();

                    // Query to fetch all user data
                    string query = "SELECT username, first_name, last_name, date_joined FROM [user]";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.Connection);

                    // Fill the DataTable with the retrieved data
                    userDataTable = new DataTable();
                    dataAdapter.Fill(userDataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = userDataTable;

                    // Set column headers
                    dataGridView1.Columns["username"].HeaderText = "Username";
                    dataGridView1.Columns["first_name"].HeaderText = "First Name";
                    dataGridView1.Columns["last_name"].HeaderText = "Last Name";
                    dataGridView1.Columns["date_joined"].HeaderText = "Date Joined";

                    // Set default header height
                    dataGridView1.ColumnHeadersHeight = 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleSeeEventsAction(List<string> selectedUsers)
        {
            if (selectedUsers.Count == 0)
            {
                MessageBox.Show("Please select at least one user.");
                return;
            }

            // Clear existing rows in DataGridView to make room for event data
            dataGridView1.Rows.Clear();

            // Loop through the selected users and fetch events
            foreach (var username in selectedUsers)
            {
                string query = @"
            SELECT e.event_name, eo.event_date, eo.event_time, eo.event_location 
            FROM event_orders eo
            JOIN events e ON eo.event_id = e.event_id
            JOIN [user] u ON eo.user_id = u.user_id
            WHERE u.username = @username";  // Filter by selected user

                // Execute the query and get event data
                using (DatabaseConnect database = new DatabaseConnect())
                {
                    database.Open();
                    SqlCommand command = new SqlCommand(query, database.Connection);
                    command.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = command.ExecuteReader();

                    // Display the user's events
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            username,                         // Username
                            reader["event_name"].ToString(),   // Event Name
                            reader["event_date"].ToString(),   // Event Date
                            reader["event_time"].ToString(),   // Event Time
                            reader["event_location"].ToString()// Event Location
                        );
                    }
                }
            }
        }

        private void SearchUsersTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (userDataTable != null)
            {
                string searchValue = searchUsersTxtBx.Text.Trim().Replace("'", "''");

                // Prevent the placeholder text from being used in the search
                if (searchValue != "Search users..." && !string.IsNullOrEmpty(searchValue))
                {
                    DataView dv = userDataTable.DefaultView;
                    dv.RowFilter = $@"
                    username LIKE '%{searchValue}%' OR
                    first_name LIKE '%{searchValue}%' OR
                    last_name LIKE '%{searchValue}%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    // Reset the data grid when no search text is entered
                    dataGridView1.DataSource = userDataTable;
                }
            }
        }

        public List<string> GetSelectedUsers()
        {
            List<string> selectedUsers = new List<string>();

            // Ensure DataGridView contains rows
            if (dataGridView1.Rows.Count > 0)
            {
                // Iterate through the rows to get selected users
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        // Assuming the user_id column is the first column
                        string userId = row.Cells["user_id"].Value.ToString();
                        selectedUsers.Add(userId);
                    }
                }
            }

            return selectedUsers;
        }
    }
}
