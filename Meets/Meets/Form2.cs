using Meets.Meetings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meets
{
    public partial class AddMeetingForm : Form
    {
        public AddMeetingForm()
        {
            InitializeComponent();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ParticipantAddBtn_Click(object sender, EventArgs e)
        {
            listViewParticipants.Items.Add(ParticipantTxtBox.Text);
            ParticipantTxtBox.Clear();
        }

        private void ParticipantTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ParticipantTxtBox.Text.Length < 1)
            {
                ParticipantAddBtn.Enabled = false;
                return;
            }
            ParticipantAddBtn.Enabled = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            MeetingList meetingList = new MeetingList();
            if(NameTxtBox.Text.Length > 0 && comboBoxCategory.Text.Length > 0 && comboBoxType.Text.Length > 0 
                && HelperLibrary.DateFunctions.IsValidDateTime(StartDatePicker.Value.ToString())
                && HelperLibrary.DateFunctions.IsValidDateTime(EndingDatePicker.Value.ToString()))
            {

                var name = NameTxtBox.Text;
                var description = DescTxtBox.Text;
                var categoryIndex = comboBoxCategory.Items.IndexOf(comboBoxCategory.Text);
                var typeIndex = comboBoxType.Items.IndexOf(comboBoxType.Text);
                var startDate = StartDatePicker.Value;
                var endDate = EndingDatePicker.Value;
                var participants = new List<string>();
                foreach(var participant in listViewParticipants.Items)
                {
                    participants.Add(participant.ToString());
                }
                Meeting newMeeting = new Meeting(name, User.Name, description, categoryIndex, typeIndex, startDate, endDate, participants);
                meetingList.AddMeeting(newMeeting);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                WarningForm warningForm = new WarningForm();
                warningForm.Show();
            }
        }
    }
}
