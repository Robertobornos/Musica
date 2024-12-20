using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Musica
{
    public partial class UserControl1 : UserControl
    {
        private Random random;
        private Timer timer;
        private ArrayList todascanciones;
        int cont;
        public UserControl1()
        {   
            InitializeComponent();
            canciones();
            cont = 0;
            MostrarCancionActual();
            random = new Random();


            trackbar();

        }


        private void trackbar()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();


            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 1;
            duracioncancion();
        }

        private void Parartrackbar()
        {
           
            timer.Stop();


           
        }

        

        private void canciones()
        {
            todascanciones = new ArrayList
            {
                "Nueva Era (part. Myke Towers)" ,
                "Cassette 01 (Freestyle) (part. C.R.O y Neo Pistéa)",
                "She Don't Give a FO (part. Khea)",
                "Como Si No Importara (part. Emilia)",
                "Ameri",
                "Imperio (part Judeline)",
                "Hello Cotto",
                "Marisola (remix) (part. Standly, Cris Mj y Nicki Nicole)",
                "Vida de Rock (part. Milo j)",
                 "Los Del Espacio (part. LIT killah, Emilia, Tiago PZK, FMK, Rusherking, Maria Becerra y Big One)",
                "GIVENCHY",
                "Fifty Fifty (part. Pablo Chill-E, Obie Wanshot, Julianno Sosa, Neo Pistea & Young Cister)",
                "hARAkiRi (part. C.R.O)",
                "Shorty (part. Nicki Nicole)",
                "Buscarte Lejos (part. Bizarrap)",
                "No Me Llores (remix) (part. Leby)",
                "Barro",
                "Envy Me Freestyle, Pt. 2 (part. Lito Kirino y Pablo Chill-E)",
                "Cine 🚬",
                "PACTO (part. Neo Pistea)",
                "Wake Up & Bake Up (feat. Wiz Khalifa & Arcángel)",
                "En Odio",
                "Antes de Perderte",
                "Rockstar",
                "antes de perderte (OG VERSION)",
                "cONTRA><Mi (part. WE$T DUBAI)",
                "Brindis (part. Headie One)",
                "Goteo",
                "QUAVO (part. Neo Pistéa y Ysy A)",
                "Trato de Estar Bien (part. Morad)",
                "Hardaway (part. YG y Eladio Carrion)",
                "Mojaa (part. Bhavi)",
                "Ella Es Una G (part. C.R.O)",
                "Si Me Sobrara El Tiempo",
                "Si Quieren Frontear (part. De La Ghetto y Quevedo)",
                "Leitmotiv",
                "Lost Tape 2016-2017 (part. C.R.O)",
                "Si Te Sentis Sola",
                "Un Día Más (part. YSY A)",
                "Duki Vs Lit Killah (Semifinal 14/8)",
                "TRAP N' EXPORT (part. Ysy A y Neo Pistea)",
                "TROYA",
                "Remember Me (part. KHEA y Bizarrap)",
                "Tussi (feat. Marcianos Crew & Ysy A)",
                "Bodak Yellow (Remix) (part. Cardi B)",
                "Guapo (part. Ysy A, Kaktov, C.R.O y Neo Pistea)",
                "Luna (part. Asan)",
                "Mericrisma",
                "RoCKSTAR 2.0 (part. Jhayco)",
                "Sin Culpa (part. DrefQuila)",
                "uNO dOS (part. Salastkbron)",
                "Yin Yan (part. Rels B)",
                "01 dE ENEro (part. Lucho SSJ)",
                "B.U.H.O (part. Midel, Arse, Khea y Klave)",
                "Ballin'",
                "Celosa",
                "Chico Estrella (part. Yesan & Asan)",
                "don't liE (part. Quevedo)",
                "Esto Recién Empieza (part. Emilia)",
                "H.I.E.L.O. (part. Obie WanShot)",
                "Lola",
                "Malbec (part. Bizarrap)",
                "Midtown",
                "Sol y Luna",
                "Te Traje Flores",
                "24 (part. Kidd Keo y Juicy J)",
                "Amor Bipolar (part. Mora)",
                "JEFES DEL SUDOESTE",
                "Luna (part. Gallagher)",
                "Pastillas (part. Asan y Zecca)",
                "aPoLLo13",
                "BICI (part. AK4:20, Juhn y Juanka)",
                "CALL ME MAYBE",
                "Como Si Na (part. Clubhats)",
                
                "Escalera",
                "Ferrari (feat. DICC)",
                "Iba a Llamarte (part. C.R.O)",
                
                "Muriendome (part. KHEA)",
                "No Drama (part. Ovi y Lucho SSJ)",
                "No Vendo Trap",
                "Perdón",
                "Pintao (part. YSY A y Rei)",
                "Shorty (part. Nicki Nicole)",
                "Sol (part. Lara91k)",
                "Sold Out Dates",
                "Ultimo Tren a Ameri",
                "Una Vaina Loca (part. Fuego & Manuel Turizo)",
                "YaMeFui (part. Bizarrap y Nicki Nicole)",
                "3 Estrellas En El Conjunto (part. Bizarrap & La T y La M)",
                "5 Stars (part. C. Tangana, Neo Pistea y Polimá Westcoast)",
                "7 Pakas (part. Chulu & C.R.O)",
                
                "Alas (part. C.R.O)",
                "Amor Al Arte",
                "Ánimo (part. Khea y Midel)",
                "Basado En Hechos Reales (part. Homer El Mero Mero)",
                "Billetes (part. KHEA y Neo Pistea)",
                "bUSCANDO Ameri",
                "Cascada",
                "Cypher MND #16 v.1: Duki (part. Mundialista Crew y ShiGant-G)",
                "Deja Vu (part. Big Deiv y CLUB HATS)",
                "Exit (part Sick Luke y Lazza)",
                "Fifty Fifty (part. Pablo Chill-E, Obie Wanshot, Julianno Sosa, Neo Pistea & Young Cister)",
                "Fvck Luv (part. C.R.O)",
                "Gelato (part. Eladio Carrion, Smokepurpp y Hide Miyabi)",
                "GiGi",
                "Hasta Las 6 (part. Kodigo, DrefQuila, JNO y SG)",
                "Hijo de La Noche (part. C.R.O y Ysy A)",
                "HitBoy (part. Khea)",
                "I Don’t Know",
                "I.D.K (part. Zanto)",
                "It's a Vibe (part. Leebrian, C. Tangana y Khea)",
                "JET LAG (part. Tiago PZK y LIT Killah)",
                "LeBron",
                "Loca (Remix) (part Bad Bunny, Cazzu y Khea)",
                "Louis Vuitton (part. 44 KID y Mesita)",
                "Máquina de Armado (part. Neo Pistea, Khea)",
                "Me Gusta Lo Simple (part. Alemán)",
                "Mi Chain de Roque",
                "Modo Avión",
                "Nota Especial",
                "One Millon Dollar Baby (part. Eladio Carrión, Sfera Ebbasta)",
                "Otro Level (part. Ysy A)",
                "R.I.P La Manshon (Freestyle)",
                "Rápido",
                "Ready For The Night (feat. NahueMC)",
                "Rosa (part. C.R.O)",
                "Sudor y Trabajo",
                "Top 5",
                "Trapperz a Máfia da Sicília (part. Felp 22, Rauw Alejandro, MC Davo & Fuego)",
                "Tumbando El Club (remix) (part. Neo Pistéa, C.R.O, Obiewanshot, Ysy A, Cazzu, Khea, Lucho SSJ, Coqeéin Montana y Marcianos Crew)"
                ,"Unfollow (part. Justin Quiles y Bizarrap)",
                "La Vuelta",
                "Acapella",
                "AEROBICO (remix) (part. BHAVI, MILO J y LIT killah)",
                "ANGELITO (part. Obie Wanshot)",
                "Baby Pluto (part. Mesita)",
                "Batman",
                "Café (part. Luyo y Fuego)",
                "Cara de Diablo (part. Midel)",
                "Carita Morena (part. Omar Montes)",
                "Cassette 01 (Freestyle) (part. C.R.O y Neo Pistéa)",
                "Cayendo Pa' Arriba",
                "CEO (part. Mesita)",
                "Cereza (part. Fuego)",
                "Colombiana (part. Marcianos Crew y Homer El Mero Mero)",
                "Como Si No Importara (part. Emilia)",
                "Cuanto (part. Lucho Ssj y Farina)",
                "Cypher MND #16 v.2: Duki (part. Mundialista Crew y ShiGant-G)",
                "DEL ESTUDIO AL ESTADIO (part. Seven Kayne)",
                "Dolce (part. Young Cister)",
                "DUKI (BZRP Music Sessions #50)",
                "Ella Es Mi Bitch (part. Pekeño 77, Mesita, 44 Kid & Franux BB)",
                "En Movimiento",
                "Entre Cuatro Paredes (part. Vicentico, La Bomba de Tiempo)",
                "Envy Me Freestyle, Pt. 2 (part. Lito Kirino y Pablo Chill-E)",
                "EO EO (part. Bles y Dellaflame)",
                "Eres Para Mí (part. Lara 91k)",
                "Flex Like Trunkz (part. Young Cister)",
                "FORNAI (part. Orodembow)",
                "Hablamos Mucho Hacemos Poco (part. Seven Kayne)",
                "Hambre de Más (part. Klan y YSY A)",
                "Hello Cotto (Remix) (part. Moonkey)",
                "I Dance (feat. YG & Cuco) [explicit]",
                "La Jefatura (part. Lucho SSJ, Marcianos Crew)",
                "Lambo (remix) (part. C.R.O., Chucky 73, We$t Dubai y Moonkey)",
                "Level Up",
                "Lex Luthor (part. C.R.O.)",
                "Ley de Atracción",
                "Lo Olvidaste",
                "Loca (part. Cazzu y Khea)",
                "Malbec (part. Bizarrap) (GALLERY SESSION)",
                "Marca de La Cadena (part. ByMonkid)",
                "Marisola (remix) (part. Standly, Cris Mj y Nicki Nicole)",
                "MASCARA (part. NICKI NICOLE)",
                "Me Dejaste Así",
                "Me Enseñaste (remix) (part. Sael)",
                "Mi Diablo",
                "Mil Colores",
                "N.C.L.C",
                "NO DA MÁS (part. YSY A)",
                "NO SON KLLE (part. Santa Fe Klan y Peso Pluma)",
                "Otra Vez",
                "Pantera",
                
                "Perdiendo El Tiempo (part. Marcianos Crew y Homer)",
                "Perrea (part. Frijo y We$t Dubai)",
                "Perreo Bendito",
                "Por Mi Nombre (part. Club Hats)",
                "RCP (part. Tiago PZK)",
                "Sake (part. WE$T DUBAI)",
                "Salgo Pa La Calle (part. Mesita)",
                "Secreto (part. Guayanaa, Farina)",
                "Señorita"
            };
        }

        private void MostrarCancionActual()
        {
            if (todascanciones.Count > 0 && cont >= 0 && cont < todascanciones.Count)
            {
                label1.Text = "Reproduciendo:"+ todascanciones[cont];
            }

          
            
        }

   

      

        private void Anterior(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                cont--;
                MostrarCancionActual();
            }
            else
            {
                MessageBox.Show("No hay canciones anteriores");
            }
            trackBar1.Value = 0;
            duracioncancion();
        }

        private void Pausar(object sender, EventArgs e)
        {
            MessageBox.Show("Reproducción pausada.");
            Parartrackbar();
        }





        private void Siguiente(object sender, EventArgs e)
        {
            if (cont < todascanciones.Count - 1)
            {
                cont++;
                MostrarCancionActual();
            }
            else
            {
                MessageBox.Show("No hay más canciones");
            }
            trackBar1.Value = 0;
            duracioncancion();


        }

        private void CambiarImagen(object sender, EventArgs e)
        {

            if (!label1.Text.Contains("DUKI") || !label1.Text.Contains("duki"))
            {

                Emilia.Visible = false;
                Nicki.Visible = false;
                Ysya.Visible = false;
                duki.Visible = true;
                Pablo.Visible = false;
                CRO.Visible = false;



                if (label1.Text.Contains("C.R.O"))
                {

                    Emilia.Visible = false;
                    Nicki.Visible = false;
                    Ysya.Visible = false;
                    duki.Visible = false;
                    Pablo.Visible = false;
                    CRO.Visible= true;


                }


                if (label1.Text.Contains("Emilia"))
                {

                    Emilia.Visible = true;
                    Nicki.Visible = false;
                    Ysya.Visible = false;
                    duki.Visible = false;
                    Pablo.Visible = false;
                    CRO.Visible = false;


                }


                if (label1.Text.Contains("Nicki"))
                {

                    Emilia.Visible = false;
                    Nicki.Visible = true;
                    Ysya.Visible = false;
                    duki.Visible = false;
                    Pablo.Visible = false;
                    CRO.Visible = false;


                }


                if (label1.Text.Contains("Ysy") || label1.Text.Contains("YSY"))
                {

                    Emilia.Visible = false;
                    Nicki.Visible = false;
                    Ysya.Visible = true;
                    duki.Visible = false;
                    Pablo.Visible = false;
                    CRO.Visible = false;

                }


                if (label1.Text.Contains("Pablo") || label1.Text.Contains("Chill-E"))
                {

                    Emilia.Visible = false;
                    Nicki.Visible = false;
                    Ysya.Visible = false;
                    duki.Visible = false;
                    Pablo.Visible =true;
                    CRO.Visible = false;

                }

            }
          




        }
        public void Timer_Tick(object sender, EventArgs e)
        {
           
            if (trackBar1.Value < trackBar1.Maximum)
            {
                trackBar1.Value++;
            }

          
          
        }


        public void duracioncancion()

        {
            label2.Text = random.Next(1, 5).ToString();

        }

       
        private void Reanudar(object sender, EventArgs e)
        {
            trackbar();
        }
    }
}
