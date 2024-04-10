using System;
using System.Windows.Forms;

namespace RentACable.Views
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void LendButton_Click(object sender, System.EventArgs e)
        {
            contentTabs.SelectTab(0);
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab(1);
        }

        private void LabelsButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab(2);
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab(3);
        }
    }
}
