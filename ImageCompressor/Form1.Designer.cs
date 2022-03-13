
namespace ImageCompressor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ZnajdzObraz = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RenderWEBP = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.faststart = new System.Windows.Forms.ToolStripMenuItem();
            this.pospieszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualitysearchbox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.przyspieszenieDlaAVIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avifspeedbox = new System.Windows.Forms.ToolStripComboBox();
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatkoweEfektyDlaWebPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffmpegsettings = new System.Windows.Forms.ToolStripTextBox();
            this.statustext = new System.Windows.Forms.Label();
            this.CustomSaveBox = new System.Windows.Forms.TextBox();
            this.CustomSave = new System.Windows.Forms.CheckBox();
            this.RenderJPG = new System.Windows.Forms.Button();
            this.RenderAVIF = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.qualitylog = new System.Windows.Forms.ListBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.unresponsive = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.oczekiwanawielkosc = new System.Windows.Forms.MaskedTextBox();
            this.sizequalitybutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZnajdzObraz
            // 
            this.ZnajdzObraz.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ZnajdzObraz.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ZnajdzObraz.Location = new System.Drawing.Point(12, 13);
            this.ZnajdzObraz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZnajdzObraz.Name = "ZnajdzObraz";
            this.ZnajdzObraz.Size = new System.Drawing.Size(145, 28);
            this.ZnajdzObraz.TabIndex = 0;
            this.ZnajdzObraz.Text = "🔍 Znajdź obrazy";
            this.ZnajdzObraz.UseVisualStyleBackColor = true;
            this.ZnajdzObraz.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista1
            // 
            this.lista1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lista1.ForeColor = System.Drawing.Color.White;
            this.lista1.ItemHeight = 16;
            this.lista1.Location = new System.Drawing.Point(12, 80);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(849, 436);
            this.lista1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // RenderWEBP
            // 
            this.RenderWEBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderWEBP.ContextMenuStrip = this.contextMenuStrip1;
            this.RenderWEBP.Enabled = false;
            this.RenderWEBP.ForeColor = System.Drawing.Color.Green;
            this.RenderWEBP.Location = new System.Drawing.Point(644, 529);
            this.RenderWEBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RenderWEBP.Name = "RenderWEBP";
            this.RenderWEBP.Size = new System.Drawing.Size(145, 28);
            this.RenderWEBP.TabIndex = 2;
            this.RenderWEBP.Text = "▶️ Renderuj (WebP)";
            this.toolTip1.SetToolTip(this.RenderWEBP, "WebP jest formatem stworzonym przez Google aby zastąpić JPEG. \r\nOpiera się na kod" +
        "eku VP8. Przeważnie daje wyższą jakość niż JPG, ale jest gorzej wspierany przez " +
        "część aplikacji.\r\n\r\nUżywa: ffmpeg");
            this.RenderWEBP.UseVisualStyleBackColor = true;
            this.RenderWEBP.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faststart,
            this.pospieszToolStripMenuItem,
            this.toolStripSeparator2,
            this.przyspieszenieDlaAVIFToolStripMenuItem,
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem,
            this.toolStripSeparator1,
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem,
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem,
            this.dodatkoweEfektyDlaWebPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(378, 192);
            // 
            // faststart
            // 
            this.faststart.CheckOnClick = true;
            this.faststart.Name = "faststart";
            this.faststart.Size = new System.Drawing.Size(377, 22);
            this.faststart.Text = "Szybki Start dla małych rozmiarów";
            this.faststart.ToolTipText = "Pomija pierwsze 10 punktów jakości na każdym kodeku, aby przejść do niższej jakoś" +
    "ci.\r\n\r\nOszczędza czas przy niskiej oczekiwanej wielkości pliku, szczególnie rend" +
    "erując do AVIF.";
            // 
            // pospieszToolStripMenuItem
            // 
            this.pospieszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualitysearchbox});
            this.pospieszToolStripMenuItem.Name = "pospieszToolStripMenuItem";
            this.pospieszToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.pospieszToolStripMenuItem.Text = "Prędkość wyszukiwania jakości";
            this.pospieszToolStripMenuItem.ToolTipText = "Wybierz co ile punktów ma być wyszukiwana jakość do oczekiwanej wielkości.\r\n\r\n1 -" +
    " Wyższa dokładność\r\n10 - Wyższa prędkość";
            // 
            // qualitysearchbox
            // 
            this.qualitysearchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.qualitysearchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.qualitysearchbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.qualitysearchbox.Name = "qualitysearchbox";
            this.qualitysearchbox.Size = new System.Drawing.Size(121, 23);
            this.qualitysearchbox.Text = "1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(374, 6);
            // 
            // przyspieszenieDlaAVIFToolStripMenuItem
            // 
            this.przyspieszenieDlaAVIFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avifspeedbox});
            this.przyspieszenieDlaAVIFToolStripMenuItem.Name = "przyspieszenieDlaAVIFToolStripMenuItem";
            this.przyspieszenieDlaAVIFToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.przyspieszenieDlaAVIFToolStripMenuItem.Text = "Prędkość kodowania AVIF";
            this.przyspieszenieDlaAVIFToolStripMenuItem.CheckedChanged += new System.EventHandler(this.przyspieszenieDlaAVIFToolStripMenuItem_CheckedChanged);
            // 
            // avifspeedbox
            // 
            this.avifspeedbox.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.avifspeedbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.avifspeedbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.avifspeedbox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.avifspeedbox.MaxLength = 1;
            this.avifspeedbox.Name = "avifspeedbox";
            this.avifspeedbox.Size = new System.Drawing.Size(121, 23);
            this.avifspeedbox.Text = "0";
            this.avifspeedbox.ToolTipText = "Wybierz prędkość kodowania zdjęć.\r\n\r\n0 - Najwolniejsze, najlepsza jakość\r\n6 - Naj" +
    "szybsze, najniższa jakość";
            // 
            // użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem
            // 
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem.CheckOnClick = true;
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem.Name = "użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem";
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem.Text = "Użyj pełnego zakresu kolorów w AVIF";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(374, 6);
            // 
            // kodujPrzezroczystośćDlaWEBPToolStripMenuItem
            // 
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem.CheckOnClick = true;
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem.Name = "kodujPrzezroczystośćDlaWEBPToolStripMenuItem";
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem.Text = "Koduj przezroczystość dla WebP";
            this.kodujPrzezroczystośćDlaWEBPToolStripMenuItem.ToolTipText = "Zmienia gamę kolorów dodając kanał alfa. Zalecane tylko do animacji";
            // 
            // użyjKodekaDoAnimacjiWebPToolStripMenuItem
            // 
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem.CheckOnClick = true;
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem.Name = "użyjKodekaDoAnimacjiWebPToolStripMenuItem";
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem.Text = "Koduj animacje WebP (obsługiwane kodeki zdjęć i wideo)";
            this.użyjKodekaDoAnimacjiWebPToolStripMenuItem.ToolTipText = "Tworzy coś w stylu GIFa, ale w lepszej jakości.\r\n\r\nJako wejście obsługiwane są fi" +
    "lmy (MP4, MOV, MKV itd.) oraz zwykłe GIFy";
            // 
            // dodatkoweEfektyDlaWebPToolStripMenuItem
            // 
            this.dodatkoweEfektyDlaWebPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffmpegsettings});
            this.dodatkoweEfektyDlaWebPToolStripMenuItem.Name = "dodatkoweEfektyDlaWebPToolStripMenuItem";
            this.dodatkoweEfektyDlaWebPToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.dodatkoweEfektyDlaWebPToolStripMenuItem.Text = "Dodatkowe efekty dla WebP";
            // 
            // ffmpegsettings
            // 
            this.ffmpegsettings.AutoCompleteCustomSource.AddRange(new string[] {
            "-vf scale=-2:1080 -sws_flags lanczos",
            "-vf smartblur=lr=5"});
            this.ffmpegsettings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ffmpegsettings.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ffmpegsettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ffmpegsettings.Name = "ffmpegsettings";
            this.ffmpegsettings.Size = new System.Drawing.Size(100, 23);
            // 
            // statustext
            // 
            this.statustext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statustext.Location = new System.Drawing.Point(12, 529);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(476, 16);
            this.statustext.TabIndex = 5;
            this.statustext.Text = "Wybierz obrazy do przetworzenia";
            // 
            // CustomSaveBox
            // 
            this.CustomSaveBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomSaveBox.Enabled = false;
            this.CustomSaveBox.Location = new System.Drawing.Point(165, 49);
            this.CustomSaveBox.Name = "CustomSaveBox";
            this.CustomSaveBox.Size = new System.Drawing.Size(775, 21);
            this.CustomSaveBox.TabIndex = 6;
            this.CustomSaveBox.Text = "R:\\element";
            this.toolTip1.SetToolTip(this.CustomSaveBox, "Wpisz ścieżkę\\nazwę-pliku. Nie wpisuj rozszerzenia.\r\n\r\nPrzykład: C:\\Users\\Public\\" +
        "Pictures\\Zdjecie");
            // 
            // CustomSave
            // 
            this.CustomSave.AutoSize = true;
            this.CustomSave.Location = new System.Drawing.Point(12, 51);
            this.CustomSave.Name = "CustomSave";
            this.CustomSave.Size = new System.Drawing.Size(147, 20);
            this.CustomSave.TabIndex = 7;
            this.CustomSave.Text = "Niestandardowy zapis";
            this.CustomSave.UseVisualStyleBackColor = true;
            this.CustomSave.CheckedChanged += new System.EventHandler(this.CustomSave_CheckedChanged);
            // 
            // RenderJPG
            // 
            this.RenderJPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderJPG.ContextMenuStrip = this.contextMenuStrip1;
            this.RenderJPG.Enabled = false;
            this.RenderJPG.ForeColor = System.Drawing.Color.Green;
            this.RenderJPG.Location = new System.Drawing.Point(795, 529);
            this.RenderJPG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RenderJPG.Name = "RenderJPG";
            this.RenderJPG.Size = new System.Drawing.Size(145, 28);
            this.RenderJPG.TabIndex = 8;
            this.RenderJPG.Text = "▶️ Renderuj (MozJPEG)";
            this.toolTip1.SetToolTip(this.RenderJPG, resources.GetString("RenderJPG.ToolTip"));
            this.RenderJPG.UseVisualStyleBackColor = true;
            this.RenderJPG.Click += new System.EventHandler(this.RenderJPG_Click);
            // 
            // RenderAVIF
            // 
            this.RenderAVIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderAVIF.ContextMenuStrip = this.contextMenuStrip1;
            this.RenderAVIF.Enabled = false;
            this.RenderAVIF.ForeColor = System.Drawing.Color.Green;
            this.RenderAVIF.Location = new System.Drawing.Point(493, 529);
            this.RenderAVIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RenderAVIF.Name = "RenderAVIF";
            this.RenderAVIF.Size = new System.Drawing.Size(145, 28);
            this.RenderAVIF.TabIndex = 9;
            this.RenderAVIF.Text = "▶️ Renderuj (AVIF)";
            this.toolTip1.SetToolTip(this.RenderAVIF, resources.GetString("RenderAVIF.ToolTip"));
            this.RenderAVIF.UseVisualStyleBackColor = true;
            this.RenderAVIF.Click += new System.EventHandler(this.RenderAVIF_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 547);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(473, 10);
            this.progressBar1.TabIndex = 10;
            // 
            // qualitylog
            // 
            this.qualitylog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualitylog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qualitylog.ForeColor = System.Drawing.Color.White;
            this.qualitylog.FormattingEnabled = true;
            this.qualitylog.ItemHeight = 16;
            this.qualitylog.Location = new System.Drawing.Point(867, 80);
            this.qualitylog.Name = "qualitylog";
            this.qualitylog.Size = new System.Drawing.Size(73, 436);
            this.qualitylog.TabIndex = 11;
            this.toolTip1.SetToolTip(this.qualitylog, "Tutaj znajdują się statystyki dotyczące jakości wybranej podczas kodowania oraz w" +
        "ielkości wynikowej pliku");
            // 
            // ClearList
            // 
            this.ClearList.ForeColor = System.Drawing.Color.Red;
            this.ClearList.Location = new System.Drawing.Point(164, 13);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(28, 28);
            this.ClearList.TabIndex = 13;
            this.ClearList.Text = "🗑️";
            this.toolTip1.SetToolTip(this.ClearList, "Wyczyść listę");
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // unresponsive
            // 
            this.unresponsive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unresponsive.ForeColor = System.Drawing.Color.Red;
            this.unresponsive.Location = new System.Drawing.Point(198, 19);
            this.unresponsive.Name = "unresponsive";
            this.unresponsive.Size = new System.Drawing.Size(629, 18);
            this.unresponsive.TabIndex = 14;
            this.unresponsive.Text = "Aplikacja jest teraz nieresponsywna, natomiast wciąż działa - nie zamykaj jej";
            this.unresponsive.Visible = false;
            // 
            // oczekiwanawielkosc
            // 
            this.oczekiwanawielkosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oczekiwanawielkosc.BeepOnError = true;
            this.oczekiwanawielkosc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.oczekiwanawielkosc.HidePromptOnLeave = true;
            this.oczekiwanawielkosc.Location = new System.Drawing.Point(833, 18);
            this.oczekiwanawielkosc.Mask = "000000";
            this.oczekiwanawielkosc.Name = "oczekiwanawielkosc";
            this.oczekiwanawielkosc.PromptChar = ' ';
            this.oczekiwanawielkosc.Size = new System.Drawing.Size(71, 21);
            this.oczekiwanawielkosc.TabIndex = 15;
            this.oczekiwanawielkosc.Text = "100";
            this.oczekiwanawielkosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oczekiwanawielkosc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.oczekiwanawielkosc, resources.GetString("oczekiwanawielkosc.ToolTip"));
            // 
            // sizequalitybutton
            // 
            this.sizequalitybutton.Location = new System.Drawing.Point(910, 17);
            this.sizequalitybutton.Name = "sizequalitybutton";
            this.sizequalitybutton.Size = new System.Drawing.Size(30, 23);
            this.sizequalitybutton.TabIndex = 16;
            this.sizequalitybutton.Text = "KB";
            this.sizequalitybutton.UseVisualStyleBackColor = true;
            this.sizequalitybutton.Click += new System.EventHandler(this.sizequalitybutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 570);
            this.Controls.Add(this.sizequalitybutton);
            this.Controls.Add(this.oczekiwanawielkosc);
            this.Controls.Add(this.unresponsive);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.qualitylog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RenderAVIF);
            this.Controls.Add(this.RenderJPG);
            this.Controls.Add(this.CustomSave);
            this.Controls.Add(this.CustomSaveBox);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.RenderWEBP);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.ZnajdzObraz);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ImageCompressor by Sho";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZnajdzObraz;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button RenderWEBP;
        private System.Windows.Forms.Label statustext;
        private System.Windows.Forms.TextBox CustomSaveBox;
        private System.Windows.Forms.CheckBox CustomSave;
        private System.Windows.Forms.Button RenderJPG;
        private System.Windows.Forms.Button RenderAVIF;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox qualitylog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pospieszToolStripMenuItem;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.ToolStripMenuItem przyspieszenieDlaAVIFToolStripMenuItem;
        private System.Windows.Forms.Label unresponsive;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox oczekiwanawielkosc;
        private System.Windows.Forms.ToolStripMenuItem kodujPrzezroczystośćDlaWEBPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użyjKodekaDoAnimacjiWebPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button sizequalitybutton;
        private System.Windows.Forms.ToolStripMenuItem dodatkoweEfektyDlaWebPToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ffmpegsettings;
        private System.Windows.Forms.ToolStripComboBox avifspeedbox;
        private System.Windows.Forms.ToolStripComboBox qualitysearchbox;
        private System.Windows.Forms.ToolStripMenuItem faststart;
    }
}

