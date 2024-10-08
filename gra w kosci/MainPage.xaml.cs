

namespace gra_w_kosci
{
    public partial class MainPage : ContentPage
    {
        int[] tab = new int[5];
        int wynik = 0;
        int poprzedni_wynik = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void rzut(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(1, 7);
                wynik += tab[i];
            }
            obraz1.Source = "kosc" + tab[0] + ".png";
            obraz2.Source = "kosc" + tab[1] + ".png";
            obraz3.Source = "kosc" + tab[2] + ".png";
            obraz4.Source = "kosc" + tab[3] + ".png";
            obraz5.Source = "kosc" + tab[4] + ".png";
            wynik_losowania.Text = "Wynik tego losowania: " + wynik;
            poprzedni_wynik += wynik;
            wynik_calkowity.Text = "Wynik gry: " + poprzedni_wynik;
            wynik = 0;
        }

        private void reset(object sender, EventArgs e)
        {
            obraz1.Source = "nic.png";
            obraz2.Source = "nic.png";
            obraz3.Source = "nic.png";
            obraz4.Source = "nic.png";
            obraz5.Source = "nic.png";
            wynik_losowania.Text = "Wynik tego losowania:";
            wynik_calkowity.Text = "Wynik gry:";
            wynik = 0;
            poprzedni_wynik = 0;
        }
    }

}
