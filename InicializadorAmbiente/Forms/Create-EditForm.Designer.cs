namespace InicializadorAmbiente.Forms;

partial class Create_EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowAplicacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSite = new System.Windows.Forms.GroupBox();
            this.btn_Site_Del = new System.Windows.Forms.Button();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.gbPrograma = new System.Windows.Forms.GroupBox();
            this.btn_Programa_Buscar = new System.Windows.Forms.Button();
            this.tb_Programa_Caminho = new System.Windows.Forms.TextBox();
            this.btn_Programa_Del = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adcSite = new System.Windows.Forms.Button();
            this.adcPrograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowAplicacoes.SuspendLayout();
            this.gbSite.SuspendLayout();
            this.gbPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intervalo de execução:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(286, 65);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 2;
            // 
            // flowAplicacoes
            // 
            this.flowAplicacoes.AutoScroll = true;
            this.flowAplicacoes.Controls.Add(this.gbSite);
            this.flowAplicacoes.Controls.Add(this.gbPrograma);
            this.flowAplicacoes.Location = new System.Drawing.Point(12, 140);
            this.flowAplicacoes.Name = "flowAplicacoes";
            this.flowAplicacoes.Size = new System.Drawing.Size(408, 283);
            this.flowAplicacoes.TabIndex = 4;
            // 
            // gbSite
            // 
            this.gbSite.Controls.Add(this.btn_Site_Del);
            this.gbSite.Controls.Add(this.tbSite);
            this.gbSite.Controls.Add(this.lblURL);
            this.gbSite.Location = new System.Drawing.Point(3, 3);
            this.gbSite.Name = "gbSite";
            this.gbSite.Size = new System.Drawing.Size(373, 72);
            this.gbSite.TabIndex = 0;
            this.gbSite.TabStop = false;
            this.gbSite.Tag = "entradaSite";
            this.gbSite.Text = "Site";
            this.gbSite.Visible = false;
            // 
            // btn_Site_Del
            // 
            this.btn_Site_Del.Location = new System.Drawing.Point(292, 49);
            this.btn_Site_Del.Name = "btn_Site_Del";
            this.btn_Site_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Site_Del.TabIndex = 6;
            this.btn_Site_Del.Text = "Deletar";
            this.btn_Site_Del.UseVisualStyleBackColor = true;
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(58, 17);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(309, 23);
            this.tbSite.TabIndex = 5;
            this.tbSite.Tag = "0";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblURL.Location = new System.Drawing.Point(6, 19);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 21);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL: ";
            // 
            // gbPrograma
            // 
            this.gbPrograma.Controls.Add(this.btn_Programa_Buscar);
            this.gbPrograma.Controls.Add(this.tb_Programa_Caminho);
            this.gbPrograma.Controls.Add(this.btn_Programa_Del);
            this.gbPrograma.Controls.Add(this.lblCaminho);
            this.gbPrograma.Location = new System.Drawing.Point(3, 81);
            this.gbPrograma.Name = "gbPrograma";
            this.gbPrograma.Size = new System.Drawing.Size(373, 80);
            this.gbPrograma.TabIndex = 0;
            this.gbPrograma.TabStop = false;
            this.gbPrograma.Tag = "entradaPrograma";
            this.gbPrograma.Text = "Programa";
            this.gbPrograma.Visible = false;
            // 
            // btn_Programa_Buscar
            // 
            this.btn_Programa_Buscar.Location = new System.Drawing.Point(292, 19);
            this.btn_Programa_Buscar.Name = "btn_Programa_Buscar";
            this.btn_Programa_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Programa_Buscar.TabIndex = 7;
            this.btn_Programa_Buscar.Text = "Buscar";
            this.btn_Programa_Buscar.UseVisualStyleBackColor = true;
            // 
            // tb_Programa_Caminho
            // 
            this.tb_Programa_Caminho.Enabled = false;
            this.tb_Programa_Caminho.Location = new System.Drawing.Point(82, 19);
            this.tb_Programa_Caminho.Name = "tb_Programa_Caminho";
            this.tb_Programa_Caminho.Size = new System.Drawing.Size(207, 23);
            this.tb_Programa_Caminho.TabIndex = 4;
            this.tb_Programa_Caminho.Tag = "";
            // 
            // btn_Programa_Del
            // 
            this.btn_Programa_Del.Location = new System.Drawing.Point(292, 49);
            this.btn_Programa_Del.Name = "btn_Programa_Del";
            this.btn_Programa_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Programa_Del.TabIndex = 8;
            this.btn_Programa_Del.Text = "Deletar";
            this.btn_Programa_Del.UseVisualStyleBackColor = true;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaminho.Location = new System.Drawing.Point(6, 19);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(80, 21);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho: ";
            this.lblCaminho.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // adcSite
            // 
            this.adcSite.Location = new System.Drawing.Point(12, 111);
            this.adcSite.Name = "adcSite";
            this.adcSite.Size = new System.Drawing.Size(46, 23);
            this.adcSite.TabIndex = 3;
            this.adcSite.Text = "+ Site";
            this.adcSite.UseVisualStyleBackColor = true;
            this.adcSite.Click += new System.EventHandler(this.adcSite_Click);
            // 
            // adcPrograma
            // 
            this.adcPrograma.Location = new System.Drawing.Point(73, 111);
            this.adcPrograma.Name = "adcPrograma";
            this.adcPrograma.Size = new System.Drawing.Size(78, 23);
            this.adcPrograma.TabIndex = 4;
            this.adcPrograma.Text = "+ Programa";
            this.adcPrograma.UseVisualStyleBackColor = true;
            this.adcPrograma.Click += new System.EventHandler(this.adcPrograma_Click);
            // 
            // Create_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 461);
            this.Controls.Add(this.adcPrograma);
            this.Controls.Add(this.adcSite);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowAplicacoes);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Create_EditForm";
            this.Text = "Create_EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowAplicacoes.ResumeLayout(false);
            this.gbSite.ResumeLayout(false);
            this.gbSite.PerformLayout();
            this.gbPrograma.ResumeLayout(false);
            this.gbPrograma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private FlowLayoutPanel flowAplicacoes;
    private GroupBox gbSite;
    private Label lblURL;
    private TextBox tbSite;
    private Button btn_Site_Del;
    private GroupBox gbPrograma;
    private Label lblCaminho;
    private Button btn_Programa_Del;
    private Button btn_Programa_Buscar;
    private TextBox tb_Programa_Caminho;
    private Button button3;
    private Button adcSite;
    private Button adcPrograma;
}