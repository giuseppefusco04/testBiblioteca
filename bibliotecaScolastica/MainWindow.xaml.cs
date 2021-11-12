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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bibliotecaScolastica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca b;
        public MainWindow()
        {
            InitializeComponent();
            txt_nLibri.Text = b.GetLibri().count;
        }

        private void btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string autore = txt_autore.Text;
                string titolo = txt_titolo.Text;
                string annoPub = txt_annoPubb.Text;
                string editore = txt_editore.Text;
                int numPag = int.Parse(txt_numPag.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cercaLibroTitolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l=b.RicercaLibroTitolo(txt_titolo.Text);
                MessageBox.Show(l.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cercaLibriAutore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Libro> libri = new List<Libro>();
                libri= b.RicercaLibroAutore(txt_autore.Text);
                foreach(Libro l in libri)
                {
                    lbx_libriAutore.Items.Add(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
