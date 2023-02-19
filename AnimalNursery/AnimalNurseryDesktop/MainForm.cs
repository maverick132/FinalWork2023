using AnimalNurserynamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalNurseryDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      
        private void buttonLoadAnimals_Click(object sender, EventArgs e)
        {
            AnimalNurseryClient animalNurseryClient = new AnimalNurseryClient("http://localhost:5244/",
            new System.Net.Http.HttpClient());

            ICollection<HomeFriend> homeFriends = animalNurseryClient.GetAllAsync().Result;
           
            listViewAnimals.Items.Clear();
            foreach (HomeFriend pet in homeFriends)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.Id.ToString();

                ListViewItem.ListViewSubItem subItemName = new ListViewItem.ListViewSubItem();
                subItemName.Text = pet.Name;
                item.SubItems.Add(subItemName);

                ListViewItem.ListViewSubItem subItemType = new ListViewItem.ListViewSubItem();
                subItemType.Text = pet.Type;
                item.SubItems.Add(subItemType);

                ListViewItem.ListViewSubItem subItemCommand = new ListViewItem.ListViewSubItem();
                subItemCommand.Text = string.Join(", ", pet.Commands);
                item.SubItems.Add(subItemCommand);

                ListViewItem.ListViewSubItem subItemBirthday = new ListViewItem.ListViewSubItem();
                subItemBirthday.Text = pet.Birthday.Date.ToShortDateString().ToString();
                item.SubItems.Add(subItemBirthday);

                listViewAnimals.Items.Add(item);
            }
        }
    }
}
