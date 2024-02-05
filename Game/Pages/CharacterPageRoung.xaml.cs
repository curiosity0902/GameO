﻿using Game.Mongodb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для CharacterPageRoung.xaml
    /// </summary>
    public partial class CharacterPageRoung : Page // создание разбойника rogue
    {
        public CharacterPageRoung()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int strength = Convert.ToInt32(StrengthTb.Text);
            int intelegence = Convert.ToInt32(IntelegenceTb.Text);
            int dexterity = Convert.ToInt32(DexterityTb.Text);
            int vitality = Convert.ToInt32(VitalityTb.Text);
            CRUD.CreateCharacterRogue(new Character(name, strength, 65, dexterity, 250, intelegence, 70, vitality, 70, 0, 0, 0, 0, 0, 0, 0, 0));
            NavigationService.Navigate(new Characters());
        }
    }
}
