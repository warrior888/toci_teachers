using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Quiz
{
    public class QuizManager
    {
        public ObservableCollection<User> Users { get; private set; }
        public ObservableCollection<Group> Groups { get; private set; }
        public List<QuizToSolve> QuizToSolves { get; private set; }

        public QuizManager()
        {
            Users = new ObservableCollection<User>();
            Groups = new ObservableCollection<Group>();
            QuizToSolves = new List<QuizToSolve>();
        }

        public bool AddUser(string name)
        {
            if (String.IsNullOrEmpty(name)) return false;

            var containsName = from user in Users
                where user.Name == name
                select user;

            if (containsName.Any()) return false;

            Users.Add(new User(name));
            return true;
        }

        public bool CreateGroup(ItemCollection @group, string name)
        {
            if (Groups.Any())
            {
                var findName = from gro in Groups
                    where gro.GroupName.Contains(name)
                    select gro;
                if (findName.Any()) return false;
            }
            Group newGroup = new Group(name);

            foreach (var user in @group)
            {
                var itIsUser = user as User;
                if (itIsUser != null)
                {
                    itIsUser.GroupMambership = newGroup.GroupName;
                    newGroup.AddMember(itIsUser);
                }
            }
            Groups.Add(newGroup);

            return true;
        }
    }
}