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
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage
    {
        public CharacterPage(Character character)
        {
            InitializeComponent();
            characterName.Text = character.Name;
            characterStats.Text = $"Strength: {character.Strength}, Intelligence: {character.Intelligence}, Agility: {character.Agility}";
        }
    }
}
