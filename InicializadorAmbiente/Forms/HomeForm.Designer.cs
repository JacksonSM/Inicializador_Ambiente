namespace InicializadorAmbiente.Forms;

partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_CriarAmbiente = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.flpAmbientes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTemplateInicializador = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flpAmbientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_CriarAmbiente,
            this.btn_Editar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_CriarAmbiente
            // 
            this.btn_CriarAmbiente.Name = "btn_CriarAmbiente";
            this.btn_CriarAmbiente.Size = new System.Drawing.Size(99, 20);
            this.btn_CriarAmbiente.Text = "Criar Ambiente";
            this.btn_CriarAmbiente.Click += new System.EventHandler(this.CriarAmbiente);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(49, 20);
            this.btn_Editar.Text = "Editar";
            // 
            // flpAmbientes
            // 
            this.flpAmbientes.Controls.Add(this.btnTemplateInicializador);
            this.flpAmbientes.Location = new System.Drawing.Point(12, 27);
            this.flpAmbientes.Name = "flpAmbientes";
            this.flpAmbientes.Size = new System.Drawing.Size(332, 380);
            this.flpAmbientes.TabIndex = 1;
            // 
            // btnTemplateInicializador
            // 
            this.btnTemplateInicializador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTemplateInicializador.Location = new System.Drawing.Point(10, 10);
            this.btnTemplateInicializador.Margin = new System.Windows.Forms.Padding(10);
            this.btnTemplateInicializador.Name = "btnTemplateInicializador";
            this.btnTemplateInicializador.Size = new System.Drawing.Size(140, 74);
            this.btnTemplateInicializador.TabIndex = 0;
            this.btnTemplateInicializador.Text = "Exemplo";
            this.btnTemplateInicializador.UseVisualStyleBackColor = true;
            this.btnTemplateInicializador.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 424);
            this.Controls.Add(this.flpAmbientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpAmbientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem btn_CriarAmbiente;
    private FlowLayoutPanel flpAmbientes;
    private Button btnTemplateInicializador;
    private ToolStripMenuItem btn_Editar;
}