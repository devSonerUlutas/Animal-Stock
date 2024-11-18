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

namespace HayvanKayit
{
    public partial class Form1 : Form
    {
        //string.split
        private string filePath = @"C:\Users\uluta\OneDrive\Masaüstü\Hayvan Kayıt.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string textInFile = "";
            if (File.Exists(filePath))
            {
                textInFile = File.ReadAllText(filePath);

                if (textInFile.ToString() != "")
                {
                    textInFile += ("-----") + Environment.NewLine;
                }
            }

            textInFile += (NameTxtB.Text) + Environment.NewLine;
            textInFile += (TypeTxtB.Text) + Environment.NewLine;
            textInFile += (dateTimePicker1.Text);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(textInFile.ToString());
                sw.Close();
            }

            NamesComB.Items.Add(NameTxtB.Text);

            NameTxtB.Clear();
            TypeTxtB.Clear();
            dateTimePicker1.Value = DateTime.Today;

        }

        private void ReadFile()
        {
            string text = File.ReadAllText(filePath);
            string[] records = text.Split(new string[] { "-----" }, StringSplitOptions.None);
            
            for (int i = 0; i < records.Length; i++)
            {
                string[] properties = records[i].Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                NamesComB.Items.Add(properties[0]);
            }
        }

        private void NamesComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = NamesComB.SelectedIndex;
            if (index >= 0)
            {
                string text = File.ReadAllText(filePath);
                string[] records = text.Split(new string[] { "-----" }, StringSplitOptions.None);
                string[] properties = records[index].Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                KindLbl.Text = properties[1];
                DateLbl.Text = properties[2];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
        }
    }
}
