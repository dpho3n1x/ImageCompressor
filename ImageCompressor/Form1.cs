using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int elementy = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Obrazy (*.png; *.jpg, *.gif, *.bmp, *.webp)|*.png;*.jpg;*.jfif;*.gif;*.apng;*.webp|Nagrania - tylko dla WebP (*.mp4; *.mkv; *.webm, *.mov, *.avi)|*.mp4;*mkv;*.webm;*.mov|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    elementy++;
                    lista1.Items.Add(file);
                }
                statustext.Text = "Gotowe do przetwarzania";
                RenderAVIF.Enabled = true;
                RenderWEBP.Enabled = true;
                RenderJPG.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("Aby rozpocząć, potrzebna jest aplikacja FFMPEG w folderze aplikacji", "Brak bibliotek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string colorspace = "yuv420p";
            if (kodujPrzezroczystośćDlaWEBPToolStripMenuItem.Checked)
            {
                colorspace = "yuva420p";
            }

            string codecvp8 = "libwebp";
            if (użyjKodekaDoAnimacjiWebPToolStripMenuItem.Checked)
            {
                codecvp8 = "libwebp_anim";
            }
            qualitylog.Items.Clear();
            unresponsive.Visible = true;
            int renderowaneelementy = 0;
            foreach (var item in lista1.Items)
            {
                int jakosc = 100;
                if (faststart.Checked)
                {
                    jakosc = 90;
                }

                if (sizequalitybutton.Text == "Q")
                {
                    if (int.Parse(oczekiwanawielkosc.Text) > 100)
                        oczekiwanawielkosc.Text = "100";
                    
                    jakosc = int.Parse(oczekiwanawielkosc.Text);
                }

                renderowaneelementy++;
                string miejscezapisu;
                progressBar1.Value = 100 * renderowaneelementy / elementy;
                if (CustomSave.Checked)
                {
                    miejscezapisu = CustomSaveBox.Text + renderowaneelementy;
                }
                else
                {
                    miejscezapisu = item.ToString();
                }
            FFMPEGwebp:
                statustext.Text = "Trwa renderowanie obrazu " + renderowaneelementy + " z " + elementy + " używając jakości " + jakosc + " do formatu WEBP";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C ffmpeg -y -hide_banner -i " + '"' + item + '"' + " -c:v " + codecvp8 + " -pix_fmt " + colorspace + " -quality " + jakosc + " " + ffmpegsettings.Text + " " + '"' + miejscezapisu + ".webp" + '"'
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                FileInfo WielkoscPlikuRAW = new FileInfo(miejscezapisu + ".webp");
                int WielkoscPliku = (int)WielkoscPlikuRAW.Length;

                if (jakosc < 0)
                {
                    MessageBox.Show("Nie mogę zmieścić zdjęcia w oczekiwanym rozmiarze", "Renderowanie Nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statustext.Text = "Wpisz większy rozmiar aby zmieścić plik.";
                    unresponsive.Visible = false;
                    return;
                }

                int Bajty = int.Parse(oczekiwanawielkosc.Text) * 1024;
                if (sizequalitybutton.Text == "Q")
                {
                    Bajty = 100000000;
                }

                if (WielkoscPliku > Bajty)
                {
                    jakosc -= int.Parse(qualitysearchbox.Text);
                    goto FFMPEGwebp;
                }
                else
                {
                    int WielkoscPlikuKB = WielkoscPliku / 1024;
                    qualitylog.Items.Add(jakosc + " (" + WielkoscPlikuKB + "KB)");
                }
            }
            statustext.Text = "Zakończono renderowanie " + elementy + " obrazów";
            MessageBox.Show("Pomyślnie zakończono renderowanie " + elementy + " obrazów.", "Przetwarzanie zakończone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            unresponsive.Visible = false;
        }

        private void CustomSave_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomSave.Checked)
            {
                CustomSaveBox.Enabled = true;
            }
            else
            {
                CustomSaveBox.Enabled = false;
            }
        }

        private void RenderJPG_Click(object sender, EventArgs e)
        {
            if (!File.Exists("cjpeg-static.exe"))
            {
                MessageBox.Show("Aby rozpocząć, potrzebna jest aplikacja MozJPEG (cjpeg-static) w folderze aplikacji", "Brak bibliotek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            unresponsive.Visible = true;
            qualitylog.Items.Clear();
            int renderowaneelementy = 0;
            foreach (var item in lista1.Items)
            {
                int jakosc = 100;
                if (faststart.Checked)
                {
                    jakosc = 90;
                }

                if (sizequalitybutton.Text == "Q")
                {
                    if (int.Parse(oczekiwanawielkosc.Text) > 100)
                        oczekiwanawielkosc.Text = "100";

                    jakosc = int.Parse(oczekiwanawielkosc.Text);
                }

                renderowaneelementy++;
                string miejscezapisu;
                progressBar1.Value = 100 * renderowaneelementy / elementy;
                if (CustomSave.Checked)
                {
                    miejscezapisu = CustomSaveBox.Text + renderowaneelementy;
                }
                else
                {
                    miejscezapisu = item.ToString();
                }
            MozJPEGenc:
                if (jakosc < 0)
                {
                    MessageBox.Show("Nie mogę zmieścić zdjęcia w oczekiwanym rozmiarze.", "Renderowanie Nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statustext.Text = "Wpisz większy rozmiar aby zmieścić plik.";
                    unresponsive.Visible = false;
                    return;
                }

                statustext.Text = "Trwa renderowanie obrazu " + renderowaneelementy + " z " + elementy + " używając jakości " + jakosc + " do formatu JPEG";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C cjpeg-static -quality " + jakosc + " -outfile " + '"' + miejscezapisu + ".jpg" + '"' + " " + '"' + item + '"'
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                FileInfo WielkoscPlikuRAW = new FileInfo(miejscezapisu + ".jpg");
                int WielkoscPliku = (int)WielkoscPlikuRAW.Length;

                int Bajty = int.Parse(oczekiwanawielkosc.Text) * 1024;

                if (sizequalitybutton.Text == "Q")
                {
                    Bajty = 100000000;
                }

                if (WielkoscPliku > Bajty)
                {
                    jakosc -= int.Parse(qualitysearchbox.Text);
                    goto MozJPEGenc;
                }
                else
                {
                    int WielkoscPlikuKB = WielkoscPliku / 1024;
                    qualitylog.Items.Add(jakosc + " (" + WielkoscPlikuKB + "KB)");
                }
            }
            statustext.Text = "Zakończono renderowanie " + elementy + " obrazów";
            MessageBox.Show("Pomyślnie zakończono renderowanie " + elementy + " obrazów.", "Przetwarzanie zakończone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            unresponsive.Visible = false;
    }

        private void ClearList_Click(object sender, EventArgs e)
        {
            lista1.Items.Clear();
            qualitylog.Items.Clear();
            elementy = 0;
        }

        private void RenderAVIF_Click(object sender, EventArgs e)
        {
            if (!File.Exists("avifenc.exe"))
            {
                MessageBox.Show("Aby rozpocząć, potrzebna jest aplikacja AVIFENC w folderze aplikacji", "Brak bibliotek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            unresponsive.Visible = true;
            int speed = int.Parse(avifspeedbox.Text);

            string colorrange = "l";
            if (użyjPełnegoZakresuKolorówWAVIFToolStripMenuItem.Checked)
            {
                colorrange = "f";
            }

            qualitylog.Items.Clear();
            int renderowaneelementy = 0;
            foreach (var item in lista1.Items)
            {
                int jakosc = 0;
                if (faststart.Checked)
                {
                    jakosc = 10;
                }

                if (sizequalitybutton.Text == "Q")
                {
                    if (int.Parse(oczekiwanawielkosc.Text) > 63)
                        oczekiwanawielkosc.Text = "63";

                    jakosc = int.Parse(oczekiwanawielkosc.Text);
                }

                renderowaneelementy++;
                string miejscezapisu;
                progressBar1.Value = 100 * renderowaneelementy / elementy;
                if (CustomSave.Checked)
                {
                    miejscezapisu = CustomSaveBox.Text + renderowaneelementy;
                }
                else
                {
                    miejscezapisu = item.ToString();
                }
            AVIFenc:
                if (jakosc > 63)
                {
                    MessageBox.Show("Nie mogę zmieścić zdjęcia w oczekiwanym rozmiarze.", "Renderowanie Nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statustext.Text = "Wpisz większy rozmiar aby zmieścić plik.";
                    unresponsive.Visible = false;
                    return;
                }

                statustext.Text = "Trwa renderowanie obrazu " + renderowaneelementy + " z " + elementy + " używając jakości " + jakosc + " do formatu AVIF";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C avifenc -j " + Environment.ProcessorCount + " --min " + jakosc + " --max " + jakosc + " -r " + colorrange + " -s " + speed + " " + '"' + item + '"' + " " + '"' + miejscezapisu + ".avif" + '"'
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                FileInfo WielkoscPlikuRAW = new FileInfo(miejscezapisu + ".avif");
                int WielkoscPliku = (int)WielkoscPlikuRAW.Length;

                int Bajty = int.Parse(oczekiwanawielkosc.Text) * 1024;

                if (sizequalitybutton.Text == "Q")
                {
                    Bajty = 100000000;
                }

                if (WielkoscPliku > Bajty)
                {
                    jakosc += int.Parse(qualitysearchbox.Text);
                    goto AVIFenc;
                }
                else
                {
                    int WielkoscPlikuKB = WielkoscPliku / 1024;
                    qualitylog.Items.Add(jakosc + " (" + WielkoscPlikuKB + "KB)");
                }
            }
            statustext.Text = "Zakończono renderowanie " + elementy + " obrazów";
            MessageBox.Show("Pomyślnie zakończono renderowanie " + elementy + " obrazów.", "Przetwarzanie zakończone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            unresponsive.Visible = false;
        }

        private void przyspieszenieDlaAVIFToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (przyspieszenieDlaAVIFToolStripMenuItem.Checked)
            {
                RenderAVIF.Text = "▶️ Renderuj (AVIF CPU4)";
            }
            else
            {
                RenderAVIF.Text = "▶️ Renderuj (AVIF)";
            }
        }

        private void sizequalitybutton_Click(object sender, EventArgs e)
        {
            if (sizequalitybutton.Text == "KB")
            {
                sizequalitybutton.Text = "Q";
                pospieszToolStripMenuItem.Enabled = false;
                faststart.Checked = false;
                faststart.Enabled = false;
            }
            else
            {
                sizequalitybutton.Text = "KB";
                pospieszToolStripMenuItem.Enabled = true;
                faststart.Checked = false;
                faststart.Enabled = true;
            }
        }
    }
}
