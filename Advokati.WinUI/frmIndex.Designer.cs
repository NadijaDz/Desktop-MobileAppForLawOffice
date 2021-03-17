namespace Advokati.WinUI
{
    partial class frmIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmPredmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRocista = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoRočišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRadniSati = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviRadniSatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspTroskovi = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTrošakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajZaOdređeniPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKlijenti = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKlijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZadaci = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviZadatakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSastanci = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviSastanakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviZaposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUgovori = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviUgovorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUred = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviUgovorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 534);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(40);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1193, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPredmeti,
            this.tsmRocista,
            this.tsmRadniSati,
            this.tspTroskovi,
            this.tsmKlijenti,
            this.tsmZadaci,
            this.tsmSastanci,
            this.tsmZaposlenici,
            this.tsmUgovori,
            this.tsmUred});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1193, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.toolTip1.SetToolTip(this.menuStrip, "\r\n");
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // tsmPredmeti
            // 
            this.tsmPredmeti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviPredmetToolStripMenuItem});
            this.tsmPredmeti.Name = "tsmPredmeti";
            this.tsmPredmeti.Size = new System.Drawing.Size(83, 24);
            this.tsmPredmeti.Text = "Predmeti";
            this.tsmPredmeti.Click += new System.EventHandler(this.UredToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // noviPredmetToolStripMenuItem
            // 
            this.noviPredmetToolStripMenuItem.Name = "noviPredmetToolStripMenuItem";
            this.noviPredmetToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.noviPredmetToolStripMenuItem.Text = "Novi predmet";
            this.noviPredmetToolStripMenuItem.Click += new System.EventHandler(this.NoviPredmetToolStripMenuItem_Click);
            // 
            // tsmRocista
            // 
            this.tsmRocista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.novoRočišteToolStripMenuItem});
            this.tsmRocista.Name = "tsmRocista";
            this.tsmRocista.Size = new System.Drawing.Size(71, 24);
            this.tsmRocista.Text = "Ročišta";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.PretragaToolStripMenuItem1_Click);
            // 
            // novoRočišteToolStripMenuItem
            // 
            this.novoRočišteToolStripMenuItem.Name = "novoRočišteToolStripMenuItem";
            this.novoRočišteToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.novoRočišteToolStripMenuItem.Text = "Novo ročište";
            this.novoRočišteToolStripMenuItem.Click += new System.EventHandler(this.NovoRočišteToolStripMenuItem_Click);
            // 
            // tsmRadniSati
            // 
            this.tsmRadniSati.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.noviRadniSatToolStripMenuItem});
            this.tsmRadniSati.Name = "tsmRadniSati";
            this.tsmRadniSati.Size = new System.Drawing.Size(88, 24);
            this.tsmRadniSati.Text = "Radni sati";
            this.tsmRadniSati.Click += new System.EventHandler(this.UgovoriToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.PretragaToolStripMenuItem2_Click);
            // 
            // noviRadniSatToolStripMenuItem
            // 
            this.noviRadniSatToolStripMenuItem.Name = "noviRadniSatToolStripMenuItem";
            this.noviRadniSatToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.noviRadniSatToolStripMenuItem.Text = "Novi radni sat";
            this.noviRadniSatToolStripMenuItem.Click += new System.EventHandler(this.NoviRadniSatToolStripMenuItem_Click);
            // 
            // tspTroskovi
            // 
            this.tspTroskovi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem3,
            this.noviTrošakToolStripMenuItem,
            this.izvještajZaOdređeniPeriodToolStripMenuItem});
            this.tspTroskovi.Name = "tspTroskovi";
            this.tspTroskovi.Size = new System.Drawing.Size(77, 24);
            this.tspTroskovi.Text = "Troškovi";
            this.tspTroskovi.Click += new System.EventHandler(this.PredmetiToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem3
            // 
            this.pretragaToolStripMenuItem3.Name = "pretragaToolStripMenuItem3";
            this.pretragaToolStripMenuItem3.Size = new System.Drawing.Size(276, 26);
            this.pretragaToolStripMenuItem3.Text = "Pretraga";
            this.pretragaToolStripMenuItem3.Click += new System.EventHandler(this.PretragaToolStripMenuItem3_Click);
            // 
            // noviTrošakToolStripMenuItem
            // 
            this.noviTrošakToolStripMenuItem.Name = "noviTrošakToolStripMenuItem";
            this.noviTrošakToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.noviTrošakToolStripMenuItem.Text = "Novi trošak";
            this.noviTrošakToolStripMenuItem.Click += new System.EventHandler(this.NoviTrošakToolStripMenuItem_Click);
            // 
            // izvještajZaOdređeniPeriodToolStripMenuItem
            // 
            this.izvještajZaOdređeniPeriodToolStripMenuItem.Name = "izvještajZaOdređeniPeriodToolStripMenuItem";
            this.izvještajZaOdređeniPeriodToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.izvještajZaOdređeniPeriodToolStripMenuItem.Text = "Izvještaj za određeni period";
            this.izvještajZaOdređeniPeriodToolStripMenuItem.Click += new System.EventHandler(this.IzvještajZaOdređeniPeriodToolStripMenuItem_Click);
            // 
            // tsmKlijenti
            // 
            this.tsmKlijenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem4,
            this.noviKlijentToolStripMenuItem});
            this.tsmKlijenti.Name = "tsmKlijenti";
            this.tsmKlijenti.Size = new System.Drawing.Size(69, 24);
            this.tsmKlijenti.Text = "Klijenti";
            this.tsmKlijenti.Click += new System.EventHandler(this.RočištaToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem4
            // 
            this.pretragaToolStripMenuItem4.Name = "pretragaToolStripMenuItem4";
            this.pretragaToolStripMenuItem4.Size = new System.Drawing.Size(167, 26);
            this.pretragaToolStripMenuItem4.Text = "Pretraga";
            this.pretragaToolStripMenuItem4.Click += new System.EventHandler(this.PretragaToolStripMenuItem4_Click);
            // 
            // noviKlijentToolStripMenuItem
            // 
            this.noviKlijentToolStripMenuItem.Name = "noviKlijentToolStripMenuItem";
            this.noviKlijentToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.noviKlijentToolStripMenuItem.Text = "Novi klijent";
            this.noviKlijentToolStripMenuItem.Click += new System.EventHandler(this.NoviKlijentToolStripMenuItem_Click);
            // 
            // tsmZadaci
            // 
            this.tsmZadaci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem5,
            this.noviZadatakToolStripMenuItem});
            this.tsmZadaci.Name = "tsmZadaci";
            this.tsmZadaci.Size = new System.Drawing.Size(68, 24);
            this.tsmZadaci.Text = "Zadaci";
            // 
            // pretragaToolStripMenuItem5
            // 
            this.pretragaToolStripMenuItem5.Name = "pretragaToolStripMenuItem5";
            this.pretragaToolStripMenuItem5.Size = new System.Drawing.Size(179, 26);
            this.pretragaToolStripMenuItem5.Text = "Pretraga";
            this.pretragaToolStripMenuItem5.Click += new System.EventHandler(this.PretragaToolStripMenuItem5_Click);
            // 
            // noviZadatakToolStripMenuItem
            // 
            this.noviZadatakToolStripMenuItem.Name = "noviZadatakToolStripMenuItem";
            this.noviZadatakToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.noviZadatakToolStripMenuItem.Text = "Novi zadatak";
            this.noviZadatakToolStripMenuItem.Click += new System.EventHandler(this.NoviZadatakToolStripMenuItem_Click);
            // 
            // tsmSastanci
            // 
            this.tsmSastanci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem6,
            this.noviSastanakToolStripMenuItem});
            this.tsmSastanci.Name = "tsmSastanci";
            this.tsmSastanci.Size = new System.Drawing.Size(77, 24);
            this.tsmSastanci.Text = "Sastanci";
            // 
            // pretragaToolStripMenuItem6
            // 
            this.pretragaToolStripMenuItem6.Name = "pretragaToolStripMenuItem6";
            this.pretragaToolStripMenuItem6.Size = new System.Drawing.Size(183, 26);
            this.pretragaToolStripMenuItem6.Text = "Pretraga";
            this.pretragaToolStripMenuItem6.Click += new System.EventHandler(this.PretragaToolStripMenuItem6_Click);
            // 
            // noviSastanakToolStripMenuItem
            // 
            this.noviSastanakToolStripMenuItem.Name = "noviSastanakToolStripMenuItem";
            this.noviSastanakToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.noviSastanakToolStripMenuItem.Text = "Novi sastanak";
            this.noviSastanakToolStripMenuItem.Click += new System.EventHandler(this.NoviSastanakToolStripMenuItem_Click);
            // 
            // tsmZaposlenici
            // 
            this.tsmZaposlenici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem7,
            this.noviZaposlenikToolStripMenuItem});
            this.tsmZaposlenici.Name = "tsmZaposlenici";
            this.tsmZaposlenici.Size = new System.Drawing.Size(99, 24);
            this.tsmZaposlenici.Text = "Zaposlenici";
            // 
            // pretragaToolStripMenuItem7
            // 
            this.pretragaToolStripMenuItem7.Name = "pretragaToolStripMenuItem7";
            this.pretragaToolStripMenuItem7.Size = new System.Drawing.Size(197, 26);
            this.pretragaToolStripMenuItem7.Text = "Pretraga";
            this.pretragaToolStripMenuItem7.Click += new System.EventHandler(this.PretragaToolStripMenuItem7_Click);
            // 
            // noviZaposlenikToolStripMenuItem
            // 
            this.noviZaposlenikToolStripMenuItem.Name = "noviZaposlenikToolStripMenuItem";
            this.noviZaposlenikToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.noviZaposlenikToolStripMenuItem.Text = "Novi zaposlenik";
            this.noviZaposlenikToolStripMenuItem.Click += new System.EventHandler(this.NoviZaposlenikToolStripMenuItem_Click);
            // 
            // tsmUgovori
            // 
            this.tsmUgovori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem8,
            this.noviUgovorToolStripMenuItem});
            this.tsmUgovori.Name = "tsmUgovori";
            this.tsmUgovori.Size = new System.Drawing.Size(76, 24);
            this.tsmUgovori.Text = "Ugovori";
            // 
            // pretragaToolStripMenuItem8
            // 
            this.pretragaToolStripMenuItem8.Name = "pretragaToolStripMenuItem8";
            this.pretragaToolStripMenuItem8.Size = new System.Drawing.Size(174, 26);
            this.pretragaToolStripMenuItem8.Text = "Pretraga";
            this.pretragaToolStripMenuItem8.Click += new System.EventHandler(this.PretragaToolStripMenuItem8_Click);
            // 
            // noviUgovorToolStripMenuItem
            // 
            this.noviUgovorToolStripMenuItem.Name = "noviUgovorToolStripMenuItem";
            this.noviUgovorToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.noviUgovorToolStripMenuItem.Text = "Novi ugovor";
            this.noviUgovorToolStripMenuItem.Click += new System.EventHandler(this.NoviUgovorToolStripMenuItem_Click);
            // 
            // tsmUred
            // 
            this.tsmUred.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem9,
            this.noviUgovorToolStripMenuItem1});
            this.tsmUred.Name = "tsmUred";
            this.tsmUred.Size = new System.Drawing.Size(55, 24);
            this.tsmUred.Text = "Ured";
            // 
            // pretragaToolStripMenuItem9
            // 
            this.pretragaToolStripMenuItem9.Name = "pretragaToolStripMenuItem9";
            this.pretragaToolStripMenuItem9.Size = new System.Drawing.Size(157, 26);
            this.pretragaToolStripMenuItem9.Text = "Pretraga";
            this.pretragaToolStripMenuItem9.Click += new System.EventHandler(this.PretragaToolStripMenuItem9_Click);
            // 
            // noviUgovorToolStripMenuItem1
            // 
            this.noviUgovorToolStripMenuItem1.Name = "noviUgovorToolStripMenuItem1";
            this.noviUgovorToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.noviUgovorToolStripMenuItem1.Text = "Novi ured";
            this.noviUgovorToolStripMenuItem1.Click += new System.EventHandler(this.NoviUgovorToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(896, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime logiranog korisnika";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::Advokati.WinUI.Properties.Resources.poweroff2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1126, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Odjavi se");
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.NotifyIcon1_BalloonTipClicked);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.BalloonTipClicked += new System.EventHandler(this.NotifyIcon2_BalloonTipClicked);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Advokati.WinUI.Properties.Resources.laww;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "Advokatski ured";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmPredmeti;
        private System.Windows.Forms.ToolStripMenuItem tsmRocista;
        private System.Windows.Forms.ToolStripMenuItem tsmRadniSati;
        private System.Windows.Forms.ToolStripMenuItem tspTroskovi;
        private System.Windows.Forms.ToolStripMenuItem tsmKlijenti;
        private System.Windows.Forms.ToolStripMenuItem tsmZadaci;
        private System.Windows.Forms.ToolStripMenuItem tsmSastanci;
        private System.Windows.Forms.ToolStripMenuItem tsmZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem tsmUgovori;
        private System.Windows.Forms.ToolStripMenuItem tsmUred;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoRočišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem noviRadniSatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem noviTrošakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem noviKlijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem noviZadatakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem noviSastanakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem noviZaposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem noviUgovorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem noviUgovorToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem izvještajZaOdređeniPeriodToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}



