﻿using LottoAdatKapcsolatt.Data;
using LottoAdatKapcsolatt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSzimulacio
{
    public partial class Form1 : Form
    {
        private List<int> tipp= new List<int>();
        private LottoSzamContext db = new LottoSzamContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            this.Size = new Size(900, 700);
            panel1.BackColor = Color.Beige;
            panel1.Size = new Size(600, 550);
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)

                {
                    CheckBox box = new CheckBox();
                    box.AutoSize = true;
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    box.Location = new Point(j * 50+50, i*50+50);
                    box.Text = (i * 5 + j + 1).ToString();
                    box.Tag = (i * 5 + j + 1).ToString();
                    panel1.Controls.Add(box);
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tipp.Add(Convert.ToInt32(box.Tag));
                if (tipp.Count() == 7)
                {
                    btnSorsol.Enabled = true;
                    foreach (CheckBox item in panel1.Controls)
                        if (!item.Checked) item.Enabled = false;
                }  
            }
            else 
            {
                tipp.Remove(Convert.ToInt32(box.Tag));
                if (tipp.Count() == 6)
                {
                    btnSorsol.Enabled = false;
                    foreach (CheckBox item in panel1.Controls)
                        item.Enabled = true;
                }
            }
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HashSet<int> set = new HashSet<int>();

            do
            {
                set.Add(rnd.Next(1, 35));
            } while (set.Count !=7);

            

            var kozos = set.Intersect(tipp);

            MessageBox.Show($"kisorsolt számok: {string.Join(", ", set.OrderBy(x => x))}, {kozos.Count()} találatod volt! ");

            db.LottoSzamok.Add(new LottoSzam(string.Join(";", set)));
            db.SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kilép_Click(object sender, EventArgs e)
        {

        }
    }
}
