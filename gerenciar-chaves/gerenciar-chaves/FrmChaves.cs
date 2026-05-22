using System.Text.Json;
using System.Security.Cryptography;
using System.Text;

namespace gerenciar_chaves

{
    public partial class FrmChaves : Form
    {

        private ListViewItem itemEditando = null;

        public class ChaveModel
        {
            public string Chave { get; set; }

            public string Conteudo { get; set; }
        }
        public FrmChaves()
        {
            InitializeComponent();
            CarregarJson();
        }

        private void BTNvisualizar_Click(object sender, EventArgs e)
        {
            if (TXTconteudo.PasswordChar == '\0')
            {
                TXTconteudo.PasswordChar = '*';
            }
            else
            {
                TXTconteudo.PasswordChar = '\0';
            }
        }

        private void BTNremover_Click(object sender, EventArgs e)
        {
            if (LVdados.SelectedItems.Count > 0)
            {
                LVdados.Items.Remove(LVdados.SelectedItems[0]);
                SalvarJson();
            }
        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {

            try
            {

                if (TXTchave.Text.Trim().Length == 0)
                {
                    MessageBox.Show("É preciso informar uma chave", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTchave.Focus();
                    return;
                }

                if (TXTconteudo.Text.ToString().Length == 0)
                {
                    MessageBox.Show("É preciso informar um conteúdo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTconteudo.Focus();
                    return;
                }

                if (itemEditando != null)
                {
                    // EDITAR
                    itemEditando.Text = TXTchave.Text.ToString().ToUpper();
                    itemEditando.SubItems[1].Text = "******";
                    itemEditando.SubItems[2].Text = "VER";
                    itemEditando.Tag = TXTconteudo.Text;
                    itemEditando = null;
                }
                else
                {
                    // NOVO
                    ListViewItem item = new ListViewItem(TXTchave.Text);
                    item.SubItems.Add("******");
                    item.SubItems.Add("VER");
                    item.Tag = TXTconteudo.Text;
                    LVdados.Items.Add(item);
                }

                SalvarJson();

                TXTchave.Clear();
                TXTconteudo.Clear();
            }

            catch
            {
                throw;
            }

        }

        private void FrmChaves_Load(object sender, EventArgs e)
        {
            LVdados.View = View.Details;
            LVdados.FullRowSelect = true;
            LVdados.MultiSelect = false;
            LVdados.Columns.Add("Chave", 150);
            LVdados.Columns.Add("Conteúdo", 250);
            LVdados.Columns.Add("Ação", 80);

        }

        private void LVdados_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (LVdados.SelectedItems.Count > 0)
            {
                itemEditando = LVdados.SelectedItems[0];
                TXTchave.Text = itemEditando.Text;
                TXTconteudo.PasswordChar = '*';
                TXTconteudo.Text = itemEditando.Tag.ToString();
            }

        }

        private void SalvarJson()
        {
            List<ChaveModel> lista = new List<ChaveModel>();
            foreach (ListViewItem item in LVdados.Items)
            {
                lista.Add(new ChaveModel
                {
                    Chave = item.Text,
                    Conteudo = Criptografar(item.Tag.ToString())
                });
            }

            string json = JsonSerializer.Serialize(lista);
            string pasta = @"C:\Users\Alberto\gerenciar-chaves\gerenciar-chaves";
            Directory.CreateDirectory(pasta);
            string arquivo = Path.Combine(pasta, "dados.json");
            File.WriteAllText(arquivo, json);
        }

        private string Criptografar(string texto)
        {
            byte[] dados = Encoding.UTF8.GetBytes(texto);
            byte[] criptografado = ProtectedData.Protect(dados, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(criptografado);
        }

        private string Descriptografar(string texto)
        {
            byte[] dados = Convert.FromBase64String(texto);
            byte[] descriptografado = ProtectedData.Unprotect(dados, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(descriptografado);
        }

        private void CarregarJson()
        {
            string pasta = @"C:\Users\Alberto\gerenciar-chaves\gerenciar-chaves";
            string arquivo = Path.Combine(pasta, "dados.json");

            if (!File.Exists(arquivo))
                return;

            string json = File.ReadAllText(arquivo);

            List<ChaveModel> lista = JsonSerializer.Deserialize<List<ChaveModel>>(json);

            LVdados.Items.Clear();

            foreach (var itemJson in lista)
            {
                ListViewItem item = new ListViewItem(itemJson.Chave);

                item.SubItems.Add("******");
                item.SubItems.Add("VER");

                item.Tag = Descriptografar(itemJson.Conteudo);

                LVdados.Items.Add(item);
            }
        }

        private void TXTchave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXTconteudo.Focus();
            }
        }

        private void TXTconteudo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNcadastrar.Focus();
            }

        }

        private void LVdados_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = LVdados.HitTest(e.Location);

            if (info.Item != null && info.SubItem != null)
            {
                int indiceColuna = info.Item.SubItems.IndexOf(info.SubItem);

                // Coluna VER
                if (indiceColuna == 2)
                {

                    string conteudo = info.Item.Tag.ToString();

                    // Copia para memória
                    Clipboard.SetText(conteudo);
                    TXTdetalhes.Text = conteudo;

                    // Se está oculto
                    if (info.Item.SubItems[1].Text == "******")
                    {
                        info.Item.SubItems[1].Text = info.Item.Tag.ToString();
                    }
                    else
                    {
                        info.Item.SubItems[1].Text = "******";
                        TXTdetalhes.Text = "";
                    }
                }
            }
        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            TXTchave.Text = "";
            TXTconteudo.Text = "";
            TXTdetalhes.Text = "";
        }
    }
}
