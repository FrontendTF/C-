using System.Windows;
using InvoiceCreatorApp.ViewModels; // Vermittler zwischen Model und View, der die Logik und Daten für die Benutzeroberfläche bereitstellt.
using System.IO; 
namespace InvoiceCreatorApp
{
    // Mainwindow erbt von Window
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new InvoiceViewModel();
        }

        // Speicherort aussuchen
        private void SaveInvoiceButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt|Word document (*.doc)|*.doc",
                DefaultExt = ".txt"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                SaveInvoice(saveFileDialog.FileName);
                MessageBox.Show("Rechnung gespeichert!");
            }
        }

        private void SaveInvoice(string filePath)
        {
            var viewModel = DataContext as InvoiceViewModel;
            if (viewModel == null) return;

            // Recheninhalt erstellen
            var invoiceContent = $"Rechnung\n\n" +
                                 $"Firmenname: {viewModel.CompanyName}\n" +
                                 $"Kundenname: {viewModel.CustomerName}\n" +
                                 $"Kundennummer: {viewModel.CustomerNumber}\n" +
                                 $"Warenbezeichnung: {viewModel.ProductName}\n" +
                                 $"Anzahl: {viewModel.Quantity}\n" +
                                 $"Preis pro Stück: {viewModel.PricePerUnit:C}\n" +
                                 $"Gesamtpreis (inkl. 20% MwSt.): {viewModel.TotalPrice:C}\n";

            File.WriteAllText(filePath, invoiceContent); // Speicherort
        }
    }
}
