using System;
using System.Drawing;
using System.Windows.Forms;

namespace Saper
{
    public class SingleField
    {
        public int FieldValue { get; set; }     // określa czy w poblizu pola znajduje się bomba - 9 = bomba
        public bool HasABomb { get; set; }
        public bool IsHide { get; set; }
        public bool IsChecked { get; set; }
        public int X;
        public int Y;
        public Button FieldButton { get; }

         public SingleField(int x, int y)
         {
            FieldValue = 0;
            HasABomb = false;
            IsHide = true;
            X = x;
            Y = y;

            FieldButton = new Button
            {
                Text = "",
                BackColor = SystemColors.ButtonFace,
                Width = 30,
                Height = 30
            };
            FieldButton.Click += new EventHandler(ClickField);
            FieldButton.MouseDown += new MouseEventHandler(RightClick_MouseDown);
         }

        private void ClickField(object sender, EventArgs e)
        {
            if (!IsHide) return;
            if (HasABomb)
            {
                FieldButton.Text = @"X";
                FieldButton.BackColor = Color.Red;
            }
            IsHide = false;
            this.FieldButton.Text = FieldValue.ToString();
            RemoveHandler(e);
        }

        private void RightClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (!IsHide) return;
            if (!IsChecked)
            {
                FieldButton.Text = @"?";
                IsChecked = true;
                RemoveHandler(e); // TODO: Sprawdzić
            }
            else
            {
                FieldButton.Text = "";
                IsChecked = false;
                AddHandler(e);
            }
        }

        private void RemoveHandler(EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                FieldButton.Click -= ClickField;
            }
            else
            {
                FieldButton.MouseDown -= ClickField;
            }
        }

        private void AddHandler(EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                FieldButton.Click += ClickField;
            }
           /* else
            {
                FieldButton.Click += ClickField;
            }*/
        }
    }
}