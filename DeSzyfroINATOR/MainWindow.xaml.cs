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

namespace DeSzyfroINATOR
{
    public partial class MainWindow : Window
    {
        bool tru = false;
        public MainWindow()
        {
            InitializeComponent();
            tru = true;
        }

        private void Ramka1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tru && Ramka1.Text != null) { 
                string dane = Ramka1.Text;
                if (dane.Length >= 4) { ID1.Text = dane.Substring(0, 4); } // ID
                if (dane.Length >= 8) { F1.Text = dane.Substring(4,4); } // F
                if (dane.Length >= 12) { Rej1.Text = dane.Substring(8, 4); } // Rej
                if (dane.Length >= 132) { Blok11.Text = dane.Substring(12, 120); } // Blok1
                if (dane.Length >= 252) { Blok12.Text = dane.Substring(132, 120); } // Blok2
                if (dane.Length >= 372) { Blok13.Text = dane.Substring(252, 120); } // Blok3
                if (dane.Length >= 492) { Blok14.Text = dane.Substring(372, 120); } // Blok4
                if (dane.Length >= 612) { Blok15.Text = dane.Substring(492, 120); } // Blok5
                if (dane.Length >= 732) { Blok16.Text = dane.Substring(612, 120); } // Blok6
                if (dane.Length >= 852) { Blok17.Text = dane.Substring(732, 120); } // Blok7
                if (dane.Length >= 972) { Blok18.Text = dane.Substring(852, 120); } // Blok8
                if (dane.Length >= 1012) { Blok19.Text = dane.Substring(972, 40); } // Blok E
                if (dane.Length >= 1020) { CRC1.Text = dane.Substring(1012, 8); } // CRC
            }
        }

        private void Ramka2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tru && Ramka2.Text != null)
            {
                string dane = Ramka2.Text;
                if (dane.Length >= 4) { ID2.Text = dane.Substring(0, 4); } // ID
                if (dane.Length >= 8) { F2.Text = dane.Substring(4, 4); } // F
                if (dane.Length >= 12) { Rej2.Text = dane.Substring(8, 4); } // Rej
                if (dane.Length >= 132) { Blok21.Text = dane.Substring(12, 120); } // Blok1
                if (dane.Length >= 252) { Blok22.Text = dane.Substring(132, 120); } // Blok2
                if (dane.Length >= 372) { Blok23.Text = dane.Substring(252, 120); } // Blok3
                if (dane.Length >= 492) { Blok24.Text = dane.Substring(372, 120); } // Blok4
                if (dane.Length >= 612) { Blok25.Text = dane.Substring(492, 120); } // Blok5
                if (dane.Length >= 732) { Blok26.Text = dane.Substring(612, 120); } // Blok6
                if (dane.Length >= 852) { Blok27.Text = dane.Substring(732, 120); } // Blok7
                if (dane.Length >= 972) { Blok28.Text = dane.Substring(852, 120); } // Blok8
                if (dane.Length >= 1012) { Blok29.Text = dane.Substring(972, 40); } // Blok E
                if (dane.Length >= 1020) { CRC2.Text = dane.Substring(1012, 8); } // CRC
            }
        }
    }
}
