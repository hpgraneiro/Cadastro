namespace aula02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_estadocivil = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb_solteiro = new System.Windows.Forms.RadioButton();
            this.rb_divorciado = new System.Windows.Forms.RadioButton();
            this.rb_casado = new System.Windows.Forms.RadioButton();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lb_sobrenome = new System.Windows.Forms.Label();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.mtb_rg = new System.Windows.Forms.MaskedTextBox();
            this.lb_rg = new System.Windows.Forms.Label();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.tb_complemento = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.tb_remail = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_remail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirNovoProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_aviso2 = new System.Windows.Forms.Label();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________________________________________________________";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(16, 95);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(49, 18);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.Text = "Nome";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Culture = new System.Globalization.CultureInfo("en-001");
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(333, 235);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(276, 24);
            this.mtb_cpf.TabIndex = 3;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(19, 116);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(280, 24);
            this.tb_nome.TabIndex = 4;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(330, 214);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(38, 18);
            this.lb_cpf.TabIndex = 5;
            this.lb_cpf.Text = "CPF";
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cb_estado.Location = new System.Drawing.Point(333, 512);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(277, 26);
            this.cb_estado.TabIndex = 6;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(330, 491);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(55, 18);
            this.lb_estado.TabIndex = 7;
            this.lb_estado.Text = "Estado";
            // 
            // lb_estadocivil
            // 
            this.lb_estadocivil.AutoSize = true;
            this.lb_estadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estadocivil.Location = new System.Drawing.Point(19, 214);
            this.lb_estadocivil.Name = "lb_estadocivil";
            this.lb_estadocivil.Size = new System.Drawing.Size(86, 18);
            this.lb_estadocivil.TabIndex = 8;
            this.lb_estadocivil.Text = "Estado Civil";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Khaki;
            this.flowLayoutPanel1.Controls.Add(this.rb_solteiro);
            this.flowLayoutPanel1.Controls.Add(this.rb_casado);
            this.flowLayoutPanel1.Controls.Add(this.rb_divorciado);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 31);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // rb_solteiro
            // 
            this.rb_solteiro.AutoSize = true;
            this.rb_solteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_solteiro.Location = new System.Drawing.Point(3, 3);
            this.rb_solteiro.Name = "rb_solteiro";
            this.rb_solteiro.Size = new System.Drawing.Size(77, 22);
            this.rb_solteiro.TabIndex = 0;
            this.rb_solteiro.TabStop = true;
            this.rb_solteiro.Text = "Solteiro";
            this.rb_solteiro.UseVisualStyleBackColor = true;
            // 
            // rb_divorciado
            // 
            this.rb_divorciado.AutoSize = true;
            this.rb_divorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_divorciado.Location = new System.Drawing.Point(170, 3);
            this.rb_divorciado.Name = "rb_divorciado";
            this.rb_divorciado.Size = new System.Drawing.Size(97, 22);
            this.rb_divorciado.TabIndex = 1;
            this.rb_divorciado.TabStop = true;
            this.rb_divorciado.Text = "Divorciado";
            this.rb_divorciado.UseVisualStyleBackColor = true;
            // 
            // rb_casado
            // 
            this.rb_casado.AutoSize = true;
            this.rb_casado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_casado.Location = new System.Drawing.Point(86, 3);
            this.rb_casado.Name = "rb_casado";
            this.rb_casado.Size = new System.Drawing.Size(78, 22);
            this.rb_casado.TabIndex = 2;
            this.rb_casado.TabStop = true;
            this.rb_casado.Text = "Casado";
            this.rb_casado.UseVisualStyleBackColor = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(235, 560);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(142, 36);
            this.btn_entrar.TabIndex = 10;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lb_sobrenome
            // 
            this.lb_sobrenome.AutoSize = true;
            this.lb_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sobrenome.Location = new System.Drawing.Point(330, 95);
            this.lb_sobrenome.Name = "lb_sobrenome";
            this.lb_sobrenome.Size = new System.Drawing.Size(84, 18);
            this.lb_sobrenome.TabIndex = 11;
            this.lb_sobrenome.Text = "sobrenome";
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sobrenome.Location = new System.Drawing.Point(333, 116);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(276, 24);
            this.tb_sobrenome.TabIndex = 12;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(330, 415);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(54, 18);
            this.lb_cidade.TabIndex = 13;
            this.lb_cidade.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(333, 438);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(276, 24);
            this.tb_cidade.TabIndex = 14;
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celular.Location = new System.Drawing.Point(19, 282);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(54, 18);
            this.lb_celular.TabIndex = 15;
            this.lb_celular.Text = "Celular";
            // 
            // mtb_celular
            // 
            this.mtb_celular.Culture = new System.Globalization.CultureInfo("en-001");
            this.mtb_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_celular.Location = new System.Drawing.Point(22, 304);
            this.mtb_celular.Mask = "(99) 00000-0000";
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(277, 24);
            this.mtb_celular.TabIndex = 16;
            // 
            // dtp_data
            // 
            this.dtp_data.CustomFormat = "";
            this.dtp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(333, 366);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(276, 24);
            this.dtp_data.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de nascimento";
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(19, 347);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(72, 18);
            this.lb_endereco.TabIndex = 19;
            this.lb_endereco.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(22, 368);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(277, 24);
            this.tb_endereco.TabIndex = 20;
            // 
            // mtb_rg
            // 
            this.mtb_rg.Culture = new System.Globalization.CultureInfo("en-001");
            this.mtb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_rg.Location = new System.Drawing.Point(333, 304);
            this.mtb_rg.Mask = "00.000.000-0";
            this.mtb_rg.Name = "mtb_rg";
            this.mtb_rg.Size = new System.Drawing.Size(276, 24);
            this.mtb_rg.TabIndex = 21;
            // 
            // lb_rg
            // 
            this.lb_rg.AutoSize = true;
            this.lb_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rg.Location = new System.Drawing.Point(330, 283);
            this.lb_rg.Name = "lb_rg";
            this.lb_rg.Size = new System.Drawing.Size(31, 18);
            this.lb_rg.TabIndex = 22;
            this.lb_rg.Text = "RG";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento.Location = new System.Drawing.Point(20, 491);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(102, 18);
            this.lb_complemento.TabIndex = 23;
            this.lb_complemento.Text = "Complemento";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(20, 415);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(62, 18);
            this.lb_numero.TabIndex = 24;
            this.lb_numero.Text = "Numero";
            // 
            // tb_complemento
            // 
            this.tb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_complemento.Location = new System.Drawing.Point(23, 512);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(276, 24);
            this.tb_complemento.TabIndex = 25;
            // 
            // tb_numero
            // 
            this.tb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero.Location = new System.Drawing.Point(23, 436);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(276, 24);
            this.tb_numero.TabIndex = 26;
            // 
            // tb_remail
            // 
            this.tb_remail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_remail.Location = new System.Drawing.Point(333, 178);
            this.tb_remail.Name = "tb_remail";
            this.tb_remail.Size = new System.Drawing.Size(280, 24);
            this.tb_remail.TabIndex = 27;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(19, 178);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 24);
            this.tb_email.TabIndex = 28;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(19, 157);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(45, 18);
            this.lb_email.TabIndex = 29;
            this.lb_email.Text = "Email";
            // 
            // lb_remail
            // 
            this.lb_remail.AutoSize = true;
            this.lb_remail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remail.Location = new System.Drawing.Point(330, 157);
            this.lb_remail.Name = "lb_remail";
            this.lb_remail.Size = new System.Drawing.Size(94, 18);
            this.lb_remail.TabIndex = 30;
            this.lb_remail.Text = "Repetir email";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.abrirNovoProjetoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // abrirNovoProjetoToolStripMenuItem
            // 
            this.abrirNovoProjetoToolStripMenuItem.Name = "abrirNovoProjetoToolStripMenuItem";
            this.abrirNovoProjetoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirNovoProjetoToolStripMenuItem.Text = "Abrir novo projeto";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lb_aviso2
            // 
            this.lb_aviso2.AutoSize = true;
            this.lb_aviso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aviso2.Location = new System.Drawing.Point(269, 52);
            this.lb_aviso2.Name = "lb_aviso2";
            this.lb_aviso2.Size = new System.Drawing.Size(47, 20);
            this.lb_aviso2.TabIndex = 32;
            this.lb_aviso2.Text = "Aviso";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(637, 608);
            this.Controls.Add(this.lb_aviso2);
            this.Controls.Add(this.lb_remail);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_remail);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.tb_complemento);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.lb_complemento);
            this.Controls.Add(this.lb_rg);
            this.Controls.Add(this.mtb_rg);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.mtb_celular);
            this.Controls.Add(this.lb_celular);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.lb_sobrenome);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lb_estadocivil);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_estadocivil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_solteiro;
        private System.Windows.Forms.RadioButton rb_casado;
        private System.Windows.Forms.RadioButton rb_divorciado;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lb_sobrenome;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.MaskedTextBox mtb_celular;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.MaskedTextBox mtb_rg;
        private System.Windows.Forms.Label lb_rg;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox tb_complemento;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.TextBox tb_remail;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_remail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirNovoProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lb_aviso2;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}

