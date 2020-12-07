using System;
using RestSharp;
using System.Windows.Forms;
using Newtonsoft.Json;
using GitHubRepositories.Models;
using System.Collections.Generic;

namespace GitHubRepositories
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private   void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Verifica se input está preenchido
            if (textNomeUsuario.Text == "")
            {
                textNomeUsuario.Focus();
                MessageBox.Show("Preencha o campo");
                return;
            }
            
            //Muda para cursor de espera
            Cursor.Current = Cursors.WaitCursor;

            //Inicia requisicao
            var client = new RestClient("https://api.github.com/");
            var nomeUsuario = textNomeUsuario.Text;
            var request = new RestRequest($"users/{nomeUsuario}/repos", DataFormat.Json);
            var response = client.Get(request);

            //Converte o retorno da api para JSON
            var listaDeRepos = JsonConvert.DeserializeObject<List<RepositorioModel>>(response.Content);

            var baseUrl = client.BaseUrl.OriginalString;

            foreach (var repositorio in listaDeRepos)
            {
                
                var endpoint = repositorio.Languages_url.Replace(baseUrl, "");

                request = new RestRequest(endpoint, DataFormat.Json);
                 
                response = client.Get(request);
                List<LinguagemModel> listaDeLinguagens = new List<LinguagemModel>();

                //Converte Converte o retorno da api para JSON
                var data = JsonConvert.DeserializeObject<Dictionary<string, int>>(response.Content);

                foreach( var language in data)
                {
                    //De cada objeto pega o nome da chave
                    var a = language.Key;

                    //Cria nova instancia da classe LinguagemModel com a string extraída 
                    LinguagemModel l = new LinguagemModel();
                    l.Nome = a;

                    //Adiciona o novo objeto na lista
                    listaDeLinguagens.Add(l);

                }

                repositorio.listaDeRepositorios = listaDeLinguagens;

            }

            Cursor.Current = Cursors.AppStarting;

            if (listaDeRepos.Count == 0 || listaDeRepos.Count == -1)
            {
                MessageBox.Show("Esse perfil não existe");
                return;
            }
             
            Form2 form = new Form2();
            form.ListaDeRepositorios = listaDeRepos;
            form.ShowDialog();
        }
 
    }
}
