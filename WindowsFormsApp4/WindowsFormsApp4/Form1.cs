using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int aktualnipocetzezonu = 1200;
        int vklad;
        public Form1()
        {
            InitializeComponent();
        }
        int zmenapenez;
        int vyhraxlose;
        int cislo;
        private void Funkceprozobrazenipenez()
        {
            if (vyhraxlose != 0)
            {
                if (vyhraxlose == 1)
                {
                    aktualnipocetzezonu += zmenapenez;
                }
                if (vyhraxlose == 289)
                {
                    aktualnipocetzezonu -= aktualnipocetzezonu;
                }
            }
            else
            {
                aktualnipocetzezonu -= zmenapenez;
            }
            label3.Text = aktualnipocetzezonu.ToString();
        }

        private int nahodnecislo()
        {
            Random rnd = new Random();
            cislo = rnd.Next(1, 19);
            label8.Text = cislo.ToString();
            return cislo;
        }

        private void dissapearallbuttons()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
        }

        
        //----------------------------------------------------------1111111111111111111111111111111111111111111111111;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if(aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 1)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            } catch(Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }
        //----------------------------------------------------------22222222222222222222222222222222222222222222222222222;
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 2)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 3)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 4)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 5)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 6)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 7)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 8)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 9)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 10)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 11)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 12)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 13)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 14)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 15)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 16)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 17)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo == 18)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 10;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo >= 12)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 2;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                vklad = int.Parse(textBox1.Text);
                if (vklad != 0)
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        if (cislo <= 12)
                        {
                            cislo = nahodnecislo();
                            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
                            zmenapenez = vklad * 2;
                            vyhraxlose = 1;
                            Funkceprozobrazenipenez();
                        }
                        else
                        {
                            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
                            zmenapenez = vklad;
                            Funkceprozobrazenipenez();
                        }
                    }
                    else
                    {
                        MessageBox.Show("uz nemas penize! seber se a bez domu");
                        dissapearallbuttons();
                    }
                }
                else
                {
                    MessageBox.Show("nic si nevlozil more");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Divka prijme a spolecne se na baru opijete tak ze zapomenes svoji vyhru u hraciho stolu a skoncis na podlaze na zachode, bohuzel tak ztracis uplne vsechno");
            aktualnipocetzezonu = 0;
            Funkceprozobrazenipenez();
            vyhraxlose = 289;
        }
    }
}
