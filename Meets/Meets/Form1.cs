using Meets.Meetings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Meets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var meetingList = new MeetingList();
            var nextMeet = meetingList.GetFirstMeeting();
            MeetingNameLbl.Text = nextMeet.Name;
            MeetingDateLbl.Text = nextMeet.StartDate.DateTime.ToShortDateString() + " " + nextMeet.StartDate.DateTime.ToShortTimeString();
            MeetingTypeLbl.Text = nextMeet.Type.ToString();
            var allMeets = meetingList.GetAllMeetings();
            int i = 0;
            foreach ( Meeting meeting in allMeets )
            {
                listViewMeets.Items.Add(meeting.Name);
                listViewMeets.Items[i].SubItems.Add(meeting.ResponsiblePerson.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.Category.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.Type.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.StartDate.ToString());
                listViewMeets.Items[i].SubItems.Add((meeting.EndDate - meeting.StartDate).Minutes.ToString() + " min");
                i++;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewMeets.SelectedItems.Count < 1)
                return;
            MeetingList meetingList = new MeetingList();
            foreach(ListViewItem selectedMeet in  listViewMeets.SelectedItems)
            {
                meetingList.DeleteMeeting(selectedMeet.Index);
                listViewMeets.Items.Remove(selectedMeet);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddMeetingForm newMeetingForm = new AddMeetingForm();
            if(newMeetingForm.ShowDialog() == DialogResult.OK)
            RefreshList(new MeetingList());
        }

        public void RefreshList(MeetingList meetingList)
        {
            var allMeets = meetingList.GetAllMeetings();
            int i = 0;
            listViewMeets.Items.Clear();
            foreach (Meeting meeting in allMeets)
            {
                listViewMeets.Items.Add(meeting.Name);
                listViewMeets.Items[i].SubItems.Add(meeting.ResponsiblePerson.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.Category.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.Type.ToString());
                listViewMeets.Items[i].SubItems.Add(meeting.StartDate.ToString());
                listViewMeets.Items[i].SubItems.Add((meeting.EndDate - meeting.StartDate).Minutes.ToString() + " min");
                i++;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MeetingList meetingList = new MeetingList();
            meetingList.CsMeetingsToJson();
        }

        private void listViewMeets_ItemActivate(object sender, EventArgs e)
        {
            MeetingList meetingList = new MeetingList();
            DetailsForm detailsForm = new DetailsForm();
            this.Tag = meetingList.GetMeetingAt(listViewMeets.SelectedItems[0].Index);
            detailsForm.Show();
        }
    }
}
