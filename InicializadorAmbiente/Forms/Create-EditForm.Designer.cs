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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeAmbiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numIntervalo = new System.Windows.Forms.NumericUpDown();
            this.flowAplicacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.template_gbSite = new System.Windows.Forms.GroupBox();
            this.btn_Site_Del = new System.Windows.Forms.Button();
            this.template_tbURL = new System.Windows.Forms.TextBox();
            this.siteDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblURL = new System.Windows.Forms.Label();
            this.template_gbPrograma = new System.Windows.Forms.GroupBox();
            this.btn_Programa_Buscar = new System.Windows.Forms.Button();
            this.template_tbPrograma_Caminho = new System.Windows.Forms.TextBox();
            this.btn_Programa_Del = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.adcSite = new System.Windows.Forms.Button();
            this.adcPrograma = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalo)).BeginInit();
            this.flowAplicacoes.SuspendLayout();
            this.template_gbSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteDataBindingSource)).BeginInit();
            this.template_gbPrograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // tbNomeAmbiente
            // 
            this.tbNomeAmbiente.Location = new System.Drawing.Point(97, 12);
            this.tbNomeAmbiente.Name = "tbNomeAmbiente";
            this.tbNomeAmbiente.Size = new System.Drawing.Size(255, 23);
            this.tbNomeAmbiente.TabIndex = 1;
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
            // numIntervalo
            // 
            this.numIntervalo.Location = new System.Drawing.Point(286, 65);
            this.numIntervalo.Name = "numIntervalo";
            this.numIntervalo.Size = new System.Drawing.Size(66, 23);
            this.numIntervalo.TabIndex = 2;
            this.numIntervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowAplicacoes
            // 
            this.flowAplicacoes.AutoScroll = true;
            this.flowAplicacoes.Controls.Add(this.template_gbSite);
            this.flowAplicacoes.Controls.Add(this.template_gbPrograma);
            this.flowAplicacoes.Location = new System.Drawing.Point(12, 140);
            this.flowAplicacoes.Name = "flowAplicacoes";
            this.flowAplicacoes.Size = new System.Drawing.Size(416, 283);
            this.flowAplicacoes.TabIndex = 4;
            // 
            // template_gbSite
            // 
            this.template_gbSite.Controls.Add(this.btn_Site_Del);
            this.template_gbSite.Controls.Add(this.template_tbURL);
            this.template_gbSite.Controls.Add(this.lblURL);
            this.template_gbSite.Location = new System.Drawing.Point(3, 3);
            this.template_gbSite.Name = "template_gbSite";
            this.template_gbSite.Size = new System.Drawing.Size(397, 72);
            this.template_gbSite.TabIndex = 0;
            this.template_gbSite.TabStop = false;
            this.template_gbSite.Tag = "";
            this.template_gbSite.Text = "Site";
            this.template_gbSite.Visible = false;
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
            // template_tbURL
            // 
            this.template_tbURL.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.siteDataBindingSource, "URL", true));
            this.template_tbURL.Location = new System.Drawing.Point(58, 17);
            this.template_tbURL.Name = "template_tbURL";
            this.template_tbURL.Size = new System.Drawing.Size(309, 23);
            this.template_tbURL.TabIndex = 5;
            this.template_tbURL.Tag = "CampoURL";
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
            // template_gbPrograma
            // 
            this.template_gbPrograma.Controls.Add(this.btn_Programa_Buscar);
            this.template_gbPrograma.Controls.Add(this.template_tbPrograma_Caminho);
            this.template_gbPrograma.Controls.Add(this.btn_Programa_Del);
            this.template_gbPrograma.Controls.Add(this.lblCaminho);
            this.template_gbPrograma.Location = new System.Drawing.Point(3, 81);
            this.template_gbPrograma.Name = "template_gbPrograma";
            this.template_gbPrograma.Size = new System.Drawing.Size(397, 80);
            this.template_gbPrograma.TabIndex = 0;
            this.template_gbPrograma.TabStop = false;
            this.template_gbPrograma.Tag = "";
            this.template_gbPrograma.Text = "Programa";
            this.template_gbPrograma.Visible = false;
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
            // template_tbPrograma_Caminho
            // 
            this.template_tbPrograma_Caminho.Enabled = false;
            this.template_tbPrograma_Caminho.Location = new System.Drawing.Point(82, 19);
            this.template_tbPrograma_Caminho.Name = "template_tbPrograma_Caminho";
            this.template_tbPrograma_Caminho.Size = new System.Drawing.Size(207, 23);
            this.template_tbPrograma_Caminho.TabIndex = 4;
            this.template_tbPrograma_Caminho.Tag = "";
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 429);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Create_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 461);
            this.Controls.Add(this.adcPrograma);
            this.Controls.Add(this.adcSite);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.flowAplicacoes);
            this.Controls.Add(this.numIntervalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeAmbiente);
            this.Controls.Add(this.label1);
            this.Name = "Create_EditForm";
            this.Text = "Create_EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalo)).EndInit();
            this.flowAplicacoes.ResumeLayout(false);
            this.template_gbSite.ResumeLayout(false);
            this.template_gbSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteDataBindingSource)).EndInit();
            this.template_gbPrograma.ResumeLayout(false);
            this.template_gbPrograma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox tbNomeAmbiente;
    private Label label2;
    private NumericUpDown numIntervalo;
    private FlowLayoutPanel flowAplicacoes;
    private GroupBox template_gbSite;
    private Label lblURL;
    private TextBox template_tbURL;
    private Button btn_Site_Del;
    private GroupBox template_gbPrograma;
    private Label lblCaminho;
    private Button btn_Programa_Del;
    private Button btn_Programa_Buscar;
    private TextBox template_tbPrograma_Caminho;
    private Button btnSalvar;
    private Button adcSite;
    private Button adcPrograma;
    private BindingSource siteDataBindingSource;
    private ErrorProvider errorProvider1;
}