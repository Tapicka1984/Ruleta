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
        int sebevedomi = 100;
        int dyzkoodholky = 10;
        public Form1()
        {
            InitializeComponent();
        }
        int zmenapenez;
        int vyhraxlose = 0;
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
            if (dyzkoodholky == 1)
            {
                aktualnipocetzezonu += 10;
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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void vyhrajednocislo()
        {
            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 10);
            zmenapenez = vklad * 10;
            vyhraxlose = 1;
            Funkceprozobrazenipenez();
        }
        private void vyhrapolovina()
        {
            MessageBox.Show("Vyhral jsi! na tve konto bude pricteno" + vklad * 2);
            zmenapenez = vklad * 2;
            vyhraxlose = 1;
            Funkceprozobrazenipenez();
        }

        private void prohra()
        {
            MessageBox.Show("bohuzel jsi prohral, tvoje penize budou pricteny na ucet vyvojare teto hry");
            zmenapenez = vklad;
            vyhraxlose = 0;
            Funkceprozobrazenipenez();
        }

        private void sebevedomi1()
        {
            label9.Visible = true;
            label10.Visible = true;
            sebevedomi -= 10;
            label10.Text = (sebevedomi).ToString();
        }           
        
        //----------------------------------------------------------1111111111111111111111111111111111111111111111111;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        cislo = nahodnecislo();
                        if (cislo == 1)
                        {
                           vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        cislo = nahodnecislo();
                        if (cislo == 2)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        cislo = nahodnecislo();
                        if (cislo == 3)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo();
                        cislo = nahodnecislo();
                        if (cislo == 4)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); 
                        cislo = nahodnecislo();

                        if (cislo == 5)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 6)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 7)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 8)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 9)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 10)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 11)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 12)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 13)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 14)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 15)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 16)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad < aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 17)
                        {
                            MessageBox.Show("zadavas mene jak 0 bro");
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo == 18)
                        {
                            vyhrajednocislo();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo >= 10)
                        {
                            vyhrapolovina();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0) || (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if (aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
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
                label8.Visible = true;
                vklad = int.Parse(textBox1.Text);
                if ((vklad > 0) && (vklad <= aktualnipocetzezonu))
                {
                    if (aktualnipocetzezonu > 0)
                    {
                        nahodnecislo(); cislo = nahodnecislo();

                        if (cislo <= 9)
                        {
                            vyhrapolovina();
                        }
                        else
                        {
                            prohra();
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
                    if (vklad <= 0)
                    {
                        if ((vklad == 0)|| (vklad < 0) && (aktualnipocetzezonu > 0))
                        {
                            if ((vklad == 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas nulu kamo");
                            }
                            if ((vklad < 0) && (aktualnipocetzezonu > 0))
                            {
                                MessageBox.Show("zadavas mene nez nula");
                            }
                        }
                        else
                        {
                            dissapearallbuttons();
                        }

                    }
                    else
                    {
                        if ((vklad > 0) && (aktualnipocetzezonu > 0))
                        {
                            MessageBox.Show("snazis se vlozit vic nes mas more!");
                        }
                        if(aktualnipocetzezonu == 0)
                        {
                            dissapearallbuttons();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            nahodnecislo(); cislo = nahodnecislo();
            if(aktualnipocetzezonu > 100)
            {
                if (cislo <= 9)
                {
                    MessageBox.Show("Divka prijme a spolecne se na baru opijete tak ze zapomenes svoji vyhru u hraciho stolu a skoncis na podlaze na zachode, bohuzel tak ztracis uplne vsechno");
                    aktualnipocetzezonu = 0;
                    Funkceprozobrazenipenez();
                    vyhraxlose = 289;
                }
                if (cislo >= 10)
                {
                    MessageBox.Show("divka si povzdechne a hodi ti 10 zetonu jako znak litosti nad tebou a nazve te nulou");
                    if(sebevedomi != 0)
                    {
                        dyzkoodholky = 1;
                        sebevedomi1();
                        Funkceprozobrazenipenez();
                    }
                    else
                    {
                        MessageBox.Show("uz nemas zadne sebevedomi ty nulo");
                        button21.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("nemas dostatek penez = nemas dostatek sebevedomi aby jsi divku pozval na rande, drink ci neco jineho, ztracis 10 bodu sebevedomi");
                if (sebevedomi != 0)
                {
                    
                    sebevedomi1();
                }
                else
                {
                    MessageBox.Show("uz nemas zadne sebevedomi ty nulo");
                    button21.Visible = false;
                }
            }
        }
    }
}
