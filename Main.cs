using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace BluxScript
{

    public partial class Main : Form
    {

        bool settings = false;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string name;

        public Main(string login)
        {

            InitializeComponent();
            name = login;
            con = new MySqlConnection("Server=localhost;Database=allsql;user=root;Pwd=;SslMode=none");
            if (settings == true)
            {

            }
        }

        static void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }

        public static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    Username
                },
                { 
                    "content",
                    msg
                }
            });
        }




        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        string id,fivem3, username, password, cpid, email, rust, cs, fivem, czas, pole1, pfpurl, ranga, daraverify, kluczwygas, kluczuzyty, uid, fivem2, cs2, spoofer2, spoofer;
        string linksponsor, linksponsor2, linksponsor3, linksponsor4, pfpreseller, pfpreseller2, pfpreseller3, pfpreseller4, pfpreseller5, sponsor, sponsor2, sponsor3, sponsor4, nickreseller, nickreseller2 , nickreseller3, nickreseller4, nickreseller5, sponsorweb, sponsorweb2, sponsorweb3, sponsorweb4;
        private object request;


        private void Main_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Login log = new Login();
            t1.Interval = 30;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
           
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM informations where id='" + "1" + "';";
            MySqlDataReader row;
            row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                if (row.Read())
                {
                    linksponsor = row["linksponsor"].ToString();
                    linksponsor2 = row["linksponsor2"].ToString();
                    linksponsor3 = row["linksponsor3"].ToString();
                    linksponsor4 = row["linksponsor4"].ToString();
                    pfpreseller = row["pfpreseller"].ToString();
                    pfpreseller2 = row["pfpreseller2"].ToString();
                    pfpreseller3 = row["pfpreseller3"].ToString();
                    pfpreseller4 = row["pfpreseller4"].ToString();
                    pfpreseller5 = row["pfpreseller5"].ToString();
                    sponsor = row["sponsor"].ToString();
                    sponsor2 = row["sponsor2"].ToString();
                    sponsor3 = row["sponsor3"].ToString();
                    sponsor4 = row["sponsor4"].ToString();
                    nickreseller = row["nickreseller"].ToString();
                    nickreseller2 = row["nickreseller2"].ToString();
                    nickreseller3 = row["nickreseller3"].ToString();
                    nickreseller4 = row["nickreseller4"].ToString();
                    nickreseller5 = row["nickreseller5"].ToString();
                    sponsorweb = row["sponsorweb"].ToString();
                    sponsorweb2 = row["sponsorweb2"].ToString();
                    sponsorweb3 = row["sponsorweb3"].ToString();
                    sponsorweb4 = row["sponsorweb4"].ToString();
                    sponsorweb4 = row["sponsorweb4"].ToString();
                    fivem3 = row["fivem3"].ToString();
                    cs2 = row["cs2"].ToString();
                    spoofer2 = row["spooferwork"].ToString();
                }
            }
            con.Close();
            guna2Panel4.Hide();
            label42.Hide();
            guna2Panel5.Hide();
            guna2Button8.Hide();
            guna2Button9.Hide();
            guna2PictureBox16.Hide();
            guna2PictureBox15.Hide();
            guna2PictureBox17.Hide();
            guna2PictureBox18.Hide();
            label43.Hide();
            guna2Button11.Hide();
            guna2Button12.Hide();

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM blux_accounts where login='" + name + "';";
            row = cmd.ExecuteReader();
            if (row.Read())
            {
                id = row["id"].ToString();
                username = row["login"].ToString();
                password = row["haslo"].ToString();
                cpid = row["cpid"].ToString();
                email = row["email"].ToString();
                rust = row["klucz_rust"].ToString();
                cs = row["klucz_cs"].ToString();
                fivem = row["klucz_fivem"].ToString();
                fivem2 = row["klucz_fivem2"].ToString();
                czas = row["klucz_czas"].ToString();
                pole1 = row["pole1"].ToString();
                pfpurl = row["linkpfp"].ToString();
                ranga = row["ranga"].ToString();
                daraverify = row["weryfikacja_data"].ToString();
                kluczwygas = row["klucz_czas"].ToString();
                kluczuzyty = row["uzytyklucz"].ToString();
                uid = row["id"].ToString();
                spoofer = row["klucz_spoofer"].ToString();
            }
            con.Close();
            //Sponsorzy
            guna2PictureBox13.Hide();
            guna2PictureBox12.Hide();
            label16.Text = sponsor;
            label17.Text = sponsor2;
            label18.Text = sponsor3;
            label19.Text = sponsor4;
            label10.Text = ranga;
            label40.Text = daraverify;
            label39.Text = kluczwygas;
            label38.Text = kluczuzyty; 
            guna2Panel1.Hide();
            label31.Hide();
            label30.Hide();
            label41.Text = "UID : " + uid;
            guna2Panel2.Hide();
            int rangalen = label10.Text.Length;




            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET ip_zalozenie='" + "undefined" + "' WHERE login='" +name + "';";
            cmd.ExecuteNonQuery();
            con.Close();




            guna2Panel3.Hide();


            //PIERDOLONE IFY NA NICK ZAJEBANY
            if (rangalen == 5)
            {
                label10.Font = new Font(label10.Font.Name, label10.Font.Size, label10.Font.Style);//GIT
                label10.Left = 767;
            }

            if (rangalen == 8)
            {
                label10.Font = new Font(label10.Font.Name, 8, label10.Font.Style);//GIT
                label10.Left = 765;

            }
                      if (rangalen == 8)
            {
                label10.Font = new Font(label10.Font.Name, 8, label10.Font.Style);//GIT
                label10.Left = 765;

            }
            if (rangalen == 9)
            {
                label10.Font = new Font(label10.Font.Name, 8, label10.Font.Style);//GIT
                label10.Left = 755;

            }
            label32.Hide();
            guna2TextBox2.Hide();






            //CZWARTE
            if (linksponsor == "brak")
            {
                guna2CirclePictureBox2.Hide();
            }
            else
            {

                var request = WebRequest.Create(linksponsor);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox2.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            //TRZECIE
            if (linksponsor2 == "brak")
            {
                guna2CirclePictureBox3.Hide();
            }
            else
            {

                var request = WebRequest.Create(linksponsor2);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox3.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            //DRUGIE
            if (linksponsor3 == "brak")
            {
                guna2CirclePictureBox4.Hide();
            }
            else
            {

                var request = WebRequest.Create(linksponsor3);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox4.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            //PIERWSZE
            if (linksponsor4 == "brak")
            {
                guna2CirclePictureBox5.Hide();
            }
            else
            {

                var request = WebRequest.Create(linksponsor4);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox5.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }














            guna2PictureBox14.Hide();

            //SPECJALNE DO RANGI
            label23.Hide(); // Reseller
            label24.Hide(); //Owner
            label25.Hide(); //Team Blux
            label26.Hide(); //INFO
            label28.Hide(); //Settings
            label33.Hide();

            guna2PictureBox19.Hide();
            guna2PictureBox20.Hide();
            guna2PictureBox21.Hide();
            guna2PictureBox22.Hide();
            guna2Button14.Hide();
            guna2Button13.Hide();
            label44.Hide();

            if (ranga == "Owner")
            {
                label24.Show(); // OWNER
            }
            if (ranga == "Reseller")
            {
                label23.Show(); // RESELLER
            }
            if (ranga == "Team Blux")
            {
                label25.Show();// TEAM BLUX
            }




















            if (spoofer == "tak")
            {
                guna2Button21.Text = "Spoof";
                guna2Button22.Text = "Unlink";
            }
            if (spoofer == "nie")
            {
                guna2Button21.Text = "Buy";
                guna2Button22.Text = "Buy";
            }
            if (spoofer2 == "przerwa")
            {

                guna2Button21.Text = "Don't Work";
            }











            if (cs == "tak")
            {
                guna2Button16.Text = "Launch";
            }
            if (cs == "nie")
            {
                guna2Button16.Text = "Buy Key";
            }
            if (cs2 == "przerwa")
            {

                guna2Button16.Text = "Detected";
            }















            //Resellerzy
            if (pfpreseller == "brak")
            {
                guna2CirclePictureBox6.Hide();
            }
            else
            {

                var request = WebRequest.Create(pfpreseller);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox6.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (pfpreseller2 == "brak")
            {
                guna2CirclePictureBox7.Hide();
            }
            else
            {

                var request = WebRequest.Create(pfpreseller2);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox7.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (pfpreseller3 == "brak")
            {
                guna2CirclePictureBox8.Hide();
            }
            else
            {

                var request = WebRequest.Create(pfpreseller3);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox8.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (pfpreseller4 == "brak")
            {
                guna2CirclePictureBox9.Hide();
            }
            else
            {

                var request = WebRequest.Create(pfpreseller4);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox9.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (pfpreseller5 == "brak")
            {
                guna2CirclePictureBox10.Hide();
            }
            else
            {

                var request = WebRequest.Create(pfpreseller5);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    guna2CirclePictureBox10.Image = Bitmap.FromStream(stream);
                    guna2CirclePictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }







            if (fivem == "tak")
            {
                guna2Button17.Text = "Launch Cheat";
            }

            if (fivem == "nie")
            {
                guna2Button17.Text = "Buy";
            }


            if (fivem2 == "tak")
            {
                guna2Button15.Text = "Launch Cheat";
            }

            if (fivem2 == "nie")
            {
                guna2Button15.Text = "Buy";
            }

            if (fivem3 == "przerwa")
            {
                guna2Button17.Text = "Detected!";
            }


            if (fivem3 == "przerwa")
            {
                guna2Button15.Text = "Detected!";
            }


            label4.Text = name;
            label15.Text = czas;

            guna2PictureBox4.Hide();
            guna2PictureBox5.Hide();
            label12.Hide();
 
            guna2PictureBox6.Hide();
            //PFP LINK DAWANIE
            label20.Hide();
            guna2PictureBox8.Hide();
            guna2TextBox1.Hide();
            label21.Hide();
            label22.Hide();
            guna2Button3.Hide();

            if (pole1 == "tak")
            {
                guna2PictureBox4.Show();
                guna2PictureBox5.Show();
                label12.Show();
                guna2PictureBox6.Show();
                guna2Button1.Hide();
                guna2Button2.Hide();
            }


            int userlen = name.Length;


            //PIERDOLONE IFY NA NICK ZAJEBANY
            if (userlen == 14 )
            {
                label4.Font = new Font (label4.Font.Name, 9, label4.Font.Style);//GIT
                label4.Left = 725;
            }
            if (userlen == 13)
            {
                label4.Font = new Font(label4.Font.Name, 9, label4.Font.Style);//GIT
                label4.Left = 728;
            }
            if (userlen == 12)
            {
                label4.Font = new Font(label4.Font.Name, 9, label4.Font.Style);//GIT
                label4.Left = 732;
            }
            if (userlen == 12)
            {
                label4.Font = new Font(label4.Font.Name, 9, label4.Font.Style);//GIT
                label4.Left = 737;
            }
            if (userlen == 11)
            {
                label4.Font = new Font(label4.Font.Name, 9, label4.Font.Style);//GIT
                label4.Left = 742;
            }
            if (userlen == 10)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style); // GIT
                label4.Left = 736;
            }
            if (userlen == 9)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style); //GIT
                label4.Left = 742;
            }
            if (userlen == 8)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style); //GIT
                label4.Left = 747;
            }
            
            if (userlen == 7)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style);//GIT
                label4.Left = 759;
            }
            if (userlen == 6)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style);//GIT
                label4.Left = 765;
            }
            if (userlen == 5)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style);//GIT
                label4.Left = 770;
            }
            if (userlen == 4)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style);//GIT
                label4.Left = 775;
            }
            if (userlen == 3)
            {
                label4.Font = new Font(label4.Font.Name, 10, label4.Font.Style);//GIT
                label4.Left = 775;
            }



           







            //PFP
            if (pfpurl == "brak")
            {
                guna2CirclePictureBox1.Hide();
                guna2PictureBox28.Hide();
                guna2PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                try
                {
                    guna2PictureBox7.Hide();
                    var request = WebRequest.Create(pfpurl);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        guna2CirclePictureBox1.Image = Bitmap.FromStream(stream);
                        guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }

                }
                catch (Exception ex)
                {
                    guna2CirclePictureBox1.Hide();
                    guna2PictureBox7.Show();
                    guna2PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    cmd = new MySqlCommand();

                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "UPDATE blux_accounts SET linkpfp='" + "brak" + "' WHERE login='" + name + "';";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form msg = new BluxMsgBox("Blux Products", "Your photo was invalid use other!", 9);
                    msg.ShowDialog();
                }
                finally
                {
                    //guwno o kurwa ale sie najebalem
                }









                try
                {
                 
                    var request = WebRequest.Create(pfpurl);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        guna2CirclePictureBox11.Image = Bitmap.FromStream(stream);
                        guna2CirclePictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;

                    }

                }
                catch (Exception ex)
                {
                    guna2CirclePictureBox11.Hide();
                }
                finally
                {
                    //guwno o kurwa ale sie najebalem
                }



            }








        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();
            else
                Opacity += 0.05;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          //MessageBox.Show("our computer is ratted 500 euro for unratted LOL RIFK KIDDO");
            
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }




        //hovery






        private void label2_MouseEnter(object sender, EventArgs e)
        {
                label2.ForeColor = Color.FromArgb(138, 43, 226);
        }



        private void label2_MouseLeave_1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }



        //KLIKNIECIE PFP RESELLERA
        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            if (nickreseller == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no Nickname!", 9);
                msg.ShowDialog();
            }
            else
            {
                Clipboard.SetText(nickreseller);
                Form msg = new BluxMsgBox("Blux Products", "Copied Reseller Name!", 9);
                msg.ShowDialog();
            }
        }

        private void label18_Click_1(object sender, EventArgs e)
        {
            if (sponsorweb3 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb3);
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }


        
        private void label25_MouseEnter(object sender, EventArgs e)
        {
            label25.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.ForeColor = Color.White;

        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label23.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.ForeColor = Color.White;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label24.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.ForeColor = Color.White;
        }

        private void label25_MouseEnter_1(object sender, EventArgs e)
        {
            label25.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label25_MouseLeave_1(object sender, EventArgs e)
        {
            label25.ForeColor = Color.White;
        }

























































        //Panele 
        //INFO button
        private void label3_Click_1(object sender, EventArgs e)
        {





            guna2Panel2.Hide();
            guna2Panel4.Hide();
            guna2Panel5.Hide();
            guna2Panel3.Hide();
            label3.ForeColor = Color.FromArgb(138, 43, 226);
            label26.Show();
            label3.Hide();
            guna2Panel1.Show();
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label28.Hide();//settings
            label11.Show();//SETTINGS
                           //NOWY TEXT
            label31.Hide();
            label32.Hide();
            label33.Hide();
            label30.Hide();
        }





        //home button
        private void label5_Click(object sender, EventArgs e)
        {





            guna2Panel2.Hide();
            guna2Panel3.Hide();
            guna2Panel4.Hide();
            guna2Panel5.Hide();
            label3.ForeColor = Color.White;//INFO
            label26.Hide();//INFO
            guna2Panel1.Hide();//INFO
            label3.Show();//INFO
            label27.Show(); //BLUEVIOLET HOME
            label28.Hide();//settings
            label11.Show();//SETTINGS
            label31.Hide();
            label32.Hide();
            label33.Hide();
            label30.Hide();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {




            guna2Panel3.Hide();
            guna2Panel5.Hide();
            guna2Panel4.Hide();
            label11.ForeColor = Color.White;//SETTINGS
            label11.Show();//SETTINGS
           guna2Panel2.Show();//SETTINGS - DO DODANIA



            label28.Show();//SETTINGS BUTTON BLUEVIOLET
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label26.Hide(); //INFO BUTTON BLUEVIOLET
            label3.Show();//INFO
            label31.Hide();
            label32.Hide();
            label33.Hide();
            label30.Hide();
        }




        //Rust i spust
        private void label29_Click(object sender, EventArgs e)
        {
           

            label11.ForeColor = Color.White;//SETTINGS
            label11.Show();//SETTINGS
            //guna2Panel2.Hide();//RUST - DO DODANIA
            label31.Show();


            label28.Hide();//SETTINGS BUTTON BLUEVIOLET
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label26.Hide(); //INFO BUTTON BLUEVIOLET
            label3.Show();//INFO
            label32.Hide();
            label33.Hide();
            label30.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

            guna2Panel5.Hide();
            guna2Panel4.Show();
            //guna2Panel2.Hide();//RUST - DO DODANIA
            label31.Hide();
            label28.Hide();//SETTINGS BUTTON BLUEVIOLET
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label26.Hide(); //INFO BUTTON BLUEVIOLET
            label3.Show();//INFO
            label32.Show();
            label29.Show();
            label33.Hide();
            label30.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {

            guna2Panel4.Hide();
            guna2Panel5.Hide();
            guna2Panel3.Show();
            //guna2Panel2.Hide();//RUST - DO DODANIA
            label31.Hide();
            label28.Hide();//SETTINGS BUTTON BLUEVIOLET
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label26.Hide(); //INFO BUTTON BLUEVIOLET
            label3.Show();//INFO
            label29.Show();
            label33.Show();
            label32.Hide();
            label30.Hide();
        }
        private void label9_Click_1(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            guna2Panel5.Show();
            //guna2Panel2.Hide();// - DO DODANIA
            label31.Hide();
            label28.Hide();//SETTINGS BUTTON BLUEVIOLET
            label27.Hide(); //HOME BUTTON BLUEVIOLET
            label26.Hide(); //INFO BUTTON BLUEVIOLET
            label3.Show();//INFO
            label29.Show();
            label33.Hide();
            label32.Hide();
            label30.Show();
        }





























        private void label29_MouseEnter(object sender, EventArgs e)
        {
            label29.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            label29.ForeColor = Color.White;
        }

        private void label33_Click_1(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 10);
            msg.ShowDialog();
            Process.Start("https://discord.gg/zDbCeY2ZgM");
        }

        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.FromArgb(138, 43, 226);
            guna2Button4.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET linkpfp='" + "brak" + "' WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            Form msg = new BluxMsgBox("Blux Products", "We are Relaunching Launcher For You!", 8);
            msg.ShowDialog();
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button7_MouseEnter(object sender, EventArgs e)
        {
            guna2Button7.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button7_MouseLeave(object sender, EventArgs e)
        {
            guna2Button7.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button5_MouseEnter(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2PictureBox19.Show();
            guna2PictureBox20.Show();
            guna2PictureBox21.Show();
            guna2PictureBox22.Show();
            label44.Show();
            guna2Button14.Show();
            guna2Button13.Show();
        }


        //TUTAJ BUTTON PEDALE JEBANY
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Show();
            guna2PictureBox13.Show();
            guna2PictureBox12.Show();
            label42.Show();
            guna2PictureBox14.Show();
            guna2Button8.Show();
            guna2Button9.Show();
            guna2Button10.Hide();
        }

        private void guna2Button8_MouseEnter(object sender, EventArgs e)
        {
            guna2Button8.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button8_MouseLeave(object sender, EventArgs e)
        {
            guna2Button8.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void guna2Button9_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void guna2Button9_MouseEnter(object sender, EventArgs e)
        {
            guna2Button9.FillColor = Color.Red;
        }

        private void guna2Button9_MouseLeave(object sender, EventArgs e)
        {
            guna2Button9.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Hide();
            guna2PictureBox13.Hide();
            guna2PictureBox12.Hide();
            label42.Hide();
            guna2PictureBox14.Hide();
            guna2Button8.Hide();
            guna2Button9.Hide();
            guna2Button10.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "Password Changed!", 10);
            msg.ShowDialog();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET haslo='" + guna2TextBox2.Text.Trim() + "' WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            sendWebHook("https://discord.com/api/webhooks/1005679664888545380/h8dXl6dfXLtByKPXDqwl0kJZyRq0Cb_xNBiZbxrnsQJg5EtFUB_Axa8tkR7Zw_2ojhSz", "Zmieniono Haslo " + "** Przez " + name + "**" + " ``Info:`` Nowe Haslo: " + guna2TextBox2.Text.Trim(), "Blux Products - Password");

            guna2TextBox2.Hide();
            guna2PictureBox13.Hide();
            guna2PictureBox12.Hide();
            label42.Hide();
            guna2PictureBox14.Hide();
            guna2Button8.Hide();
            guna2Button9.Hide();
            guna2Button10.Show();
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_MouseEnter(object sender, EventArgs e)
        {
            guna2Button10.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button10_MouseLeave(object sender, EventArgs e)
        {
                        guna2Button10.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2PictureBox16.Show();
            guna2PictureBox15.Show();
            guna2PictureBox17.Show();
            guna2PictureBox18.Show();
            label43.Show();
            guna2Button11.Show();
            guna2Button12.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            guna2PictureBox16.Hide();
            guna2PictureBox15.Hide();
            guna2PictureBox17.Hide();
            guna2PictureBox18.Hide();
            label43.Hide();
            guna2Button11.Hide();
            guna2Button12.Hide();
        }

        private void guna2PictureBox18_MouseEnter(object sender, EventArgs e)
        {

        }

        private void guna2Button12_MouseEnter(object sender, EventArgs e)
        {
            guna2Button12.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button12_MouseLeave(object sender, EventArgs e)
        {
            guna2Button12.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button11_MouseEnter(object sender, EventArgs e)
        {
            guna2Button11.FillColor = Color.Red;
        }

        private void guna2Button11_MouseLeave(object sender, EventArgs e)
        {
            guna2Button11.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "We have just reset your CPUID!", 9);
            msg.ShowDialog();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET cpid='" + "brak" + "' WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            sendWebHook("https://discord.com/api/webhooks/1005683380303700059/EarwhUHUkv9k9UC8POUeu4f-XXh-Ln5hsnMe4ZTrbdTOsQ6wWrmLb-YBHKCXxzXWXrPq", "Usunieto CPUID " + "** Przez " + name + "**" + " ``Info:`` Stare CPUID: " + cpid, "Blux Products - CPUID");
            guna2PictureBox16.Hide();
            guna2PictureBox15.Hide();
            guna2PictureBox17.Hide();
            guna2PictureBox18.Hide();
            label43.Hide();
            guna2Button11.Hide();
            guna2Button12.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            guna2PictureBox19.Hide();
            guna2PictureBox20.Hide();
            guna2PictureBox21.Hide();
            guna2PictureBox22.Hide();
            label44.Hide();
            guna2Button14.Hide();
            guna2Button13.Hide();
        }

        private void guna2Button13_MouseEnter(object sender, EventArgs e)
        {
            guna2Button13.FillColor = Color.Red;
        }

        private void guna2Button13_MouseLeave(object sender, EventArgs e)
        {
            guna2Button13.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button14_MouseEnter(object sender, EventArgs e)
        {
            guna2Button14.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button14_MouseLeave(object sender, EventArgs e)
        {
            guna2Button14.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            guna2PictureBox19.Hide();
            guna2PictureBox20.Hide();
            guna2PictureBox21.Hide();
            guna2PictureBox22.Hide();
            label44.Hide();
            guna2Button14.Hide();
            guna2Button13.Hide();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM blux_accounts WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            sendWebHook("https://discord.com/api/webhooks/1005663109089861692/4BWbR3oXS8YAjmdWeHTmuBk9RqHfSWGgKLBIE5Dze0VCH9LXX0_yflM5HXzX25W1mOIH", "Usunieto Konto " + "** Przez " + name + "**" + " ``Info:`` Profilowe Zdjecie: " + pfpurl + " Uzyty Klucz: " + kluczuzyty + " CpuID: " + cpid + " Ranga: " + ranga + " Email: " + email + " Data Wygasniecia Klucza: " + kluczwygas, "Blux Products - Deleting");
            Form msg = new BluxMsgBox("Blux Products", "Your Account is deleted!", 9);
            msg.ShowDialog();
            Application.Exit();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }


        //Button Fivem
        private void guna2Button17_Click(object sender, EventArgs e)
        {
            if (fivem3 == "przerwa")
            {
                Form msg = new BluxMsgBox("Blux Products", "You can't do this!", 10);
                msg.ShowDialog();
                Application.Exit();
            }

            if (fivem == "nie")
            {
            Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
            msg.ShowDialog();
            Process.Start("https://discord.gg/zDbCeY2ZgM");
            }


            if (fivem == "tak")
            {
                Form msg = new BluxMsgBox("Blux Products", "Launching Cheat!", 10);
                msg.ShowDialog();
                this.Hide();
                BluxLoader bl = new BluxLoader();
                bl.ShowDialog();
            }


        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {
            if (fivem3 == "przerwa")
            {
                Form msg = new BluxMsgBox("Blux Products", "You can't do this!", 10);
                msg.ShowDialog();
                Application.Exit();
            }
            if (fivem2 == "nie")
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start("https://discord.gg/zDbCeY2ZgM");
            }


            if (fivem2 == "tak")
            {
                Form msg = new BluxMsgBox("Blux Products", "Launching Cheat!", 10);
                msg.ShowDialog();
                this.Hide();
                BluxLoader bl = new BluxLoader();
                bl.ShowDialog();
            }



        }

        private void guna2Button15_MouseEnter(object sender, EventArgs e)
        {
            guna2Button15.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button15_MouseLeave(object sender, EventArgs e)
        {
            guna2Button15.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button16_MouseEnter(object sender, EventArgs e)
        {
            guna2Button16.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button16_MouseLeave(object sender, EventArgs e)
        {
            guna2Button16.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
            msg.ShowDialog();
            Process.Start("https://discord.gg/tMY45E9ZYp");
        }

        private void guna2Button18_MouseEnter(object sender, EventArgs e)
        {
            guna2Button18.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button18_MouseLeave(object sender, EventArgs e)
        {
            guna2Button18.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
            msg.ShowDialog();
            Process.Start("https://discord.gg/tMY45E9ZYp");
        }

        private void guna2Button19_MouseEnter(object sender, EventArgs e)
        {
            guna2Button19.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button19_MouseLeave(object sender, EventArgs e)
        {
            guna2Button19.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void guna2Button22_MouseEnter(object sender, EventArgs e)
        {
            guna2Button22.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button21_MouseEnter(object sender, EventArgs e)
        {
            guna2Button21.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button21_MouseLeave(object sender, EventArgs e)
        {
            guna2Button21.FillColor = Color.FromArgb(40, 40, 40);
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {


            if (spoofer == "nie")
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start("https://discord.gg/zDbCeY2ZgM");
            }


            if (spoofer == "tak")
            {
                Form msg = new BluxMsgBox("Blux Products", "Launching Unlinker!", 10);
                msg.ShowDialog();









                if (guna2CheckBox10.Checked == true)//XBOX
                {
                    Form msg2 = new BluxMsgBox("Blux Products", "Done Xbox!", 13);
                    msg2.ShowDialog();
                }
                if (guna2CheckBox7.Checked == true)//DISCORD
                {
                    Form msg3 = new BluxMsgBox("Blux Products", "Done Discord!", 13);
                    msg3.ShowDialog();
                }
                if (guna2CheckBox8.Checked == true)//STEAM
                {
                    Form msg4 = new BluxMsgBox("Blux Products", "Done Steam!", 13);
                    msg4.ShowDialog();
                }
                if (guna2CheckBox9.Checked == true)//ROCKSTAR
                {
                    Form msg5 = new BluxMsgBox("Blux Products", "Done Rockstar!", 13);
                    msg5.ShowDialog();
                }
                if (guna2CheckBox11.Checked == true)//ALL
                {
                    Form msg6 = new BluxMsgBox("Blux Products", "Done All!", 13);
                    msg6.ShowDialog();
                }















            }
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            if (spoofer2 == "przerwa")
            {
                Form msg = new BluxMsgBox("Blux Products", "You can't do this!", 10);
                msg.ShowDialog();
                Application.Exit();
            }

            if (spoofer == "nie")
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start("https://discord.gg/zDbCeY2ZgM");
            }


            if (spoofer == "tak")
            {
                Form msg = new BluxMsgBox("Blux Products", "Launching Spoofer!", 10);
                msg.ShowDialog();
                






              if (guna2CheckBox5.Checked == true)//FIVEMAPP
                {
                    Form msg2 = new BluxMsgBox("Blux Products", "Done FivemApp!", 13);
                    msg2.ShowDialog();
                }
                if (guna2CheckBox4.Checked == true)//REGISTRY
                {
                    Form msg2 = new BluxMsgBox("Blux Products", "Done Registry!", 13);
                    msg2.ShowDialog();
                }
                if (guna2CheckBox3.Checked == true)//APPDATA
                {
                    Form msg2 = new BluxMsgBox("Blux Products", "Done Appdata!", 13);
                    msg2.ShowDialog();
                }
                if (guna2CheckBox2.Checked == true)//MAIN SPOOF
                {
                    Form msg2 = new BluxMsgBox("Blux Products", "Done Main Spoof!", 13);
                    msg2.ShowDialog();
                }
                if (guna2CheckBox1.Checked == true)//ALL
                {
                    ExecuteCommand("echo testing");
                   
                    Form msg2 = new BluxMsgBox("Blux Products", "Done All!", 13);
                    msg2.ShowDialog();


                }






            }
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == false)//ALL
            {
                guna2CheckBox1.Checked = false;
                guna2CheckBox2.Checked = false;
                guna2CheckBox3.Checked = false;
                guna2CheckBox4.Checked = false;
                guna2CheckBox5.Checked = false;
            } else
            {
                guna2CheckBox1.Checked = true;
                guna2CheckBox2.Checked = true;
                guna2CheckBox3.Checked = true;
                guna2CheckBox4.Checked = true;
                guna2CheckBox5.Checked = true;
            }



        }

        private void guna2CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox11.Checked == false)//ALL
            {
                guna2CheckBox10.Checked = false;
                guna2CheckBox7.Checked = false;
                guna2CheckBox8.Checked = false;
                guna2CheckBox9.Checked = false;
                guna2CheckBox11.Checked = false;
            }
            else
            {
                guna2CheckBox10.Checked = true;
                guna2CheckBox7.Checked = true;
                guna2CheckBox8.Checked = true;
                guna2CheckBox9.Checked = true;
                guna2CheckBox11.Checked = true;
            }
        }

        private void guna2Button22_MouseLeave(object sender, EventArgs e)
        {
            guna2Button22.FillColor = Color.FromArgb(40, 40, 40);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

            if (cs2 == "przerwa")
            {
                Form msg = new BluxMsgBox("Blux Products", "You can't do this!", 10);
                msg.ShowDialog();
                Application.Exit();
            }

            if (cs == "nie")
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start("https://discord.gg/zDbCeY2ZgM");
            }


            if (cs == "tak")
            {
                Form msg = new BluxMsgBox("Blux Products", "Launching Cheat!", 10);
                msg.ShowDialog();
                this.Hide();
                BluxLoader bl = new BluxLoader();
                bl.ShowDialog();
            }


        }

        private void guna2Button17_MouseEnter(object sender, EventArgs e)
        {
            guna2Button17.FillColor = Color.FromArgb(138, 43, 226);
        }

        private void guna2Button17_MouseLeave(object sender, EventArgs e)
        {
            guna2Button17.FillColor = Color.FromArgb(77, 77, 77);
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.Gray;
        }

        private void label32_Click(object sender, EventArgs e)
        { 

        }

        private void label40_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (sponsorweb4 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb4);
            }
        }

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {
            if (nickreseller2 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no Nickname!", 9);
                msg.ShowDialog();
            }
            else
            {
                Clipboard.SetText(nickreseller2);
                Form msg = new BluxMsgBox("Blux Products", "Copied Reseller Name!", 9);
                msg.ShowDialog();
            }
        }



        private void guna2CirclePictureBox8_Click_1(object sender, EventArgs e)
        {
            if (nickreseller3 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no Nickname!", 9);
                msg.ShowDialog();
            }
            else
            {
                Clipboard.SetText(nickreseller3);
                Form msg = new BluxMsgBox("Blux Products", "Copied Reseller Name!", 9);
                msg.ShowDialog();
            }
        }


        private void guna2CirclePictureBox9_Click_1(object sender, EventArgs e)
        {
            if (nickreseller4 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no Nickname!", 9);
                msg.ShowDialog();
            }
            else
            {
                Clipboard.SetText(nickreseller4);
                Form msg = new BluxMsgBox("Blux Products", "Copied Reseller Name!", 9);
                msg.ShowDialog();
            }
        }



        private void guna2CirclePictureBox10_Click_1(object sender, EventArgs e)
        {
            if (nickreseller5 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no Nickname!", 9);
                msg.ShowDialog();
            }
            else
            {
                Clipboard.SetText(nickreseller5);
                Form msg = new BluxMsgBox("Blux Products", "Copied Reseller Name!", 9);
                msg.ShowDialog();
            }
        }
        //SPONSORZY PFP CLICK
        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
                if (sponsorweb == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb);
            }
        }
        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            if (sponsorweb2 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb2);
            }
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            if (sponsorweb3 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb3);
            }
        }
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (sponsorweb4 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb4);
            }
        }

















        //BUTTON PFP
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.TextLength == 0 || guna2TextBox1.TextLength == 1 || guna2TextBox1.TextLength == 2 || guna2TextBox1.TextLength == 3 || guna2TextBox1.TextLength == 4 || guna2TextBox1.TextLength == 5)
            {
                Form msg = new BluxMsgBox("Blux Products", "You need to input photo!", 11);
                msg.ShowDialog();
            } 
            else
            {

                string zdjecie = guna2TextBox1.Text.Trim();
                bool urlcontain = zdjecie.Contains("jpg");
                bool urlcontain2 = zdjecie.Contains("png");
                bool urlcontain3 = zdjecie.Contains("jpeg");
                bool urlcontain4 = zdjecie.Contains("gif");

                if (urlcontain || urlcontain2 || urlcontain3 || urlcontain4)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "UPDATE blux_accounts SET linkpfp='" + zdjecie + "' WHERE login='" + name + "';";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    label20.Hide();
                    guna2PictureBox8.Hide();
                    guna2TextBox1.Hide();
                    label21.Hide();
                    label22.Hide();
                    guna2Button3.Hide();
                    if (pole1 == "nie")
                    {
                        guna2Button1.Show();
                        guna2Button2.Show();
                    }
                    Form msg = new BluxMsgBox("Blux Products", "We are Relaunching Launcher For You!", 8);
                    msg.ShowDialog();
                    Login LoginForm = new Login();
                    LoginForm.Show();
                    this.Hide();
                } else
                {
                    Form msg = new BluxMsgBox("Blux Products", "Only JPG,PNG,JPEG AND GIFS!", 9);
                    msg.ShowDialog();
                }
            }
        }




        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(138, 43, 226);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("http://experiencestudio.pl/");
        }

        //nie
       private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2PictureBox4.Show();
            guna2PictureBox5.Show();
            label12.Show();
            guna2PictureBox6.Show();
            guna2Button1.Hide();
            guna2Button2.Hide();
            sendWebHook("https://discord.com/api/webhooks/979053318116630568/oxKbtSctyRKtx8ETF-PoAKSuHqVVJvDHtraRC1ajsEcweQukiL9xfWLYQdMcu8i0wIl9", "Should we add Valorant cheat " + "*" + guna2Button2.Text + "*" + " **sended by** " + name, "Blux Products - Voting");
            cmd = new MySqlCommand();

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET pole1='" + "tak" + "' WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            Form msg = new BluxMsgBox("Blux Products", "Voted!", 11);
            msg.ShowDialog();

        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            //KLIKNIECIE PICTURE BOXA
            // DODAC TEXTBOXA W KTORYM BEDZIE MOZNA WRZUCIC LINK I UPDATE DO BAZY DANYCH
            guna2PictureBox4.Show();
            guna2PictureBox5.Show();
            guna2PictureBox6.Show();
            guna2Button1.Hide();
            guna2Button2.Hide();
            label20.Show();
            guna2PictureBox8.Show();
            guna2TextBox1.Show();
            label21.Show();
            label22.Show();
            guna2Button3.Show();
            guna2Button3.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (sponsorweb2 == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb2);
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            if (sponsorweb == "brak")
            {
                Form msg = new BluxMsgBox("Blux Products", "There is no redirect!", 9);
                msg.ShowDialog();
            }
            else
            {
                Form msg = new BluxMsgBox("Blux Products", "Redirecting!", 9);
                msg.ShowDialog();
                Process.Start(sponsorweb);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }






        //tak
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2PictureBox4.Show();
            guna2PictureBox5.Show();
            label12.Show();
            guna2PictureBox6.Show();
            guna2Button2.Hide();
            guna2Button1.Hide();
            sendWebHook("https://discord.com/api/webhooks/979053318116630568/oxKbtSctyRKtx8ETF-PoAKSuHqVVJvDHtraRC1ajsEcweQukiL9xfWLYQdMcu8i0wIl9", "Should we add Valorant cheat " + "*" + guna2Button1.Text + "*" + " **sended by** " + name, "Blux Products - Voting");
            cmd = new MySqlCommand();

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET pole1='" + "tak" + "' WHERE login='" + name + "';";
            cmd.ExecuteNonQuery();
            con.Close();

            Form msg = new BluxMsgBox("Blux Products", "Voted!", 11);
            msg.ShowDialog();
        }














        //hovery






        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {
            //SETTINGS

            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;

        }

        private void label37_Click(object sender, EventArgs e)
        {
            //fivem
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;
        }

        private void label43_MouseHover(object sender, EventArgs e)
        {
          
        }






        private void label40_Click(object sender, EventArgs e)
        {
            //SPOOFER
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;
        }

        private void label42_Click(object sender, EventArgs e)
        {
            //USERINFO
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            //rust
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            //CS:GO
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 100;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.50;
        }








        }
    }





