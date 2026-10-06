namespace URL_functies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Stap 1======
1. Welke functies heb je nodig? Noteer voor elke functie een naam. Zorg ervoor dat de naam onmiddellijke duidelijk is voor wat deze functie moet doen.
        HaalProtocol
        HaalDomeinnaam

=======Analyse Stap 2======
HaalProtocol
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        een URl - string

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        de positie van de eerste ":" nemen (IndexOf)
        alles voor de eerste ":" is de Protocol

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        Protocol = http

HaalDomeinnaam
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        een URl - string

2. Bewerking: Welke formules heb je nodig om de berekening te kunnen doen?
        de positie van de eerste "." nemen (IndexOf)
        de positie van de laatste "/" nemen (IndexOf)
        positie / - positie . is lengte domein
        substring ( positie punt , lengte domein) = het domein

3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        Domeinnaam = broeders.be

==========Testdata=========

4. Testdata: Verzin en noteer testgegevens, en bereken met je rekenmachine de juiste oplossing. Zo weet je of je oefening klopt.
        Url = http://www.broeders.be/startpagina
        Wordt
        Protocol = http
        Domeinnaam = broeders.be

=========================== */
        private void ProtocolButton_Click(object sender, EventArgs e)
        {
            string URL = Convert.ToString(InputTextBox.Text);
            OutputLabel.Text = HaalProtocol(URL);
        }

        private void DomeinnaamButton_Click(object sender, EventArgs e)
        {
            string URL = Convert.ToString(InputTextBox.Text);
            OutputLabel.Text = HaalDomeinnaam(URL);
        }


        private string HaalProtocol(string URL)
        {
            int PositieDubbelPunt = URL.IndexOf(":");
            return URL.Substring(0, PositieDubbelPunt);
        }


        private string HaalDomeinnaam(string URL)
        {
            int PositiePunt = URL.IndexOf(".");
            int PositieSlash = URL.LastIndexOf("/");
            int LengteDomein = PositieSlash - PositiePunt;
            return URL.Substring((PositiePunt + 1), (LengteDomein - 1));
        }
    }
}
