using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Quiz
{
    public class Group
    {
        public static int GroupId { get; private set; }
        public List<User> GroupMember { get; private set; }
        public int GroupPoints { get; private set; }
        public string GroupName { get; private set; }

        private const int MaxMembersInGroup = 4;

        public Group(string name)
        {
            GroupName = name;
            ++GroupId;
            GroupMember = new List<User>();
        }

        public override string ToString()
        {
            return GroupId.ToString();
        }

        public bool AddMember(User user)
        {
            if (user == null) return false;
            if (GroupMember.Count <= MaxMembersInGroup)
            {
                GroupMember.Add(user);
                return true;
            }
            return false;
        }

        public void SummGroupPoints()
        {
            foreach (var member in GroupMember)
            {
                GroupPoints += member.Score;
            }
        }
    }
}