using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_Loft_Membership_List
{
    public partial class main : Form
    {
        DatabaseLink dbl = new DatabaseLink();
        public main()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            //Sets the membership start date to today's date as soon as the form loads, formatted as shown
            //NOTE: May want to look into a way to have set today run every 24hrs and update in case the computer doesn't get shut down
            txt_StartDate.Text = getToday().ToString("MM/dd/yyyy");

            determineEndDate();

            //Create new lists for all the members, and the expired ones
            List<member> allMemberData = new List<member>();
            List<member> expiredMemberData = new List<member>();
            //populate those lists from our DatabaseLink class
            allMemberData = dbl.getFullMemberList();
            expiredMemberData = dbl.getExpiredMembers(allMemberData);
            //Populate the current members box and set it to display the full name, and nothing else (though that information is still present so we can use it)
            lst_CurrentMembers.DataSource = allMemberData;
            lst_CurrentMembers.DisplayMember = "fullName";
            //Ditto for the expired members 
            lst_ExpiredMembers.DataSource = expiredMemberData;
            lst_ExpiredMembers.DisplayMember = "fullName";
        }

        private void main_Load(object sender, EventArgs e)
        {
            refresh();   
        }


        private DateTime getToday()
        {
            //Returns the current day
            return DateTime.Today; 
        }

        private void determineEndDate()
        {
            DateTime today = getToday();
            DateTime expirationDate;

            if(rad_1Month.Checked == true) 
            {
                //Add one month to the current date to find the expiration of the membership if the 1 month radio button is checked
                expirationDate = today.AddDays(30); 
            }
            else if (rad_2Months.Checked == true)
            {
                expirationDate = today.AddDays(60); 
            }
            else
            {
                //This code should never execute
                expirationDate = today; 
            }

            //Finally, set the text box = to the new expiration date
            txt_EndDate.Text = expirationDate.ToString("MM/dd/yyyy"); 
        }

        private void chk_Override_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox determines if you can manually edit the text boxes for date or not
            if (chk_Override.Checked == true) 
            {
                txt_StartDate.Enabled = true;
                txt_EndDate.Enabled = true;
            }
            else
            {
                txt_StartDate.Enabled = false;
                txt_EndDate.Enabled = false;
            }
        }

        private void rad_1Month_CheckedChanged(object sender, EventArgs e)
        {
            determineEndDate();
        }

        private void updateStartEndDates(ListBox list)
        {
            // Make sure the list box isn't empty before we try and update the dates
            if (list.Items.Count > 0)
            {
                member selected = list.SelectedItem as member;
                DateTime expireDate = Convert.ToDateTime(selected.membershipEndDate);
                DateTime today = getToday();
                if (expireDate < today)
                {
                    lbl_ed.ForeColor = Color.Red;
                }
                else if (expireDate > today && expireDate < today.AddDays(14))
                {
                    lbl_ed.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    lbl_ed.ForeColor = Color.Black;
                }

                lbl_ed.Text = expireDate.ToShortDateString().ToString();
                lbl_sd.Text = selected.membershipStartDate.ToString();
            }
            else
            {
                lbl_ed.Text = "xx/xx/xxxx";
                lbl_sd.Text = "xx/xx/xxxx";
            }
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            DateTime sdateholder, edateholder;

            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_StartDate.Text == "" || txt_EndDate.Text == "")
            {
                MessageBox.Show("Please fill out all field before adding a member");
            }
            else
            {
                try
                {
                    // Verify that the user entered a valid date
                    sdateholder = Convert.ToDateTime(txt_StartDate.Text);
                    edateholder = Convert.ToDateTime(txt_EndDate.Text);

                    string fname = txt_FirstName.Text;
                    string lname = txt_LastName.Text;
                    // Convert the date back into a string with the proper format (in the event the user left out a 0 or used a 2 didget year)
                    string sDate = sdateholder.ToString("MM/dd/yyyy");
                    string eDate = edateholder.ToString("MM/dd/yyyy");

                    dbl.addToDatabase(fname, lname, sDate, eDate);
                    refresh();
                    txt_FirstName.Text = "";
                    txt_LastName.Text = "";
                }

                catch
                {
                    MessageBox.Show("Please Enter a Valid Date.");
                }
            }
        }

        private void btn_Renew_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/36995639/get-object-information-of-selected-listbox-item
            

            member selected;
            // Returns the selected item in our list box as an object of type member
            // Figures out which list box to use based on the tab selected. Also verifies that the list isn't empty to avoid a crash
            if (tabs.SelectedTab == tabs.TabPages["tab_current"] && lst_CurrentMembers.Items.Count > 0)
            {
                selected = lst_CurrentMembers.SelectedItem as member;
            }
            else if (tabs.SelectedTab == tabs.TabPages["tab_expired"] && lst_ExpiredMembers.Items.Count > 0)
            {
                selected = lst_ExpiredMembers.SelectedItem as member;
            }
            else
            {
                selected = null;
            }

            if(selected != null)
            {
                DateTime today = getToday();
                dbl.renewMembership(selected, today);
                refresh();
                MessageBox.Show("Membership successfully renewed!");
            }
            else
            {
                MessageBox.Show("Please make a valid selection from the member's list");
            }
        }

        private void btn_DeleteMember_Click(object sender, EventArgs e)
        {
            member selected;
            long selectedID;

            if (tabs.SelectedTab == tabs.TabPages["tab_current"] == true)
            {
                selected = lst_CurrentMembers.SelectedItem as member;
            }
            else if (tabs.SelectedTab == tabs.TabPages["tab_expired"])
            {
                selected = lst_ExpiredMembers.SelectedItem as member;
            }
            else
            {
                // This only happens if a empty list is present
                selected = null;
            }
            
            if (selected != null)
            {
                selectedID = selected.Id;
                dbl.deleteMember(selectedID);
                refresh();
                MessageBox.Show("Member " + selected.firstName + " " + selected.lastName + " deleted");
            }
   
            else
            {
                MessageBox.Show("Please Make a Selection from the list");
            }

        }

        private void lst_ExpiredMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the list box isn't empty, try and update the date
            updateStartEndDates(lst_ExpiredMembers);
        }

        private void lst_CurrentMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStartEndDates(lst_CurrentMembers);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tabs.TabPages["tab_current"])
            {
                updateStartEndDates(lst_CurrentMembers);
            }
            else
            {
                updateStartEndDates(lst_ExpiredMembers);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int index;
            string search = txt_MemberSearch.Text;
            ListBox lb;

            if (tabs.SelectedTab == tabs.TabPages["tab_current"])
            {
                lb = lst_CurrentMembers;    
            }
            else
            {
                lb = lst_ExpiredMembers;
            }

            if (search != "")
            {
                index = lb.FindString(search);
                if (index != -1)
                {
                    lb.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show("No Members Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid search term");
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Billiard Loft Membership List: Version 1.5 by Connor McNamara", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
