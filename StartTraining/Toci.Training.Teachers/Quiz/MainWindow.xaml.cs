using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly QuizManager _quizManager;

        public MainWindow()
        {
            InitializeComponent();
            _quizManager = FindResource("QuizManager") as QuizManager;
        }

        private void AddUser()
        {
            if (_quizManager.AddUser(UserNameTextBox.Text))
            {
                ConfirmedTextBlock.Text = "Added";
                ConfirmedTextBlock.Visibility = Visibility.Visible;
                UserNameTextBox.Clear();
            }
            else
            {

                ConfirmedTextBlock.Text = "Empty box or name exist";
                ConfirmedTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void ButtonBase_OnClick(object sender, EventArgs e)
        {
            if (e is KeyEventArgs)
            {
                var keyEvents = e as KeyEventArgs;
                if (keyEvents.Key == Key.Enter)
                    AddUser();
            }
            else if (e is RoutedEventArgs)
            {
                var mouseEvents = e as MouseEventArgs;
                AddUser();
            }
        }

        private void AddGroupButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_quizManager.CreateGroup(CreatedGroupPanel.Items, GroupNameTextBox.Text))
            {
                GroupWarringTextBlock.IsEnabled = true;
                GroupWarringTextBlock.Text = "Name already exist. \nPlease change group name.";
            }
            else
            {
                GroupWarringTextBlock.IsEnabled = false;
                CreatedGroupPanel.Items.Clear();
                AddGroupButton.IsEnabled = false;
                GroupNameTextBox.Clear();
            }
        }

        private void UserList_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListView)
            {
                ListView list = (ListView) sender;
                var user = list.SelectedItem as User;
                if (user?.GroupMambership != null || CreatedGroupPanel.Items.Contains(list.SelectedItem))
                {
                    AllUserWaringTextBlock.Text = "User already has a group";
                    return;
                }
                AllUserWaringTextBlock.Text = "";
                CreatedGroupPanel.Items.Add(list.SelectedItem);
                AddGroupButton.IsEnabled = true;
            }
        }
    }
}
