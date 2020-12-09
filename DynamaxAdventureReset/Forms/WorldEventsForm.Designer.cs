namespace DynamaxAdventureReset
{
    partial class WorldEventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldEventsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_giftcosmog_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ct_birds_uncaughtBTN = new System.Windows.Forms.Button();
            this.ct_birds_caughtBTN = new System.Windows.Forms.Button();
            this.ct_gmoltres_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.ct_gzapdos_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.ct_garticuno_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_applyBTN = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Game";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Isle of Armor";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ct_giftcosmog_PB);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crown Tundra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cosmog Gift";
            // 
            // ct_giftcosmog_PB
            // 
            this.ct_giftcosmog_PB.Caught = false;
            this.ct_giftcosmog_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_giftcosmog_PB.Location = new System.Drawing.Point(6, 19);
            this.ct_giftcosmog_PB.MaximumSize = new System.Drawing.Size(130, 56);
            this.ct_giftcosmog_PB.MinimumSize = new System.Drawing.Size(130, 56);
            this.ct_giftcosmog_PB.Name = "ct_giftcosmog_PB";
            this.ct_giftcosmog_PB.Pokemon = 789;
            this.ct_giftcosmog_PB.PokemonSubform = 0;
            this.ct_giftcosmog_PB.Size = new System.Drawing.Size(130, 56);
            this.ct_giftcosmog_PB.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ct_birds_uncaughtBTN);
            this.groupBox1.Controls.Add(this.ct_birds_caughtBTN);
            this.groupBox1.Controls.Add(this.ct_gmoltres_PB);
            this.groupBox1.Controls.Add(this.ct_gzapdos_PB);
            this.groupBox1.Controls.Add(this.ct_garticuno_PB);
            this.groupBox1.Location = new System.Drawing.Point(142, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galarian Birds";
            // 
            // ct_birds_uncaughtBTN
            // 
            this.ct_birds_uncaughtBTN.Location = new System.Drawing.Point(142, 57);
            this.ct_birds_uncaughtBTN.Name = "ct_birds_uncaughtBTN";
            this.ct_birds_uncaughtBTN.Size = new System.Drawing.Size(99, 32);
            this.ct_birds_uncaughtBTN.TabIndex = 6;
            this.ct_birds_uncaughtBTN.Text = "Un-Caught All";
            this.ct_birds_uncaughtBTN.UseVisualStyleBackColor = true;
            this.ct_birds_uncaughtBTN.Click += new System.EventHandler(this.ct_birds_uncaughtBTN_Click);
            // 
            // ct_birds_caughtBTN
            // 
            this.ct_birds_caughtBTN.Location = new System.Drawing.Point(142, 19);
            this.ct_birds_caughtBTN.Name = "ct_birds_caughtBTN";
            this.ct_birds_caughtBTN.Size = new System.Drawing.Size(99, 32);
            this.ct_birds_caughtBTN.TabIndex = 5;
            this.ct_birds_caughtBTN.Text = "Caught All";
            this.ct_birds_caughtBTN.UseVisualStyleBackColor = true;
            this.ct_birds_caughtBTN.Click += new System.EventHandler(this.ct_birds_caughtBTN_Click);
            // 
            // ct_gmoltres_PB
            // 
            this.ct_gmoltres_PB.Caught = false;
            this.ct_gmoltres_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_gmoltres_PB.Location = new System.Drawing.Point(6, 143);
            this.ct_gmoltres_PB.MaximumSize = new System.Drawing.Size(130, 56);
            this.ct_gmoltres_PB.MinimumSize = new System.Drawing.Size(130, 56);
            this.ct_gmoltres_PB.Name = "ct_gmoltres_PB";
            this.ct_gmoltres_PB.Pokemon = 146;
            this.ct_gmoltres_PB.PokemonSubform = 1;
            this.ct_gmoltres_PB.Size = new System.Drawing.Size(130, 56);
            this.ct_gmoltres_PB.TabIndex = 7;
            // 
            // ct_gzapdos_PB
            // 
            this.ct_gzapdos_PB.Caught = false;
            this.ct_gzapdos_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_gzapdos_PB.Location = new System.Drawing.Point(6, 81);
            this.ct_gzapdos_PB.MaximumSize = new System.Drawing.Size(130, 56);
            this.ct_gzapdos_PB.MinimumSize = new System.Drawing.Size(130, 56);
            this.ct_gzapdos_PB.Name = "ct_gzapdos_PB";
            this.ct_gzapdos_PB.Pokemon = 145;
            this.ct_gzapdos_PB.PokemonSubform = 1;
            this.ct_gzapdos_PB.Size = new System.Drawing.Size(130, 56);
            this.ct_gzapdos_PB.TabIndex = 6;
            // 
            // ct_garticuno_PB
            // 
            this.ct_garticuno_PB.Caught = false;
            this.ct_garticuno_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_garticuno_PB.Location = new System.Drawing.Point(6, 19);
            this.ct_garticuno_PB.MaximumSize = new System.Drawing.Size(130, 56);
            this.ct_garticuno_PB.MinimumSize = new System.Drawing.Size(130, 56);
            this.ct_garticuno_PB.Name = "ct_garticuno_PB";
            this.ct_garticuno_PB.Pokemon = 144;
            this.ct_garticuno_PB.PokemonSubform = 1;
            this.ct_garticuno_PB.Size = new System.Drawing.Size(130, 56);
            this.ct_garticuno_PB.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_applyBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_applyBTN
            // 
            this.ts_applyBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_applyBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_applyBTN.Name = "ts_applyBTN";
            this.ts_applyBTN.Size = new System.Drawing.Size(93, 22);
            this.ts_applyBTN.Text = "Apply Selection";
            this.ts_applyBTN.Click += new System.EventHandler(this.ts_applyBTN_Click);
            // 
            // WorldEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorldEventsForm";
            this.Text = "World Events";
            this.Load += new System.EventHandler(this.WorldEvents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.PokemonBaseUC ct_garticuno_PB;
        private Controls.PokemonBaseUC ct_gmoltres_PB;
        private Controls.PokemonBaseUC ct_gzapdos_PB;
        private System.Windows.Forms.Button ct_birds_uncaughtBTN;
        private System.Windows.Forms.Button ct_birds_caughtBTN;
        private Controls.PokemonBaseUC ct_giftcosmog_PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_applyBTN;
    }
}