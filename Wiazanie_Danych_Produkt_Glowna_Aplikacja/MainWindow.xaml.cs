using System.Windows;

namespace Wiazanie_Danych_Produkt_Glowna_Aplikacja
{
    public partial class MainWindow : Window
    {
        private Produkt pl = null;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            pl = new Produkt("DZ-10", "długopis żelowy", 132, "Katowice 1");
            gridProdukt.DataContext = pl;
        }

        private void btnPotwierdz_Click(object sender, RoutedEventArgs e)
        {
            string tekst = string.Format("{0} {1}{2}", "Wprowadzono dane:", Environment.NewLine, pl.ToString());
            MessageBox.Show(tekst);
        }
    }
}
