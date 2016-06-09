/// <summary>
/// ControlTowerWindow.cs
/// Created:  Viktor Rusnak, 2015-04-02
/// Revised:  
/// Purpose:  To subscribe to events from the publisher 
/// and display the changes in graphical user interface.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_5_lvl2
{
    /// <summary>
    /// Interaction logic for ControlTowerWindow.xaml
    /// </summary>
    public partial class ControlTowerWindow : Window
    {
        delegate void AircraftDelegate();
        FlightWindow aircraft, lufthansa, sas, easyjet, norwegian;

        /// <summary>
        /// This constructor opens up the application.
        /// </summary>
        public ControlTowerWindow()
        {
            System.Threading.Thread.Sleep(3000);
            InitializeComponent();

            System.Drawing.Icon icon = Properties.Resources.controltowerwindow;
            System.IO.MemoryStream iconStream = new System.IO.MemoryStream();
            icon.Save(iconStream);
            iconStream.Seek(0, System.IO.SeekOrigin.Begin);
            this.Icon = BitmapFrame.Create(iconStream);

            tbFlightCode.Text = string.Empty;
            tbFlightCode.Focus();
        }

        /// <summary>
        /// Loads an image. Takes a bitmap as parameter.
        /// </summary>
        private BitmapImage LoadImage(System.Drawing.Bitmap aircraft)
        {
            using (System.IO.MemoryStream memory = new System.IO.MemoryStream())
            {
                aircraft.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }

        /// <summary>
        /// Initiates a new aircraft.
        /// </summary>
        private void InitiateLufthansa()
        {
            System.Drawing.Bitmap aircraft = Properties.Resources.lufthansa;
            BitmapImage flightImage = LoadImage(aircraft);
            lufthansa = new FlightWindow("Lufthansa", tbFlightCode.Text.ToUpper(), flightImage);
            LogRunwayTime(lufthansa);
            lufthansa.TakeOff += OnNewTakeOff;
            lufthansa.Land += OnNewLand;
            lufthansa.ChangeRoute += OnNewChangeRoute;
        }

        /// <summary>
        /// Initiates a new aircraft.
        /// </summary>
        private void InitiateSAS()
        {
            System.Drawing.Bitmap aircraft = Properties.Resources.sas;
            BitmapImage flightImage = LoadImage(aircraft);
            sas = new FlightWindow("Scandinavian Airlines", tbFlightCode.Text.ToUpper(), flightImage);
            LogRunwayTime(sas);
            sas.TakeOff += OnNewTakeOff;
            sas.Land += OnNewLand;
            sas.ChangeRoute += OnNewChangeRoute;
        }

        /// <summary>
        /// Initiates a new aircraft.
        /// </summary>
        private void InitiateEasyjet()
        {
            System.Drawing.Bitmap aircraft = Properties.Resources.easyjet;
            BitmapImage flightImage = LoadImage(aircraft);
            easyjet = new FlightWindow("Easy jet", tbFlightCode.Text.ToUpper(), flightImage);
            LogRunwayTime(easyjet);
            easyjet.TakeOff += OnNewTakeOff;
            easyjet.Land += OnNewLand;
            easyjet.ChangeRoute += OnNewChangeRoute;
        }

        /// <summary>
        /// Initiates a new aircraft.
        /// </summary>
        private void InitiateNorwegian()
        {
            System.Drawing.Bitmap aircraft = Properties.Resources.norwegian;
            BitmapImage flightImage = LoadImage(aircraft);
            norwegian = new FlightWindow("Norwegian", tbFlightCode.Text.ToUpper(), flightImage);
            LogRunwayTime(norwegian);
            norwegian.TakeOff += OnNewTakeOff;
            norwegian.Land += OnNewLand;
            norwegian.ChangeRoute += OnNewChangeRoute;
        }

        /// <summary>
        /// Initiates a new default aircraft.
        /// </summary>
        private void InitiateDefaultAircraft()
        {
            System.Drawing.Bitmap aircraftImage = Properties.Resources.default_plane;
            BitmapImage flightImage = LoadImage(aircraftImage);
            aircraft = new FlightWindow(string.Empty, tbFlightCode.Text.ToUpper(), flightImage);
            LogRunwayTime(aircraft);
            aircraft.TakeOff += OnNewTakeOff;
            aircraft.Land += OnNewLand;
            aircraft.ChangeRoute += OnNewChangeRoute;
        }

        /// <summary>
        /// Adds an item representing an aircraft take-off to the ListView.
        /// </summary>
        private void OnNewTakeOff(object sender, TakeOffInfo e)
        {
            lstStatus.Items.Add(e.ToString());
        }

        /// <summary>
        /// Adds an item representing an aircraft landing to the ListView.
        /// </summary>
        private void OnNewLand(object sender, LandInfo e)
        {
            lstStatus.Items.Add(e.ToString());
        }

        /// <summary>
        /// Adds an item representing an aircraft change of direction to the ListView.
        /// </summary>
        private void OnNewChangeRoute(object sender, ChangeRouteInfo e)
        {
            lstStatus.Items.Add(e.ToString());
        }

        /// <summary>
        /// Adds an item representing an aircraft sent to runway log time to the ListView.
        /// </summary>
        private void LogRunwayTime(FlightWindow aircraft)
        {
            lstStatus.Items.Add(aircraft.Flight + " sent to runway " + DateTime.Now.ToLongTimeString());
        }

        /// <summary>
        /// Method is called when the "Send to Runway" button is pushed.
        /// </summary>
        private void btnSendPlaneToRunway_Click(object sender, RoutedEventArgs e)
        {
            FlightWindow currAircraft = null; ;
            if (tbFlightCode.Text == string.Empty)
            {
                string strMsg;
                strMsg = "No aircraft found. Try another flightcode. \nUse format: XXX123";
                MessageBox.Show(strMsg, "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string strFormat = tbFlightCode.Text.ToLower().Substring(0, 3);
                switch (strFormat)
                {
                    case "lhf":      
                        InitiateLufthansa();
                        currAircraft = lufthansa;
                        break;
                    case "sas":                     
                        InitiateSAS();
                        currAircraft = sas;
                        break;
                    case "ezy":                  
                        InitiateEasyjet();
                        currAircraft = easyjet;
                        break;
                    case "now":                     
                        InitiateNorwegian();
                        currAircraft = norwegian;
                        break;
                    default:              
                        InitiateDefaultAircraft();
                        currAircraft = aircraft;
                        break;
                }
            }
            tbFlightCode.Text = string.Empty;
            if (currAircraft != null)
            {
                currAircraft.Show();
                currAircraft.IsReady();
            }
            tbFlightCode.Focus();
        }

        /// <summary>
        /// Method called when window is being closed.
        /// </summary>
        private void ControlTowerWindow1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Application will exit. Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Method called when "Exit" in menu is pressed.
        /// </summary>
        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
