using System; 
using System.Windows.Forms;
using GitHubRepositories.Models;
using System.Collections.Generic;

namespace GitHubRepositories
{
    public partial class Form2 : Form
    {

        public List<RepositorioModel> ListaDeRepositorios
        {
            get { return listaDeRepositorios; }
            set { listaDeRepositorios = value; }
        }

        private List<RepositorioModel> listaDeRepositorios;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (var repositorio in listaDeRepositorios)
            {
                var nodePai = treeView1.Nodes.Add(repositorio.Nome);
                nodePai.Nodes.Add(repositorio.Descricao);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var nodeSelecionado = treeView1.SelectedNode;

            //Se o nó clicado for um subnó, nada acontece
            if(nodeSelecionado.Level == 1)
            {
                return;
            } 

            RepositorioModel repositorio = ListaDeRepositorios.Find(repo => repo.Nome == nodeSelecionado.Text);

            labelNomeRepositorio.Text = repositorio.Nome;
            linkRepositorioURL.Text = repositorio.Url;
            labelDescricao.Text = repositorio.Descricao; 
             
        }

        private void linkRepositorioURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
