using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace formos
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<int> szamok = new List<int>();//r.Next(200000, 5500000)
            for (int i = 0; i < 100000; i++)
            {
                szamok.Add(r.Next(200000, 5500000));
            }
            var a = DateTime.Now;
            StreamWriter sw = new StreamWriter("fizetes.txt");
            foreach(var szam in szamok)
            {
                sw.WriteLine(szam.ToString());
            }
            sw.Close();
            var b = DateTime.Now;
            var time=b - a;
            textBox1.Text=time.ToString();
            List<string> sorok = new List<string>();
            a=DateTime.Now;
            StreamReader sr = new StreamReader("fizetes.txt");
            while (!sr.EndOfStream)
            {
                sorok.Add(sr.ReadLine());
            }
            sr.Close();
            b=DateTime.Now;
            time = b - a;
            textBox2.Text = time.ToString();
            a = DateTime.Now;
            List<double> novelt = new List<double>();
            StreamReader sr2 = new StreamReader("fizetes.txt");
            while (!sr2.EndOfStream)
            {
                novelt.Add(Convert.ToDouble(sr2.ReadLine()));
            }
            sr2.Close();
            for(int i = 0; i < novelt.Count; i++)
            {
                novelt[i] *= 1.1;
            }
            StreamWriter sw2 = new StreamWriter("fizetes.txt");
            for(int i = 0; i < novelt.Count; i++)
            {
                sw2.WriteLine(novelt[i]);
            }
            sw2.Close();
            b = DateTime.Now;
            time = b - a;
            textBox3.Text = time.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            //List<Fizetes> szamok = new List<Fizetes>();//r.Next(200000, 5500000)
            List<double> szamok = new List<double>();
            for (int i = 0; i < 100000; i++)
            {
                szamok.Add(r.Next(200000, 5500000));
            }
            var a = DateTime.Now;
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(szamok.GetType());
            StreamWriter sw = new StreamWriter("fizetes.xml");
            writer.Serialize(sw, szamok);
            sw.Close();
            var b = DateTime.Now;
            var time = b - a;
            textBox1.Text = time.ToString();
            List<double> beolv = new List<double>();
            a = DateTime.Now;
            XmlTextReader reader=new XmlTextReader("fizetes.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        {
                            beolv.Add(Convert.ToDouble(reader.Value));
                            break;
                        }
                    default:
                        {
                            beolv.Add(0);
                            listBox1.Items.Add("hiba");
                            break;
                        }                
                }
            }
            b = DateTime.Now;
            time = b - a;
            textBox2.Text = time.ToString();
            List<double> novelt = new List<double>();
            a = DateTime.Now;
            XmlTextReader reader2 = new XmlTextReader("fizetes.xml");
            while (reader2.Read())
            {
                switch (reader2.NodeType)
                {
                    case XmlNodeType.Text:
                        {
                            novelt.Add(Convert.ToDouble(reader2.Value));
                            break;
                        }
                    default:
                        {
                            beolv.Add(0);
                            listBox1.Items.Add("hiba2");
                            break;
                        }
                }
            }
        }
    }
}
