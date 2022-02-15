using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esDataBindings1
{
    public partial class Form2 : Form
    {
        class Uni {
            public Uni(string sigla, string cognome, string citta)
            {
                Sigla = sigla;
                Cognome = cognome;
                Citta = citta;
            }

            public string Sigla { get; set; }
            public string Cognome { get; set; }
            public string Citta { get; set; }

        }



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Uni> elencoUni= new List<Uni>();

            Uni uni1 = new Uni("UNIPD", "Università di Padova", "Padova");
            Uni uni2 = new Uni("UNIVR", "Università di Verona", "Verona");
            Uni uni3 = new Uni("UNIVE", "Università Ca' Foscari di Venezia", "Venezia");
            Uni uni4 = new Uni("UNITN", "Università di Trento", "Trento");

            elencoUni.Add(uni1);
            elencoUni.Add(uni2);
            elencoUni.Add(uni3);
            elencoUni.Add(uni4);


            BindingSource Uni = new BindingSource();
            Uni.DataSource = elencoUni;

           
            cbSigle.DataSource = Uni;
            cbSigle.DisplayMember = "Sigla";

            lblNome.DataBindings.Add(new Binding("Text", Uni, "Nome"));
            lblCitta.DataBindings.Add(new Binding("Text", Uni, "Citta"));


        }
    }
}
