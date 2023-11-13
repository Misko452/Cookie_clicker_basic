using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_hra
{
    public partial class Main_hra : Form
    {
        public Main_hra()
        {
            InitializeComponent();

            //setup hry po spuštění programu

            Zaokrouhleni();
            pocet_babushek.Text = pocet_babicek.ToString();
            Generator.Interval = (int)interval;
            pictureBox1.Image = Properties.Resources.Cookie;
            Pocetrobotu.Text = pocet_robotu.ToString();
            labelrychlostautomatizace.Visible = false;
            labelrychlostautomatizace.Text = pomoc + " sušenek/s";

            this.Width = 380;
            this.Height = (int)velikost;
            
        }

        Random nahoda = new Random();
        

        double pocet_susenek = 0;
        bool shop = false;
        double interval = 1000;
        double nasobic_klikani = 1000000000;
        int velikost = 465 ;
        double pomoc = 0;
        bool nom = false;


        //upgrady

        //Babicka
        double pocet_babicek = 0;
        double cena_babicky = 50;

        //Nasobic
        double nasobek_kliknuti = 0;
        double cena_nasobice = 10;

        //Robot
        double pocet_robotu = 0;
        double cena_robotu = 150;

        //Farma
        double pocet_farma = 0;
        double cena_farmy = 1000;

        //Továrna
        double pocet_tovaren = 0;
        double cena_tovarny = 30000;

        //CHernobyl
        double pocet_chernobyl = 0;
        double cena_chernobylu = 300000;

        //Musk
        double pocet_Musk = 0;
        double cena_Musk = 1000000;

        //PLanety
        double pocet_planet = 0;
        double cena_planet = 20000000;

        //Hvezdy
        double pocet_hvezd = 0;
        double cena_hvez = 100000000;

        //Emzaci
        double pocet_Alien = 0;
        double cena_Alien = 500000000;

        //Galaxie
        double pocet_Galax = 0;
        double cena_Galax = 1000000000;

        //Clone
        double pocet_clone = 0;
        double cena_clone = 50000000000;

        //Polobuh
        double pocet_polobuh = 0;
        double cena_polobuh = 200000000000;

        //Buh
        double pocet_buh = 0;
        double cena_buh = 1000000000000;

        //zdrazovani
        double zdrazeni_babci;
        double zdrazeni_kliku;
        double zdrazeni_robota;
        double zdrazeni_farmy;
        double zdrazeni_tovaren;
        double zdrazeni_chernobylu;
        double zdrazeni_Musk;
        double zdraznei_planet;
        double zdrazeni_hvezd;
        double zdrazeni_alien;
        double zdrazeni_galax;
        double zdrazeni_clone;
        double zdrazeni_polobuh;
        
        public void Zaokrouhleni()
        {
            if (pocet_susenek >= 1000000000000)
            {
                labelpocet.Text = "Počet sušenek: " + Math.Round(pocet_susenek / 1000000000) + "B";
            }
            else if (pocet_susenek >= 1000000000)
            {
                labelpocet.Text = "Počet sušenek: " + Math.Round(pocet_susenek / 1000000000, 3) + "Mld";
            }
            else if (pocet_susenek >= 1000000)
            {
                labelpocet.Text = "Počet sušenek: " + Math.Round(pocet_susenek / 1000000, 2) + "M";
            }
            else if (pocet_susenek >= 1000) 
            {
                labelpocet.Text = "Počet sušenek: " + Math.Round(pocet_susenek / 1000, 2) + "K";
            }
            else
                labelpocet.Text = "Počet sušenek: " + pocet_susenek;
        }

        public void Zakrouhleni_pomoci()
        {
            if (pomoc >= 1000000000000)
            {
                labelrychlostautomatizace.Text = Math.Round(pomoc / 1000000000000, 3) + "B sušenek/s";
            }
            else if (pomoc >= 1000000000)
            {
                labelrychlostautomatizace.Text = Math.Round(pomoc / 1000000000, 3) + "Mld sušenek/s";
            }
            else if (pomoc >= 1000000)
            {
                labelrychlostautomatizace.Text = Math.Round(pomoc / 1000000, 3) + "M sušenek/s";
            }
            else if (pomoc >= 1000)
            {
                labelrychlostautomatizace.Text = Math.Round(pomoc / 1000, 3) + "K sušenek/s";
            }
            else labelrychlostautomatizace.Text = pomoc + " sušenek/s";
        }

        public void Zdrazeni_babca()
        {
            if (cena_babicky >= 50)
            {
                zdrazeni_babci = nahoda.Next(50, 80);
            }
            else if (cena_babicky >= 150)
            {
                zdrazeni_babci = nahoda.Next(200, 480);
            }
            else if (cena_babicky >= 500)
            {
                zdrazeni_babci = nahoda.Next(500, 2000);
            }
            else if (cena_babicky >= 1000)
            {
                zdrazeni_babci = nahoda.Next(800, 5000);
            }
            else if (cena_babicky >= 2000)
            {
                zdrazeni_babci = nahoda.Next(1000, 8000);
            }
        }

        public void Zdrazeni_robot()
        {
            if (cena_robotu >= 150)
            {
                zdrazeni_robota = nahoda.Next(250, 500);
            }
            else if (cena_robotu >= 500)
            {
                zdrazeni_robota = nahoda.Next(700, 1000);
            }
            else if (cena_robotu >= 1000)
            {
                zdrazeni_robota = nahoda.Next(1500, 2200);
            }
            else if (cena_robotu >= 2000)
            {
                zdrazeni_robota = nahoda.Next(5000, 8900);
            }
            else if (cena_robotu >= 8000)
            {
                zdrazeni_robota = nahoda.Next(10000, 20000);
            }
        }

        public void Zdrazeni_klik()
        {
            if (cena_nasobice >= 10)
            {
                zdrazeni_kliku = nahoda.Next(50, 100);
            }
            else if (cena_nasobice >= 150)
            {
                zdrazeni_kliku = nahoda.Next(50, 500);
            }
            else if (cena_nasobice >= 500)
            {
                zdrazeni_kliku = nahoda.Next(800, 3000);
            }
        }
        public void Zdrazeni_Farem()
        {
            if (cena_farmy >= 1000)
            {
                zdrazeni_farmy = nahoda.Next(1500, 2000);
            }
            else if (cena_farmy >= 2000)
            {
                zdrazeni_farmy = nahoda.Next(2500, 3000);
            }
            else if (cena_farmy >= 4000)
            {
                zdrazeni_farmy = nahoda.Next(5000, 7000);
            }
        }

        public void Zdrazeni_Tovaren()
        {
            if (cena_tovarny >= 30000)
            {
                zdrazeni_tovaren = nahoda.Next(10000, 30000);
            }
            else if (cena_tovarny >= 60000)
            {
                zdrazeni_tovaren = nahoda.Next(50000, 100000);
            }
            else if (cena_tovarny >= 100000)
            {
                zdrazeni_tovaren = nahoda.Next(100000, 150000);
            }
        }

        public void Zdrazeni_Chernobyl()
        {
            if (cena_chernobylu >= 300000)
            {
                zdrazeni_chernobylu = nahoda.Next(100000, 300000);
            }
            else if (cena_chernobylu >= 600000)
            {
                zdrazeni_chernobylu = nahoda.Next(500000, 1000000);
            }
            else if (cena_chernobylu >= 1000000)
            {
                zdrazeni_chernobylu = nahoda.Next(1000000, 1500000);
            }
        }

        public void Zdrazeni_Musk()
        {
            if (cena_Musk >= 1000000)
            {
                zdrazeni_Musk = nahoda.Next(1000000, 3000000);
            }
            else if (cena_Musk >= 6000000)
            {
                zdrazeni_Musk = nahoda.Next(5000000, 10000000);
            }
            else if (cena_Musk >= 10000000)
            {
                zdrazeni_Musk = nahoda.Next(10000000, 15000000);
            }
        }

        public void Zdrazeni_Planet()
        {
            if (cena_planet >= 20000000)
            {
                zdraznei_planet = nahoda.Next(10000000, 30000000);
            }
            else if (cena_planet >= 60000000)
            {
                zdraznei_planet = nahoda.Next(50000000, 100000000);
            }
            else if (cena_planet >= 100000000)
            {
                zdraznei_planet = nahoda.Next(100000000, 150000000);
            }
        }

        public void Zdrazeni_Hvezda()
        {
            if (cena_hvez >= 100000000)
            {
                zdrazeni_hvezd = nahoda.Next(100000000, 300000000);
            }
            else if (cena_hvez >= 600000000)
            {
                zdrazeni_hvezd = nahoda.Next(500000000, 1000000000);
            }
            else if (cena_hvez >= 1000000000)
            {
                zdrazeni_hvezd = nahoda.Next(1000000000, 1500000000);
            }
        }

        public void Zdrazeni_Alien()
        {
            if (cena_Alien >= 500000000)
            {
                zdrazeni_alien = nahoda.Next(100000000, 300000000);
            }
            else if (cena_Alien >= 800000000)
            {
                zdrazeni_alien = nahoda.Next(300000000, 1000000000);
            }
            else if (cena_Alien >= 1200000000)
            {
                zdrazeni_alien = nahoda.Next(1000000000, 1500000000);
            }
        }

        public void Zdrazeni_Galaxie()
        {
            if (cena_Galax >= 1000000000)
            {
                zdrazeni_galax += 1000000000 / 2;
            }
            else if (cena_Galax >= 8000000000)
            {
                zdrazeni_galax += 500000000 / 2;
            }

        }
        public void Zdrazeni_Clone()
        {
            if (cena_clone >= 50000000000)
            {
                zdrazeni_clone += 20000000000;
            }
            else if (cena_clone >= 80000000000)
            {
                zdrazeni_clone += 40000000000;
            }

        }
        public void Zdrazeni_Polobuh()
        {
            if (cena_polobuh >= 200000000000)
            {
                zdrazeni_polobuh += 20000000000;
            }
            else if (cena_polobuh >= 80000000000)
            {
                zdrazeni_polobuh += 40000000000;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //kliknutí na sušenku
            if (nom == false)
            {
                pictureBox1.Image = Properties.Resources.Cookie_2;
                nom = true;
            }
            else if (nom == true)
            {
                pictureBox1.Image = Properties.Resources.Cookie;
                nom = false;
            }
            
            pocet_susenek += nasobic_klikani;
            Zaokrouhleni();
            
        }

        private void buttonshop_Click(object sender, EventArgs e)
        {
            //zobrazí shop a s ním i upgrady

            if (shop == false)
            {
                labelbabistaPopis.Visible = true;
                pocet_babushek.Visible = true;
                buttonpridejbabushku.Visible = true;

                PopisNasobice.Visible = true;
                pridejNasobic.Visible = true;
                pocet_nasobicu.Visible = true;

                Robotpopis.Visible = true;
                buttonrobot.Visible = true;
                Pocetrobotu.Visible = true;

                labelFarmaPopis.Visible = true;
                buttonFarma.Visible = true;
                PocetFarem.Visible = true;

                labelTovarnaPopis.Visible = true;
                buttonTovarna.Visible = true;
                TovarnaPocet.Visible = true;

                labelCherobyl.Visible = true;
                buttonCHernobyl.Visible = true;
                PocetChernobyl.Visible = true;

                labelMusk.Visible = true;
                buttonMusk.Visible = true;
                MuskPocet.Visible = true;

                labelPlanet.Visible = true; 
                buttonPlanet.Visible = true;
                pocetPlanet.Visible = true;

                labelHvezda.Visible = true;
                buttonhvezda.Visible = true;
                pocetHvezda.Visible = true;

                labelAlien.Visible = true;
                buttonAlien.Visible = true;
                pocetAlien.Visible = true;

                labelGalaxie.Visible = true;
                buttonGalaxie.Visible = true;
                pocetGalaxie.Visible = true;

                labelClone.Visible = true;
                buttonClone.Visible = true;
                ClonePocet.Visible = true;

                labelPolobuh.Visible = true;
                buttonPolobuh.Visible = true;
                pocetPolobuh.Visible = true;

                labelBuh.Visible = true; 
                buttonBuh.Visible = true;
                pocetBuh.Visible = true;    

                this.Width = 830;
                this.Height = velikost;

                shop = true;
            }
            else if (shop == true)
            {
                labelbabistaPopis.Visible = false;
                pocet_babushek.Visible = false;
                buttonpridejbabushku.Visible = false;

                PopisNasobice.Visible = false;
                pridejNasobic.Visible = false;
                pocet_nasobicu.Visible = false;

                Robotpopis.Visible = false;
                buttonrobot.Visible = false;
                Pocetrobotu.Visible = false;

                labelFarmaPopis.Visible = false;
                buttonFarma.Visible = false;
                PocetFarem.Visible = false;

                labelTovarnaPopis.Visible = false;
                buttonTovarna.Visible = false;
                TovarnaPocet.Visible = false;

                labelCherobyl.Visible = false;
                buttonCHernobyl.Visible = false;
                PocetChernobyl.Visible = false;

                labelMusk.Visible = false;
                buttonMusk.Visible = false;
                MuskPocet.Visible = false;

                labelPlanet.Visible = false;
                buttonPlanet.Visible = false;
                pocetPlanet.Visible = false;

                labelHvezda.Visible = false;
                buttonhvezda.Visible = false;
                pocetHvezda.Visible = false;

                labelAlien.Visible = false;
                buttonAlien.Visible = false;
                pocetAlien.Visible = false;

                labelGalaxie.Visible = false;
                buttonGalaxie.Visible = false;
                pocetGalaxie.Visible = false;

                labelClone.Visible = false;
                buttonClone.Visible = false;
                ClonePocet.Visible = false;

                labelPolobuh.Visible = false;
                buttonPolobuh.Visible = false;
                pocetPolobuh.Visible = false;

                labelBuh.Visible = false;
                buttonBuh.Visible = false;
                pocetBuh.Visible = false;


                this.Width = 385;
                this.Height = velikost;

                shop = false;
            }           
        }

        private void buttonpridejbabushku_Click(object sender, EventArgs e)
        {
            //generování babiček
            if (pocet_susenek >= cena_babicky)
            {
                Generator.Enabled = true;
                pocet_babicek++;
                pocet_susenek -= cena_babicky;
                Zdrazeni_babca();
                cena_babicky += zdrazeni_babci;
                pomoc += 1;

                Zaokrouhleni();
                
                pocet_babushek.Text = pocet_babicek.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;


                if (cena_babicky >= 1000000000)
                {
                    labelbabistaPopis.Text = "Babushka pekařka: " + Math.Round(cena_babicky / 1000000000, 3) + "Mld ";
                }
                else if (cena_babicky >= 1000000)
                    {
                        labelbabistaPopis.Text = "Babushka pekařka: " + Math.Round(cena_babicky / 1000000, 2) + "M ";
                    }
                else if (cena_babicky >= 1000)
                    {
                        labelbabistaPopis.Text = "Babushka pekařka: " + cena_babicky / 1000 + "K ";
                    }
                else  
                    labelbabistaPopis.Text = "Babushka pekařka: " + cena_babicky;
            }
            
        }

        private void Generator_Tick(object sender, EventArgs e)
        {
            //přidávání sušenek s upgrady

            pocet_susenek += pomoc;
            Zaokrouhleni();
        }


        private void pridejNasobic_Click(object sender, EventArgs e)
        {
            //více sušenek za 1 kliknutí

            if (pocet_susenek >= cena_nasobice)
            {
                nasobic_klikani += 1;
                nasobek_kliknuti++;
                pocet_susenek -= cena_nasobice;
                Zdrazeni_klik();
                cena_nasobice += zdrazeni_kliku;

                pocet_nasobicu.Text = nasobek_kliknuti.ToString();
                Zaokrouhleni();
                PopisNasobice.Text = "Sušenky za kliknutí: " + cena_nasobice;

                if (cena_nasobice >= 1000000000)
                {
                    PopisNasobice.Text = "Sušenky za kliknutí: " + Math.Round(cena_nasobice / 1000000000, 4) + "Mld ";
                }
                else if (cena_nasobice >= 1000000)
                {
                    PopisNasobice.Text = "Sušenky za kliknutí: " + Math.Round(cena_nasobice / 1000000, 2) + "M ";
                }
                else if (cena_nasobice >= 1000)
                {
                    PopisNasobice.Text = "Sušenky za kliknutí: " + cena_nasobice / 1000 + "K ";
                }
                else
                    PopisNasobice.Text = "Sušenky za kliknutí: " + cena_nasobice;

            }
            
        }

        private void PopisNasobice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tento upgrade násobí počet sušenek, které získáš klikáním. \nZačínáš s jednou sušenkou za kliknutí, momentálně vyděláváš " + nasobic_klikani + " sušenek/kliknutí");
        }

        private void labelbabistaPopis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Babushka pekařka. \nMístní babička, která je nadšená do pečení a má dost síly na to se nechat najmout a pomoct ti s pečením. \nKdyž jí najmeš bude za tebe automaticky dělat sušenky a bude se ti generovat vždy 1 sušenku navíc. \nAktuálni počet generovaných sušenek je: " + pomoc);

        }
        private void buttonrobot_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_robotu)
            {
                Generator.Enabled = true;
                pocet_robotu++;
                pocet_susenek -= cena_robotu;
                Zdrazeni_robot();
                cena_robotu += zdrazeni_robota;
                pomoc += 5;

                Zaokrouhleni();
                Pocetrobotu.Text = pocet_robotu.ToString();
                Zakrouhleni_pomoci(); 
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_robotu >= 1000000000)
                {
                    Robotpopis.Text = "Pečící robot: " + Math.Round(cena_robotu / 1000000000, 3) + "Mld ";
                }
                else if (cena_robotu >= 1000000)
                {
                    Robotpopis.Text = "Pečící robot: " + Math.Round(cena_robotu / 1000000, 2) + "M ";
                }
                else if (cena_robotu >= 1000)
                {
                    Robotpopis.Text = "Pečící robot: " + cena_robotu / 1000 + "K ";
                }
                else
                    Robotpopis.Text = "Pečící robot: " + cena_robotu;
            }
        }

        private void buttonFarma_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_farmy)
            {
                Generator.Enabled = true;
                pocet_farma++;
                pocet_susenek -= cena_farmy;
                Zdrazeni_Farem();
                cena_farmy += zdrazeni_farmy;
                pomoc += 20;

                Zaokrouhleni();
                PocetFarem.Text = pocet_farma.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_farmy >= 1000000000)
                {
                    labelFarmaPopis.Text = "Farma na sušenky: " + Math.Round(cena_farmy / 1000000000, 3) + "Mld ";
                }
                else if (cena_farmy >= 1000000)
                {
                    labelFarmaPopis.Text = "Farma na sušenky: " + Math.Round(cena_farmy / 1000000, 2) + "M ";
                }
                else if (cena_farmy >= 1000)
                {
                    labelFarmaPopis.Text = "Farma na sušenky: " + cena_farmy / 1000 + "K ";
                }
                
            }
        }

        private void buttonTovarna_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_tovarny)
            {
                Generator.Enabled = true;
                pocet_tovaren++;
                pocet_susenek -= cena_tovarny;
                Zdrazeni_Tovaren();
                cena_tovarny += zdrazeni_tovaren;
                pomoc += 100;

                Zaokrouhleni();
                TovarnaPocet.Text = pocet_tovaren.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_tovarny >= 1000000000)
                {
                    labelTovarnaPopis.Text = "Továrna: " + Math.Round(cena_tovarny / 1000000000, 3) + "Mld ";
                }
                else if (cena_farmy >= 1000000)
                {
                    labelTovarnaPopis.Text = "Továrna: " + Math.Round(cena_tovarny / 1000000, 2) + "M ";
                }
                else if (cena_farmy >= 1000)
                {
                    labelTovarnaPopis.Text = "Továrna: " + cena_tovarny / 1000 + "K ";
                }

            }
        }
        private void buttonCHernobyl_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_chernobylu)
            {
                Generator.Enabled = true;
                pocet_chernobyl++;
                pocet_susenek -= cena_chernobylu;
                Zdrazeni_Chernobyl();
                cena_chernobylu += zdrazeni_chernobylu;
                pomoc += 5000;

                Zaokrouhleni();
                PocetChernobyl.Text = pocet_chernobyl.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_chernobylu >= 1000000000)
                {
                    labelCherobyl.Text = "Sušenky z Chernobylu: " + Math.Round(cena_chernobylu / 1000000000, 3) + "Mld ";
                }
                else if (cena_chernobylu >= 1000000)
                {
                    labelCherobyl.Text = "Sušenky z Chernobylu: " + Math.Round(cena_chernobylu / 1000000, 2) + "M ";
                }
                else if (cena_chernobylu >= 1000)
                {
                    labelCherobyl.Text = "Sušenky z Chernobylu: " + cena_chernobylu / 1000 + "K ";
                }

            }
        }

        private void buttonMusk_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_Musk)
            {
                Generator.Enabled = true;
                pocet_Musk++;
                pocet_susenek -= cena_Musk;
                Zdrazeni_Musk();
                cena_Musk += zdrazeni_Musk;
                pomoc += 20000;

                Zaokrouhleni();
                MuskPocet.Text = pocet_Musk.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_Musk >= 1000000000)
                {
                    labelMusk.Text = "Odkoupení Elonem Muskem: " + Math.Round(cena_Musk / 1000000000, 3) + "Mld ";
                }
                else
                {
                    labelMusk.Text = "Odkoupení Elonem Muskem: " + Math.Round(cena_Musk / 1000000, 2) + "M ";
                }

            }
        }

        private void buttonPlanet_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_planet)
            {
                Generator.Enabled = true;
                pocet_planet++;
                pocet_susenek -= cena_planet;
                Zdrazeni_Planet();
                cena_planet += zdraznei_planet;
                pomoc += 100000;

                Zaokrouhleni();
                pocetPlanet.Text = pocet_planet.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_planet >= 1000000000)
                {
                    labelPlanet.Text = "Multiplanet. produkce: " + Math.Round(cena_planet / 1000000000, 3) + "Mld ";
                }
                else
                {
                    labelPlanet.Text = "Multiplanet. produkce: " + Math.Round(cena_planet / 1000000, 2) + "M ";
                }

            }
        }
        private void buttonhvezda_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_hvez)
            {
                Generator.Enabled = true;
                pocet_hvezd++;
                pocet_susenek -= cena_hvez;
                Zdrazeni_Hvezda();
                cena_hvez += zdrazeni_hvezd;
                pomoc += 1000000;

                Zaokrouhleni();
                pocetHvezda.Text = pocet_hvezd.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_hvez >= 1000000000)
                {
                    labelHvezda.Text = "Hvězda sušenek: " + Math.Round(cena_hvez / 1000000000, 3) + "Mld ";
                }
                else
                {
                    labelHvezda.Text = "Hvězda sušenek: " + Math.Round(cena_hvez / 1000000, 2) + "M ";
                }

            }
        }

        private void buttonAlien_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_hvez)
            {
                Generator.Enabled = true;
                pocet_Alien++;
                pocet_susenek -= cena_Alien;
                Zdrazeni_Alien();
                cena_Alien += zdrazeni_alien;
                pomoc += 100000000;

                Zaokrouhleni();
                pocetAlien.Text = pocet_Alien.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_Alien >= 1000000000000)
                {
                    labelAlien.Text = "Mimozemská pracovní síla: " + Math.Round(cena_Alien / 1000000000000, 5) + "B ";
                }
                else if (cena_Alien >= 1000000000)
                {
                    labelAlien.Text = "Mimozemská pracovní síla: " + Math.Round(cena_Alien / 1000000000, 3) + "Mld ";
                }
                else
                {
                    labelAlien.Text = "Mimozemská pracovní síla: " + Math.Round(cena_Alien / 1000000, 2) + "M ";
                }

            }
        }
        private void buttonGalaxie_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_Galax)
            {
                Generator.Enabled = true;
                pocet_Galax++;
                pocet_susenek -= cena_Galax;
                Zdrazeni_Galaxie();
                cena_Galax += zdrazeni_galax;
                pomoc += 10000000;

                Zaokrouhleni();
                pocetGalaxie.Text = pocet_Galax.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_Galax >= 1000000000000)
                {
                    labelGalaxie.Text = "Sušenková multigalxiální kolonie:  " + Math.Round(cena_Galax / 1000000000000, 5) + "B ";
                }
                else if (cena_Alien >= 100000000)
                {
                    labelGalaxie.Text = "Sušenková multigalxiální kolonie:  " + Math.Round(cena_Galax / 1000000000, 3) + "Mld ";
                }

            }
        }
        private void buttonClone_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_clone)
            {
                Generator.Enabled = true;
                pocet_clone++;
                pocet_susenek -= cena_clone;
                Zdrazeni_Clone();
                cena_clone += zdrazeni_clone;
                pomoc += 100000000;

                Zaokrouhleni();
                ClonePocet.Text = pocet_clone.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_clone >= 1000000000000)
                {
                    labelClone.Text = "Cookie klonovač: " + Math.Round(cena_clone / 1000000000000, 5) + "B";
                }
                else if (cena_clone >= 100000000)
                {
                    labelClone.Text = "Cookie klonovač: " + Math.Round(cena_clone / 1000000000, 3) + "Mld";
                }
                

            }
        }
        private void buttonPolobuh_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_polobuh)
            {
                Generator.Enabled = true;
                pocet_polobuh++;
                pocet_susenek -= cena_polobuh;
                cena_polobuh += zdrazeni_polobuh;
                pomoc += 10000000000;

                Zaokrouhleni();
                pocetPolobuh.Text = pocet_polobuh.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_polobuh >= 1000000000000)
                {
                    labelPolobuh.Text = "Sušenkový polobůh: " + Math.Round(cena_polobuh / 1000000000000, 5) + "B";
                }
                else if (cena_clone >= 100000000)
                {
                    labelPolobuh.Text = "Sušenkový polobůh: " + Math.Round(cena_polobuh / 1000000000, 3) + "Mld";
                }
                

            }
        }
        private void buttonBuh_Click(object sender, EventArgs e)
        {
            if (pocet_susenek >= cena_buh)
            {
                Generator.Enabled = true;
                pocet_buh++;
                pocet_susenek -= cena_buh;
                Zdrazeni_Polobuh();
                pomoc += 100000000000;

                Zaokrouhleni();
                pocetBuh.Text = pocet_buh.ToString();
                Zakrouhleni_pomoci();
                labelrychlostautomatizace.Visible = true;
                velikost = 500;
                this.Height = (int)velikost;

                if (cena_buh >= 1000000000000)
                {
                    labelBuh.Text = "Sušenkový bůh: " + Math.Round(cena_buh / 1000000000000, 5) + "B";
                }


            }
        }
        private void Main_hra_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                pocet_susenek += nasobic_klikani;
                Zaokrouhleni();
            }
        }
        private void buttonshop_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonshop.Enabled = false;
            buttonshop.Enabled = true;
        }

        private void Main_hra_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void Main_hra_Click(object sender, EventArgs e)
        {



        }
        private void buttonshop_KeyDown(object sender, KeyEventArgs e)
        {


        }
        private void animace_Tick(object sender, EventArgs e)
        {
        }

        
    }
}
