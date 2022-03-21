using Agrotis.Zoom;
using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrotis.Cadastro
{
    public partial class CadastroClientes : CadastroPadrao
    {
        public CadastroClientes()
        {
            this.classe = "Clientes";
            InitializeComponent();
        }

        private void cepMaskedTextBox_Validated(object sender, EventArgs e)
        {
            getCEPAsync();
        }

        private async Task getCEPAsync()
        {
            string cep = cepMaskedTextBox.Text.Replace("-", "");
            String request_uri = "http://viacep.com.br/ws/" + cep + "/json";
            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(request_uri); ;
            if (response.IsSuccessStatusCode)
            {
                Clientes cliente = (Clientes)bindingSource.Current;
                String resultado = await response.Content.ReadAsStringAsync();
                Cep.Cep myDeserializedClass = JsonConvert.DeserializeObject<Cep.Cep>(resultado);
                if(myDeserializedClass.bairro != "")
                {
                    cliente.Bairro = myDeserializedClass.bairro;
                    bairroTextBox.Text = cliente.Bairro;
                }
                cliente.Cidade = myDeserializedClass.localidade;
                cidadeTextBox.Text = cliente.Cidade;
                cliente.Codigo_IBGE = Convert.ToInt32(myDeserializedClass.ibge);
                codigo_IBGETextBox.Text = cliente.Codigo_IBGE.ToString();
                cliente.UF = myDeserializedClass.uf;
                uFTextBox.Text = cliente.UF;
            }
            else
            {
                MessageBox.Show("Cep não existente");
            }
        }
    }
}
