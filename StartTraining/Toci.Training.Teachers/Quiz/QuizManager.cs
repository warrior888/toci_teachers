using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;

namespace Quiz
{
    public class QuizManager
    {
        public ObservableCollection<User> Users { get; private set; }
        public List<Group> Groups { get; private set; }
        public List<QuizToSolve> QuizToSolves { get; private set; }

        public QuizManager()
        {
            Users = new ObservableCollection<User>();
            Groups = new List<Group>();
            QuizToSolves = new List<QuizToSolve>();
            // TODO: Dokończyć
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

        public void CreateGroup(string[] usernames)
        {
            var findUsers = from user in Users
                where usernames.Contains(user.Name)
                select user;

            Group newGroup = new Group();

            foreach (var user in findUsers)
                newGroup.AddMember(user);

            Groups.Add(newGroup);
        }
    }
}