using System.Collections.Generic;
using System.Windows.Documents;

namespace Quiz
{
    public class Group
    {
        public int GroupId { get; private set; }
        public List<User> GroupMember { get; private set; }
        public int GroupPoints { get; private set; }

        private const int MaxMembersInGroup = 4;

        public Group()
        {
            GroupId++;
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