using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using Microsoft.Win32;
using System.Collections.ObjectModel;

namespace ShowHashFileNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Hash> hashes;

        public MainWindow()
        {
            InitializeComponent();

            hashes = new ObservableCollection<Hash>();
 
            hashList.ItemsSource = hashes.Select(u => u.Name?.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            OpenFileDialog dlg = new OpenFileDialog();
           
            if (dlg.ShowDialog() == true)
            {
                string directory1 = dlg.FileName;
                textBox3.Text = dlg.FileName;
                using (var md5 = MD5.Create())
                            {
                                using (var stream = File.OpenRead(directory1))
                                {
                                    var  hash = md5.ComputeHash(stream);
                                    textBox2.Text = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                                }
                            }

                using (var sha256 = SHA256.Create())
                            {
                                using (var stream = File.OpenRead(directory1))
                                {
                                    var hash = sha256.ComputeHash(stream);
                                    textBox1.Text = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                                }
                            }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string md5file = "no hash";
            string sha256file = "no hash";

            string directory = textBox5.Text;

            hashes.Clear();

            var dir = new DirectoryInfo(directory);
             
          
                FileInfo[] files = dir.GetFiles();
          
                    foreach (FileInfo fInfo in files)
                    {
                    //    using (FileStream fileStream = fInfo.Open(FileMode.Open))
                        {
                            try
                            {

                        
                            using (var md5 = MD5.Create())
                            {
                                using (var stream = File.OpenRead(fInfo.FullName))
                                {
                                      var hash = md5.ComputeHash(stream);
                                      md5file = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                                     
                                }
                            }
                            using (var sha256 = SHA256.Create())
                            {
                                using (var stream = File.OpenRead(fInfo.FullName))
                                {
                                    var hash = sha256.ComputeHash(stream);
                                    sha256file = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                                }
                            }

                        hashes.Add(new Hash(fInfo.Name, fInfo.Length, System.IO.Path.GetExtension(fInfo.Name), md5file,sha256file));
                           // hashList.ItemsSource =
                           //         hashes.Select(u => u.Name?.ToString()) + ":" +
                                 // hashes.Select(u => u.Name?.ToString()) + ":" +
                           //         hashes.Select(u => u.Typ?.ToString()) + ":" +
                            //        hashes.Select(u => u.Md5hash?.ToString()) + ":" +
                            //        hashes.Select(u => u.Sha256hash?.ToString());
                            hashList.ItemsSource = hashes;







                    }
                            catch (IOException)
                            {
                                MessageBox.Show("I/O Exception");
                            }
                            catch (UnauthorizedAccessException)
                            {
                                MessageBox.Show("Access Exception");
                            }
                        }
                    }

              


        }
    }


}
