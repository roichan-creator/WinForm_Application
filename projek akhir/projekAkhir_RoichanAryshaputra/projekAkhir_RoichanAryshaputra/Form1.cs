namespace projekAkhir_RoichanAryshaputra
{
    public partial class Form1 : Form
    {
        //Membuat Variabel yang berisi data data dari class menu dan ItemPesanan
        private List<Menu> menuItems;
        private List<ItemPesanan> orderItems;
        //Membuat Variabel yang berisi nama file
        private string fileRiwayat = "riwayat_pesanan.txt";
        public Form1()
        {
            //Inisialisasi komponen form
            InitializeComponent();
            //Inisialisasi list orderItems
            orderItems = new List<ItemPesanan>();
            //Memanggil method inisialisasi menuItems
            initializemenuItems();

        }

        //Inisialisasi data menu
        private void initializemenuItems()
        {
            //Menambahkan data data menu ke dalam list menuItems
            menuItems = new List<Menu>
            {
                //kategori burger
                new Menu { Id = 1, Nama = "Big Mac", Harga = 43500, Kategori = "Burger" },
                new Menu { Id = 2, Nama = "Cheeseburger Deluxe", Harga = 34500, Kategori = "Burger" },
                new Menu { Id = 3, Nama = "Triple Cheeseburger", Harga = 65500, Kategori = "Burger" },
                new Menu { Id = 4, Nama = "Beef Burger Deluxe", Harga = 40000, Kategori = "Burger" },
                new Menu { Id = 5, Nama = "Chicken Burger Deluxe", Harga = 30000, Kategori = "Burger" },
                //kategori Ayam
                new Menu { Id = 6, Nama = "PaMer 7 Ayam McD Gulai Krispy", Harga = 198500, Kategori = "Ayam" },
                new Menu { Id = 7, Nama = "2 ALC Ayam Krispy McD Gulai", Harga = 50000, Kategori = "Ayam" },
                new Menu { Id = 8, Nama = "PaNas 1 Ayam McD Gulai Krispy", Harga = 43000, Kategori = "Ayam" },
                new Menu { Id = 9, Nama = "PaNas 2 Ayam McD Gulai Spicy Large", Harga = 66500, Kategori = "Ayam" },
                new Menu { Id = 10, Nama = "2pcs Korean Soy Garlic Wings", Harga = 16500, Kategori = "Ayam" },
                //kategori Makanan Pendamping 
                new Menu { Id = 11, Nama = "French Fries (M)", Harga = 15000, Kategori = "Makanan Pendamping" },
                new Menu { Id = 12, Nama = "French Fries(L)", Harga = 20000, Kategori = "Makanan Pendamping" },
                new Menu { Id = 13, Nama = "Hash Brown", Harga = 15000, Kategori = "Makanan Pendamping" },
                new Menu { Id = 14, Nama = "Apple Pie", Harga = 12000, Kategori = "Makanan Pendamping" },
                 // kategori Minuman
                new Menu { Id = 15, Nama = "Coca-Cola (M)", Harga = 12000, Kategori = "Minuman" },
                new Menu { Id = 16, Nama = "Coca-Cola (L)", Harga = 15000, Kategori = "Minuman" },
                new Menu { Id = 17, Nama = "Sprite (M)", Harga = 12000, Kategori = "Minuman" },
                new Menu { Id = 18, Nama = "Sprite (L)", Harga = 15000, Kategori = "Minuman" },
                new Menu { Id = 19, Nama = "Orange juice", Harga = 18000, Kategori = "Minuman" },
                new Menu { Id = 20, Nama = "McCafe latte", Harga = 25000, Kategori = "Minuman" },
                // kategori Makanan Penutup
                new Menu { Id = 21, Nama = "McFlurry Oreo", Harga = 25000, Kategori = "Makanan Penutup" },
                new Menu { Id = 22, Nama = "Sundae Chocolate", Harga = 15000, Kategori = "Makanan Penutup" },
                new Menu { Id = 23, Nama = "Sunday Strawberry", Harga = 25000, Kategori = "Makanan Penutup" }
            };
            //Mengisi ComboBox Kategori dengan kategori unik dari menuItems
            var kategori = menuItems.Select(m => m.Kategori).Distinct().OrderBy(k => k).ToList();
            cmbKategori.Items.Add("=== Semua Kategori ===");
            //Menambahkan setiap kategori ke dalam ComboBox
            foreach (var Kategori in kategori)
            {
                cmbKategori.Items.Add(Kategori);
            }
            cmbKategori.SelectedIndex = 0;

        }

        //Membuat class menu
        public class Menu
        {
            //Properti dari class menu
            public int Id { get; set; }
            public string Nama { get; set; }
            public decimal Harga { get; set; }
            public string Kategori { get; set; }
            //Override method ToString untuk menampilkan nama dan harga menu
            public override string ToString()
            {
                return $"{Nama} - Rp {Harga:N0}";
            }

        }
        //Membuat class ItemPesanan
        public class ItemPesanan
        {
            //Properti dari class ItemPesanan
            public Menu Menu { get; set; }
            public int Jumlah { get; set; } = 1;
            //Constructor dari class ItemPesanan
            public ItemPesanan(Menu item)
            {
                Menu = item;
            }
            //Override method ToString untuk menampilkan nama dan harga menu
            public override string ToString()
            {
                return $"{Menu.Nama} x{Jumlah} - Rp {Menu.Harga * Jumlah:N0}";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Cek apakah ada pesanan yang disimpan
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Tidak ada pesanan yang disimpan saat ini.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Mendapatkan nama pelanggan, jika kosong gunakan "Pelanggan"
            string namapelanggan = string.IsNullOrWhiteSpace(txtNama.Text)
                ? "Pelanggan" : txtNama.Text.Trim();
            // Menyimpan riwayat pesanan ke file teks
            try
            {
                // Membuka file riwayat dalam mode append
                using (StreamWriter writer = new StreamWriter(fileRiwayat, true))
                {
                    // Menulis header riwayat pesanan
                    writer.WriteLine("=".PadRight(70, '='));
                    writer.WriteLine("             Riwayat Pesanan McDonald's");
                    writer.WriteLine("=".PadRight(70, '='));
                    writer.WriteLine($"Tanggal dan Jam: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    writer.WriteLine($"Pelanggan: {namapelanggan}");
                    writer.WriteLine("-".PadRight(70, '-'));
                    writer.WriteLine("Detail Pesanan:");
                    writer.WriteLine();

                    int no = 1;

                    // Menulis setiap item pesanan ke file
                    foreach (var item in orderItems)
                    {
                        writer.WriteLine($"{no}. {item.Menu.Nama} x{item.Jumlah}  - Rp {item.Menu.Harga:N0}");
                        no++;
                    }
                    decimal total = orderItems.Sum(o => o.Menu.Harga * o.Jumlah);
                    writer.WriteLine();
                    writer.WriteLine("-".PadRight(70, '-'));
                    writer.WriteLine($"  {"TOTAL".PadRight(40)} Rp {total:N0}");
                    writer.WriteLine("=".PadRight(70, '='));
                    writer.WriteLine("         Terimakasih, Sampai berjumpa lagi!");
                    writer.WriteLine("                  I'm lovin' it");
                    writer.WriteLine("=".PadRight(70, '='));
                    writer.WriteLine();
                    writer.WriteLine();
                }
                MessageBox.Show($"pesanan berhasil di simpan !\n\nNama Pelanggan: {namapelanggan}\n" +
                    $"Total Pembayaran: Rp {orderItems.Sum(o => o.Menu.Harga * o.Jumlah):N0}",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset pesanan setelah disimpan
                orderItems.Clear();
                lstPesanan.Items.Clear();
                txtNama.Clear();
                cmbKategori.SelectedIndex = 0;
                UpdateTotal();
            }
            // Menangani kesalahan saat menyimpan pesanan
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan pesanan. Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPilihMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Memperbarui daftar menu berdasarkan kategori yang dipilih
            cmbPilihMenu.Items.Clear();
            cmbPilihMenu.Items.Add("=== Pilih Menu ===");

            // Menampilkan semua menu jika kategori "Semua Kategori" dipilih
            if (cmbKategori.SelectedIndex == 0)
            {
                // Tampilkan semua menu
                foreach (var menu in menuItems)
                {
                    cmbPilihMenu.Items.Add(menu);
                }
            }

            // Menampilkan menu berdasarkan kategori yang dipilih
            else
            {
                string selectedCategory = cmbKategori.SelectedItem.ToString();
                var filteredMenu = menuItems.Where(m => m.Kategori == selectedCategory).ToList();
                foreach (var menu in filteredMenu)
                {
                    cmbPilihMenu.Items.Add(menu);
                }
            }
            cmbPilihMenu.SelectedIndex = 0;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Menambahkan item pesanan ke daftar pesanan
            if (cmbPilihMenu.SelectedIndex > 0)
            {
                Menu selectedMenu = (Menu)cmbPilihMenu.SelectedItem;
                // Cek apakah item pesanan sudah ada dalam daftar
                var existingItem = orderItems.FirstOrDefault(o => o.Menu.Id == selectedMenu.Id);
                // Jika sudah ada, tambahkan jumlahnya
                if (existingItem != null)
                {
                    // Menambahkan jumlah item pesanan
                    existingItem.Jumlah++;
                    // Memperbarui tampilan item pesanan di ListBox
                    int index = lstPesanan.Items.IndexOf(existingItem);
                    lstPesanan.Items[index] = existingItem;
                }
                else
                {
                    ItemPesanan itemPesanan = new ItemPesanan(selectedMenu);
                    orderItems.Add(itemPesanan);
                    lstPesanan.Items.Add(itemPesanan);
                }

                UpdateTotal();
            }
            // Jika tidak ada menu yang dipilih, tampilkan peringatan
            else
            {
                MessageBox.Show("Silakan pilih menu terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Menghapus item pesanan yang dipilih dari daftar pesanan
            if (lstPesanan.SelectedIndex >= 0)
            {
                ItemPesanan selectedItem = (ItemPesanan)lstPesanan.SelectedItem;
                orderItems.Remove(selectedItem);
                lstPesanan.Items.Remove(selectedItem);
                UpdateTotal();
            }
            // Jika tidak ada item yang dipilih, tampilkan peringatan
            else
            {
                MessageBox.Show("Silakan pilih item pesanan yang akan dihapus.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Memperbarui total harga pesanan
        private void UpdateTotal()
        {
            // Menghitung total harga dari semua item pesanan
            decimal total = orderItems.Sum(o => o.Menu.Harga * o.Jumlah);
            lblTotal.Text = $"Total: Rp {total:N0}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Mereset daftar pesanan setelah konfirmasi dari pengguna
            if (orderItems.Count > 0)
            {
                // Menampilkan dialog konfirmasi
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mereset pesanan?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Jika pengguna memilih "Yes", reset daftar pesanan
                if (result == DialogResult.Yes)
                {
                    orderItems.Clear();
                    lstPesanan.Items.Clear();
                    UpdateTotal();
                }
            }
        }

        // Membuka file riwayat pesanan dengan Notepad
        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            // Memanggil method untuk membuka riwayat dengan Notepad
            BukaRiwayat();
        }

        // Method untuk membuka file riwayat pesanan dengan Notepad
        private void BukaRiwayat()
        {
            // Cek apakah file riwayat ada
            try
            {
                // Jika file tidak ada, tampilkan pesan informasi
                if (!File.Exists(fileRiwayat))
                {
                    MessageBox.Show("Belum ada riwayat pesanan.\n\nSilakan lakukan checkout terlebih dahulu.",
                        "File Tidak Ditemukan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                // Membuka file riwayat dengan Notepad
                System.Diagnostics.Process.Start("notepad.exe", fileRiwayat);
            }
            // Menangani kesalahan saat membuka file riwayat
            catch (Exception ex)
            {
                // Menampilkan pesan error jika gagal membuka file
                MessageBox.Show($"Gagal membuka file riwayat!\n\nError: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnKurangi_Click(object sender, EventArgs e)
        {
            // Mengurangi jumlah item pesanan yang dipilih
            if (lstPesanan.SelectedIndex >= 0)
            {
                int selectedIndex = lstPesanan.SelectedIndex;
                ItemPesanan selectedItem = (ItemPesanan)lstPesanan.SelectedItem;
                // Cek apakah jumlah item lebih dari 1
                if (selectedItem.Jumlah > 1)
                {
                    // Kurangi jumlah item pesanan
                    selectedItem.Jumlah--;

                    // Update tampilan ListBox
                    lstPesanan.Items.Clear();
                    // tambah semua item pesanan kembali ke ListBox
                    foreach (var item in orderItems)
                    {
                        lstPesanan.Items.Add(item);
                    }

                    lstPesanan.SelectedIndex = selectedIndex;
                }
                // Jika jumlah item adalah 1, hapus item dari daftar
                else
                {
                    orderItems.Remove(selectedItem);
                    lstPesanan.Items.Remove(selectedItem);
                }

                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Silakan pilih item pesanan yang akan dikurangi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstPesanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}