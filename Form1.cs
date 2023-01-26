using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;



namespace TimeInTarkovDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(10)
            };
            timer.Tick += TimeInTarkov;
            timer.Start();
        }

        private void TimeInTarkov(object sender, EventArgs e)
        {
            //in Tarkov vergeht die zeit X mal schneller
            int tarkovTimeTranslator = 7;

            //umrechnung normal zu unixtime (stunde)
            //ms * sekunden * minuten
            int dayInUnixtime = 1000 * 60 * 60 * 24;

            //Korrektur Zeitzone Russland ( UTC +3 )
            //Konventieren von utc zu  "Russian Standard Time" +3 UTC
            int utctorst = 1000 * 60 * 60 * 3;

            //Konvertiert in UnixTime und führt berechnung durch
            long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            unixTimestamp = unixTimestamp * tarkovTimeTranslator % dayInUnixtime;
            unixTimestamp += utctorst;

            //Konvertiert Unix zurück in Datetime
            DateTime tarkovTime = DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp).DateTime;

            //Setz die differenz zur zweiten zeit
            TimeSpan diftotimetwo = new TimeSpan(12, 0, 0);
            DateTime tarkovTime2 = tarkovTime.Add(diftotimetwo);

            //aktualliesiert die Oberfläche
            label1.Text = tarkovTime.ToString("HH:mm:ssf");
            label2.Text = tarkovTime2.ToString("HH:mm:ssf");


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/donate/?hosted_button_id=LP8T8Z36YPWD8");

        }
    }
}
