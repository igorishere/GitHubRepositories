
namespace GitHubRepositories
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.linkRepositorioURL = new System.Windows.Forms.LinkLabel();
            this.labelNomeRepositorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 309);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 309);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.labelDescricao);
            this.panel2.Controls.Add(this.linkRepositorioURL);
            this.panel2.Controls.Add(this.labelNomeRepositorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 311);
            this.panel2.TabIndex = 1;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.labelDescricao.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelDescricao.Location = new System.Drawing.Point(17, 131);
            this.labelDescricao.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(398, 51);
            this.labelDescricao.TabIndex = 3;
            this.labelDescricao.Text = "lorem ipsum lorem ipsum lorem ipsum  lorem ipsum lorem ipsum lorem ipsum  lorem i" +
    "psum lorem ipsum lorem ipsum  lorem ipsum lorem ipsum lorem ipsum  lorem ipsum l" +
    "orem ipsum lorem ipsum ";
            // 
            // linkRepositorioURL
            // 
            this.linkRepositorioURL.AutoSize = true;
            this.linkRepositorioURL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkRepositorioURL.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkRepositorioURL.Location = new System.Drawing.Point(17, 80);
            this.linkRepositorioURL.Name = "linkRepositorioURL";
            this.linkRepositorioURL.Size = new System.Drawing.Size(121, 13);
            this.linkRepositorioURL.TabIndex = 2;
            this.linkRepositorioURL.TabStop = true;
            this.linkRepositorioURL.Text = "www.loremipsum.com.br";
            this.linkRepositorioURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRepositorioURL_LinkClicked);
            // 
            // labelNomeRepositorio
            // 
            this.labelNomeRepositorio.AutoSize = true;
            this.labelNomeRepositorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeRepositorio.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelNomeRepositorio.Location = new System.Drawing.Point(14, 17);
            this.labelNomeRepositorio.Name = "labelNomeRepositorio";
            this.labelNomeRepositorio.Size = new System.Drawing.Size(186, 32);
            this.labelNomeRepositorio.TabIndex = 1;
            this.labelNomeRepositorio.Text = "Lorem Ipsum";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(764, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repositorios";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNomeRepositorio;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.LinkLabel linkRepositorioURL;
    }
}