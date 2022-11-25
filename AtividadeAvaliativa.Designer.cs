namespace veiculosproj
{
    partial class AtividadeAvaliativa
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
            this.components = new System.ComponentModel.Container();
            this.Dados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtAliquota = new System.Windows.Forms.TextBox();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.rdParcelaUnica = new System.Windows.Forms.RadioButton();
            this.rdParcelado = new System.Windows.Forms.RadioButton();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlacaConsulta = new System.Windows.Forms.TextBox();
            this.txtParcelasAPagar = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPlacaConsultar = new System.Windows.Forms.TextBox();
            this.txtFormaPagmto = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.relogio = new System.Windows.Forms.TextBox();
            this.mkdData = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Dados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.tabPage1);
            this.Dados.Controls.Add(this.tabPage2);
            this.Dados.Controls.Add(this.tabPage3);
            this.Dados.Controls.Add(this.tabPage4);
            this.Dados.Location = new System.Drawing.Point(12, 26);
            this.Dados.Name = "Dados";
            this.Dados.SelectedIndex = 0;
            this.Dados.Size = new System.Drawing.Size(496, 429);
            this.Dados.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.txtImposto);
            this.tabPage1.Controls.Add(this.txtAliquota);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.txtPlaca);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IPVA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.mkdData);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPagar);
            this.tabPage3.Controls.Add(this.txtParcelasAPagar);
            this.tabPage3.Controls.Add(this.txtPlacaConsulta);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(488, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Efetuar Pagamento";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtValorPago);
            this.tabPage4.Controls.Add(this.txtFormaPagmto);
            this.tabPage4.Controls.Add(this.txtPlacaConsultar);
            this.tabPage4.Controls.Add(this.btnConsultar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(488, 403);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do Veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alíquota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor imposto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(170, 26);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 26);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            this.txtPlaca.Enter += new System.EventHandler(this.txtPlaca_Enter);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(170, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtAliquota
            // 
            this.txtAliquota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquota.Location = new System.Drawing.Point(170, 115);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.ReadOnly = true;
            this.txtAliquota.Size = new System.Drawing.Size(100, 26);
            this.txtAliquota.TabIndex = 3;
            this.txtAliquota.Text = "4%";
            this.txtAliquota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtImposto
            // 
            this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImposto.Location = new System.Drawing.Point(170, 147);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(100, 26);
            this.txtImposto.TabIndex = 4;
            this.txtImposto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(328, 23);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 144);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtParcelas);
            this.groupBox1.Controls.Add(this.txtParcela);
            this.groupBox1.Controls.Add(this.rdParcelado);
            this.groupBox1.Controls.Add(this.rdParcelaUnica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(353, 201);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 158);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(26, 365);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(405, 36);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // rdParcelaUnica
            // 
            this.rdParcelaUnica.AutoSize = true;
            this.rdParcelaUnica.Location = new System.Drawing.Point(16, 38);
            this.rdParcelaUnica.Name = "rdParcelaUnica";
            this.rdParcelaUnica.Size = new System.Drawing.Size(268, 24);
            this.rdParcelaUnica.TabIndex = 8;
            this.rdParcelaUnica.TabStop = true;
            this.rdParcelaUnica.Text = "Parcela Única - 10% desconto";
            this.rdParcelaUnica.UseVisualStyleBackColor = true;
            this.rdParcelaUnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // rdParcelado
            // 
            this.rdParcelado.AutoSize = true;
            this.rdParcelado.Location = new System.Drawing.Point(16, 106);
            this.rdParcelado.Name = "rdParcelado";
            this.rdParcelado.Size = new System.Drawing.Size(141, 24);
            this.rdParcelado.TabIndex = 9;
            this.rdParcelado.TabStop = true;
            this.rdParcelado.Text = "Parcelado - 3x";
            this.rdParcelado.UseVisualStyleBackColor = true;
            this.rdParcelado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(96, 70);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(100, 26);
            this.txtParcela.TabIndex = 5;
            this.txtParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(100, 132);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(100, 26);
            this.txtParcelas.TabIndex = 6;
            this.txtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parcelas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parcela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bianca Lemes Costa  RA:201288";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 1;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Placa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Parcelas a Pagar:";
            // 
            // txtPlacaConsulta
            // 
            this.txtPlacaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaConsulta.Location = new System.Drawing.Point(80, 44);
            this.txtPlacaConsulta.Name = "txtPlacaConsulta";
            this.txtPlacaConsulta.Size = new System.Drawing.Size(100, 26);
            this.txtPlacaConsulta.TabIndex = 1;
            this.txtPlacaConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtParcelasAPagar
            // 
            this.txtParcelasAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelasAPagar.Location = new System.Drawing.Point(175, 110);
            this.txtParcelasAPagar.Name = "txtParcelasAPagar";
            this.txtParcelasAPagar.Size = new System.Drawing.Size(100, 26);
            this.txtParcelasAPagar.TabIndex = 2;
            this.txtParcelasAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(45, 176);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(285, 33);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(372, 52);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 122);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtPlacaConsultar
            // 
            this.txtPlacaConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaConsultar.Location = new System.Drawing.Point(102, 49);
            this.txtPlacaConsultar.Name = "txtPlacaConsultar";
            this.txtPlacaConsultar.Size = new System.Drawing.Size(158, 26);
            this.txtPlacaConsultar.TabIndex = 1;
            this.txtPlacaConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtFormaPagmto
            // 
            this.txtFormaPagmto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPagmto.Location = new System.Drawing.Point(210, 103);
            this.txtFormaPagmto.Name = "txtFormaPagmto";
            this.txtFormaPagmto.Size = new System.Drawing.Size(158, 26);
            this.txtFormaPagmto.TabIndex = 2;
            this.txtFormaPagmto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(136, 151);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(158, 26);
            this.txtValorPago.TabIndex = 3;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Placa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Forma de Pagamento";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Valor Pago";
            // 
            // relogio
            // 
            this.relogio.Dock = System.Windows.Forms.DockStyle.Left;
            this.relogio.Location = new System.Drawing.Point(0, 0);
            this.relogio.Name = "relogio";
            this.relogio.Size = new System.Drawing.Size(100, 20);
            this.relogio.TabIndex = 2;
            this.relogio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mkdData
            // 
            this.mkdData.Location = new System.Drawing.Point(192, 77);
            this.mkdData.Mask = "00/00/0000";
            this.mkdData.Name = "mkdData";
            this.mkdData.Size = new System.Drawing.Size(68, 20);
            this.mkdData.TabIndex = 1;
            this.mkdData.ValidatingType = typeof(System.DateTime);
            this.mkdData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdData_MaskInputRejected);
            this.mkdData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mkdData_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(136, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "data:";
            // 
            // AtividadeAvaliativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.relogio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dados);
            this.Name = "AtividadeAvaliativa";
            this.Text = "Atividade Avaliativa";
            this.Load += new System.EventHandler(this.AtividadeAvaliativa_Load);
            this.Dados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Dados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.RadioButton rdParcelado;
        private System.Windows.Forms.RadioButton rdParcelaUnica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.TextBox txtAliquota;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtParcelasAPagar;
        private System.Windows.Forms.TextBox txtPlacaConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtFormaPagmto;
        private System.Windows.Forms.TextBox txtPlacaConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox relogio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mkdData;
    }
}

