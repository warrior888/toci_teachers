﻿using System;
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
        public Dictionary<string, Group> Groups { get; private set; }
        public List<QuizToSolve> QuizToSolves { get; private set; }

        public QuizManager()
        {
            Users = new ObservableCollection<User>();
            Groups = new Dictionary<string, Group>();
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

        public bool CreateGroup(ItemCollection @group, string name)     //(string[] usernames)
        {
            if (Groups.Keys.Contains(name)) return false;

            /*var findUsers = from user in Users
                where @group.Contains(user)
                select user;*/

            Group newGroup = new Group();

            foreach (var user in @group)
            {
                var itIsUser = user as User;
                if (itIsUser != null)
                {
                    itIsUser.GroupMambership = newGroup.GroupId;
                    newGroup.AddMember(itIsUser);
                }
            }
            Groups.Add(name, newGroup);
            return true;
        }
    }
}