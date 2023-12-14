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

namespace Meets
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void ParticipantListForm_Load(object sender, EventArgs e)
        {
            var selectedMeet = Application.OpenForms["Form1"].Tag as Meeting;
            NameLbl.Text = selectedMeet.Name;
            DescriptionLbl.Text = selectedMeet.Description;
            listViewParticipants.Items.Clear();
            foreach(var participant in selectedMeet.Participants)
            {
                listViewParticipants.Items.Add((participant.Replace("ListViewItem: {", "")).Replace("}", ""));
            }
        }
    }
}
