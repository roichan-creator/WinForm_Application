namespace projekAkhir_RoichanAryshaputra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblJudul = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblKategori = new Label();
            cmbKategori = new ComboBox();
            lblPilihMenu = new Label();
            cmbPilihMenu = new ComboBox();
            btnTambah = new Button();
            lblPesanan = new Label();
            lstPesanan = new ListBox();
            btnHapus = new Button();
            btnReset = new Button();
            lblTotal = new Label();
            btnSimpan = new Button();
            btnRiwayat = new Button();
            btnKurangi = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(255, 188, 13);
            lblJudul.Location = new Point(58, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(458, 41);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Selamat Datang di McDonald'";
            // 
            // lblNama
            // 
            lblNama.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.FromArgb(255, 188, 13);
            lblNama.Location = new Point(30, 100);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(62, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(160, 100);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(270, 28);
            txtNama.TabIndex = 2;
            // 
            // lblKategori
            // 
            lblKategori.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.FromArgb(255, 188, 13);
            lblKategori.Location = new Point(30, 145);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(100, 25);
            lblKategori.TabIndex = 3;
            lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(160, 145);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(270, 27);
            cmbKategori.TabIndex = 4;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblPilihMenu
            // 
            lblPilihMenu.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPilihMenu.ForeColor = Color.FromArgb(255, 188, 13);
            lblPilihMenu.Location = new Point(30, 190);
            lblPilihMenu.Name = "lblPilihMenu";
            lblPilihMenu.Size = new Size(100, 25);
            lblPilihMenu.TabIndex = 5;
            lblPilihMenu.Text = "Pilih Menu";
            // 
            // cmbPilihMenu
            // 
            cmbPilihMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilihMenu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPilihMenu.FormattingEnabled = true;
            cmbPilihMenu.Location = new Point(30, 215);
            cmbPilihMenu.Name = "cmbPilihMenu";
            cmbPilihMenu.Size = new Size(440, 27);
            cmbPilihMenu.TabIndex = 6;
            cmbPilihMenu.SelectedIndexChanged += cmbPilihMenu_SelectedIndexChanged;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(218, 41, 28);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Location = new Point(476, 209);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(102, 35);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesanan.ForeColor = Color.FromArgb(41, 41, 41);
            lblPesanan.Location = new Point(30, 265);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(173, 24);
            lblPesanan.TabIndex = 8;
            lblPesanan.Text = "\U0001f6d2Pesanan Kamu";
            // 
            // lstPesanan
            // 
            lstPesanan.BackColor = Color.White;
            lstPesanan.BorderStyle = BorderStyle.FixedSingle;
            lstPesanan.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPesanan.FormattingEnabled = true;
            lstPesanan.ItemHeight = 19;
            lstPesanan.Location = new Point(30, 295);
            lstPesanan.Name = "lstPesanan";
            lstPesanan.Size = new Size(580, 173);
            lstPesanan.TabIndex = 9;
            lstPesanan.SelectedIndexChanged += lstPesanan_SelectedIndexChanged;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(239, 68, 68);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(30, 485);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(140, 38);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "× Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(107, 114, 128);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(184, 485);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 38);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(30, 538);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(580, 50);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL: Rp 0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(34, 197, 94);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(30, 594);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(280, 45);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "💳 CHECKOUT";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(255, 188, 13);
            btnRiwayat.Cursor = Cursors.Hand;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.ForeColor = Color.FromArgb(41, 41, 41);
            btnRiwayat.Location = new Point(340, 591);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(280, 45);
            btnRiwayat.TabIndex = 14;
            btnRiwayat.Text = "📋 Riwayat";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKurangi
            // 
            btnKurangi.BackColor = Color.FromArgb(107, 114, 128);
            btnKurangi.Cursor = Cursors.Hand;
            btnKurangi.FlatStyle = FlatStyle.Flat;
            btnKurangi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKurangi.Location = new Point(338, 485);
            btnKurangi.Name = "btnKurangi";
            btnKurangi.Size = new Size(140, 38);
            btnKurangi.TabIndex = 15;
            btnKurangi.Text = "Kurangi";
            btnKurangi.UseVisualStyleBackColor = false;
            btnKurangi.Click += btnKurangi_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(218, 41, 28);
            ClientSize = new Size(632, 653);
            Controls.Add(btnKurangi);
            Controls.Add(btnRiwayat);
            Controls.Add(btnSimpan);
            Controls.Add(lblTotal);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(lstPesanan);
            Controls.Add(lblPesanan);
            Controls.Add(btnTambah);
            Controls.Add(cmbPilihMenu);
            Controls.Add(lblPilihMenu);
            Controls.Add(cmbKategori);
            Controls.Add(lblKategori);
            Controls.Add(txtNama);
            Controls.Add(lblNama);
            Controls.Add(lblJudul);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Pesanan McDonald's";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }
        private Label lblJudul;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblKategori;
        private ComboBox cmbKategori;
        private Label lblPilihMenu;
        private ComboBox cmbPilihMenu;
        private Button btnTambah;
        private Label lblPesanan;
        private ListBox lstPesanan;
        private Button btnHapus;
        private Button btnReset;
        private Label lblTotal;
        private Button btnSimpan;
        private Button btnRiwayat;
        private Button btnKurangi;
    }
}
