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
using System.Net;

namespace Nadjia
{
    public partial class frmMain : Form
    {
        public string Forecast;
        public XDocument GetData;
        public int PeakConnections = 0;

        public frmMain()
        {
            InitializeComponent();
            // Define the document outside the try block. 
            XDocument NewDoc = new XDocument();

            // Tell the application to try the operation. 
            try
            {
                // Read the document from disk. 
                //                NewDoc = XDocument.Load(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\EMMA_Settings.XML");
                NewDoc = XDocument.Load("NADJIA_Settings.XML");
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(" The " + exception.FileName + " is missing.\r\n" + "Did you accidentally delete it?");
            }
            // Copy results to configuration.
            //       MessageBox.Show(NewDoc.Declaration + "\r\n" + NewDoc.ToString());
            nadiaConfig.trackLibraryFolder = NewDoc.Root.Element("TrackLibrary").Value;
            nadiaConfig.LRQuestionsFolder = NewDoc.Root.Element("LRQuestions").Value;
            nadiaConfig.soundboardLibraryFolder = NewDoc.Root.Element("SoundboardFiles").Value;
            nadiaConfig.masterDatabase = NewDoc.Root.Element("MasterDatabase").Value;

        }

//        private List<TrackInfo> _musicLibrary = new List<TrackInfo>();
        private List<Label> _statusLabels;

        public void GetForecast()
        {
            // Contains the result of a retry request. 
            DialogResult TryAgain = DialogResult.Yes;

            // Keep trying to get the weather data until the user gives up or the call is successful. 
            while (TryAgain == DialogResult.Yes)
            {
                try
                {
                    // Get the weather data. 
                    GetData = XDocument.Load("http://api.openweathermap.org/data/2.5/weather?q=Indianapolis&mode=xml&appid=610879fc5d8d771a35e87a7f134a09ad");
                    // MessageBox.Show("XML: " + GetData);
                    // End the loop. 
                    TryAgain = DialogResult.No;
                }
                catch (WebException WE)
                {
                    TryAgain = MessageBox.Show("Couldn't obtain the weather data!\r\nTry Again?", "Data Download Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            // Obtain all the forecasts. 
            double Kelvin = double.Parse(GetData.Element("current").Element("temperature").Attribute("value").Value);
            double Farenheit = (Kelvin - 273.15) * 9 / 5 + 32;
            string Forecast = "Temp: " + Convert.ToInt16(Farenheit).ToString() + "F ";
            try
            {
                Forecast += "; Humidity: " + GetData.Root.Element("humidity").Attribute("value").Value + "%.\r\n";
                Forecast += char.ToUpper(GetData.Root.Element("weather").Attribute("value").Value[0]) + GetData.Root.Element("weather").Attribute("value").Value.Substring(1) + ".\r\n";
                Forecast += GetData.Root.Element("wind").Element("speed").Attribute("name").Value;
                Forecast += " from the " + GetData.Element("current").Element("wind").Element("direction").Attribute("name").Value + ".\r\n";
            }
            catch (Exception e) { }
            lblWeather.Text = Forecast.ToUpper();


        }

        public void GetStreamStats()
        {
            // Contains the result of a retry request. 
            DialogResult TryAgain = DialogResult.Yes;

            // Keep trying to get the stream data until the user gives up or the call is successful. 
            while (TryAgain == DialogResult.Yes)
            {
                try
                {
                    // Get the weather data. 
                    GetData = XDocument.Load("http://s5.voscast.com:8330/statistics");
                    // MessageBox.Show("XML: " + GetData);
                    // End the loop. 
                    TryAgain = DialogResult.No;
                }
                catch (WebException WE)
                {
                    TryAgain = MessageBox.Show("Couldn't obtain the server data!\r\nTry Again?", "Data Download Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            

            var rand = new Random();

            int CurrentListeners = Int16.Parse(GetData.Root.Element("STREAMSTATS").Element("STREAM").Element("CURRENTLISTENERS").Value);
            int PeakListeners = Int16.Parse(GetData.Root.Element("STREAMSTATS").Element("STREAM").Element("PEAKLISTENERS").Value);
            int UniqueListeners = Int16.Parse(GetData.Root.Element("STREAMSTATS").Element("STREAM").Element("UNIQUELISTENERS").Value);
            string CurrentTrack = GetData.Root.Element("STREAMSTATS").Element("STREAM").Element("SONGTITLE").Value;
            int FakeConnections = (8 + CurrentListeners * 4 + rand.Next(0, 5));
            if (FakeConnections > PeakConnections) { PeakConnections = FakeConnections; }
            // string StatString = "CURRENT CONNECTIONS:  " + FakeConnections + "/" + PeakConnections + "/" + UniqueListeners + "\r\n";
            //            StatString += "PEAK CONNECTIONS:  " + PeakConnections + "\r\n";
            //           StatString += "DROPPED CONNECTIONS:  " + UniqueListeners + "\r\n";
            lblActiveStreams.Text = FakeConnections.ToString();
            lblPeakStreams.Text = PeakListeners.ToString();
            lblDuplicateStreams.Text = UniqueListeners.ToString();
            lblCurrentTrack.Text=CurrentTrack.ToUpper();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void updateSystemStatus(string statusmessage)
        {
            for (int i = _statusLabels.Count - 1; i > 0; i--)
                {
                    _statusLabels[i].Text = _statusLabels[i - 1].Text;
                }

                _statusLabels[0].Text = statusmessage;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _statusLabels = new List<Label>
                {
                    lblSystemStatus1,
                    lblSystemStatus2,
                    lblSystemStatus3,
                    lblSystemStatus4,
                    lblSystemStatus5
                };
            updateSystemStatus("Starting Nadjia...");

            GetForecast();
            updateSystemStatus("Weather data loaded.");

            GetStreamStats();
            updateSystemStatus("Stream statistics loaded.");
            string libraryPath = @"C:\Users\djays\Documents\EMMA\library.xml";
            AppState.MusicLibrary = LibraryLoader.LoadLibrary(libraryPath);
            updateSystemStatus("Loaded " + AppState.MusicLibrary.Count + " tracks from music library.");

        }

        private void sysClock_Tick(object sender, EventArgs e)
        {
            int hours = DateTime.Now.TimeOfDay.Hours;
            string AMPM = " AM";
            string strMyTime;
            if (hours > 12) { hours -= 12; AMPM = " PM"; }

            strMyTime= hours.ToString("D2") + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("D2") + ":" + DateTime.Now.TimeOfDay.Seconds.ToString("D2") + AMPM;
            lblAirTime.Text = "AIR TIME: " + strMyTime;
            if ((DateTime.Now.TimeOfDay.Minutes % 10 == 0) && (DateTime.Now.TimeOfDay.Seconds == 0)) { GetForecast(); updateSystemStatus("Weather updated as of " + strMyTime);}
            if (DateTime.Now.TimeOfDay.Seconds == 0) { GetStreamStats(); updateSystemStatus("Track updated at " + strMyTime); }
        }

        private void rebuildDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBuildLibrary();
            frm.Show();
        }
    }
}
