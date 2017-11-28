using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MusicShop
{
    public partial class PlayUserProductsForm : Form
    {
        SoundPlayer player;
        System.Reflection.Assembly a;
        string resourcesFolderPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), @"Resources\");
        string targetPath = null;
        List<product> songs = new List<product>();
        int songIndex = 0;
        bool playPauseFlag = false;

        public PlayUserProductsForm()
        {
            InitializeComponent();
        }

        private System.IO.Stream GetStream(string filename)
        {
            /*
            string[] names = a.GetManifestResourceNames();
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }*/
            return a.GetManifestResourceStream("MusicShop.Resources." + filename);
        }

        

        private void PlayUserProductsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            a = System.Reflection.Assembly.GetExecutingAssembly();
            player = new SoundPlayer();

            List<invoicedetail> ids = MusicShopBL.GetUserProducts(MusicShopPage.User);

            productsPanel.Controls.Clear();
            songsPanel.Controls.Clear();

            foreach (invoicedetail id in ids)
            {
                if (id.product.producttype.productTypeName == "song")
                {
                    songs.Add(id.product);

                    TableLayoutPanel songPanel = new TableLayoutPanel();
                    songPanel.Size = new System.Drawing.Size(500, 40);
                    songPanel.RowCount = 1;
                    songPanel.ColumnCount = 4;
                    songPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    songPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    songPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    songPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    Label productNameLabel = new Label();
                    productNameLabel.Text = id.product.productName;
                    productNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    songPanel.Controls.Add(productNameLabel, 0, 0);

                    Label productTypeLabel = new Label();
                    productTypeLabel.Text = id.product.producttype.productTypeName;
                    productTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    songPanel.Controls.Add(productTypeLabel, 1, 0);

                    Button playButton = new Button { Margin = new Padding(0) };
                    playButton.Tag = id.product;
                    playButton.Click += new System.EventHandler(playClick);
                    playButton.Text = "PLAY";
                    songPanel.Controls.Add(playButton, 2, 0);

                    Button downloadButton = new Button { Margin = new Padding(0) };
                    downloadButton.Tag = id.product;
                    downloadButton.Click += new System.EventHandler(downloadClick);
                    downloadButton.Text = "DOWNLOAD";
                    downloadButton.Size = new Size(100, 23);
                    songPanel.Controls.Add(downloadButton, 3, 0);

                    songsPanel.Controls.Add(songPanel);
                }
                else
                {
                    TableLayoutPanel productPanel = new TableLayoutPanel();
                    productPanel.Size = new System.Drawing.Size(500, 40);
                    productPanel.RowCount = 1;
                    productPanel.ColumnCount = 4;
                    productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    productPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

                    Label productNameLabel = new Label();
                    productNameLabel.Text = id.product.productName;
                    productNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    productPanel.Controls.Add(productNameLabel, 0, 0);

                    Label productTypeLabel = new Label();
                    productTypeLabel.Text = id.product.producttype.productTypeName;
                    productTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    productPanel.Controls.Add(productTypeLabel, 1, 0);

                    Button downloadButton = new Button { Margin = new Padding(0) };
                    downloadButton.Tag = id.product;
                    downloadButton.Click += new System.EventHandler(downloadClick);
                    downloadButton.Text = "DOWNLOAD";
                    downloadButton.Size = new Size(100,23);
                    productPanel.Controls.Add(downloadButton, 3, 0);

                    productsPanel.Controls.Add(productPanel);
                }
                
            }

            product firstSong = songs.ElementAt(0);
            SetSong(firstSong);
        }

        private void downloadClick(object sender, EventArgs e)
        {
            if (targetPath == null)
            {
                MessageBox.Show("You must first choose download destionation folder!");
                return;
            }
            Button b = sender as Button;
            product prod = b.Tag as product;
            string filename = prod.productFileName;
            try
            {
                System.IO.File.Copy(resourcesFolderPath + filename, System.IO.Path.Combine(targetPath, filename), true);
            }
            catch (Exception exception) {
                MessageBox.Show("Couldn't save file!");
            }
            
        }

        private void playClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            product song = b.Tag as product;
            songIndex = songs.IndexOf(song);
            SetSong(song);
        }

        private void chooseDownloadFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                targetPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void nextSongButton_Click(object sender, EventArgs e)
        {
            if (songIndex < songs.Count - 1)
            {
                songIndex++;
                product song = songs.ElementAt(songIndex);
                SetSong(song);
                songPlayingLabel.Text = song.productName;
            }
            

        }

        private void previousSongButton_Click(object sender, EventArgs e)
        {
            if (songIndex > 0)
            {
                songIndex--;
                product song = songs.ElementAt(songIndex);
                SetSong(song);
            }
        }

        private void SetSong(product song)
        {
            player.Stop();
            player.Stream = GetStream(song.productFileName);
            songPlayingLabel.Text = song.productName;
        }
        
        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (playPauseFlag)
            {
                player.Stop();
                playPauseFlag = false;
                playPauseButton.Text = "Play";
            }
            else
            {
                player.Play();
                playPauseFlag = true;
                playPauseButton.Text = "Pause";
            }
        }
    }
}
