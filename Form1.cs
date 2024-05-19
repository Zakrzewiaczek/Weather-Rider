using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Data
{
    public partial class Form1 : Form
    {
        public APIData api = new APIData("7daf5528a4db41b5ae686e8f567f264e", "EPWA");

        public Form1()
        {
            InitializeComponent();
            headerLabel.Text = $"WEATHER STATION: {api.StationName.ToUpper()}, {api.Country.ToUpper()}";

            SetVariables setVariables = new SetVariables(this, api);
            setVariables.SetData();

            /*new Thread(() => 
            {
                while(true)
                {
                    //Thread.Sleep(1000);
                    api.Refresh();
                    Console.WriteLine("Odświerzono");
                }
            }).Start();*/
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            api.Refresh();
        }

        /*
        foreach (KeyValuePair<string, string> entry in api.GetData())
        {
            Console.WriteLine("Klucz: {0}, Wartość: {1}", entry.Key, entry.Value);
        }
        */
    }
}
