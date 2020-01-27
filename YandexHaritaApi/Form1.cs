using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace YandexHaritaApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKonumBul_Click(object sender, EventArgs e)
        {

            XmlTextReader txtReader = new XmlTextReader("http://ip-api.com/xml");

            while (txtReader.Read())
            {
                if (txtReader.NodeType == XmlNodeType.Element)
                {
                    if (txtReader.Name == "lat")
                    {
                        txtReader.Read();
                        txtLat.Text = txtReader.Value.ToString();
                    }

                    if (txtReader.Name == "lon")
                    {
                        txtReader.Read();
                        txtLon.Text = txtReader.Value.ToString();
                    }
                }
            }
            txtReader.Close();

          
        }
        //https://geocode-maps.yandex.ru/1.x/?apikey=trnsl.1.1.20200118T161836Z.1f472802ae361350.d30e592fd1e1840118a6a2ece0b76e983dc4d3f9&geocode=Yalova&ll={0},{1}&spn=2.5,2.5&lang=en-US
        private void BtnAdreseDok_Click(object sender, EventArgs e)
        {
            string adres = string.Format("https://geocode-maps.yandex.ru/1.x/?apikey=702b17a2-23ed-4334-a853-dd854d94626f&geocode=Kocaeli&={0},{1}&spn=2.5,2.5&lang=en-US", txtLat.Text,txtLon.Text);

            XmlTextReader textReader = new XmlTextReader(adres);

            while (textReader.Read())
            {
                if (textReader.NodeType == XmlNodeType.Element)
                {
                    if (textReader.Name == "AddressLine")
                    {
                        textReader.Read();
                        richtxtAdres.Text = textReader.Value.ToString();
                    }

                }
            }
            textReader.Close();
        }

        private void Txtarama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string adresim = string.Format("https://yandex.com.tr/search/xml?user=mestkahraman&key=03.1012124684:bd8a71278714ed193717e1a10cc4fa86&query={0}&l10n=tr&sortby=tm.order%3Dascending&filter=strict&groupby=attr%3D%22%22.mode%3Dflat.groups-on-page%3D10.docs-in-group%3D1",txtarama.Text);
                XmlTextReader reader = new XmlTextReader(adresim);

                List<string> linkler = new List<string>();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "url")
                        {
                            reader.Read();
                            linkler.Add(reader.Value.ToString());
                        }
                       
                    }
                }
                reader.Close();
            }
        }
    }
}
