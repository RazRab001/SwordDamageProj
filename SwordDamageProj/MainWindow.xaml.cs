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

namespace SwordDamageProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeaponDamage swordDamage;
        public MainWindow()
        {
            InitializeComponent();
            listBox.Items.Add(new SwordDamage());
            listBox.Items.Add(new ArrowDamage());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (swordDamage != null)
            {
                swordDamage.Rolling();
                text.Text = swordDamage.Damage.ToString();
            }
        }

        private void flameCheck_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.IsFlame = true;
            text.Text = swordDamage.Damage.ToString();
        }
        private void flameCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.IsFlame = false;
            text.Text = swordDamage.Damage.ToString();
        }

        private void magicCheck_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.IsMagic = true;
            text.Text = swordDamage.Damage.ToString();
        }
        private void magicCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.IsMagic = false;
            text.Text = swordDamage.Damage.ToString();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem is WeaponDamage selectedWeapon)
            {
                swordDamage = selectedWeapon;
            }
        }
    }
}
