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
    /// Логика взаимодействия для Characters.xaml
    /// </summary>
    public partial class Characters
    {
        //public int 
        public Characters()
        {
            InitializeComponent();
        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            Character warrior = new Character("Warrior");
            warrior.CalculateStats();
            CharacterPage warriorPage = new CharacterPage(warrior);
            this.Content = warriorPage;
        }

        private void RogueBtn_Click(object sender, RoutedEventArgs e)
        {
            Character rogue = new Character("Rogue");
            rogue.CalculateStats();
            CharacterPage roguePage = new CharacterPage(rogue);
            this.Content = roguePage;
        }

        private void WizardBtn_Click(object sender, RoutedEventArgs e)
        {
            Character wizard = new Character("Mage");
            wizard.CalculateStats();
            CharacterPage wizardPage = new CharacterPage(wizard);
            this.Content = wizardPage;
        }
    }
}
