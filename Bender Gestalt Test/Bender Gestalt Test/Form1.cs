using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Bender_Gestalt_Test
{
    public partial class Form1 : Form
    {
       




        int total = 0;
        int a=0,b=0,c=0,d=0;
        int f=0,g=0,h=0,i=0;
        int j=0,k=0,l=0,m=0;

        string Rotation="";
        string Over_lapping="";
        string Simplification = "";
        string Fragmentation = "";
        string Retrogression = "";
        string Preservation     = "";
        string Collusion_tendecy = "";
        string Impotence = "";
        string Clouser_difficulty = "";
        string Motor_incoordination = "";
        string Cohesion = "";
        string Angulation = "";
        string picname="";


        public Form1()
        {
            InitializeComponent();
            
        }

        OleDbConnection connect = new OleDbConnection();

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Maximized;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
                metroTextBox1.Enabled = true;
            }








        }





     






        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox5.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox4.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }


        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox7.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox8.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox9.Checked)
            {
                j = 1;
                metroTextBox10.Text = Convert.ToString(j);
            }
            else
            {
                j = 0;
                metroTextBox10.Text = Convert.ToString(j);
            }
        }

     
        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

   

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.Load(openFileDialog1.FileName);

            }

            string imagepath = pictureBox10.ImageLocation.ToString();
            picname = imagepath.Substring(imagepath.LastIndexOf('\\'));
            picname = picname.Remove(0,1);
            picname = picname.Remove(picname.Length - 4,4);


            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = true;
                metroTextBox1.Enabled = false;
                metroButton2.Enabled = false;
            }

        }





        























        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox15.Text = "";
            metroButton1.Enabled = false;
            total = a + b + c + d + f + g + h + i + j + k + l + m;
            metroTextBox16.Text = Convert.ToString(total);

            if (total <= 4) {
                metroTextBox15.ForeColor = Color.Black;
                metroTextBox15.BackColor = Color.DarkRed;
                metroTextBox15.Text = "Absence of brain impairment";
            }
           if(total==5 || total==6)
            { metroTextBox15.BackColor = Color.Orange;
                metroTextBox15.Text = "Brain impairment";
            }
            if (total == 7 || total == 8)
            {
                metroTextBox15.BackColor = Color.DeepSkyBlue;
                metroTextBox15.Text = "Strong evidence of Brain impairment";
            }
            if (total == 9 || total == 10 || total == 11 || total == 12)
            {
                metroTextBox15.BackColor = Color.YellowGreen;
                metroTextBox15.Text = "Very Strong evidence of Brain impairment";
            }


            //CheckBoxes
            //Rotation
            if (metroCheckBox1.Checked)
            {
                Rotation += " A ";
            }
            if (metroCheckBox18.Checked)
            {
                Rotation += " 1 ";
            }
            if (metroCheckBox31.Checked)
            {
                Rotation += " 2 ";
            }
            if (metroCheckBox44.Checked)
            {
                Rotation += " 3 ";
            }
            if (metroCheckBox57.Checked)
            {
                Rotation += " 4 ";
            }
            if (metroCheckBox70.Checked)
            {
                Rotation += " 5 ";
            }
            if (metroCheckBox83.Checked)
            {
                Rotation += " 6 ";
            }
            if (metroCheckBox96.Checked)
            {
                Rotation += " 7 ";
            }
            if (metroCheckBox109.Checked)
            {
                Rotation += " 8 ";
            }

            //OverLapping Difficulty
            if (metroCheckBox91.Checked)
            {
                Over_lapping += " 6 ";
            }
            if (metroCheckBox104.Checked)
            {
                Over_lapping += " 7 ";
            }
            //Simplification
            if (metroCheckBox3.Checked)
            {
                Simplification += " A ";
            }
            if (metroCheckBox25.Checked)
            {
                Simplification += " 1 ";
            }
            if (metroCheckBox38.Checked)
            {
                Simplification += " 2 ";
            }
            if (metroCheckBox51.Checked)
            {
                Simplification += " 3 ";
            }
            if (metroCheckBox64.Checked)
            {
                Simplification += " 4 ";
            }
            if (metroCheckBox77.Checked)
            {
                Simplification += " 5 ";
            }
            if (metroCheckBox90.Checked)
            {
                Simplification += " 6 ";
            }
            if (metroCheckBox106.Checked)
            {
                Simplification += " 7 ";
            }
            if (metroCheckBox116.Checked)
            {
                Simplification += " 8 ";
            }


            //Fragmentation
            if (metroCheckBox4.Checked)
            {
                Fragmentation += " A ";
            }
            if (metroCheckBox24.Checked)
            {
                Fragmentation += " 1 ";
            }
            if (metroCheckBox37.Checked)
            {
                Fragmentation += " 2 ";
            }
            if (metroCheckBox50.Checked)
            {
                Fragmentation += " 3 ";
            }
            if (metroCheckBox63.Checked)
            {
                Fragmentation += " 4 ";
            }
            if (metroCheckBox76.Checked)
            {
                Fragmentation += " 5 ";
            }
            if (metroCheckBox89.Checked)
            {
                Fragmentation += " 6 ";
            }
            if (metroCheckBox102.Checked)
            {
                Fragmentation += " 7 ";
            }
            if (metroCheckBox115.Checked)
            {
                Fragmentation += " 8 ";
            }
            //Retrogression
            if (metroCheckBox5.Checked)
            {
                Retrogression += " A ";
            }
            if (metroCheckBox23.Checked)
            {
                Retrogression += " 1 ";
            }
            if (metroCheckBox36.Checked)
            {
                Retrogression += " 2 ";
            }
            if (metroCheckBox49.Checked)
            {
                Retrogression += " 3 ";
            }
            if (metroCheckBox75.Checked)
            {
                Retrogression += " 5 ";
            }
            if (metroCheckBox101.Checked)
            {
                Retrogression += " 7 ";
            }
            if (metroCheckBox114.Checked)
            {
                Retrogression += " 8 ";
            }
            //Preservation
            if (metroCheckBox22.Checked)
            {
                Preservation += " 1 ";
            }
            if (metroCheckBox35.Checked)
            {
                Preservation += " 2 ";
            }
            if (metroCheckBox48.Checked)
            {
                Preservation += " 3 ";
            }
            if (metroCheckBox74.Checked)
            {
                Preservation += " 5 ";
            }
            //Collusion Tendecy
            if (metroCheckBox7.Checked)
            {
                Collusion_tendecy += " A ";
            }
            if (metroCheckBox21.Checked)
            {
                Collusion_tendecy += " 1 ";
            }
            if (metroCheckBox34.Checked)
            {
                Collusion_tendecy += " 2 ";
            }
            if (metroCheckBox47.Checked)
            {
                Collusion_tendecy += " 3 ";
            }
            if (metroCheckBox60.Checked)
            {
                Collusion_tendecy += " 4 ";
            }
            if (metroCheckBox73.Checked)
            {
                Collusion_tendecy += " 5 ";
            }
            if (metroCheckBox86.Checked)
            {
                Collusion_tendecy += " 6 ";
            }
            if (metroCheckBox99.Checked)
            {
                Collusion_tendecy += " 7 ";
            }
            if (metroCheckBox112.Checked)
            {
                Collusion_tendecy += " 8 ";
            }
            //Impotense
            if (metroCheckBox8.Checked)
            {
                Impotence += " A ";
            }
            if (metroCheckBox20.Checked)
            {
                Impotence += " 1 ";
            }
            if (metroCheckBox33.Checked)
            {
                Impotence += " 2 ";
            }
            if (metroCheckBox46.Checked)
            {
                Impotence += " 3 ";
            }
            if (metroCheckBox59.Checked)
            {
                Impotence += " 4 ";
            }
            if (metroCheckBox72.Checked)
            {
                Impotence += " 5 ";
            }
            if (metroCheckBox85.Checked)
            {
                Impotence += " 6 ";
            }
            if (metroCheckBox98.Checked)
            {
                Impotence += " 7 ";
            }
            if (metroCheckBox111.Checked)
            {
                Impotence += " 8 ";
            }
            //Clousre Difficulty
            if (metroCheckBox9.Checked)
            {
                Clouser_difficulty += " A ";
            }
            if (metroCheckBox58.Checked)
            {
                Clouser_difficulty += " 4 ";
            }
            if (metroCheckBox97.Checked)
            {
                Clouser_difficulty += " 7 ";
            }
            //Motor Incoodination
            if (metroCheckBox10.Checked)
            {
                Motor_incoordination += " A ";
            }
            if (metroCheckBox17.Checked)
            {
                Motor_incoordination += " 1 ";
            }
            if (metroCheckBox30.Checked)
            {
                Motor_incoordination += " 2 ";
            }
            if (metroCheckBox43.Checked)
            {
                Motor_incoordination += " 3 ";
            }
            if (metroCheckBox56.Checked)
            {
                Motor_incoordination += " 4 ";
            }
            if (metroCheckBox69.Checked)
            {
                Motor_incoordination += " 5 ";
            }
            if (metroCheckBox82.Checked)
            {
                Motor_incoordination += " 6 ";
            }
            if (metroCheckBox95.Checked)
            {
                Motor_incoordination += " 7 ";
            }
            if (metroCheckBox108.Checked)
            {
                Motor_incoordination += " 8 ";
            }
            //Angulation
            if (metroCheckBox29.Checked)
            {
                Angulation += " 2 ";
            }
            if (metroCheckBox42.Checked)
            {
                Angulation += " 3 ";
            }
            //Choesion
            if (metroCheckBox12.Checked)
            {
                 Cohesion += " A ";
            }
            if (metroCheckBox15.Checked)
            {
                Cohesion += " 1 ";
            }
            if (metroCheckBox28.Checked)
            {
                Cohesion += " 2 ";
            }
            if (metroCheckBox41.Checked)
            {
                Cohesion += " 3 ";
            }
            if (metroCheckBox54.Checked)
            {
                Cohesion += " 4 ";
            }
            if (metroCheckBox67.Checked)
            {
                Cohesion += " 5 ";
            }
            if (metroCheckBox80.Checked)
            {
                Cohesion += " 6 ";
            }
            if (metroCheckBox93.Checked)
            {
                Cohesion += " 7 ";
            }
            if (metroCheckBox106.Checked)
            {
                Cohesion += " 8 ";
            }
            // DataBase

            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\N3vRMor3\Documents\Visual Studio 2015\Projects\Bender Gestalt Test\Bender Gestalt Test\Bender_Gestalt_Test_db.accdb";

            string Name = metroTextBox1.Text;
            string Date = Convert.ToDateTime(metroDateTime1.Text).ToShortDateString();
            int Total = Convert.ToInt32(metroTextBox16.Text);
            string Status = metroTextBox15.Text;
            connect.Open();

            

            string my_querry = "Insert into bender_gestalt_test_table(Name,[Date],Total_Score,Status,Rotation,Over_lapping_difficulty,Simplification,Fragmentation,Retrogression,Preservation,Collusion_tendecy,Impotence,Clouser_difficulty,Motor_incoordination,Angulation,Cohesion,[Case])values('" + Name + "','" + Date  + "','" + Total + "','"+ Status +"','"+ Rotation + "','" + Over_lapping + "','" + Simplification + "','" + Fragmentation + "','" + Retrogression + "','" + Preservation + "','"+ Collusion_tendecy + "','"+Impotence+"','"+ Clouser_difficulty + "','" +Motor_incoordination+ "','" + Angulation + "','" + Cohesion+ "','" + picname + "')";
            OleDbCommand cmd = new OleDbCommand(my_querry,connect);

            if (connect.State == ConnectionState.Open)
            {
                //cmd.Parameters.Add("@Name", OleDbType.Char, 80).Value = Name; 
                //cmd.Parameters.Add("@Date", OleDbType.Date, 20).Value = Date;
                //cmd.Parameters.Add("@Total", OleDbType.Integer, 80).Value = Total;
                //cmd.Parameters.Add("@Status", OleDbType.Char, 80).Value = Status;
                try
                {
                    cmd.ExecuteNonQuery();
                  //  MessageBox.Show("Data Added To Database");
                    connect.Close();

                }

                catch (Exception expe)
                {
                   MessageBox.Show("Failed Due to"+expe.Message);
                    connect.Close();
                }
            }

            else
            {
                MessageBox.Show("Connection Faield");
            }

        }



        private void metroCheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox21.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }

        }

        private void metroCheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox18.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox31.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox44.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox57.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox70.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox25.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox38.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox51.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox64.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox77.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox90_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox90.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox103_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox103.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox116_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox116.Checked)
            {
                c = 1;
                metroTextBox4.Text = Convert.ToString(c);
            }
            else
            {
                c = 0;
                metroTextBox4.Text = Convert.ToString(c);
            }
        }

        private void metroCheckBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox24.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox37.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox50.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox63.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox76.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox89_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox89.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox102_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox102.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox115_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox115.Checked)
            {
                d = 1;
                metroTextBox5.Text = Convert.ToString(d);
            }
            else
            {
                d = 0;
                metroTextBox5.Text = Convert.ToString(d);
            }

        }

        private void metroCheckBox104_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox104.Checked)
            {
                b = 1;
                metroTextBox3.Text = Convert.ToString(b);
            }
            else
            {
                b = 0;
                metroTextBox3.Text = Convert.ToString(b);
            }
        }

        private void metroCheckBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox83.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroTextBox16_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox23.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox36.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox49.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox75.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox35.Checked)
            {
                g = 1;
                metroTextBox7.Text = Convert.ToString(g);
            }
            else
            {
                g = 0;
                metroTextBox7.Text = Convert.ToString(g);
            }
        }

        private void metroCheckBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox48.Checked)
            {
                g = 1;
                metroTextBox7.Text = Convert.ToString(g);
            }
            else
            {
                g = 0;
                metroTextBox7.Text = Convert.ToString(g);
            }
        }

        private void metroCheckBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox74.Checked)
            {
                g = 1;
                metroTextBox7.Text = Convert.ToString(g);
            }
            else
            {
                g = 0;
                metroTextBox7.Text = Convert.ToString(g);
            }
        }

        private void metroCheckBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox34.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox47.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox60_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox60.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox73.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox86.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox99_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox99.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox112_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox112.Checked)
            {
                h = 1;
                metroTextBox8.Text = Convert.ToString(h);
            }
            else
            {
                h = 0;
                metroTextBox8.Text = Convert.ToString(h);
            }
        }

        private void metroCheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox20.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox33.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox46.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox59.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox72.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroCheckBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox58.Checked)
            {
                j = 1;
                metroTextBox10.Text = Convert.ToString(j);
            }
            else
            {
                j = 0;
                metroTextBox10.Text = Convert.ToString(j);
            }
        }

        private void metroCheckBox97_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox97.Checked)
            {
                j = 1;
                metroTextBox10.Text = Convert.ToString(j);
            }
            else
            {
                j = 0;
                metroTextBox10.Text = Convert.ToString(j);
            }
        }

        private void metroCheckBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (metroCheckBox10.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox17.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox30.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox43.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox56.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox69.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox82.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox95.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox108_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox108.Checked)
            {
                k = 1;
                metroTextBox11.Text = Convert.ToString(k);
            }
            else
            {
                k = 0;
                metroTextBox11.Text = Convert.ToString(k);
            }
        }

        private void metroCheckBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox29.Checked)
            {
                l = 1;
                metroTextBox12.Text = Convert.ToString(l);
            }
            else
            {
                l = 0;
                metroTextBox12.Text = Convert.ToString(l);
            }
        }

        private void metroCheckBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox42.Checked)
            {
                l = 1;
                metroTextBox12.Text = Convert.ToString(l);
            }
            else
            {
                l = 0;
                metroTextBox12.Text = Convert.ToString(l);
            }
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox12.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox15.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox28.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox41.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox54.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox67.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox80.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox93_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox93.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroCheckBox106_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox106.Checked)
            {
                m = 1;
                metroTextBox13.Text = Convert.ToString(m);
            }
            else
            {
                m = 0;
                metroTextBox13.Text = Convert.ToString(m);
            }
        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }
     

   
        private void Form1_Click(object sender, EventArgs e)
        {
        }

      


        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (metroTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter your name first for further execution");
                    return;
                }

                if (metroTextBox1.Text== "Admin"  || metroTextBox1.Text == "admin")
                {
                    metroTextBox1.Text = string.Empty;
                    Form2 frm = new Form2();
                    frm.Show();

                }

                


                else
                {
                       metroTextBox1.Enabled = false;
                        metroButton2.Enabled = true;
                     
                }

            }
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
                metroButton2.Enabled = true;
                metroTextBox1.Enabled = false;

            }

        }

        private void metroLabel38_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }


     

        //-------------------------------------------
        private int lastX;
        private int lastY;

        private void metroLabel15_MouseMove(object sender, MouseEventArgs e)
        {
           
                if (e.X != this.lastX || e.Y != this.lastY)
            {
             
                toolTip1.SetToolTip(this.metroLabel15, "Score if there is a rotation of 80º to 180º (including mirror-imaging) of the major axis of the whole figure (not a partof the figure). Do not score if S shifts the position of the card or paper and then draws the figure accurately.");
      
                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel16_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel16, "Difficulty in reproducing the portions of the figures that should overlap. (a) Omission of the portions of the figurewhich overlap. (b) Simplification of figures only at the point of over lap. (c) Marked sketching or reworking only atthe point of overlap. (d) Distortion of the figure at the point of overlap. (e) Figures overlap at the wrong place.(f) Failure of figures to overlap.DO NOT SCORE – parts of figures more than 1 / 8 in. apart, score Simplification.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel17_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel17, " Score if the figure is drawn in a simplified or easier from that is not more primitive from a maturational point of view, from the stimulus. (a) Circles for dots on figure 1.  (b) Nonoverlapping parts. (c) Joining parts of figures aremore than 1/8 inch apart. (d)   Very simplified drawing. DO NOT SCORE – (a) figures less than 1/8 inch apart,score Close Difficulty. (b) Curves substituted for angles, not an error.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel18_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel18, "Score if the figure is broken up into parts destroying the gestalt or if the figure is incomplete (unless S refuses todraw the entire figure).");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel27_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel27, "Substitution of a more primitive gestalt form than the stimulus. (a) Loops for circles (if persistent). (b) Dashes for dots (if extreme and persistent). (c) Triangle for diamond or hexagon. (d) Square for diamond. (e) Rectangle for hexagon. DO NOT SCORE – Do not score if curves are substituted for angles or angulation of bottom of hexagonon figure 7 is omitted.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel19_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel19, "There are 2 kinds of Perseveration errors. If both occur, this error is still only scored once. TYPE A: Inappropriatesubstitution of the features of a preceding stimulus, such as replacing the circles of figure 2 with the dots of figure1 (must have made dots, not  circles on figure 1); replacing the dots of figures 3 & 5 with the circles of figure 2 (must have made circles on figure 2 and dots on  1). TYPE B:Intradesign perseveration on continuing to draw afigure beyond the limits called for by the stimulus. For figure 1, 14 or more dots must be present, for figure 2, 13 or more columns of circles.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel20_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel20, "One figure is drawn as touching or overlapping another figure (collision) or is drawn within 1/4 inch or less of another figure but does not touch (collision tendency).");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel21_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel21, "Behavioral or verbal expressions of inability to draw a figure correctly (often accompanied by statements such as “Iknow this drawing is not right but I just can’t make it right”). (a) Repetitious drawings or numerous erasures of figures with similar          inaccuracies. (b) S realizes that an error has been made and tries to correct it unsuccessfully or expresses inability to correct it.DO NOT SCORE – Second attempt that corrects an error.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel22_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel22, "Difficulty in getting the joining parts of figures together or getting adjacent parts of a figure to touch. If figures aremore than 1/8 inch apart at joining point, score Simplification.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel23_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel23, "Irregular (tremor-like) lines, especially with heavy pressure. Behavioral observations are important for scoring thiserror. Be sure S is drawing on a smooth surface. (a) Marked and persistent gasp, overlap, redrawing, sketching, erasures, increased pressure at points where parts of the design join one another.DO NOT SCORE – Parts of figures are more than 1 / 8 inch apart, score Simplification.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel24_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel24, "Severe difficulty in reproducing the angulation of figures. (a) Failure to reproduce angulation of a figure. (b)Angulation of the whole figure 45º to 80º rather than parts of a figure (but not greater than 80º, which would berotation). (c) Variability of the                 angulation of more than half the rows of circles of figure 2.DO NOT SCORE – (a) Figure 3 should be scored leniently because its angulation is especially hard to reproduce.(b) Reversal of angulation on figure 2, score Rotation.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel25_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel25, "Isolated decrease or increase in size of figures. Score very conservatively. This error is most frequentlyoverscored. (a) Decrease in the size of part of a figure by more than 1 / 3 of the dimensions used in the rest of thefigure. (b) Increase or decrease in the size of a figure by 1 / 3 of the dimensions used in the other drawings (not compared to the size of the stimulus cards).Exclude parts of drawing that are larger due to Perseveration.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }

        private void metroLabel26_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X != this.lastX || e.Y != this.lastY)
            {

                toolTip1.SetToolTip(this.metroLabel26, "Score if total time is greater than 15 minutes.");

                this.lastX = e.X;
                this.lastY = e.Y;
            }
        }





    
        private void metroPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {

            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        //  --------------------------------------


        private void metroCheckBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox85.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox98_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox98.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox111_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox111.Checked)
            {
                i = 1;
                metroTextBox9.Text = Convert.ToString(i);
            }
            else
            {
                i = 0;
                metroTextBox9.Text = Convert.ToString(i);
            }
        }

        private void metroCheckBox101_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox101.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox114_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox114.Checked)
            {
                f = 1;
                metroTextBox6.Text = Convert.ToString(f);
            }
            else
            {
                f = 0;
                metroTextBox6.Text = Convert.ToString(f);
            }
        }

        private void metroCheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox22.Checked)
            {
                g = 1;
                metroTextBox7.Text = Convert.ToString(g);
            }
            else
            {
                g = 0;
                metroTextBox7.Text = Convert.ToString(g);
            }
        }

        private void metroCheckBox96_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox96.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox109_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox109.Checked)
            {
                a = 1;
                metroTextBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = 0;
                metroTextBox2.Text = Convert.ToString(a);
            }
        }

        private void metroCheckBox91_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox91.Checked)
            {
                b = 1;
                metroTextBox3.Text = Convert.ToString(b);
            }
            else
            {
                b = 0;
                metroTextBox3.Text = Convert.ToString(b);
            }
        }
    }
}
