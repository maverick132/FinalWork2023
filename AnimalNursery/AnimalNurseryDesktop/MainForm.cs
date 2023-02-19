﻿using AnimalNurserynamespace;
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
                switch (subItemType.Text)
                {
                    case "Cat":
                        pet.Type = "Кошка";
                        break;
                    case "Dog":
                        pet.Type = "Собака";
                        break;
                    case "Hamster":
                        pet.Type = "Хомяк";
                        break;
                    case "Donkey":
                        pet.Type = "Осёл";
                        break;
                    case "Horse":
                        pet.Type = "Лошадь";
                        break;
                    case "Camel":
                        pet.Type = "Верблюд";
                        break;
                }
                 
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

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            FormAddAnimal formAddAnimal = new FormAddAnimal();
            formAddAnimal.ShowDialog();
        }

        private void toolStripMenuItemAddCommands_Click(object sender, EventArgs e)
        {
            FormAddCommands formAddCommands = new FormAddCommands(this.listViewAnimals.FocusedItem);
            formAddCommands.ShowDialog();
        }

        private void buttonUpdateAnimal_Click(object sender, EventArgs e)
        {
           AnimalNurseryClient animalNurseryClient = new AnimalNurseryClient("http://localhost:5244/",
           new System.Net.Http.HttpClient());
            HomeFriend homeFriend= new HomeFriend();
           
            foreach (ListViewItem item in listViewAnimals.Items)
            {
                if (item.Selected)
                {
                    homeFriend = animalNurseryClient.GetByIdAsync(int.Parse(item.Text)).Result;

                }
            }

            FormUpdateAnimal formUpdateClient = new FormUpdateAnimal(homeFriend);
            formUpdateClient.ShowDialog();
        }

        private void buttonDeleteAnimal_Click(object sender, EventArgs e)
        {

            AnimalNurseryClient animalNurseryClient = new AnimalNurseryClient("http://localhost:5244/",
            new System.Net.Http.HttpClient());

            foreach (ListViewItem item in listViewAnimals.Items)
            {
                if (item.Selected)
                {

                    animalNurseryClient.DeleteAsync(int.Parse(item.Text));
                    listViewAnimals.Items.Remove(item);

                }
            }
        }

        private void toolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateAnimal formUpdateClient = new FormUpdateAnimal(listViewAnimals.FocusedItem);
            formUpdateClient.ShowDialog();
        }

        private void toolStripMenuItemDeleteAnimal_Click(object sender, EventArgs e)
        {
            AnimalNurseryClient animalNurseryClient = new AnimalNurseryClient("http://localhost:5244/",
            new System.Net.Http.HttpClient());

            FormUpdateAnimal formUpdateClient = new FormUpdateAnimal(listViewAnimals.FocusedItem);
            animalNurseryClient.DeleteAsync(int.Parse(listViewAnimals.FocusedItem.Text));
            listViewAnimals.Items.Remove(listViewAnimals.FocusedItem);
        }
    }
}
