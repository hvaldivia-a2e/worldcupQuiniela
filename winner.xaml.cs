using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorldCupQuiniela
{
    /// <summary>
    /// Interaction logic for winner.xaml
    /// </summary>
    public partial class winner : Window {
        public string Champ { get; set; }
        public winner() { InitializeComponent(); }
        private void Window_Loaded(object sender, RoutedEventArgs e) { lbChamp.Content = Champ; }
        private void Button_Click(object sender, RoutedEventArgs e)  { PrintCertificate(Champ); }
        private void PrintCertificate(string name) {

            PrintDialog dialog = new PrintDialog();

            FlowDocument f = new FlowDocument
            {
                PagePadding = new Thickness(10, 0, 10, 0),
                FontSize = 44,
                FontWeight = System.Windows.FontWeights.Bold,
                FontFamily = new System.Windows.Media.FontFamily("Arial")
            };

            System.Windows.Controls.Image image = new System.Windows.Controls.Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri(System.IO.Path.GetFullPath(".//certificate-back.jpg"));
            bimg.EndInit();
            image.Source = bimg;
            f.Background = new System.Windows.Media.ImageBrush(bimg);

            #region table

            Table table1 = new Table();
            f.Blocks.Add(table1);
            table1.CellSpacing = 0;
            table1.BorderThickness = new Thickness(0);
            table1.Columns.Add(new TableColumn());
            table1.RowGroups.Add(new TableRowGroup());
            table1.LineHeight = 220.0;

            table1.RowGroups[0].Rows.Add(new TableRow());
            TableRow currentRow = table1.RowGroups[0].Rows[0];
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(string.Format("\r\n\r\n{0}", name)))));
            currentRow.Cells[0].TextAlignment = TextAlignment.Center;

            #endregion

            IDocumentPaginatorSource idoc = f as IDocumentPaginatorSource;
            dialog.PrintDocument(idoc.DocumentPaginator, "certificate");
        }
    }
}
