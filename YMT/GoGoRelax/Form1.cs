using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoGoRelax
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        //使いません
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //使いません
        private void label3_Click(object sender, EventArgs e)
        {

        }

        //btn name: searchBtn 
        //btnをクリックするとこちらのメソッドが動かします
        private void searchBtn_Click(object sender, EventArgs e)
        {
            // string[] types = new string[] {}
            
            string city = cityTxt.Text;
            Console.WriteLine(city);
            StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");

            if (city != " ")
            {
                location.Append(city + "," + "+");
            }
            location.Append("cafe" + "park" + "beach" + "onsen");
           
            webView.Source = new Uri(location.ToString());
          

        }

        private void cafeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
