using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Data.OleDb;
using System.Media;

namespace Nadjia
{
    public partial class frmSoundboard : Form
    {
        Button[] btnBoard = new Button[10];
        Button[] btnCart = new Button[50];
        string[,] cartTrack = new string[10, 50];
        string[,] cartCaption = new string[10, 50];
        int i, j, intActiveBoard;

        Int32 xPos, yPos;

        XDocument ButtonConfig = new XDocument();

        public frmSoundboard()
        {
            InitializeComponent();

        }

        private void frmSoundboard_Load(object sender, EventArgs e)
        {
            // draw Board buttons
            for (i = 0; i < 10; i++)
            {
                // Initialize one variable 
                btnBoard[i] = new System.Windows.Forms.Button();
            
                // draw Cart buttons
                btnBoard[i].Tag = i + 1; 
                btnBoard[i].Width = 120; 
                btnBoard[i].Height = 70; 
                btnBoard[i].Left = xPos;
                btnBoard[i].Top = yPos;
                this.Controls.Add(btnBoard[i]);

                btnBoard[i].Text = ("BANK " + (i+1)).ToString();
                btnBoard[i].BackColor = Color.DarkGray;
                btnBoard[i].ForeColor = Color.LightGray;
                btnBoard[i].Enabled = false;

                // the Event of click Button 
                btnBoard[i].Click += new System.EventHandler(ClickBoard);

                xPos = xPos + btnBoard[i].Width;
            }

            // Draw Cart buttons
            xPos = 0;
            yPos =70;
            for (i = 0; i < 50; i++)
            {
                // Initialize one variable 
                btnCart[i] = new System.Windows.Forms.Button();

                // draw Cart buttons
                btnCart[i].Tag = i + 1;
                btnCart[i].Width = 120;
                btnCart[i].Height = 70;
                btnCart[i].Left = xPos;
                btnCart[i].Top = yPos;
                this.Controls.Add(btnCart[i]);

                btnCart[i].Text = ("CART " + (i + 1)).ToString();
                btnCart[i].BackColor = Color.DarkBlue;
                btnCart[i].ForeColor = Color.LightBlue;
                btnCart[i].Enabled = false;

                // the Event of click Button 
                btnCart[i].Click += new System.EventHandler(ClickCart);
               

                xPos += btnCart[i].Width;
                if ((i+1) % 10==0)
                {
                    xPos = 0;
                    yPos += btnCart[i].Height;
                }
            }

            // run through XML
            string xmlConfig = nadjiaConfig.soundboardLibraryFolder + "\\Soundboard.xls";

            string sql = "select distinct Boardname, boardnumber from Soundboard order by boardnumber";

            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + nadjiaConfig.masterDatabase))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, connection);

                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();

                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            i=Int32.Parse(reader["Boardnumber"].ToString()) -1;
                            btnBoard[i].Text = reader["BoardName"].ToString();
                            btnBoard[i].Enabled = true;
                            btnBoard[i].BackColor = Color.DarkRed;
                            btnBoard[i].ForeColor = Color.DarkGoldenrod;
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sql = "select buttoncaption, filename, boardnumber, buttonnumber, rownumber, columnnumber from Soundboard";
                OleDbCommand command2 = new OleDbCommand(sql, connection);

                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();

                    // Execute command  
                    using (OleDbDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            i = Int32.Parse(reader["Boardnumber"].ToString());
                            j = ((Int32.Parse(reader["Rownumber"].ToString()) -1) * 10) + (Int32.Parse(reader["ColumnNumber"].ToString())-1);
                            cartCaption[i, j] = reader["ButtonCaption"].ToString();
                            cartTrack[i, j] = nadjiaConfig.soundboardLibraryFolder + "\\" + reader["FileName"].ToString();
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

            // load up Bank 1 by default
            ClickBoard(btnBoard[0], e);
        }

        public void ClickBoard(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            intActiveBoard = Int32.Parse(btn.Tag.ToString());

            // Dim all buttons
            for (i=0;i<10;i++)
            {
                if (btnBoard[i].BackColor == Color.Red)
                {
                    btnBoard[i].BackColor = Color.DarkRed;
                    btnBoard[i].ForeColor = Color.DarkGoldenrod;
                }
            }

            // Light active board
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.Yellow;

            // Load active board
            for (i=0;i<50;i++)
            {
                // If the button is active
                if (cartCaption[intActiveBoard, i] != "")
                {
                    btnCart[i].Text = cartCaption[intActiveBoard, i];
                    btnCart[i].BackColor = Color.DarkGreen;
                    btnCart[i].ForeColor = Color.White;
                    btnCart[i].Enabled = true;
                }
                else
                {
                    // if the button is not active
                    btnCart[i].Text = ("CART " + (i + 1)).ToString();
                    btnCart[i].BackColor = Color.DarkGray;
                    btnCart[i].ForeColor = Color.LightGray;
                    btnCart[i].Enabled = false;
                }
            }
        }

        public void ClickCart(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            // Tag button as created (why?), turn it on, play the sound, turn it off
            btn.BackColor = Color.Green;
            try
                {
                SoundPlayer sndLightning = new SoundPlayer(cartTrack[intActiveBoard,Int32.Parse(btn.Tag.ToString())-1]);
                sndLightning.Play();
            }
            catch (Exception ex)
                {
                MessageBox.Show(cartTrack[intActiveBoard, Int32.Parse(btn.Tag.ToString()) - 1] + "\r" + ex.Message);
                }
            btn.BackColor = Color.DarkGreen;

        }
    }
}
