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
    public partial class Form1 : Form
    {
        class Persona
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string NomeCompleto { get; set; }


            public Persona(int id, string nome, string cognome)
            {
                ID = id;
                Nome = nome;
                Cognome = cognome;
                NomeCompleto = nome + " " + cognome;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> elencoPersone = new List<Persona>();

            Persona persona1 = new Persona(01, "Diego", "Lazzaretto");
            Persona persona2 = new Persona(02, "Alberto", "Fanchin");
            Persona persona3 = new Persona(03, "Tommaso", "Candoni");
            Persona persona4 = new Persona(04, "Giorgio", "Fanin");

            elencoPersone.Add(persona1);
            elencoPersone.Add(persona2);
            elencoPersone.Add(persona3);
            elencoPersone.Add(persona4);

            labelNome.DataBindings.Add(new Binding("Text", textBox1, "Text"));
            textBox2.DataBindings.Add(new Binding("Text", textBox1, "Text"));


            BindingSource Persone = new BindingSource();
            Persone.DataSource = elencoPersone;

            cbPersone.DataSource = Persone;
            cbPersone.DisplayMember = "Cognome";

            cbNomeCompleto.DataSource = Persone;
            cbNomeCompleto.DisplayMember = "NomeCompleto";

            cbId.DataSource = Persone;
            cbId.DisplayMember = "Id";

            lblName.DataBindings.Add(new Binding("Text", Persone, "Nome"));

            tbSize.DataBindings.Add(new Binding("Text", this, "Size"));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
