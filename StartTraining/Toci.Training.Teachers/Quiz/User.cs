using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class User
    {
        public int UserId => _userId;
        public string Name { get; set; }
        public int Score { get; private set; }
        public int GroupMambership { get; set; }
        public List<String> ResolvedQuiz { get; private set; }

        private static int _userId = 0;

        public User(string name)
        {
            _userId++;
            Name = name;
        }

        public bool AddResolvedQuiz(string quizName)
        {
            if (String.IsNullOrEmpty(quizName) || ResolvedQuiz.Contains(quizName))
                return false;
            ResolvedQuiz.Add(quizName);
            return true;

        }

        public void AllocationOfPoints(int points)
        {
            if (points >= 0)
                Score += points;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
