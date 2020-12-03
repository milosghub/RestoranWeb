using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public readonly VetBusiness vetBusiness;
        public Form1()
        {
            this.vetBusiness = new VetBusiness();
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<Veterinar> results = this.vetBusiness.GetAllVets();

            listBox.Items.Clear();
            foreach(Veterinar v in results)
            {
                listBox.Items.Add(v.Id + ", " + v.FullName + ", " + v.Speciality + ", " + v.Expirience);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Veterinar v = new Veterinar();
            v.FullName = textBoxName.Text;
            v.Speciality = textBoxSpeciality.Text;
            v.Expirience = Convert.ToInt32(textBoxExpirience.Text);

            if (this.vetBusiness.InsertVet(v))
            {
                RefreshData();
                textBoxName.Clear();
                textBoxSpeciality.Clear();
                textBoxExpirience.Clear();
            }
            else
                MessageBox.Show("Greska pri upisu!");
        }
    }
}
