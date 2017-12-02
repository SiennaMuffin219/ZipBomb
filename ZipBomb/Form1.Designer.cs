namespace ZipBomb
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLemplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.UnitChanger = new System.Windows.Forms.ComboBox();
            this.ZipButton = new System.Windows.Forms.Button();
            this.LinesNb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Parcourir = new System.Windows.Forms.Button();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinesNb)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(484, 24);
            this.MenuStrip.TabIndex = 0;
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLemplacementToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichiersToolStripMenuItem.Text = "&Fichier";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.fermerToolStripMenuItem.Text = "Quitter";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // changerLemplacementToolStripMenuItem
            // 
            this.changerLemplacementToolStripMenuItem.Name = "changerLemplacementToolStripMenuItem";
            this.changerLemplacementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.changerLemplacementToolStripMenuItem.Text = "Changer l\'emplacement";
            this.changerLemplacementToolStripMenuItem.Click += new System.EventHandler(this.changerLemplacementToolStripMenuItem_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 318);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(460, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 1;
            // 
            // UnitChanger
            // 
            this.UnitChanger.FormattingEnabled = true;
            this.UnitChanger.Items.AddRange(new object[] {
            "o",
            "Ko",
            "Mo",
            "Go",
            "To"});
            this.UnitChanger.Location = new System.Drawing.Point(302, 97);
            this.UnitChanger.Name = "UnitChanger";
            this.UnitChanger.Size = new System.Drawing.Size(52, 21);
            this.UnitChanger.TabIndex = 2;
            // 
            // ZipButton
            // 
            this.ZipButton.Location = new System.Drawing.Point(198, 155);
            this.ZipButton.Name = "ZipButton";
            this.ZipButton.Size = new System.Drawing.Size(104, 25);
            this.ZipButton.TabIndex = 3;
            this.ZipButton.Text = "Zip Bomb !";
            this.ZipButton.UseVisualStyleBackColor = true;
            this.ZipButton.Click += new System.EventHandler(this.ZipButton_Click);
            // 
            // LinesNb
            // 
            this.LinesNb.Location = new System.Drawing.Point(143, 98);
            this.LinesNb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LinesNb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LinesNb.Name = "LinesNb";
            this.LinesNb.Size = new System.Drawing.Size(120, 20);
            this.LinesNb.TabIndex = 4;
            this.LinesNb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LinesNb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Poids final :";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fichier :";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(143, 61);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FileName.Size = new System.Drawing.Size(211, 20);
            this.FileName.TabIndex = 7;
            this.FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Parcourir
            // 
            this.Parcourir.Location = new System.Drawing.Point(372, 59);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Size = new System.Drawing.Size(75, 23);
            this.Parcourir.TabIndex = 8;
            this.Parcourir.Text = "Parcourir";
            this.Parcourir.UseVisualStyleBackColor = true;
            this.Parcourir.Click += new System.EventHandler(this.Parcourir_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àproposdeToolStripMenuItem});
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem1.Text = "&Aide";
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.àproposdeToolStripMenuItem.Text = "À &propos de...";
            this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.àproposdeToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Parcourir);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinesNb);
            this.Controls.Add(this.ZipButton);
            this.Controls.Add(this.UnitChanger);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinesNb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLemplacementToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ComboBox UnitChanger;
        private System.Windows.Forms.Button ZipButton;
        private System.Windows.Forms.NumericUpDown LinesNb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Parcourir;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    }
}

