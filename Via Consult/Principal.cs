using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Via_Consult
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Váriaveis globais
        public int tipo = 3; // 0 - SPED, 1 - SINTEGRA
        public int seg = 0, min = 0, hr = 0;

        public Principal()
        {
            InitializeComponent();
            //Desabilitando os botões por padrão
            DesabilitaBotoes();
        }

        private void btnSelectArq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Abrindo a caixa de dialogo para selecionar o diretório
            DialogResult openDir = fdbSelectDir.ShowDialog();

            //Verificando se foi selecionado algum diretório
            if (openDir == DialogResult.OK)
            {
                //declarando as variáveis locais
                string line;
                int qtdFiles = 1;

                //pegando o diretório selecionado e colocando na barra de status
                toolDirArq.Text = fdbSelectDir.SelectedPath;
                //Percorrendo a pasta selecionada para ler os arquivos
                DirectoryInfo dirFiles = new DirectoryInfo(fdbSelectDir.SelectedPath);
                //executa a função GetFile (lista os arquivos desejado de acordo como parametro)
                FileInfo[] arq = dirFiles.GetFiles("*.txt");
                //verificando se o diretório selecionado tem arquivo txt
                if(arq.Count() > 0)
                {
                    //listando o diretório e pegando o primeiro arquivo para verificar se o mesmo é SPED ou SINTEGRA
                    foreach(FileInfo fileinfo in arq)
                    {
                        if(qtdFiles.Equals(1))
                        {
                            //abrindo o arquivo e lendo a primeira linha para identificar se é SPED ou SINTEGRA
                            StreamReader readfile = new StreamReader(@fileinfo.DirectoryName + "\\" + fileinfo.Name);
                            while((line = readfile.ReadLine()) != null)
                            {
                                //se o arquivo for SPED usar o delimitador "|"
                                string[] typeArq = line.Split('|');
                                //se encontrar o delimitador "|" na primeira linha do arquivo significa que é SPED caso contrário é SINTEGRA
                                if(typeArq.Length > 2)
                                {
                                    //Definindo o tipo SPED para 0
                                    tipo = 0;
                                }
                                else if(line.Substring(0,2).Equals("10"))
                                {
                                    //Definindo o tipo SINTEGRA para 1
                                    tipo = 1;
                                }
                                break;
                            }
                            //se não for definido nenhum tipo para o arquivo significa que não é nem SPED, nem SINTEGRA
                            if (tipo.Equals(3))
                            {
                                MessageBox.Show("O diretório não tem nenhum arquivo SPED ou SINTEGRA, por favor verifique...", "Erro do sistema");
                                toolDirArq.Text = "Nenhum...";
                            }

                            //fechando o arquivo
                            readfile.DiscardBufferedData();
                            readfile.Close();
                        }
                        qtdFiles++;
                        break;
                    }
                    //habilitando os botões
                    HabilitaBoteoes();
                }
                else
                {
                    MessageBox.Show("O diretório selecinado não contém arquivo txt", "Erro do sistema");
                    toolDirArq.Text = "Nenhum...";
                }

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnConexaoFTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        /// <summary>
        /// Função que habilita os botões quando um arquivo SPED ou SINTEGRA é selecionado
        /// </summary>
        public void HabilitaBoteoes()
        {
            //Habilitando os botões
            btnAddAcao.Enabled = true;
            btnAddRegistro.Enabled = true;
            btnAddCampo.Enabled = true;
            btnAddParametro.Enabled = true;
            btnAddPosicao.Enabled = true;
            btnAddPreposicao.Enabled = true;
            btnSalvarRegra.Enabled = true;
        }

        /// <summary>
        /// Função que desabilita os botões quando o programa é iniciado
        /// </summary>     
        public void DesabilitaBotoes()
        {
            //Desabilitando os botões
            btnAddAcao.Enabled = false;
            btnAddRegistro.Enabled = false;
            btnAddCampo.Enabled = false;
            btnAddParametro.Enabled = false;
            btnAddPosicao.Enabled = false;
            btnAddPreposicao.Enabled = false;
            btnSalvarRegra.Enabled = false;

        }

    }
}
