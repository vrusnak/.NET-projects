using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing.Printing;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_6_lvl2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> newProduct = new List<string>();
        List<string> itemList = new List<string>();
        List<Product> products = new List<Product>();
        Sender currSender = new Sender();
        Receiver currReceiver = new Receiver();

        /// <summary>
        /// Initializes the MainWindow.
        /// </summary>
        public MainWindow()
        {
            System.Threading.Thread.Sleep(3000);
            InitializeComponent();
            DefaultImage();
            ReadTextFile();
            PlaceReceiver();
            PlaceSender();
            PlaceItems();
            UpdateGUI();
            PlaceEventHandlers();
        }

        /// <summary>
        /// Places event handlers.
        /// </summary>
        private void PlaceEventHandlers()
        {
            menuLoadImg.Click += (s, e) =>
            {
                string path = OpenFile();
                imgInvoice.Source = new BitmapImage(new Uri(path));
            };
            menuSaveInvoice.Click += (s, e) => SaveInvoice();
            menuPrintInvoice.Click += (s, e) => PrintInvoice();
            menuExit.Click += (s, e) => this.Close();

            btnUnselect.Click += (s, e) => lwProducts.SelectedIndex = -1;

            lwProducts.SelectionChanged += (s, e) =>
            {
                if (lwProducts.SelectedIndex > -1)
                    btnUnselect.Visibility = Visibility.Visible;
                else
                    btnUnselect.Visibility = Visibility.Hidden;
            };

            tbDiscount.TextChanged += (s, e) =>
            {
                if (tbDiscount.Text.Contains("."))
                {
                    tbDiscount.Text = tbDiscount.Text.Replace(".", ",");
                    tbDiscount.SelectionStart = tbDiscount.Text.Length;
                }
                if (tbDiscount.Text != string.Empty)
                {
                    double value;
                    double discount = 0;
                    if (double.TryParse(tbDiscount.Text, out value))
                        discount = double.Parse(tbDiscount.Text);
                    tbTotal.Text = string.Format("{0:0.00}", CalcTotalAmount() - discount);
                }
                else
                    tbTotal.Text = string.Format("{0:0.00}", CalcTotalAmount());
            };

            tbInvoiceDate.LostFocus += (s, e) =>
            {
                DateTime date;
                if (!DateTime.TryParse(tbInvoiceDate.Text, out date))
                {
                    MessageBox.Show("Not a valid dateformat!", "Wrong format", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbInvoiceDate.Text = currReceiver.InvoiceDate;
                }
            };
            tbDueDate.LostFocus += (s, e) =>
            {
                DateTime date;
                if (!DateTime.TryParse(tbDueDate.Text, out date))
                {
                    MessageBox.Show("Not a valid dateformat!", "Wrong format", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbDueDate.Text = currReceiver.DueDate;
                }
            };
        }

        /// <summary>
        /// Loads an icon and a default image.
        /// </summary>
        private void DefaultImage()
        {
            System.Drawing.Icon icon = Properties.Resources.invoiceIcon;
            System.IO.MemoryStream iconStream = new System.IO.MemoryStream();
            icon.Save(iconStream);
            iconStream.Seek(0, System.IO.SeekOrigin.Begin);
            this.Icon = BitmapFrame.Create(iconStream);

            System.Drawing.Bitmap image = Properties.Resources.noImage;
            BitmapImage bitmapImage = LoadImage(image);
            imgInvoice.Source = bitmapImage;
        }

        /// <summary>
        /// Updates the MainWindow.
        /// </summary>
        private void UpdateGUI()
        {
            if (products != null)
                lwProducts.ItemsSource = products;
            lblSenderAddress.Text = currSender.GetAddress();
            lblPhone.Text = currSender.GetPhone();
            lblWebsite.Text = currSender.GetWebsite();
            lblReceiverAddress.Text = currReceiver.GetAddress();
            lblInvoiceNbr.Text = "Invoice number\n" + currReceiver.InvoiceNbr;
            lblInvoiceDate.Text = "Invoice date\n";
            lblDueDate.Text = "Due Date\n";

            tbInvoiceDate.Text = currReceiver.InvoiceDate;
            tbDueDate.Text = currReceiver.DueDate;
            tbTotal.IsReadOnly = true;
            tbTotal.Text = string.Format("{0:0.00}", CalcTotalAmount());

            btnUnselect.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Reads a textfile and saves it in a list.
        /// </summary>
        private void ReadTextFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/Invoice.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        newProduct.Add(line);
                    for (int i = 9; i < newProduct.Count - 7; i++)
                    {
                        if (newProduct[i].Contains("."))
                            newProduct[i] = newProduct[i].Replace(".", ",");
                        itemList.Add(newProduct[i]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Initializes the reciever information.
        /// </summary>
        private void PlaceReceiver()
        {
            currReceiver.InvoiceNbr = newProduct[0];
            currReceiver.InvoiceDate = newProduct[1];
            currReceiver.DueDate = newProduct[2];
            currReceiver.ReceiverCompany = newProduct[3];
            currReceiver.ReceiverName = newProduct[4];
            currReceiver.Street = newProduct[5];
            currReceiver.ZipCode = newProduct[6];
            currReceiver.City = newProduct[7];
            currReceiver.Country = newProduct[8];
        }

        /// <summary>
        /// Initializes the products information.
        /// </summary>
        private void PlaceItems()
        {
            Product currProduct = new Product();
            currProduct.Items = int.Parse(itemList[itemList.Count - itemList.Count]);
            itemList.Remove(itemList[0]);
            int count = 1;

            while (itemList.Count != 0)
            {
                currProduct.Description = itemList[itemList.Count - itemList.Count];
                itemList.Remove(itemList[0]);
                currProduct.Quantity = itemList[itemList.Count - itemList.Count];
                itemList.Remove(itemList[0]);
                currProduct.UnitPrice = itemList[itemList.Count - itemList.Count];
                itemList.Remove(itemList[0]);
                currProduct.Tax = itemList[itemList.Count - itemList.Count];
                itemList.Remove(itemList[0]);
                currProduct.TotalTax = (0.01 * double.Parse(currProduct.Tax)) * double.Parse(currProduct.Quantity) * double.Parse(currProduct.UnitPrice);
                currProduct.Total = double.Parse(currProduct.UnitPrice) * double.Parse(currProduct.Quantity);

                products.Add(new Product() { Items = count, Description = currProduct.Description, Quantity = currProduct.Quantity, UnitPrice = currProduct.UnitPrice, Tax = currProduct.Tax, TotalTax = currProduct.TotalTax, Total = currProduct.Total });
                count++;
            }
        }

        /// <summary>
        /// Initializes the sender information.
        /// </summary>
        private void PlaceSender()
        {
            currSender.SenderCompany = newProduct[newProduct.Count - 7];
            currSender.Street = newProduct[newProduct.Count - 6];
            currSender.ZipCode = newProduct[newProduct.Count - 5];
            currSender.City = newProduct[newProduct.Count - 4];
            currSender.Country = newProduct[newProduct.Count - 3];
            currSender.Phone = newProduct[newProduct.Count - 2];
            currSender.URL = newProduct[newProduct.Count - 1];
        }

        /// <summary>
        /// Calculates the total amount to pay.
        /// </summary>
        /// <returns>
        /// The total amount to pay.
        /// </returns>
        private double CalcTotalAmount()
        {
            double amount = 0;
            foreach (Product item in products)
                amount += item.Total;
            return amount;
        }

        /// <summary>
        /// Opens a file from the local computer.
        /// </summary>
        /// <returns></returns>
        private string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    return filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File not opened", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return null;
        }

        /// <summary>
        /// Saves a file to the local computer.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private string SaveFile(RenderTargetBitmap bitmap)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    if (!(filePath.Contains(".jpeg") || filePath.Contains(".jpg")))
                        filePath += ".jpeg";
                    JpegBitmapEncoder jpeg = new JpegBitmapEncoder();
                    jpeg.Frames.Add(BitmapFrame.Create(bitmap));
                    Stream stream = File.Create(filePath);
                    jpeg.Save(stream);
                    stream.Flush();
                    stream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File could not be saved", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return null;
        }

        /// <summary>
        /// Loads an image. Takes a bitmap as parameter.
        /// </summary>
        private BitmapImage LoadImage(System.Drawing.Bitmap image)
        {
            using (System.IO.MemoryStream memory = new System.IO.MemoryStream())
            {
                image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage;
            }
        }

        /// <summary>
        /// Saves the invoice as an image to the local machine.
        /// </summary>
        private void SaveInvoice()
        {
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)this.Width, (int)this.Height, 99, 103, PixelFormats.Pbgra32);
            bitmap.Render(this);
            SaveFile(bitmap);
        }

        /// <summary>
        /// Skriver bara ut componenterna (ingen text)
        /// </summary>
        private void PrintInvoice()
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(gridMain, "Invoice");
            }
        }
    }
}
