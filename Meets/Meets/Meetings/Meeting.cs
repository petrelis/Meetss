using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace Meets.Meetings
{
    public class Meeting : Object
    {
        public enum MeetingCategory
        {
            Sales,
            Dev,
            Management
        }
        public enum MeetingType
        {
            InPerson,
            OnLine
        }

        public string Name { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Description { get; set; }
        public MeetingCategory Category { get; set; }
        public MeetingType Type { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public List<string> Participants { get; set; }


        public Meeting(string Name, string ResponsiblePerson, string Description, int CategoryIndex, int TypeIndex, DateTimeOffset StartDate, DateTimeOffset EndDate, List<string> Participants)
        {
            this.Name = Name;
            this.ResponsiblePerson = ResponsiblePerson;
            this.Description = Description;
            this.Category = (MeetingCategory)CategoryIndex;
            this.Type = (MeetingType)TypeIndex;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Participants = Participants;
        }

        public static Meeting AddNewMeeting(String username)
        {
            Console.Clear();
            var name = "test"; //ConsoleInputOutputFunctions.GetNotNullStringFromReadLine("name");
            var responsiblePerson = "test";
            var description = Console.ReadLine();
            var categoryIndex = 1;//GetCategoryIndex();
            var typeIndex = 1;//GetTypeIndex();
            var startDate = new DateTimeOffset();// DateFunctions.GetStartDateTime();
            var endDate = new DateTimeOffset();// DateFunctions.GetEndDateTime(startDate);
            var participants = new List<string>();

            var newMeeting = new Meeting(name,
                responsiblePerson,
                description,
                categoryIndex,
                typeIndex,
                startDate,
                endDate,
                participants);

            return newMeeting;
        }
    }
}
