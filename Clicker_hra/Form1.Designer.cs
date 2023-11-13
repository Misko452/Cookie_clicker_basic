namespace Clicker_hra
{
    partial class Main_hra
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_hra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelpocet = new System.Windows.Forms.Label();
            this.buttonshop = new System.Windows.Forms.Button();
            this.labelbabistaPopis = new System.Windows.Forms.Label();
            this.buttonpridejbabushku = new System.Windows.Forms.Button();
            this.pocet_babushek = new System.Windows.Forms.Label();
            this.Generator = new System.Windows.Forms.Timer(this.components);
            this.pocet_nasobicu = new System.Windows.Forms.Label();
            this.pridejNasobic = new System.Windows.Forms.Button();
            this.PopisNasobice = new System.Windows.Forms.Label();
            this.Pocetrobotu = new System.Windows.Forms.Label();
            this.buttonrobot = new System.Windows.Forms.Button();
            this.Robotpopis = new System.Windows.Forms.Label();
            this.labelrychlostautomatizace = new System.Windows.Forms.Label();
            this.pocetPlanet = new System.Windows.Forms.Label();
            this.buttonPlanet = new System.Windows.Forms.Button();
            this.labelPlanet = new System.Windows.Forms.Label();
            this.TovarnaPocet = new System.Windows.Forms.Label();
            this.buttonTovarna = new System.Windows.Forms.Button();
            this.labelTovarnaPopis = new System.Windows.Forms.Label();
            this.PocetChernobyl = new System.Windows.Forms.Label();
            this.buttonCHernobyl = new System.Windows.Forms.Button();
            this.labelCherobyl = new System.Windows.Forms.Label();
            this.pocetHvezda = new System.Windows.Forms.Label();
            this.buttonhvezda = new System.Windows.Forms.Button();
            this.labelHvezda = new System.Windows.Forms.Label();
            this.PocetFarem = new System.Windows.Forms.Label();
            this.buttonFarma = new System.Windows.Forms.Button();
            this.labelFarmaPopis = new System.Windows.Forms.Label();
            this.MuskPocet = new System.Windows.Forms.Label();
            this.buttonMusk = new System.Windows.Forms.Button();
            this.labelMusk = new System.Windows.Forms.Label();
            this.ClonePocet = new System.Windows.Forms.Label();
            this.buttonClone = new System.Windows.Forms.Button();
            this.labelClone = new System.Windows.Forms.Label();
            this.pocetAlien = new System.Windows.Forms.Label();
            this.buttonAlien = new System.Windows.Forms.Button();
            this.labelAlien = new System.Windows.Forms.Label();
            this.pocetGalaxie = new System.Windows.Forms.Label();
            this.buttonGalaxie = new System.Windows.Forms.Button();
            this.labelGalaxie = new System.Windows.Forms.Label();
            this.pocetBuh = new System.Windows.Forms.Label();
            this.buttonBuh = new System.Windows.Forms.Button();
            this.labelBuh = new System.Windows.Forms.Label();
            this.pocetPolobuh = new System.Windows.Forms.Label();
            this.buttonPolobuh = new System.Windows.Forms.Button();
            this.labelPolobuh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clicker_hra.Properties.Resources.Cookie;
            this.pictureBox1.Location = new System.Drawing.Point(-68, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelpocet
            // 
            this.labelpocet.AutoSize = true;
            this.labelpocet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpocet.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpocet.Location = new System.Drawing.Point(12, 384);
            this.labelpocet.Name = "labelpocet";
            this.labelpocet.Size = new System.Drawing.Size(335, 44);
            this.labelpocet.TabIndex = 1;
            this.labelpocet.Text = "Počet sušenek: 0 ";
            // 
            // buttonshop
            // 
            this.buttonshop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonshop.Location = new System.Drawing.Point(12, 444);
            this.buttonshop.Name = "buttonshop";
            this.buttonshop.Size = new System.Drawing.Size(395, 50);
            this.buttonshop.TabIndex = 2;
            this.buttonshop.Text = "Shop";
            this.buttonshop.UseVisualStyleBackColor = false;
            this.buttonshop.Click += new System.EventHandler(this.buttonshop_Click);
            this.buttonshop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonshop_KeyPress);
            // 
            // labelbabistaPopis
            // 
            this.labelbabistaPopis.AutoSize = true;
            this.labelbabistaPopis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbabistaPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelbabistaPopis.Location = new System.Drawing.Point(494, 47);
            this.labelbabistaPopis.Name = "labelbabistaPopis";
            this.labelbabistaPopis.Size = new System.Drawing.Size(230, 27);
            this.labelbabistaPopis.TabIndex = 3;
            this.labelbabistaPopis.Text = "Babushka pekařka: 50";
            this.labelbabistaPopis.Visible = false;
            this.labelbabistaPopis.Click += new System.EventHandler(this.labelbabistaPopis_Click);
            // 
            // buttonpridejbabushku
            // 
            this.buttonpridejbabushku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonpridejbabushku.Location = new System.Drawing.Point(971, 43);
            this.buttonpridejbabushku.Name = "buttonpridejbabushku";
            this.buttonpridejbabushku.Size = new System.Drawing.Size(41, 33);
            this.buttonpridejbabushku.TabIndex = 4;
            this.buttonpridejbabushku.Text = "+";
            this.buttonpridejbabushku.UseVisualStyleBackColor = true;
            this.buttonpridejbabushku.Visible = false;
            this.buttonpridejbabushku.Click += new System.EventHandler(this.buttonpridejbabushku_Click);
            // 
            // pocet_babushek
            // 
            this.pocet_babushek.AutoSize = true;
            this.pocet_babushek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_babushek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocet_babushek.Location = new System.Drawing.Point(1029, 47);
            this.pocet_babushek.Name = "pocet_babushek";
            this.pocet_babushek.Size = new System.Drawing.Size(26, 27);
            this.pocet_babushek.TabIndex = 5;
            this.pocet_babushek.Text = "0";
            this.pocet_babushek.Visible = false;
            // 
            // Generator
            // 
            this.Generator.Interval = 1000;
            this.Generator.Tick += new System.EventHandler(this.Generator_Tick);
            // 
            // pocet_nasobicu
            // 
            this.pocet_nasobicu.AutoSize = true;
            this.pocet_nasobicu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocet_nasobicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocet_nasobicu.Location = new System.Drawing.Point(1029, 9);
            this.pocet_nasobicu.Name = "pocet_nasobicu";
            this.pocet_nasobicu.Size = new System.Drawing.Size(26, 27);
            this.pocet_nasobicu.TabIndex = 8;
            this.pocet_nasobicu.Text = "0";
            this.pocet_nasobicu.Visible = false;
            // 
            // pridejNasobic
            // 
            this.pridejNasobic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridejNasobic.Location = new System.Drawing.Point(971, 5);
            this.pridejNasobic.Name = "pridejNasobic";
            this.pridejNasobic.Size = new System.Drawing.Size(41, 33);
            this.pridejNasobic.TabIndex = 7;
            this.pridejNasobic.Text = "+";
            this.pridejNasobic.UseVisualStyleBackColor = true;
            this.pridejNasobic.Visible = false;
            this.pridejNasobic.Click += new System.EventHandler(this.pridejNasobic_Click);
            // 
            // PopisNasobice
            // 
            this.PopisNasobice.AutoSize = true;
            this.PopisNasobice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopisNasobice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PopisNasobice.Location = new System.Drawing.Point(494, 9);
            this.PopisNasobice.Name = "PopisNasobice";
            this.PopisNasobice.Size = new System.Drawing.Size(237, 27);
            this.PopisNasobice.TabIndex = 6;
            this.PopisNasobice.Text = "Sušenky za kliknutí: 10\r\n";
            this.PopisNasobice.Visible = false;
            this.PopisNasobice.Click += new System.EventHandler(this.PopisNasobice_Click);
            // 
            // Pocetrobotu
            // 
            this.Pocetrobotu.AutoSize = true;
            this.Pocetrobotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pocetrobotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pocetrobotu.Location = new System.Drawing.Point(1029, 84);
            this.Pocetrobotu.Name = "Pocetrobotu";
            this.Pocetrobotu.Size = new System.Drawing.Size(26, 27);
            this.Pocetrobotu.TabIndex = 11;
            this.Pocetrobotu.Text = "0";
            this.Pocetrobotu.Visible = false;
            // 
            // buttonrobot
            // 
            this.buttonrobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonrobot.Location = new System.Drawing.Point(971, 80);
            this.buttonrobot.Name = "buttonrobot";
            this.buttonrobot.Size = new System.Drawing.Size(41, 33);
            this.buttonrobot.TabIndex = 10;
            this.buttonrobot.Text = "+";
            this.buttonrobot.UseVisualStyleBackColor = true;
            this.buttonrobot.Visible = false;
            this.buttonrobot.Click += new System.EventHandler(this.buttonrobot_Click);
            // 
            // Robotpopis
            // 
            this.Robotpopis.AutoSize = true;
            this.Robotpopis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Robotpopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Robotpopis.Location = new System.Drawing.Point(494, 84);
            this.Robotpopis.Name = "Robotpopis";
            this.Robotpopis.Size = new System.Drawing.Size(176, 27);
            this.Robotpopis.TabIndex = 9;
            this.Robotpopis.Text = "Pečící robot: 150";
            this.Robotpopis.Visible = false;
            // 
            // labelrychlostautomatizace
            // 
            this.labelrychlostautomatizace.AutoSize = true;
            this.labelrychlostautomatizace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelrychlostautomatizace.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelrychlostautomatizace.Location = new System.Drawing.Point(12, 497);
            this.labelrychlostautomatizace.Name = "labelrychlostautomatizace";
            this.labelrychlostautomatizace.Size = new System.Drawing.Size(210, 44);
            this.labelrychlostautomatizace.TabIndex = 12;
            this.labelrychlostautomatizace.Text = " sušenek/s";
            // 
            // pocetPlanet
            // 
            this.pocetPlanet.AutoSize = true;
            this.pocetPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetPlanet.Location = new System.Drawing.Point(1029, 275);
            this.pocetPlanet.Name = "pocetPlanet";
            this.pocetPlanet.Size = new System.Drawing.Size(26, 27);
            this.pocetPlanet.TabIndex = 21;
            this.pocetPlanet.Text = "0";
            this.pocetPlanet.Visible = false;
            // 
            // buttonPlanet
            // 
            this.buttonPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlanet.Location = new System.Drawing.Point(971, 271);
            this.buttonPlanet.Name = "buttonPlanet";
            this.buttonPlanet.Size = new System.Drawing.Size(41, 33);
            this.buttonPlanet.TabIndex = 20;
            this.buttonPlanet.Text = "+";
            this.buttonPlanet.UseVisualStyleBackColor = true;
            this.buttonPlanet.Visible = false;
            this.buttonPlanet.Click += new System.EventHandler(this.buttonPlanet_Click);
            // 
            // labelPlanet
            // 
            this.labelPlanet.AutoSize = true;
            this.labelPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlanet.Location = new System.Drawing.Point(494, 275);
            this.labelPlanet.Name = "labelPlanet";
            this.labelPlanet.Size = new System.Drawing.Size(275, 27);
            this.labelPlanet.TabIndex = 19;
            this.labelPlanet.Text = "Multiplanet. produkce: 20M";
            this.labelPlanet.Visible = false;
            // 
            // TovarnaPocet
            // 
            this.TovarnaPocet.AutoSize = true;
            this.TovarnaPocet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TovarnaPocet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TovarnaPocet.Location = new System.Drawing.Point(1029, 159);
            this.TovarnaPocet.Name = "TovarnaPocet";
            this.TovarnaPocet.Size = new System.Drawing.Size(26, 27);
            this.TovarnaPocet.TabIndex = 18;
            this.TovarnaPocet.Text = "0";
            this.TovarnaPocet.Visible = false;
            // 
            // buttonTovarna
            // 
            this.buttonTovarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTovarna.Location = new System.Drawing.Point(971, 155);
            this.buttonTovarna.Name = "buttonTovarna";
            this.buttonTovarna.Size = new System.Drawing.Size(41, 33);
            this.buttonTovarna.TabIndex = 17;
            this.buttonTovarna.Text = "+";
            this.buttonTovarna.UseVisualStyleBackColor = true;
            this.buttonTovarna.Visible = false;
            this.buttonTovarna.Click += new System.EventHandler(this.buttonTovarna_Click);
            // 
            // labelTovarnaPopis
            // 
            this.labelTovarnaPopis.AutoSize = true;
            this.labelTovarnaPopis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTovarnaPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTovarnaPopis.Location = new System.Drawing.Point(494, 159);
            this.labelTovarnaPopis.Name = "labelTovarnaPopis";
            this.labelTovarnaPopis.Size = new System.Drawing.Size(146, 27);
            this.labelTovarnaPopis.TabIndex = 16;
            this.labelTovarnaPopis.Text = "Továrna: 30K";
            this.labelTovarnaPopis.Visible = false;
            // 
            // PocetChernobyl
            // 
            this.PocetChernobyl.AutoSize = true;
            this.PocetChernobyl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PocetChernobyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PocetChernobyl.Location = new System.Drawing.Point(1029, 197);
            this.PocetChernobyl.Name = "PocetChernobyl";
            this.PocetChernobyl.Size = new System.Drawing.Size(26, 27);
            this.PocetChernobyl.TabIndex = 15;
            this.PocetChernobyl.Text = "0";
            this.PocetChernobyl.Visible = false;
            // 
            // buttonCHernobyl
            // 
            this.buttonCHernobyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCHernobyl.Location = new System.Drawing.Point(971, 193);
            this.buttonCHernobyl.Name = "buttonCHernobyl";
            this.buttonCHernobyl.Size = new System.Drawing.Size(41, 33);
            this.buttonCHernobyl.TabIndex = 14;
            this.buttonCHernobyl.Text = "+";
            this.buttonCHernobyl.UseVisualStyleBackColor = true;
            this.buttonCHernobyl.Visible = false;
            this.buttonCHernobyl.Click += new System.EventHandler(this.buttonCHernobyl_Click);
            // 
            // labelCherobyl
            // 
            this.labelCherobyl.AutoSize = true;
            this.labelCherobyl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCherobyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCherobyl.Location = new System.Drawing.Point(494, 197);
            this.labelCherobyl.Name = "labelCherobyl";
            this.labelCherobyl.Size = new System.Drawing.Size(296, 27);
            this.labelCherobyl.TabIndex = 13;
            this.labelCherobyl.Text = "Sušenky z Chernobylu: 300K\r\n";
            this.labelCherobyl.Visible = false;
            // 
            // pocetHvezda
            // 
            this.pocetHvezda.AutoSize = true;
            this.pocetHvezda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetHvezda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetHvezda.Location = new System.Drawing.Point(1029, 314);
            this.pocetHvezda.Name = "pocetHvezda";
            this.pocetHvezda.Size = new System.Drawing.Size(26, 27);
            this.pocetHvezda.TabIndex = 30;
            this.pocetHvezda.Text = "0";
            this.pocetHvezda.Visible = false;
            // 
            // buttonhvezda
            // 
            this.buttonhvezda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonhvezda.Location = new System.Drawing.Point(971, 310);
            this.buttonhvezda.Name = "buttonhvezda";
            this.buttonhvezda.Size = new System.Drawing.Size(41, 33);
            this.buttonhvezda.TabIndex = 29;
            this.buttonhvezda.Text = "+";
            this.buttonhvezda.UseVisualStyleBackColor = true;
            this.buttonhvezda.Visible = false;
            this.buttonhvezda.Click += new System.EventHandler(this.buttonhvezda_Click);
            // 
            // labelHvezda
            // 
            this.labelHvezda.AutoSize = true;
            this.labelHvezda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHvezda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHvezda.Location = new System.Drawing.Point(494, 314);
            this.labelHvezda.Name = "labelHvezda";
            this.labelHvezda.Size = new System.Drawing.Size(241, 27);
            this.labelHvezda.TabIndex = 28;
            this.labelHvezda.Text = "Hvězda sušenek: 100M\r\n";
            this.labelHvezda.Visible = false;
            // 
            // PocetFarem
            // 
            this.PocetFarem.AutoSize = true;
            this.PocetFarem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PocetFarem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PocetFarem.Location = new System.Drawing.Point(1029, 122);
            this.PocetFarem.Name = "PocetFarem";
            this.PocetFarem.Size = new System.Drawing.Size(26, 27);
            this.PocetFarem.TabIndex = 27;
            this.PocetFarem.Text = "0";
            this.PocetFarem.Visible = false;
            // 
            // buttonFarma
            // 
            this.buttonFarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFarma.Location = new System.Drawing.Point(971, 118);
            this.buttonFarma.Name = "buttonFarma";
            this.buttonFarma.Size = new System.Drawing.Size(41, 33);
            this.buttonFarma.TabIndex = 26;
            this.buttonFarma.Text = "+";
            this.buttonFarma.UseVisualStyleBackColor = true;
            this.buttonFarma.Visible = false;
            this.buttonFarma.Click += new System.EventHandler(this.buttonFarma_Click);
            // 
            // labelFarmaPopis
            // 
            this.labelFarmaPopis.AutoSize = true;
            this.labelFarmaPopis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFarmaPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFarmaPopis.Location = new System.Drawing.Point(494, 122);
            this.labelFarmaPopis.Name = "labelFarmaPopis";
            this.labelFarmaPopis.Size = new System.Drawing.Size(231, 27);
            this.labelFarmaPopis.TabIndex = 25;
            this.labelFarmaPopis.Text = "Farma na sušenky: 1K";
            this.labelFarmaPopis.Visible = false;
            // 
            // MuskPocet
            // 
            this.MuskPocet.AutoSize = true;
            this.MuskPocet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MuskPocet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MuskPocet.Location = new System.Drawing.Point(1029, 237);
            this.MuskPocet.Name = "MuskPocet";
            this.MuskPocet.Size = new System.Drawing.Size(26, 27);
            this.MuskPocet.TabIndex = 24;
            this.MuskPocet.Text = "0";
            this.MuskPocet.Visible = false;
            // 
            // buttonMusk
            // 
            this.buttonMusk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMusk.Location = new System.Drawing.Point(971, 233);
            this.buttonMusk.Name = "buttonMusk";
            this.buttonMusk.Size = new System.Drawing.Size(41, 33);
            this.buttonMusk.TabIndex = 23;
            this.buttonMusk.Text = "+";
            this.buttonMusk.UseVisualStyleBackColor = true;
            this.buttonMusk.Visible = false;
            this.buttonMusk.Click += new System.EventHandler(this.buttonMusk_Click);
            // 
            // labelMusk
            // 
            this.labelMusk.AutoSize = true;
            this.labelMusk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMusk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMusk.Location = new System.Drawing.Point(494, 237);
            this.labelMusk.Name = "labelMusk";
            this.labelMusk.Size = new System.Drawing.Size(327, 27);
            this.labelMusk.TabIndex = 22;
            this.labelMusk.Text = "Odkoupení Elonem Muskem: 1M";
            this.labelMusk.Visible = false;
            // 
            // ClonePocet
            // 
            this.ClonePocet.AutoSize = true;
            this.ClonePocet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClonePocet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClonePocet.Location = new System.Drawing.Point(1029, 417);
            this.ClonePocet.Name = "ClonePocet";
            this.ClonePocet.Size = new System.Drawing.Size(26, 27);
            this.ClonePocet.TabIndex = 39;
            this.ClonePocet.Text = "0";
            this.ClonePocet.Visible = false;
            // 
            // buttonClone
            // 
            this.buttonClone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClone.Location = new System.Drawing.Point(971, 417);
            this.buttonClone.Name = "buttonClone";
            this.buttonClone.Size = new System.Drawing.Size(41, 33);
            this.buttonClone.TabIndex = 38;
            this.buttonClone.Text = "+";
            this.buttonClone.UseVisualStyleBackColor = true;
            this.buttonClone.Visible = false;
            this.buttonClone.Click += new System.EventHandler(this.buttonClone_Click);
            // 
            // labelClone
            // 
            this.labelClone.AutoSize = true;
            this.labelClone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClone.Location = new System.Drawing.Point(494, 421);
            this.labelClone.Name = "labelClone";
            this.labelClone.Size = new System.Drawing.Size(246, 27);
            this.labelClone.TabIndex = 37;
            this.labelClone.Text = "Cookie klonovač: 50Mld\r\n";
            this.labelClone.Visible = false;
            // 
            // pocetAlien
            // 
            this.pocetAlien.AutoSize = true;
            this.pocetAlien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetAlien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetAlien.Location = new System.Drawing.Point(1029, 347);
            this.pocetAlien.Name = "pocetAlien";
            this.pocetAlien.Size = new System.Drawing.Size(26, 27);
            this.pocetAlien.TabIndex = 36;
            this.pocetAlien.Text = "0";
            this.pocetAlien.Visible = false;
            // 
            // buttonAlien
            // 
            this.buttonAlien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAlien.Location = new System.Drawing.Point(971, 347);
            this.buttonAlien.Name = "buttonAlien";
            this.buttonAlien.Size = new System.Drawing.Size(41, 33);
            this.buttonAlien.TabIndex = 35;
            this.buttonAlien.Text = "+";
            this.buttonAlien.UseVisualStyleBackColor = true;
            this.buttonAlien.Visible = false;
            this.buttonAlien.Click += new System.EventHandler(this.buttonAlien_Click);
            // 
            // labelAlien
            // 
            this.labelAlien.AutoSize = true;
            this.labelAlien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlien.Location = new System.Drawing.Point(494, 351);
            this.labelAlien.Name = "labelAlien";
            this.labelAlien.Size = new System.Drawing.Size(334, 27);
            this.labelAlien.TabIndex = 34;
            this.labelAlien.Text = "Mimozemská pracovní síla: 500M";
            this.labelAlien.Visible = false;
            // 
            // pocetGalaxie
            // 
            this.pocetGalaxie.AutoSize = true;
            this.pocetGalaxie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetGalaxie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetGalaxie.Location = new System.Drawing.Point(1029, 382);
            this.pocetGalaxie.Name = "pocetGalaxie";
            this.pocetGalaxie.Size = new System.Drawing.Size(26, 27);
            this.pocetGalaxie.TabIndex = 33;
            this.pocetGalaxie.Text = "0";
            this.pocetGalaxie.Visible = false;
            // 
            // buttonGalaxie
            // 
            this.buttonGalaxie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGalaxie.Location = new System.Drawing.Point(971, 382);
            this.buttonGalaxie.Name = "buttonGalaxie";
            this.buttonGalaxie.Size = new System.Drawing.Size(41, 33);
            this.buttonGalaxie.TabIndex = 32;
            this.buttonGalaxie.Text = "+";
            this.buttonGalaxie.UseVisualStyleBackColor = true;
            this.buttonGalaxie.Visible = false;
            this.buttonGalaxie.Click += new System.EventHandler(this.buttonGalaxie_Click);
            // 
            // labelGalaxie
            // 
            this.labelGalaxie.AutoSize = true;
            this.labelGalaxie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGalaxie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGalaxie.Location = new System.Drawing.Point(494, 386);
            this.labelGalaxie.Name = "labelGalaxie";
            this.labelGalaxie.Size = new System.Drawing.Size(387, 27);
            this.labelGalaxie.TabIndex = 31;
            this.labelGalaxie.Text = "Sušenková multigalxiální kolonie: 1Mld";
            this.labelGalaxie.Visible = false;
            // 
            // pocetBuh
            // 
            this.pocetBuh.AutoSize = true;
            this.pocetBuh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetBuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetBuh.Location = new System.Drawing.Point(1029, 485);
            this.pocetBuh.Name = "pocetBuh";
            this.pocetBuh.Size = new System.Drawing.Size(26, 27);
            this.pocetBuh.TabIndex = 45;
            this.pocetBuh.Text = "0";
            this.pocetBuh.Visible = false;
            // 
            // buttonBuh
            // 
            this.buttonBuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuh.Location = new System.Drawing.Point(971, 486);
            this.buttonBuh.Name = "buttonBuh";
            this.buttonBuh.Size = new System.Drawing.Size(41, 33);
            this.buttonBuh.TabIndex = 44;
            this.buttonBuh.Text = "+";
            this.buttonBuh.UseVisualStyleBackColor = true;
            this.buttonBuh.Visible = false;
            this.buttonBuh.Click += new System.EventHandler(this.buttonBuh_Click);
            // 
            // labelBuh
            // 
            this.labelBuh.AutoSize = true;
            this.labelBuh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuh.Location = new System.Drawing.Point(494, 489);
            this.labelBuh.Name = "labelBuh";
            this.labelBuh.Size = new System.Drawing.Size(202, 27);
            this.labelBuh.TabIndex = 43;
            this.labelBuh.Text = "Sušenkový bůh: 1B\r\n";
            this.labelBuh.Visible = false;
            // 
            // pocetPolobuh
            // 
            this.pocetPolobuh.AutoSize = true;
            this.pocetPolobuh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pocetPolobuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetPolobuh.Location = new System.Drawing.Point(1029, 450);
            this.pocetPolobuh.Name = "pocetPolobuh";
            this.pocetPolobuh.Size = new System.Drawing.Size(26, 27);
            this.pocetPolobuh.TabIndex = 42;
            this.pocetPolobuh.Text = "0";
            this.pocetPolobuh.Visible = false;
            // 
            // buttonPolobuh
            // 
            this.buttonPolobuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPolobuh.Location = new System.Drawing.Point(971, 450);
            this.buttonPolobuh.Name = "buttonPolobuh";
            this.buttonPolobuh.Size = new System.Drawing.Size(41, 33);
            this.buttonPolobuh.TabIndex = 41;
            this.buttonPolobuh.Text = "+";
            this.buttonPolobuh.UseVisualStyleBackColor = true;
            this.buttonPolobuh.Visible = false;
            this.buttonPolobuh.Click += new System.EventHandler(this.buttonPolobuh_Click);
            // 
            // labelPolobuh
            // 
            this.labelPolobuh.AutoSize = true;
            this.labelPolobuh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPolobuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPolobuh.Location = new System.Drawing.Point(494, 454);
            this.labelPolobuh.Name = "labelPolobuh";
            this.labelPolobuh.Size = new System.Drawing.Size(288, 27);
            this.labelPolobuh.TabIndex = 40;
            this.labelPolobuh.Text = "Sušenkový polobůh: 200Mld";
            this.labelPolobuh.Visible = false;
            // 
            // Main_hra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 556);
            this.Controls.Add(this.pocetBuh);
            this.Controls.Add(this.buttonBuh);
            this.Controls.Add(this.labelBuh);
            this.Controls.Add(this.pocetPolobuh);
            this.Controls.Add(this.buttonPolobuh);
            this.Controls.Add(this.labelPolobuh);
            this.Controls.Add(this.ClonePocet);
            this.Controls.Add(this.buttonClone);
            this.Controls.Add(this.labelClone);
            this.Controls.Add(this.pocetAlien);
            this.Controls.Add(this.buttonAlien);
            this.Controls.Add(this.labelAlien);
            this.Controls.Add(this.pocetGalaxie);
            this.Controls.Add(this.buttonGalaxie);
            this.Controls.Add(this.labelGalaxie);
            this.Controls.Add(this.pocetHvezda);
            this.Controls.Add(this.buttonhvezda);
            this.Controls.Add(this.labelHvezda);
            this.Controls.Add(this.PocetFarem);
            this.Controls.Add(this.buttonFarma);
            this.Controls.Add(this.labelFarmaPopis);
            this.Controls.Add(this.MuskPocet);
            this.Controls.Add(this.buttonMusk);
            this.Controls.Add(this.labelMusk);
            this.Controls.Add(this.pocetPlanet);
            this.Controls.Add(this.buttonPlanet);
            this.Controls.Add(this.labelPlanet);
            this.Controls.Add(this.TovarnaPocet);
            this.Controls.Add(this.buttonTovarna);
            this.Controls.Add(this.labelTovarnaPopis);
            this.Controls.Add(this.PocetChernobyl);
            this.Controls.Add(this.buttonCHernobyl);
            this.Controls.Add(this.labelCherobyl);
            this.Controls.Add(this.labelrychlostautomatizace);
            this.Controls.Add(this.Pocetrobotu);
            this.Controls.Add(this.buttonrobot);
            this.Controls.Add(this.Robotpopis);
            this.Controls.Add(this.pocet_nasobicu);
            this.Controls.Add(this.pridejNasobic);
            this.Controls.Add(this.PopisNasobice);
            this.Controls.Add(this.pocet_babushek);
            this.Controls.Add(this.buttonpridejbabushku);
            this.Controls.Add(this.labelbabistaPopis);
            this.Controls.Add(this.buttonshop);
            this.Controls.Add(this.labelpocet);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_hra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tvořič zánětu karpálních tunelů";
            this.Click += new System.EventHandler(this.Main_hra_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_hra_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelpocet;
        private System.Windows.Forms.Button buttonshop;
        private System.Windows.Forms.Label labelbabistaPopis;
        private System.Windows.Forms.Button buttonpridejbabushku;
        private System.Windows.Forms.Label pocet_babushek;
        private System.Windows.Forms.Timer Generator;
        private System.Windows.Forms.Label pocet_nasobicu;
        private System.Windows.Forms.Button pridejNasobic;
        private System.Windows.Forms.Label PopisNasobice;
        private System.Windows.Forms.Label Pocetrobotu;
        private System.Windows.Forms.Button buttonrobot;
        private System.Windows.Forms.Label Robotpopis;
        private System.Windows.Forms.Label labelrychlostautomatizace;
        private System.Windows.Forms.Label pocetPlanet;
        private System.Windows.Forms.Button buttonPlanet;
        private System.Windows.Forms.Label labelPlanet;
        private System.Windows.Forms.Label TovarnaPocet;
        private System.Windows.Forms.Button buttonTovarna;
        private System.Windows.Forms.Label labelTovarnaPopis;
        private System.Windows.Forms.Label PocetChernobyl;
        private System.Windows.Forms.Button buttonCHernobyl;
        private System.Windows.Forms.Label labelCherobyl;
        private System.Windows.Forms.Label pocetHvezda;
        private System.Windows.Forms.Button buttonhvezda;
        private System.Windows.Forms.Label labelHvezda;
        private System.Windows.Forms.Label PocetFarem;
        private System.Windows.Forms.Button buttonFarma;
        private System.Windows.Forms.Label labelFarmaPopis;
        private System.Windows.Forms.Label MuskPocet;
        private System.Windows.Forms.Button buttonMusk;
        private System.Windows.Forms.Label labelMusk;
        private System.Windows.Forms.Label ClonePocet;
        private System.Windows.Forms.Button buttonClone;
        private System.Windows.Forms.Label labelClone;
        private System.Windows.Forms.Label pocetAlien;
        private System.Windows.Forms.Button buttonAlien;
        private System.Windows.Forms.Label labelAlien;
        private System.Windows.Forms.Label pocetGalaxie;
        private System.Windows.Forms.Button buttonGalaxie;
        private System.Windows.Forms.Label labelGalaxie;
        private System.Windows.Forms.Label pocetBuh;
        private System.Windows.Forms.Button buttonBuh;
        private System.Windows.Forms.Label labelBuh;
        private System.Windows.Forms.Label pocetPolobuh;
        private System.Windows.Forms.Button buttonPolobuh;
        private System.Windows.Forms.Label labelPolobuh;
    }
}

