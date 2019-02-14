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
using CriaTabela.Classes;

namespace CriaTabela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void criatabela1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pathName.Text))
            {
                Parametros parametros = new Parametros { appname = appName.Text.ToString(), tabela = tableName.Text.ToString(), caminho = pathName.Text.ToString() };
                List<Campos> campos = new List<Campos> { };

                foreach (DataGridViewRow linha in fields.Rows)
                {
                    if (linha.Cells["nome"].Value != null && linha.Cells["tipo"].Value != null && linha.Cells["format"].Value != null)
                    {
                        campos.Add(new Campos {
                            nome = linha.Cells["nome"].Value.ToString(),
                            tipo = linha.Cells["tipo"].Value.ToString(),
                            format = linha.Cells["format"].Value.ToString()
                        });                        
                    }
                }

                PythonClass.Executa(parametros, campos);
            }
            else
            {
                MessageBox.Show("Caminho inválido");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveFileDialog1 = new FolderBrowserDialog();
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string caminhoSalvar = saveFileDialog1.SelectedPath;
                pathName.Text = caminhoSalvar;
            }

        }
    }
    
    class Parametros
    {
        public string appname { get; set; }
        public string tabela { get; set; }
        public string caminho { get; set; }
    }
    class Campos
    {
        public string nome { get; set; }
        public string tipo { get; set; }
        public string format { get; set; }
    }

}
