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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.main_gift_toxel_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.main_gift_typenull_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.main_gift_gcharmander_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.main_eevee_save_data_CB = new System.Windows.Forms.CheckBox();
            this.main_letsgo_forcelegal_CB = new System.Windows.Forms.CheckBox();
            this.main_geevee_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.main_pikachu_save_data_CB = new System.Windows.Forms.CheckBox();
            this.main_gpikachu_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ct_gift_poipole_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ct_spiritomb_forcelegal_CB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_spiritomb_players_NUD = new System.Windows.Forms.NumericUpDown();
            this.ct_spiritomb_visible_CB = new System.Windows.Forms.CheckBox();
            this.ct_spiritomb_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ct_gmoltres_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.ct_birds_uncaughtBTN = new System.Windows.Forms.Button();
            this.ct_birds_caughtBTN = new System.Windows.Forms.Button();
            this.ct_gzapdos_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.ct_garticuno_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.ct_giftcosmog_PB = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_applyBTN = new System.Windows.Forms.ToolStripButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pokemonBaseUC7 = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.pokemonBaseUC8 = new DynamaxAdventureReset.Controls.PokemonBaseUC();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_spiritomb_players_NUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.main_gift_toxel_PB);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Game";
            // 
            // main_gift_toxel_PB
            // 
            this.main_gift_toxel_PB.Caught = false;
            this.main_gift_toxel_PB.DrawDynaxMaxIcon = false;
            this.main_gift_toxel_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.main_gift_toxel_PB.Location = new System.Drawing.Point(420, 9);
            this.main_gift_toxel_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.main_gift_toxel_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.main_gift_toxel_PB.Name = "main_gift_toxel_PB";
            this.main_gift_toxel_PB.Pokemon = 848;
            this.main_gift_toxel_PB.PokemonName = "Toxel Gift";
            this.main_gift_toxel_PB.PokemonSubform = "";
            this.main_gift_toxel_PB.Size = new System.Drawing.Size(130, 72);
            this.main_gift_toxel_PB.TabIndex = 24;
            this.main_gift_toxel_PB.ToolTip = "";
            // 
            // main_gift_typenull_PB
            // 
            this.main_gift_typenull_PB.Caught = false;
            this.main_gift_typenull_PB.DrawDynaxMaxIcon = false;
            this.main_gift_typenull_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.main_gift_typenull_PB.Location = new System.Drawing.Point(6, 97);
            this.main_gift_typenull_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.main_gift_typenull_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.main_gift_typenull_PB.Name = "main_gift_typenull_PB";
            this.main_gift_typenull_PB.Pokemon = 772;
            this.main_gift_typenull_PB.PokemonName = "Type:Null Gift";
            this.main_gift_typenull_PB.PokemonSubform = "";
            this.main_gift_typenull_PB.Size = new System.Drawing.Size(130, 72);
            this.main_gift_typenull_PB.TabIndex = 23;
            this.main_gift_typenull_PB.ToolTip = "Player must be champion";
            // 
            // main_gift_gcharmander_PB
            // 
            this.main_gift_gcharmander_PB.Caught = false;
            this.main_gift_gcharmander_PB.DrawDynaxMaxIcon = true;
            this.main_gift_gcharmander_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.main_gift_gcharmander_PB.Location = new System.Drawing.Point(6, 19);
            this.main_gift_gcharmander_PB.MaximumSize = new System.Drawing.Size(135, 72);
            this.main_gift_gcharmander_PB.MinimumSize = new System.Drawing.Size(135, 72);
            this.main_gift_gcharmander_PB.Name = "main_gift_gcharmander_PB";
            this.main_gift_gcharmander_PB.Pokemon = 4;
            this.main_gift_gcharmander_PB.PokemonName = "Gigantmax Charmander Gift";
            this.main_gift_gcharmander_PB.PokemonSubform = "";
            this.main_gift_gcharmander_PB.Size = new System.Drawing.Size(135, 72);
            this.main_gift_gcharmander_PB.TabIndex = 21;
            this.main_gift_gcharmander_PB.ToolTip = "Player must be champion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.main_eevee_save_data_CB);
            this.groupBox4.Controls.Add(this.main_letsgo_forcelegal_CB);
            this.groupBox4.Controls.Add(this.main_geevee_PB);
            this.groupBox4.Controls.Add(this.main_pikachu_save_data_CB);
            this.groupBox4.Controls.Add(this.main_gpikachu_PB);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 200);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Let\'s Go Gifts";
            // 
            // main_eevee_save_data_CB
            // 
            this.main_eevee_save_data_CB.AutoSize = true;
            this.main_eevee_save_data_CB.Location = new System.Drawing.Point(80, 136);
            this.main_eevee_save_data_CB.Name = "main_eevee_save_data_CB";
            this.main_eevee_save_data_CB.Size = new System.Drawing.Size(153, 17);
            this.main_eevee_save_data_CB.TabIndex = 17;
            this.main_eevee_save_data_CB.Text = "Let\'s Go Eevee Save Data";
            this.main_eevee_save_data_CB.UseVisualStyleBackColor = true;
            this.main_eevee_save_data_CB.CheckedChanged += new System.EventHandler(this.main_eevee_save_data_CB_CheckedChanged);
            // 
            // main_letsgo_forcelegal_CB
            // 
            this.main_letsgo_forcelegal_CB.AutoSize = true;
            this.main_letsgo_forcelegal_CB.Location = new System.Drawing.Point(6, 175);
            this.main_letsgo_forcelegal_CB.Name = "main_letsgo_forcelegal_CB";
            this.main_letsgo_forcelegal_CB.Size = new System.Drawing.Size(152, 17);
            this.main_letsgo_forcelegal_CB.TabIndex = 18;
            this.main_letsgo_forcelegal_CB.Text = "Show Legalility Corrections";
            this.main_letsgo_forcelegal_CB.UseVisualStyleBackColor = true;
            this.main_letsgo_forcelegal_CB.CheckedChanged += new System.EventHandler(this.main_letsgo_forcelegal_CB_CheckedChanged);
            // 
            // main_geevee_PB
            // 
            this.main_geevee_PB.Caught = false;
            this.main_geevee_PB.DrawDynaxMaxIcon = false;
            this.main_geevee_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.main_geevee_PB.Location = new System.Drawing.Point(6, 97);
            this.main_geevee_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.main_geevee_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.main_geevee_PB.Name = "main_geevee_PB";
            this.main_geevee_PB.Pokemon = 133;
            this.main_geevee_PB.PokemonName = "Gigantmax Eevee Gift";
            this.main_geevee_PB.PokemonSubform = "gmax";
            this.main_geevee_PB.Size = new System.Drawing.Size(130, 72);
            this.main_geevee_PB.TabIndex = 15;
            this.main_geevee_PB.ToolTip = "";
            this.main_geevee_PB.LegaliltyCheck_OnClick += new System.EventHandler(this.main_geevee_PB_LegaliltyCheck_OnClick);
            this.main_geevee_PB.Caught_OnClick += new System.EventHandler(this.main_geevee_PB_Caught_OnClick);
            // 
            // main_pikachu_save_data_CB
            // 
            this.main_pikachu_save_data_CB.AutoSize = true;
            this.main_pikachu_save_data_CB.Location = new System.Drawing.Point(80, 58);
            this.main_pikachu_save_data_CB.Name = "main_pikachu_save_data_CB";
            this.main_pikachu_save_data_CB.Size = new System.Drawing.Size(161, 17);
            this.main_pikachu_save_data_CB.TabIndex = 16;
            this.main_pikachu_save_data_CB.Text = "Let\'s Go Pikachu Save Data";
            this.main_pikachu_save_data_CB.UseVisualStyleBackColor = true;
            this.main_pikachu_save_data_CB.CheckedChanged += new System.EventHandler(this.main_pikachu_save_data_CB_CheckedChanged);
            // 
            // main_gpikachu_PB
            // 
            this.main_gpikachu_PB.Caught = false;
            this.main_gpikachu_PB.DrawDynaxMaxIcon = false;
            this.main_gpikachu_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.main_gpikachu_PB.Location = new System.Drawing.Point(6, 19);
            this.main_gpikachu_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.main_gpikachu_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.main_gpikachu_PB.Name = "main_gpikachu_PB";
            this.main_gpikachu_PB.Pokemon = 25;
            this.main_gpikachu_PB.PokemonName = "Gigantmax Pikachu Gift";
            this.main_gpikachu_PB.PokemonSubform = "gmax";
            this.main_gpikachu_PB.Size = new System.Drawing.Size(130, 72);
            this.main_gpikachu_PB.TabIndex = 14;
            this.main_gpikachu_PB.ToolTip = "";
            this.main_gpikachu_PB.LegaliltyCheck_OnClick += new System.EventHandler(this.main_gpikachu_PB_LegaliltyCheck_OnClick);
            this.main_gpikachu_PB.Caught_OnClick += new System.EventHandler(this.main_gpikachu_PB_Caught_OnClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Isle of Armor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pokemonBaseUC7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.pokemonBaseUC8);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 206);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Watt Donation";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ct_gift_poipole_PB);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.ct_giftcosmog_PB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crown Tundra";
            // 
            // ct_gift_poipole_PB
            // 
            this.ct_gift_poipole_PB.Caught = false;
            this.ct_gift_poipole_PB.DrawDynaxMaxIcon = false;
            this.ct_gift_poipole_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_gift_poipole_PB.Location = new System.Drawing.Point(467, 84);
            this.ct_gift_poipole_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_gift_poipole_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_gift_poipole_PB.Name = "ct_gift_poipole_PB";
            this.ct_gift_poipole_PB.Pokemon = 803;
            this.ct_gift_poipole_PB.PokemonName = "Poipole Gift";
            this.ct_gift_poipole_PB.PokemonSubform = "";
            this.ct_gift_poipole_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_gift_poipole_PB.TabIndex = 10;
            this.ct_gift_poipole_PB.ToolTip = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ct_spiritomb_forcelegal_CB);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ct_spiritomb_players_NUD);
            this.groupBox3.Controls.Add(this.ct_spiritomb_visible_CB);
            this.groupBox3.Controls.Add(this.ct_spiritomb_PB);
            this.groupBox3.Location = new System.Drawing.Point(261, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 165);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spiritomb Values";
            // 
            // ct_spiritomb_forcelegal_CB
            // 
            this.ct_spiritomb_forcelegal_CB.AutoSize = true;
            this.ct_spiritomb_forcelegal_CB.Location = new System.Drawing.Point(9, 139);
            this.ct_spiritomb_forcelegal_CB.Name = "ct_spiritomb_forcelegal_CB";
            this.ct_spiritomb_forcelegal_CB.Size = new System.Drawing.Size(152, 17);
            this.ct_spiritomb_forcelegal_CB.TabIndex = 10;
            this.ct_spiritomb_forcelegal_CB.Text = "Show Legalility Corrections";
            this.ct_spiritomb_forcelegal_CB.UseVisualStyleBackColor = true;
            this.ct_spiritomb_forcelegal_CB.CheckedChanged += new System.EventHandler(this.ct_spiritomb_forcelegal_CB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Players Interacted with";
            // 
            // ct_spiritomb_players_NUD
            // 
            this.ct_spiritomb_players_NUD.Location = new System.Drawing.Point(9, 113);
            this.ct_spiritomb_players_NUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ct_spiritomb_players_NUD.Name = "ct_spiritomb_players_NUD";
            this.ct_spiritomb_players_NUD.Size = new System.Drawing.Size(111, 20);
            this.ct_spiritomb_players_NUD.TabIndex = 10;
            this.ct_spiritomb_players_NUD.ValueChanged += new System.EventHandler(this.ct_spiritomb_players_NUD_ValueChanged);
            // 
            // ct_spiritomb_visible_CB
            // 
            this.ct_spiritomb_visible_CB.AutoSize = true;
            this.ct_spiritomb_visible_CB.Location = new System.Drawing.Point(80, 58);
            this.ct_spiritomb_visible_CB.Name = "ct_spiritomb_visible_CB";
            this.ct_spiritomb_visible_CB.Size = new System.Drawing.Size(56, 17);
            this.ct_spiritomb_visible_CB.TabIndex = 9;
            this.ct_spiritomb_visible_CB.Text = "Visible";
            this.ct_spiritomb_visible_CB.UseVisualStyleBackColor = true;
            this.ct_spiritomb_visible_CB.CheckedChanged += new System.EventHandler(this.ct_spiritomb_visible_CB_CheckedChanged);
            // 
            // ct_spiritomb_PB
            // 
            this.ct_spiritomb_PB.Caught = false;
            this.ct_spiritomb_PB.DrawDynaxMaxIcon = false;
            this.ct_spiritomb_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_spiritomb_PB.Location = new System.Drawing.Point(6, 19);
            this.ct_spiritomb_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_spiritomb_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_spiritomb_PB.Name = "ct_spiritomb_PB";
            this.ct_spiritomb_PB.Pokemon = 442;
            this.ct_spiritomb_PB.PokemonName = "Spiritomb";
            this.ct_spiritomb_PB.PokemonSubform = "";
            this.ct_spiritomb_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_spiritomb_PB.TabIndex = 8;
            this.ct_spiritomb_PB.ToolTip = "";
            this.ct_spiritomb_PB.LegaliltyCheck_OnClick += new System.EventHandler(this.ct_spiritomb_PB_LegaliltyCheck_OnClick);
            this.ct_spiritomb_PB.Caught_OnClick += new System.EventHandler(this.ct_spiritomb_PB_Caught_OnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ct_gmoltres_PB);
            this.groupBox1.Controls.Add(this.ct_birds_uncaughtBTN);
            this.groupBox1.Controls.Add(this.ct_birds_caughtBTN);
            this.groupBox1.Controls.Add(this.ct_gzapdos_PB);
            this.groupBox1.Controls.Add(this.ct_garticuno_PB);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galarian Birds";
            // 
            // ct_gmoltres_PB
            // 
            this.ct_gmoltres_PB.Caught = false;
            this.ct_gmoltres_PB.DrawDynaxMaxIcon = false;
            this.ct_gmoltres_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_gmoltres_PB.Location = new System.Drawing.Point(6, 175);
            this.ct_gmoltres_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_gmoltres_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_gmoltres_PB.Name = "ct_gmoltres_PB";
            this.ct_gmoltres_PB.Pokemon = 146;
            this.ct_gmoltres_PB.PokemonName = "Galarian Moltres";
            this.ct_gmoltres_PB.PokemonSubform = "1";
            this.ct_gmoltres_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_gmoltres_PB.TabIndex = 7;
            this.ct_gmoltres_PB.ToolTip = "";
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
            // ct_gzapdos_PB
            // 
            this.ct_gzapdos_PB.Caught = false;
            this.ct_gzapdos_PB.DrawDynaxMaxIcon = false;
            this.ct_gzapdos_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_gzapdos_PB.Location = new System.Drawing.Point(6, 97);
            this.ct_gzapdos_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_gzapdos_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_gzapdos_PB.Name = "ct_gzapdos_PB";
            this.ct_gzapdos_PB.Pokemon = 145;
            this.ct_gzapdos_PB.PokemonName = "Galarian Zapdos";
            this.ct_gzapdos_PB.PokemonSubform = "1";
            this.ct_gzapdos_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_gzapdos_PB.TabIndex = 6;
            this.ct_gzapdos_PB.ToolTip = "";
            // 
            // ct_garticuno_PB
            // 
            this.ct_garticuno_PB.Caught = false;
            this.ct_garticuno_PB.DrawDynaxMaxIcon = false;
            this.ct_garticuno_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_garticuno_PB.Location = new System.Drawing.Point(6, 19);
            this.ct_garticuno_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_garticuno_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_garticuno_PB.Name = "ct_garticuno_PB";
            this.ct_garticuno_PB.Pokemon = 144;
            this.ct_garticuno_PB.PokemonName = "Galarian Articuno";
            this.ct_garticuno_PB.PokemonSubform = "1";
            this.ct_garticuno_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_garticuno_PB.TabIndex = 5;
            this.ct_garticuno_PB.ToolTip = "";
            // 
            // ct_giftcosmog_PB
            // 
            this.ct_giftcosmog_PB.Caught = false;
            this.ct_giftcosmog_PB.DrawDynaxMaxIcon = false;
            this.ct_giftcosmog_PB.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Legal;
            this.ct_giftcosmog_PB.Location = new System.Drawing.Point(467, 6);
            this.ct_giftcosmog_PB.MaximumSize = new System.Drawing.Size(130, 72);
            this.ct_giftcosmog_PB.MinimumSize = new System.Drawing.Size(130, 72);
            this.ct_giftcosmog_PB.Name = "ct_giftcosmog_PB";
            this.ct_giftcosmog_PB.Pokemon = 789;
            this.ct_giftcosmog_PB.PokemonName = "Cosmog (Fwoofy) Gift";
            this.ct_giftcosmog_PB.PokemonSubform = "";
            this.ct_giftcosmog_PB.Size = new System.Drawing.Size(130, 72);
            this.ct_giftcosmog_PB.TabIndex = 6;
            this.ct_giftcosmog_PB.ToolTip = "";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.main_gift_gcharmander_PB);
            this.groupBox5.Controls.Add(this.main_gift_typenull_PB);
            this.groupBox5.Location = new System.Drawing.Point(255, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 200);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Champion Gifts";
            // 
            // pokemonBaseUC7
            // 
            this.pokemonBaseUC7.Caught = false;
            this.pokemonBaseUC7.DrawDynaxMaxIcon = true;
            this.pokemonBaseUC7.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Illegal;
            this.pokemonBaseUC7.Location = new System.Drawing.Point(6, 97);
            this.pokemonBaseUC7.MaximumSize = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC7.MinimumSize = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC7.Name = "pokemonBaseUC7";
            this.pokemonBaseUC7.Pokemon = 7;
            this.pokemonBaseUC7.PokemonName = "Gigantmax Bulbasaur Gift";
            this.pokemonBaseUC7.PokemonSubform = "";
            this.pokemonBaseUC7.Size = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC7.TabIndex = 24;
            this.pokemonBaseUC7.ToolTip = "";
            // 
            // pokemonBaseUC8
            // 
            this.pokemonBaseUC8.Caught = false;
            this.pokemonBaseUC8.DrawDynaxMaxIcon = true;
            this.pokemonBaseUC8.Legalility = DynamaxAdventureReset.Controls.PokemonRenderUC.LegalStatus.Illegal;
            this.pokemonBaseUC8.Location = new System.Drawing.Point(6, 19);
            this.pokemonBaseUC8.MaximumSize = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC8.MinimumSize = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC8.Name = "pokemonBaseUC8";
            this.pokemonBaseUC8.Pokemon = 1;
            this.pokemonBaseUC8.PokemonName = "Gigantmax Bulbasaur Gift";
            this.pokemonBaseUC8.PokemonSubform = "";
            this.pokemonBaseUC8.Size = new System.Drawing.Size(130, 72);
            this.pokemonBaseUC8.TabIndex = 23;
            this.pokemonBaseUC8.ToolTip = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Page not done yet! TODO!";
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
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_spiritomb_players_NUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_applyBTN;
        private Controls.PokemonBaseUC ct_spiritomb_PB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ct_spiritomb_visible_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ct_spiritomb_players_NUD;
        private System.Windows.Forms.CheckBox ct_spiritomb_forcelegal_CB;
        private Controls.PokemonBaseUC main_gpikachu_PB;
        private Controls.PokemonBaseUC main_geevee_PB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox main_eevee_save_data_CB;
        private System.Windows.Forms.CheckBox main_letsgo_forcelegal_CB;
        private System.Windows.Forms.CheckBox main_pikachu_save_data_CB;
        private Controls.PokemonBaseUC main_gift_typenull_PB;
        private Controls.PokemonBaseUC main_gift_gcharmander_PB;
        private Controls.PokemonBaseUC ct_gift_poipole_PB;
        private Controls.PokemonBaseUC main_gift_toxel_PB;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls.PokemonBaseUC pokemonBaseUC7;
        private Controls.PokemonBaseUC pokemonBaseUC8;
        private System.Windows.Forms.Label label3;
    }
}