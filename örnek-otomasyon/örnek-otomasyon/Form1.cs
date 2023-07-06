



using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Word;
using Rectangle = iTextSharp.text.Rectangle;
using System.Windows.Forms;
using System.IO;
using Document = iTextSharp.text.Document;

namespace örnek_otomasyon
{

    public partial class Form1 : Form
    {


        double toplam = 0;
        double fiyattoplam = 0;
        double kdvh = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void gridAyari()
        {
            DataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı

            DataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor

            DataGridView1.ColumnCount = 5; //Kaç kolon olacağı belirleniyor…
                                           //
            DataGridView1.Columns[0].Width = 400; //belirlenen kolonların genişliği ayarlanıyor
            DataGridView1.Columns[1].Width = 100;
            DataGridView1.Columns[2].Width = 100;
            DataGridView1.Columns[3].Width = 100;
            DataGridView1.Columns[4].Width = 50;



        }
        private void ekles()
        {
            if (urunadi.Text != "" && fiyat.Text != "" && adet.Text != "")
            {

                toplam = Convert.ToDouble(fiyat.Text) * Convert.ToDouble(adet.Text);
                DataGridView1.Rows.Add(urunadi.Text, fiyat.Text + " TL", adet.Text, toplam + "  TL");
                hesaplama();
                //urunadi.Text = "";
                //fiyat.Text = "";
                //adet.Text = "";
                urunadi.Select();
                DataGridView1.ClearSelection();

            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurun.");

        }
        private void hesaplama()
        {
            string m;
            if (DataGridView1.Rows.Count >= 0)
            {
                fiyattoplam = 0;

                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    m = DataGridView1.Rows[i].Cells["Colum4"].Value.ToString();
                    m = m.Remove(m.Length - 4, 4);

                    fiyattoplam += Convert.ToDouble(m);
                }
            }

            kdvh = fiyattoplam * 0.18;
            double g = fiyattoplam + kdvh;

            txtaratoplam.Text = fiyattoplam.ToString("0.##") + " TL";
            if (checkBox1.Checked == true)
            {
                txtkdv.Text = kdvh.ToString("0.##") + " TL";
                txttoplam.Text = g.ToString("0.##") + " TL";
            }
            else
            {
                txtkdv.Text = "-";
                txttoplam.Text = fiyattoplam.ToString("0.##") + " TL";
            }

            dataGridView2.Rows.Clear();


            dataGridView2.Rows.Add(txtaratoplam.Text, txtkdv.Text, txttoplam.Text);
            dataGridView2.ClearSelection();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            ekles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAyari();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.RowCount > 0)
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridView1.Rows.RemoveAt(e.RowIndex);
                    hesaplama();
                }
            }

        }

        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hesaplama();
        }
        int sayiSiniri = 30;

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count != 0)
            {


                iTextSharp.text.Document document = new iTextSharp.text.Document();
                //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("deneme.pdf", FileMode.Create));

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = saveDialog.FileName;
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(dosyaYolu, FileMode.Create));





                    document.Open();
                    // Şablon dosyasını yükleyin
                    PdfReader templateReader = new PdfReader("sablon2.pdf");
                    PdfImportedPage templatePage = writer.GetImportedPage(templateReader, 1);



                    // Şablonu belgeye ekleyin
                    PdfContentByte contentByte = writer.DirectContent;
                    contentByte.AddTemplate(templatePage, 0, 0);

                    // DataGridView'deki verileri tablo şeklinde şablonun içine yerleştirin
                    PdfPTable table = new PdfPTable(DataGridView1.Columns.Count - 1);
                    table.WidthPercentage = 100;
                    table.DefaultCell.FixedHeight = 1;
                    //Belirli sayı sınırını burada belirleyin

                    PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                    emptyCell.Border = Rectangle.NO_BORDER;
                    emptyCell.Colspan = DataGridView1.Columns.Count;
                    emptyCell.FixedHeight = 120;
                    table.AddCell(emptyCell);

                    //Sütun başlıklarını ekleyin
                    for (int i = 0; i < DataGridView1.Columns.Count; i++)
                    {
                        if (DataGridView1.Columns[i].HeaderText != "SIL") // Sil sütununu atlama
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(DataGridView1.Columns[i].HeaderText));
                            cell.Border = Rectangle.NO_BORDER;
                            cell.BackgroundColor = BaseColor.ORANGE;
                            cell.Padding = 3;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }

                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridView1.Columns.Count - 1; j++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(DataGridView1.Rows[i].Cells[j].Value.ToString()));
                            cell.BackgroundColor = BaseColor.ORANGE;
                            // Hücrenin özelliklerini belirleme
                            cell.Padding = 3;
                            cell.Border = Rectangle.NO_BORDER;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_CENTER;
                            cell.BackgroundColor = BaseColor.WHITE;


                            table.AddCell(cell);
                        }

                        if (sayiSiniri == 0) // Belirli sayı sınırına ulaştığında yeni sayfa açma
                        {

                            document.Add(table); // Mevcut tabloyu ekle
                            document.NewPage(); // Yeni sayfa oluştur
                            sayiSiniri = 40;


                            table = new PdfPTable(DataGridView1.Columns.Count - 1); // Yeni tablo oluştur
                            table.WidthPercentage = 100;

                            // Yeni sayfadaki tablonun hücrelerini özelleştirme
                            for (int k = 0; k < DataGridView1.Columns.Count - 1; k++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(DataGridView1.Columns[k].HeaderText));

                                // Hücrenin özelliklerini belirleme
                                cell.Padding = 3;
                                cell.Border = Rectangle.NO_BORDER;
                                cell.BackgroundColor = BaseColor.ORANGE;
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.VerticalAlignment = Element.ALIGN_CENTER;
                                //cell.BackgroundColor = BaseColor.LIGHT_GRAY;

                                table.AddCell(cell);
                            }

                        }
                        sayiSiniri--;
                    }
                    PdfPCell tableCell1 = new PdfPCell(table);
                    tableCell1.Border = Rectangle.NO_BORDER;

                    // Tablonun konumunu belirle
                    tableCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    tableCell1.VerticalAlignment = Element.ALIGN_CENTER;



                    // ---------------------------------------------------


                    PdfPTable sonutable = new PdfPTable(dataGridView2.Columns.Count);
                    table.WidthPercentage = 100;

                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {

                        PdfPCell cell = new PdfPCell(new Phrase(dataGridView2.Columns[i].HeaderText));
                        cell.BackgroundColor = BaseColor.ORANGE;
                        cell.Padding = 10;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_CENTER;
                        sonutable.AddCell(cell);

                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dataGridView2.Rows[i].Cells[j].Value.ToString()));

                            // Hücrenin özelliklerini belirleme
                            cell.Padding = 10;
                            cell.Border = Rectangle.NO_BORDER;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_CENTER;
                            cell.BackgroundColor = BaseColor.WHITE;
                            sonutable.AddCell(cell);
                        }

                    }


                    PdfPCell tableCell2 = new PdfPCell(sonutable);
                    tableCell1.Border = Rectangle.NO_BORDER;

                    //Tablonun konumunu belirle

                    tableCell2.VerticalAlignment = Element.ALIGN_CENTER;
                    tableCell2.BackgroundColor = BaseColor.LIGHT_GRAY;

                    //Tabloyu belgeye ekleyin

                    document.Add(table);
                    document.Add(sonutable);

                    // Şablon dosyasını ve PDF belgesini kapatın ve kaydedin

                    document.Close();
                    templateReader.Close();
                    writer.Close();

                    DialogResult r = MessageBox.Show("PDF belgesi başarıyla kaydedildi!");

                    if (r == DialogResult.OK)
                    {
                        DataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                        txtaratoplam.Text = "";
                        txtkdv.Text = "";
                        txttoplam.Text = "";

                    }
                }
            }
            else
                MessageBox.Show("BOŞ BELGE OLUŞTURULAMAZ !!");
        }
    }

    //-------------------------------------------------------



    //iTextSharp.text.Document document = new iTextSharp.text.Document();
    //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("deneme.pdf", FileMode.Create));
    //    document.Open();


    //    // Şablon dosyasını yükleyin
    //    PdfReader templateReader = new PdfReader("sablon2.pdf");
    //    PdfImportedPage templatePage = writer.GetImportedPage(templateReader, 1);

    //    // Şablonu belgeye ekleyin
    //    PdfContentByte contentByte = writer.DirectContent;
    //    contentByte.AddTemplate(templatePage, 0, 0);

    //    // DataGridView1 için tablo oluşturun
    //    PdfPTable firstTable = new PdfPTable(DataGridView1.Columns.Count - 1);
    //    firstTable.WidthPercentage = 100;
    //    firstTable.DefaultCell.FixedHeight = 5f;

    //    float firstTableHeight = firstTable.TotalHeight;


    //    PdfPCell emptyCell = new PdfPCell(new Phrase(""));
    //    emptyCell.Border = Rectangle.NO_BORDER;
    //    emptyCell.Colspan = DataGridView1.Columns.Count - 1;
    //    emptyCell.FixedHeight = 125;
    //    firstTable.AddCell(emptyCell);

    //    // Sütun başlıklarını ekleyin
    //    for (int i = 0; i < DataGridView1.Columns.Count; i++)
    //    {
    //        if (DataGridView1.Columns[i].HeaderText != "SIL") // Sil sütununu atlama
    //        {
    //            PdfPCell cell = new PdfPCell(new Phrase(DataGridView1.Columns[i].HeaderText));
    //            cell.Border = Rectangle.NO_BORDER;
    //            cell.BackgroundColor = BaseColor.ORANGE;
    //            cell.Padding = 10;
    //            cell.HorizontalAlignment = Element.ALIGN_CENTER;
    //            cell.VerticalAlignment = Element.ALIGN_CENTER;
    //            cell.BackgroundColor = BaseColor.ORANGE;

    //            firstTable.AddCell(cell);
    //        }
    //    }

    //    // Verileri tabloya ekleyin
    //    for (int i = 0; i < DataGridView1.Rows.Count; i++)
    //    {
    //        for (int j = 0; j < DataGridView1.Columns.Count - 1; j++)
    //        {
    //            PdfPCell cell = new PdfPCell(new Phrase(DataGridView1.Rows[i].Cells[j].Value.ToString()));
    //            cell.BackgroundColor = BaseColor.ORANGE;
    //            cell.Padding = 10;
    //            cell.Border = Rectangle.NO_BORDER;
    //            cell.HorizontalAlignment = Element.ALIGN_CENTER;
    //            cell.VerticalAlignment = Element.ALIGN_CENTER;
    //            cell.BackgroundColor = BaseColor.LIGHT_GRAY;                  
    //            firstTable.AddCell(cell);
    //        }
    //    }

    //    // İkinci tablo için PdfPTable oluşturun
    //    PdfPTable secondTable = new PdfPTable(dataGridView2.Columns.Count);
    //    secondTable.WidthPercentage = 100;

    //    // Sütun başlıklarını ekleyin
    //    for (int i = 0; i < dataGridView2.Columns.Count; i++)
    //    {
    //        PdfPCell cell = new PdfPCell(new Phrase(dataGridView2.Columns[i].HeaderText));
    //        cell.BackgroundColor = BaseColor.ORANGE;
    //        cell.Padding = 10;
    //        cell.HorizontalAlignment = Element.ALIGN_CENTER;
    //        cell.VerticalAlignment = Element.ALIGN_CENTER;
    //        secondTable.AddCell(cell);
    //    }

    //    // Verileri tabloya ekleyin
    //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
    //    {
    //        for (int j = 0; j < dataGridView2.Columns.Count; j++)
    //        {
    //            PdfPCell cell = new PdfPCell(new Phrase(dataGridView2.Rows[i].Cells[j].Value.ToString()));
    //            cell.Padding = 10;
    //            cell.Border = Rectangle.NO_BORDER;
    //            cell.HorizontalAlignment = Element.ALIGN_CENTER;
    //            cell.VerticalAlignment = Element.ALIGN_CENTER;
    //            cell.BackgroundColor = BaseColor.GRAY;
    //            secondTable.AddCell(cell);
    //        }
    //    }
    //  //// if (document.NewPage())
    //  //  {
    //  //      for (int i = 0; i < dataGridView2.Columns.Count; i++)
    //  //      {
    //  //          PdfPCell cell = new PdfPCell(new Phrase(dataGridView2.Columns[i].HeaderText));
    //  //          cell.BackgroundColor = BaseColor.ORANGE;
    //  //          cell.Padding = 10;
    //  //          cell.HorizontalAlignment = Element.ALIGN_CENTER;
    //  //          cell.VerticalAlignment = Element.ALIGN_CENTER;
    //  //          secondTable.AddCell(cell);
    //  //      }
    //  //  }
    //    document.Add(firstTable);
    //    document.Add(secondTable);

    //    document.Close();
    //    MessageBox.Show("pdf kaydedildi");




}






