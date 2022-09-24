using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KBC
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

       
        
        public string q1 = "Where is the Taj Mahal Loacted? ";
        public string q2 = "Which is the longest river in India? ";
        public string q3 = "Which of the following is the World’s First Granite Temple? ";
        public string q4 = "Neelam Sanjiva Reddy was the _______ President of India? ";

        public string o1 = "Who was the first Deputy Prime Minister of India? ";
        public string o2 = "The longest river of south India is _______";
        public string o3 = "The first Indian to win Ramon Magsaysay Award was _______";
        public string o4 = " First Indian Woman Ambassador at United Nations was";
        public string o5 = "Khari Baoli, the Asia’s largest wholesale spice market, is in _________";

        public string c1 = "Which is the first Indian Language to attain Classical Language Status?";
        public string c2 = "The World famous Khonghampat Orchidarium is in which of the following Indian States?";

        public string d1 = "Railways were first introduced to India in the year _______ from Bombay to Thane. ";
        public string d2 = "Whats pi value in mathematics......";


        public string e1 = "As per Census 2011, which Indian state has the lowest literacy rate? ";
        public string e2 = "How many types of Prerogative writs are there in the Indian Constitution?";

        public string l1 = "Who launched the first indigenous Indian shipping service between Tuticorin and Colombo?";
        public string l2 = "Largest Brackish Water Lagoon – Chilika lake, is in which Indian State?";

        System.Timers.Timer tam;
        int  tim=60;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            playerlbl.Text = "Player: " +  Class1.name;

            tam=new System.Timers.Timer();
            tam.Interval = 1000;
            tam.Elapsed += TimeE;
            tam.Start();



            ptlbl.Text = "Points: 0";
            Label1.BackColor = Color.Red;
            Random Ran = new Random();
            int Question = Ran.Next(1, 4);
            if (Question == 1)
            {
                QuestionBox.Text = q1;
                Option1.Text = "A). Agra";//
                Option2.Text = "B). Varanasi";
                Option3.Text = "C). Allahabad";
                Option4.Text = "D). Lucknow";
                Label1.BackColor = Color.Red;
            }
            else if (Question == 2)
            {
                QuestionBox.Text = q2;
                Option1.Text = "A). Ganga River";//
                Option2.Text = "B). Krishna River";
                Option3.Text = "C). Yamuna River";
                Option4.Text = "D). Godavari River";
                Label1.BackColor = Color.Red;
            }
            else if (Question == 3)
            {
                QuestionBox.Text = q3;
                Option1.Text = "A). Brihadeswara temple "; //
                Option2.Text = "B). Puri Jagannath temple";
                Option3.Text = "C). Meenakshi Amman Temple";
                Option4.Text = "D). Govindajee Temple";
                Label1.BackColor = Color.Red;
            }
            else if (Question == 4)
            {
                QuestionBox.Text = q4;
                Option1.Text = "A). Sixth";//
                Option2.Text = "B). Fourth";
                Option3.Text = "C). Fifth";
                Option4.Text = "D). ninth";
                Label1.BackColor = Color.Red;
            }



        }

        private void TimeE(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                tim -= 1;
                if (tim == 0)
                {
                    tam.Stop();
                    MessageBox.Show("Sorry You Ran out of time");
                    Option1.Enabled = false;
                    Option2.Enabled = false;
                    Option3.Enabled = false;
                    Option4.Enabled = false;


                    Option1.Text = "";
                    Option2.Text = "";
                    Option3.Text = "";
                    Option4.Text = "";
                    
                    QuestionBox.Text = "";

                    Hint.Enabled = false;
                    Fifty.Enabled = false;

                }
                
                timelbl.Text = string.Format("00:{0}", tim.ToString());
            }));
        }

        private int click = 0;
        private void Option1_Click(object sender, EventArgs e)
        {
            tam.Stop();
            timelbl.Text = "01:00";
            tim = 60;

        

            if (QuestionBox.Text == q2 || QuestionBox.Text == q3 || QuestionBox.Text == q1 || QuestionBox.Text == q4)
            {
                MessageBox.Show("Congratulations!!");
                tam.Start();
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;

                Random Ran2 = new Random();
                    int que = Ran2.Next(1, 3);
                    if (que == 1)
                    {
                        ptlbl.Text = "Points: 100";
                        QuestionBox.Text = o1;
                        Option1.Text = "A). BR Ambedkar";
                        Option2.Text = "B). Raja Ram Mohan Roy";
                        Option3.Text = "C). Sardar Vallabhai Patel";//
                        Option4.Text = "D). Jawaharlal Nehru";
                        label2.BackColor = Color.Red;
                        Label1.BackColor = Color.Lime;

                    }
                    else if (que == 2)
                    {
                        ptlbl.Text = "Points: 100";
                        QuestionBox.Text = o2;
                        Option1.Text = "A). Cauvery";
                        Option2.Text = "B). Krishna";
                        Option3.Text = "C). Godaavari";//
                        Option4.Text = "D). Yamuna";
                        label2.BackColor = Color.Red;
                        Label1.BackColor = Color.Lime;
                    }
                    else if (que == 3)
                    {
                        ptlbl.Text = "Points: 100";
                        QuestionBox.Text = o3;
                        Option1.Text = "A). Dr Zakir Hussain";
                        Option2.Text = "B). Santosh George";
                        Option3.Text = "C). Acharya Vinoba Bhave";//
                        Option4.Text = "D). GV Mavlankar";
                        label2.BackColor = Color.Red;
                        Label1.BackColor = Color.Lime;
                    }
                }
            



            if (click == 1)
            {


                if (QuestionBox.Text == o1 || QuestionBox.Text == o2 || QuestionBox.Text == o3)
                {
                    MessageBox.Show("Better Try Next Time!!");
                    Option3.BackColor = Color.Lime;
                    Option1.Enabled = false;
                    Option2.Enabled = false;
                    Option3.Enabled = false;
                    Option4.Enabled = false;
                    Hint.Enabled = false;
                    Fifty.Enabled = false;
                }
             
            else if (QuestionBox.Text == c1 || QuestionBox.Text == c2)
                    {
                        MessageBox.Show("Better Try Next Time!!");
                    Option1.Enabled = false;
                    Option2.Enabled = false;
                    Option3.Enabled = false;
                    Option4.Enabled = false;
                    Hint.Enabled = false;
                    Fifty.Enabled = false;
                    Option4.BackColor = Color.Lime;
                    }
                click++;
            }
            else 
            {
                click += 1;

            }

            if (QuestionBox.Text == o4 || QuestionBox.Text == o5)
            {
                MessageBox.Show("Congratulations!!");
                tam.Start();
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;

                

                Random Ran3 = new Random();
                int que1 = Ran3.Next(1, 3);
                if (que1 == 1)
                {
                    ptlbl.Text = "Points: 10000";
                    QuestionBox.Text = c1;
                    Option1.Text = "A). Malayalam";
                    Option2.Text = "B). Kannada";
                    Option3.Text = "C). Kannada";
                    Option4.Text = "D). Tamil";//
                    label4.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;


                }
                else
                {
                    ptlbl.Text = "Points: 10000";
                    QuestionBox.Text = c2;
                    Option1.Text = "A). Karnataka";
                    Option2.Text = "B).  Madhya Pradesh";
                    Option3.Text = "C). Meghalaya";
                    Option4.Text = "D). Manipur";//
                    label4.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;


                }
            }

         
            else if (QuestionBox.Text == d1 || QuestionBox.Text == d2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
                
            }

            if (QuestionBox.Text == e1 || QuestionBox.Text == e2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option2.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == l1 || QuestionBox.Text == l2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option2.BackColor = Color.Lime;
            }
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            tam.Stop();
            timelbl.Text = "01:00";
            tim = 60;

            if (QuestionBox.Text == o1 || QuestionBox.Text == o2 || QuestionBox.Text == o3)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option3.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == q1 || QuestionBox.Text == q4)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == o4 || QuestionBox.Text == o5)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == q2 || QuestionBox.Text == q3)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }

            if (QuestionBox.Text == c1 || QuestionBox.Text == c2)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == d1 || QuestionBox.Text == d2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }

            if (QuestionBox.Text == e1 || QuestionBox.Text == e2)
            {
                MessageBox.Show("Congratulations!!");
                tam.Start();
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;

               
                Random Ran4 = new Random();
                int que4 = Ran4.Next(1, 4);
                if (que4 == 1 || que4 == 4)
                {
                    ptlbl.Text = "Points: 10000000";
                    QuestionBox.Text = l1;
                    Option1.Text = "A). Salim Malik";
                    Option2.Text = "B). VO Chidambaranar";//
                    Option3.Text = "C). Prakash Jai Kumar";
                    Option4.Text = "D). Naveen Krishna Reddy";
                    label7.BackColor = Color.Red;
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.LimeGreen;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
                else
                {
                    ptlbl.Text = "Points: 10000000";
                    QuestionBox.Text = l2;
                    Option1.Text = "A). West Bengal";
                    Option2.Text = "B). Odisha";//
                    Option3.Text = "C). Karnataka";
                    Option4.Text = "D). Assam";
                    label7.BackColor = Color.Red;
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.LimeGreen;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
            }

            if (QuestionBox.Text == l1 || QuestionBox.Text == l2)
            {
                
                Option1.Enabled = false;
                Option3.Enabled = false;
                Option2.Enabled = false;
                Option4.Enabled = false;

                MessageBox.Show("Congratulations You won the Garnd Prize!!");
              
                    ptlbl.Text = "Points: 100000000";
                    QuestionBox.Text = "You won The Prize of 100000000";

                
                label7.BackColor = Color.Red;
                label5.BackColor = Color.Lime;
                label6.BackColor = Color.LimeGreen;
                label3.BackColor = Color.Lime;
                Label1.BackColor = Color.Lime;
                label2.BackColor = Color.LimeGreen;
                label4.BackColor = Color.LimeGreen;

            }
        }


        private void Option3_Click(object sender, EventArgs e)
        {
            tam.Stop();
            timelbl.Text = "01:00";
            tim = 60;

            if (QuestionBox.Text == o1 || QuestionBox.Text == o2 || QuestionBox.Text == o3)
            {
                MessageBox.Show("Congratulations!!");
                tam.Start();
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;

              
                Random Ran2 = new Random();
                int que = Ran2.Next(1, 4);
                if (que == 1)
                {
                    ptlbl.Text = "Points: 1000";
                    QuestionBox.Text = o4;
                    Option1.Text = "A).  Vijayalakshmi Pandit";//
                    Option2.Text = "B). Arati Saha";
                    Option3.Text = "C). Amrutha Krishnan";
                    Option4.Text = "D). Pavithra Ramanarayanan";
                    label3.BackColor = Color.Red;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;

                }
                else
                {
                    ptlbl.Text = "Points: 1000";
                    QuestionBox.Text = o5;
                    Option1.Text = "A). Delhi";//
                    Option2.Text = "B). Kolkata";
                    Option3.Text = "C). Chennai";
                    Option4.Text = "D). Mumbai";
                    label3.BackColor = Color.Red;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;

                }

            }
            else if (QuestionBox.Text == q2 || QuestionBox.Text == q3)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == q1 || QuestionBox.Text == q4)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option4.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == o4 || QuestionBox.Text == o5)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }

            if (QuestionBox.Text == c1 || QuestionBox.Text == c2)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }
            if (QuestionBox.Text == d1 || QuestionBox.Text == d2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }

            if (QuestionBox.Text == l1 || QuestionBox.Text == l2)
            {

                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option2.BackColor = Color.Lime;
            }
        }

        private void Option4_Click(object sender, EventArgs e)
        {
            tam.Stop();
            timelbl.Text = "01:00";
            tim = 60;


            if (QuestionBox.Text == c1 || QuestionBox.Text == c2)
            {
                MessageBox.Show("Congratulations!!");
                tam.Start();
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;

                Random Ran2 = new Random();
                int que = Ran2.Next(1, 4);
                if (que == 1 || que == 4)
                {
                    ptlbl.Text = "Points: 100000";
                    QuestionBox.Text = d1;
                    Option1.Text = "A). 1850";
                    Option2.Text = "B). 1847";
                    Option3.Text = "C). 1863";
                    Option4.Text = "D). 1853";//
                    label5.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
                else
                {
                    ptlbl.Text = "Points: 100000";
                    QuestionBox.Text = d2;
                    Option1.Text = "A). 3.17";
                    Option2.Text = "B). 3.27";
                    Option3.Text = "C). 3.15";
                    Option4.Text = "D). 3.14";//
                    label5.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
            }
            else if (QuestionBox.Text == q2 || QuestionBox.Text == q3)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == q1 || QuestionBox.Text == q4)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option4.BackColor = Color.Lime;
            }
            else if (QuestionBox.Text == o4 || QuestionBox.Text == o5)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option1.BackColor = Color.Lime;
            }
            if (QuestionBox.Text == o1 || QuestionBox.Text == o2 || QuestionBox.Text == o3)
            {
                MessageBox.Show("Better Try Next Time!!");
                Option1.Enabled = false;
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Hint.Enabled = false;
                Fifty.Enabled = false;
                Option3.BackColor = Color.Lime;
            }


            if (QuestionBox.Text == d1 || QuestionBox.Text == d2)
            {

                MessageBox.Show("Congratulations!!");

                
                Option1.Enabled = true;
                Option3.Enabled = true;
                Option2.Enabled = true;
                Option4.Enabled = true;
                Random Ran2 = new Random();
                int que = Ran2.Next(1, 4);
                if (que == 1 || que == 4)
                {
                    ptlbl.Text = "Points: 1000000";
                    QuestionBox.Text = e1;
                    Option1.Text = "A). Kerela";
                    Option2.Text = "B). Bihar";//
                    Option3.Text = "C). Madhya Pradesh";
                    Option4.Text = "D). Utter Pradesh";
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
                else
                {
                    ptlbl.Text = "Points: 1000000";
                    QuestionBox.Text = e2;
                    Option1.Text = "A). 10";
                    Option2.Text = "B). 5";//
                    Option3.Text = "C). 8";
                    Option4.Text = "D). 3";
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.Red;
                    label3.BackColor = Color.Lime;
                    Label1.BackColor = Color.Lime;
                    label2.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }

                if (QuestionBox.Text == l1 || QuestionBox.Text == l2)
                {

                    MessageBox.Show("Better Try Next Time!!");
                    Option2.BackColor = Color.Lime;
                }


            }
        }

      
        private void Hint_Click(object sender, EventArgs e)
        {
            Hint.Enabled= false;

            if (QuestionBox.Text == q1)
            {
                MessageBox.Show("It is on the banks of the Yamuna River");
                

            }
            else if (QuestionBox.Text == q2)
            {
                MessageBox.Show("It originates from the Gangotri Glacier in Uttarakhand and empties into the Bay of Bengal");
            }
            else if (QuestionBox.Text == q3)
            {
                MessageBox.Show("It is 1,000-year-old temple in Thanjavur, Tamil Nadu and made by Kumar Shree");
            }
            else if (QuestionBox.Text == q4)
            {
                MessageBox.Show("He served as the president of India, from 1977 to 1982.");
            }
            else if (QuestionBox.Text == o1)
            {
                MessageBox.Show("He earned  the title \"Iron Man of India\".");


            }
            else if (QuestionBox.Text == o2)
            {
                MessageBox.Show("It is India's second longest river ");
            }
            else if (QuestionBox.Text == o3)
            {
                MessageBox.Show("He was an eminent philosopher and the Gita has also been translated into Marathi language by him with the title Geetai");
            }
            else if (QuestionBox.Text == o4)
            {
                MessageBox.Show("She was an Indian diplomat and politician who was the 6th Governor of Maharashtra ");
            }
            else if (QuestionBox.Text == o5)
            {
                MessageBox.Show("Located on the Khari Baoli Road adjacent to Fatehpuri Masjid at the western end of the Chandni Chowk");
            }


            if (QuestionBox.Text == d1)
            {
                MessageBox.Show("Coinage (Colonial Offences) Act and Customs Consolidation Act was passed");
            }
            else if (QuestionBox.Text == d2)
            {
                MessageBox.Show("22/7");
            }
            else if (QuestionBox.Text == l1)
            {
                MessageBox.Show("He founded the Swadeshi Steam Navigation Company[1] in 1906 to compete against the monopoly of the British India Steam Navigation Company (BISNC).");
            }
            else if (QuestionBox.Text == l2)
            {
                MessageBox.Show("It is spread over the Puri, Khurda and Ganjam districts");
            }
            else if (QuestionBox.Text == c1)
            {
                MessageBox.Show("M. G. Ramachandran spoke this language");
            }
            else if (QuestionBox.Text == c2)
            {
                MessageBox.Show(" It is a botanical garden in Imphal city");
            }
            else if (QuestionBox.Text == e1)
            {
                MessageBox.Show(" It is the third-largest state by population and twelfth-largest by territory");
            }
            else if (QuestionBox.Text == e2)
            {
                MessageBox.Show("5");
            }
        }

        private void Fifty_Click(object sender, EventArgs e)
        {
            if (QuestionBox.Text == q1 || QuestionBox.Text == q2 || QuestionBox.Text == q3 || QuestionBox.Text == q4 || QuestionBox.Text == o4 || QuestionBox.Text == o5)
            {
                //OptionA
                Option2.Text = "";
                Option4.Text = "";
                Option2.Enabled = false;
                Option4.Enabled = false;
                Fifty.Enabled = false;

            }
            else if (QuestionBox.Text == o1 || QuestionBox.Text == o2 || QuestionBox.Text == o3)
            {
                //OptC
                Option2.Text = "";
                Option4.Text = "";
                Option2.Enabled = false;
                Option4.Enabled = false;
                Fifty.Enabled = false;
            }
            else if (QuestionBox.Text == e1 || QuestionBox.Text == e2 || QuestionBox.Text == l1 || QuestionBox.Text == l2)
            {
                //OptB
                Option1.Text = "";
                Option3.Text = "";
                Option1.Enabled = false;
                Option3.Enabled = false;
                Fifty.Enabled = false;


            }
            else if (QuestionBox.Text == c1 || QuestionBox.Text == c2 || QuestionBox.Text == d1 || QuestionBox.Text == d2)
            {
                //OptD
                Option1.Text = "";
                Option3.Text = "";
                Fifty.Enabled = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Sorry out of time");
            
        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
