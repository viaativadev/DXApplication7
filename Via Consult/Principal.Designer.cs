namespace Via_Consult
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSelectArq = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddAcao = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddRegistro = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCampo = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddParametro = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddPosicao = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddPreposicao = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvarRegra = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbrirRegra = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btnConexaoFTP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Thema = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolblDirArq = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDirArq = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolblDirArqAux = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDirArqAux = new System.Windows.Forms.ToolStripStatusLabel();
            this.fdbSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSelectArq,
            this.btnAddAcao,
            this.btnAddRegistro,
            this.btnAddCampo,
            this.btnAddParametro,
            this.btnAddPosicao,
            this.btnAddPreposicao,
            this.btnSalvarRegra,
            this.btnAbrirRegra,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.btnConexaoFTP,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barButtonItem18});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage7});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 146);
            // 
            // btnSelectArq
            // 
            this.btnSelectArq.Caption = "Selecionar Arquivos";
            this.btnSelectArq.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSelectArq.Glyph")));
            this.btnSelectArq.Id = 1;
            this.btnSelectArq.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSelectArq.LargeGlyph")));
            this.btnSelectArq.Name = "btnSelectArq";
            this.btnSelectArq.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelectArq_ItemClick);
            // 
            // btnAddAcao
            // 
            this.btnAddAcao.Caption = "Adicionar ação";
            this.btnAddAcao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddAcao.Glyph")));
            this.btnAddAcao.Id = 2;
            this.btnAddAcao.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddAcao.LargeGlyph")));
            this.btnAddAcao.Name = "btnAddAcao";
            // 
            // btnAddRegistro
            // 
            this.btnAddRegistro.Caption = "Escolher registro";
            this.btnAddRegistro.Id = 3;
            this.btnAddRegistro.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddRegistro.LargeGlyph")));
            this.btnAddRegistro.Name = "btnAddRegistro";
            this.btnAddRegistro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnAddCampo
            // 
            this.btnAddCampo.Caption = "Vincular campo";
            this.btnAddCampo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddCampo.Glyph")));
            this.btnAddCampo.Id = 4;
            this.btnAddCampo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddCampo.LargeGlyph")));
            this.btnAddCampo.Name = "btnAddCampo";
            // 
            // btnAddParametro
            // 
            this.btnAddParametro.Caption = "Adicionar parâmetro";
            this.btnAddParametro.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddParametro.Glyph")));
            this.btnAddParametro.Id = 5;
            this.btnAddParametro.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddParametro.LargeGlyph")));
            this.btnAddParametro.Name = "btnAddParametro";
            // 
            // btnAddPosicao
            // 
            this.btnAddPosicao.Caption = "Definir posição";
            this.btnAddPosicao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddPosicao.Glyph")));
            this.btnAddPosicao.Id = 6;
            this.btnAddPosicao.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddPosicao.LargeGlyph")));
            this.btnAddPosicao.Name = "btnAddPosicao";
            // 
            // btnAddPreposicao
            // 
            this.btnAddPreposicao.Caption = "Escolher preposição";
            this.btnAddPreposicao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddPreposicao.Glyph")));
            this.btnAddPreposicao.Id = 7;
            this.btnAddPreposicao.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddPreposicao.LargeGlyph")));
            this.btnAddPreposicao.Name = "btnAddPreposicao";
            // 
            // btnSalvarRegra
            // 
            this.btnSalvarRegra.Caption = "Salvar Regra";
            this.btnSalvarRegra.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvarRegra.Glyph")));
            this.btnSalvarRegra.Id = 8;
            this.btnSalvarRegra.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalvarRegra.LargeGlyph")));
            this.btnSalvarRegra.Name = "btnSalvarRegra";
            // 
            // btnAbrirRegra
            // 
            this.btnAbrirRegra.Caption = "Abrir Regra";
            this.btnAbrirRegra.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAbrirRegra.Glyph")));
            this.btnAbrirRegra.Id = 9;
            this.btnAbrirRegra.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAbrirRegra.LargeGlyph")));
            this.btnAbrirRegra.Name = "btnAbrirRegra";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Biblioteca";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Biblioteca";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.LargeGlyph")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Baixar arquivos";
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.LargeGlyph")));
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnConexaoFTP
            // 
            this.btnConexaoFTP.Caption = "Conexão FTP";
            this.btnConexaoFTP.Glyph = ((System.Drawing.Image)(resources.GetObject("btnConexaoFTP.Glyph")));
            this.btnConexaoFTP.Id = 13;
            this.btnConexaoFTP.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnConexaoFTP.LargeGlyph")));
            this.btnConexaoFTP.Name = "btnConexaoFTP";
            this.btnConexaoFTP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnConexaoFTP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConexaoFTP_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Adicionar regras";
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 15;
            this.barButtonItem14.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.LargeGlyph")));
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Ver regras";
            this.barButtonItem15.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.Glyph")));
            this.barButtonItem15.Id = 16;
            this.barButtonItem15.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.LargeGlyph")));
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Desenvolvedor";
            this.barButtonItem16.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.Glyph")));
            this.barButtonItem16.Id = 17;
            this.barButtonItem16.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.LargeGlyph")));
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Auditar arquivos";
            this.barButtonItem17.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.Glyph")));
            this.barButtonItem17.Id = 18;
            this.barButtonItem17.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.LargeGlyph")));
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Ver última auditoria";
            this.barButtonItem18.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.Glyph")));
            this.barButtonItem18.Id = 19;
            this.barButtonItem18.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.LargeGlyph")));
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Arquivos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSelectArq);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Selecione os Arquivos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Filtros";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddAcao);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddRegistro);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddCampo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddParametro);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddPosicao);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddPreposicao);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Filtros";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSalvarRegra);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAbrirRegra);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Regras";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Programas";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Bioblioteca";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Banco de arquivos";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnConexaoFTP);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Base de arquivos";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Regras";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Regras";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Auditoria";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem17);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem18);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Auditar";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "Sobre";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem16);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Sobre";
            // 
            // Thema
            // 
            this.Thema.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolblDirArq,
            this.toolDirArq,
            this.toolblDirArqAux,
            this.toolDirArqAux});
            this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.statusBar.Location = new System.Drawing.Point(0, 606);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBar.Size = new System.Drawing.Size(1022, 113);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolblDirArq
            // 
            this.toolblDirArq.Name = "toolblDirArq";
            this.toolblDirArq.Size = new System.Drawing.Size(1019, 15);
            this.toolblDirArq.Text = "Diretório de arquivo selecionado:";
            this.toolblDirArq.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolDirArq
            // 
            this.toolDirArq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolDirArq.Name = "toolDirArq";
            this.toolDirArq.Size = new System.Drawing.Size(1019, 15);
            this.toolDirArq.Text = "Nenhum...";
            this.toolDirArq.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolblDirArqAux
            // 
            this.toolblDirArqAux.Name = "toolblDirArqAux";
            this.toolblDirArqAux.Size = new System.Drawing.Size(1019, 15);
            this.toolblDirArqAux.Text = "Diretório de arquivo auxiliar:";
            this.toolblDirArqAux.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolDirArqAux
            // 
            this.toolDirArqAux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolDirArqAux.Name = "toolDirArqAux";
            this.toolDirArqAux.Size = new System.Drawing.Size(1019, 15);
            this.toolDirArqAux.Text = "Nenhum...";
            this.toolDirArqAux.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Principal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 719);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Principal";
            this.Ribbon = this.ribbonControl1;
            this.Text = "VIA Consult Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSelectArq;
        private DevExpress.XtraBars.BarButtonItem btnAddAcao;
        private DevExpress.XtraBars.BarButtonItem btnAddRegistro;
        private DevExpress.XtraBars.BarButtonItem btnAddCampo;
        private DevExpress.XtraBars.BarButtonItem btnAddParametro;
        private DevExpress.XtraBars.BarButtonItem btnAddPosicao;
        private DevExpress.XtraBars.BarButtonItem btnAddPreposicao;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel Thema;
        private DevExpress.XtraBars.BarButtonItem btnSalvarRegra;
        private DevExpress.XtraBars.BarButtonItem btnAbrirRegra;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem btnConexaoFTP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolblDirArq;
        private System.Windows.Forms.ToolStripStatusLabel toolDirArq;
        private System.Windows.Forms.ToolStripStatusLabel toolblDirArqAux;
        private System.Windows.Forms.ToolStripStatusLabel toolDirArqAux;
        private System.Windows.Forms.FolderBrowserDialog fdbSelectDir;
    }
}

