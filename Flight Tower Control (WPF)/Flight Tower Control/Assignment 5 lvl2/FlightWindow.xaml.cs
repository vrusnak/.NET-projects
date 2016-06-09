/// <summary>
/// FlightWindow.cs
/// Created:  Viktor Rusnak, 2015-04-02
/// Revised:  
/// Purpose:  To publish events to the subscriber.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Assignment_5_lvl2
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        FlightWindow thisFlightWindow;
        public event EventHandler<TakeOffInfo> TakeOff;
        public event EventHandler<LandInfo> Land;
        public event EventHandler<ChangeRouteInfo> ChangeRoute;
        private string name, flightNbr, flight;
        private bool airbourne, runway;

        /// <summary>
        /// Property gets or sets the boolean value of airbourne.
        /// </summary>
        public bool IsAirbourne
        {
            get { return this.airbourne; }
            set { this.airbourne = value; }
        }

        /// <summary>
        /// Property gets or sets the boolean value of runway.
        /// </summary>
        public bool IsAtRunway
        {
            get { return this.runway; }
            set { this.runway = value; }
        }

        /// <summary>
        /// Property gets or sets the flight.
        /// </summary>
        public string Flight
        {
            get { return this.flight; }
        }

        /// <summary>
        /// Returns true if the aircraft is not airbourn but at runway.
        /// </summary>
        public bool IsReady()
        {
            if (!airbourne && runway)
            {
                ReadyForTakeoff();
                return true;
            }
            return false;
        }

        /// <summary>
        /// This constructor opens up the application.
        /// </summary>
        public FlightWindow(string name, string flightNbr, BitmapImage img)
        {
            InitializeComponent();
            InitiateGUI(name, flightNbr);
            this.name = name;
            this.flightNbr = flightNbr;
            if (name == string.Empty)
                this.flight = flightNbr;
            else
                this.flight = name + " " + flightNbr;
            this.runway = true;

            System.Drawing.Icon icon = Properties.Resources.flightwindow;
            System.IO.MemoryStream iconStream = new System.IO.MemoryStream();
            icon.Save(iconStream);
            iconStream.Seek(0, System.IO.SeekOrigin.Begin);
            this.Icon = BitmapFrame.Create(iconStream);

            ImageSource imageSource = img;
            flightImage.Source = imageSource;

            thisFlightWindow = this;

        }

        /// <summary>
        /// Initiates the GUI.
        /// </summary>
        private void InitiateGUI(string name, string flightNbr)
        {
            this.Title = name + " " + flightNbr;

            cbChangeRoute.Items.Add("10 deg");
            cbChangeRoute.Items.Add("30 deg");
            cbChangeRoute.Items.Add("60 deg");
            cbChangeRoute.Items.Add("90 deg");
            cbChangeRoute.Items.Add("180 deg");

            lblChangeRoute.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Called when aircraft take-off is taking place.
        /// </summary>
        private void OnTakeOff(TakeOffInfo e)
        {
            if (TakeOff != null)
                TakeOff(this, e);
        }

        /// <summary>
        /// Called when aircraft landing is taking place.
        /// </summary>
        private void OnLand(LandInfo e)
        {
            if (Land != null)
                Land(this, e);
        }

        /// <summary>
        /// Called when aircraft change of route is taking place.
        /// </summary>
        private void OnChangeRoute(ChangeRouteInfo e)
        {
            if (ChangeRoute != null)
                ChangeRoute(this, e);
        }

        /// <summary>
        /// Called when button "Take off" is pressed.
        /// </summary>
        private void btnTakeOff_Click(object sender, RoutedEventArgs e)
        {
            TakeOffInfo takeOffInfo = new TakeOffInfo(this.Title);
            OnTakeOff(takeOffInfo);
            btnTakeOff.IsEnabled = false;
            btnLand.IsEnabled = true;
            cbChangeRoute.IsEnabled = true;
            lblChangeRoute.Visibility = Visibility.Visible;
            IsAirbourne = true;
            IsAtRunway = false;
            PlaySound(false, this.name, this.flightNbr);
            takeOffInfo = null;
        }

        /// <summary>
        /// Called when button "Land" is pressed.
        /// </summary>
        private void btnLand_Click(object sender, RoutedEventArgs e)
        {
            LandInfo landInfo = new LandInfo(this.Title);
            OnLand(landInfo);
            btnTakeOff.IsEnabled = true;
            btnLand.IsEnabled = false;
            cbChangeRoute.IsEnabled = false;
            IsAirbourne = false;
            IsAtRunway = false;
            this.Close();
            PlaySound(true, this.name, this.flightNbr);
            landInfo = null;
        }

        /// <summary>
        /// Called when change of route direcetion is selected from the combobox.
        /// </summary>
        private void cbChangeRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbChangeRoute.SelectedIndex != -1)
            {
                ChangeRouteInfo changeRouteInfo = new ChangeRouteInfo(this.Title, cbChangeRoute.SelectedItem.ToString());
                OnChangeRoute(changeRouteInfo);
                cbChangeRoute.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Called when aircraft is on runway.
        /// </summary>
        private void ReadyForTakeoff()
        {
            System.Speech.Synthesis.PromptBuilder pb = new System.Speech.Synthesis.PromptBuilder();
            System.Speech.Synthesis.PromptStyle ps = new System.Speech.Synthesis.PromptStyle();

            pb.AppendText(name);
            ps.Rate = System.Speech.Synthesis.PromptRate.Slow;
            pb.StartStyle(ps);
            pb.AppendTextWithHint(flightNbr, System.Speech.Synthesis.SayAs.SpellOut);
            pb.EndStyle();
            pb.AppendText("Ready for take-off!");
            System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
            speech.Speak(pb);
        }

        /// <summary>
        /// Plays a sound.
        /// </summary>
        private void PlaySound(bool landed, string name, string flightNbr)
        {
            System.Media.SoundPlayer player;

            if (!landed)
            {
                player = new System.Media.SoundPlayer(Properties.Resources.takeoff);
                player.Play();
            }
            else if (landed)
            {
                player = new System.Media.SoundPlayer(Properties.Resources.applause);
                player.Play();
            }
        }

        /// <summary>
        /// Called when current window is closed.
        /// </summary>
        private void FlightWindow1_Closed(object sender, EventArgs e)
        {
            if (!airbourne)
            {
                airbourne = false;
                runway = false;
            }
        }

        /// <summary>
        /// Called when current window is being closed.
        /// </summary>
        private void FlightWindow1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (airbourne)
                e.Cancel = true;
        }
    }
}
