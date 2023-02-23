using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Management;
namespace BluxScript
{
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
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


        public Login(string name)
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=allsql;user=root;Pwd=;SslMode=none");
        }
        //TO PIERDOLONE GOWNO
        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=allsql;user=root;Pwd=;SslMode=none");
        }

        Timer t1 = new Timer();
        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#1A1A1A");

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 60;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            string update = "";
            string working = "";
            string working2 = "";
            string working3 = "";
            string working4 = "";
            string working5 = "";
            string working6 = "";
            string tojuzkoniec = "";
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
                    tojuzkoniec = row["tojuzkoniec"].ToString();
                    update = row["updatelauncher"].ToString();
                    working = row["textworking"].ToString();
                    working2 = row["textworking2"].ToString();
                    working3 = row["textworking3"].ToString();
                    working4 = row["textworking4"].ToString();
                    working5 = row["textworking5"].ToString();
                    working6 = row["textworking6"].ToString();
                }
            }
            con.Close();
            if (update == "tak")
            {

                Form msg = new BluxMsgBox("Blux Products", "Download New Version!", 11);
                msg.ShowDialog();
                Application.Exit();
            }
            if (tojuzkoniec == "tak")
            {

                Form msg = new BluxMsgBox("Blux Products", "This is The End Of Blux!", 11);
                msg.ShowDialog();
                Application.Exit();

            }
            label4.Text = working;
            label5.Text = working2;
            label6.Text = working3;
            label7.Text = working4; 
            label8.Text = working5;
           label9.Text = working6; 







        }

       
    

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void cpidupdate()
        {
            con.Close();
            cmd.Dispose();
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            string logintrimmed = guna2TextBox2.Text.Trim();
            cmd = new MySqlCommand();

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE blux_accounts SET cpid='" + id + "' WHERE login='" + logintrimmed+"';";
            cmd.ExecuteNonQuery();
            con.Close();
            sendWebHook("https://discord.com/api/webhooks/1005683380303700059/EarwhUHUkv9k9UC8POUeu4f-XXh-Ln5hsnMe4ZTrbdTOsQ6wWrmLb-YBHKCXxzXWXrPq", "Dodano CPUID " + "** Przez " + logintrimmed + "**" + " ``Info:`` Nowe CPUID: " + id, "Blux Products - CPUID");

        }

        public string GetLoginText()
        {
            return guna2TextBox2.Text.Trim();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            string user = guna2TextBox2.Text;
            string pass = guna2TextBox1.Text;
            /*cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM blux_accounts where login='" + guna2TextBox2.Text + "' AND haslo='" + guna2TextBox1.Text + "'";
            dr = cmd.ExecuteReader();
            System.Diagnostics.Debug.WriteLine(id);
            if (dr.Read())
            {
                con.Close();
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM blux_accounts where login='" + guna2TextBox2.Text + "' AND haslo='" + guna2TextBox1.Text + "'AND cpid='"+id+"'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    Form Main = new Main();

                    this.Hide();

                    Main.Show();
                } else
                {
                    MessageBox.Show("This account is attached to another computer. Please reset CPUID at our website.");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }*/



                    string username, password, cpid, verify, banned;
            string logintrimmed = guna2TextBox2.Text.Trim();
            string passwordtrimmed = guna2TextBox1.Text.Trim();
            MySqlDataReader row;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM blux_accounts where login='" + logintrimmed + "';";
            row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                if (row.Read())
                {
                    banned = row["banned"].ToString();
                    username = row["login"].ToString();
                    password = row["haslo"].ToString();
                    cpid = row["cpid"].ToString();
                    verify = row["weryfikacja"].ToString();
                    if (username == logintrimmed && password == passwordtrimmed)
                    {
                      
                        if (cpid == id)
                        {
                            if (verify == "czeka")
                            {
                                Form msg = new BluxMsgBox("Blux Products", "Please verify your email!", 11);
                                msg.ShowDialog();

                                //MessageBox.Show("Please verify your email!");
                            } else if (banned == "tak")
                            {
                                Form msg = new BluxMsgBox("Blux Products", "You are banned!", 11);
                                msg.ShowDialog();
                            }
                            else
                            {
                                Form Main = new Main(logintrimmed);

                                this.Hide();

                                Main.Show();
                            }

                        }
                        else if (cpid == "brak")
                        {



                            if (verify == "czeka")
                            {
                                Form msg = new BluxMsgBox("Blux Products", "Please verify your email!", 11);
                                msg.ShowDialog();
                                //MessageBox.Show("Please verify your email!");
                            }
                            else if (banned == "tak")
                            {
                                Form msg = new BluxMsgBox("Blux Products", "You are banned!", 11);
                                msg.ShowDialog();
                            }
                            else
                            {
                                Form Main = new Main(logintrimmed);

                                this.Hide();

                                Main.Show();
                                Main m = new Main(logintrimmed);
                                cpidupdate();
                                Form msg = new BluxMsgBox("Blux Products", "New CPUID has been linked.", 11);
                                msg.ShowDialog();
                            }


                        }

                        else
                        {
                            Form msg = new BluxMsgBox("Blux Products", "Invalid CPUID.", 11);
                            msg.ShowDialog();
                            //MessageBox.Show("This account is attached to another computer. Please reset CPUID at our website.");
                        }
                    } else
                    {
                        Form msg = new BluxMsgBox("Blux Products", "Invalid password",11);
                        msg.ShowDialog();
                        //MessageBox.Show("Invalid password");
                    }
                }
            } else
            {
                Form msg = new BluxMsgBox("Blux Products", "Account not found!",11);
                msg.ShowDialog();
                //MessageBox.Show("Account not found!");
            }
            
            con.Close();


        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bluxproducts.com/");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bluxproducts.com/");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bluxproducts.com/");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
