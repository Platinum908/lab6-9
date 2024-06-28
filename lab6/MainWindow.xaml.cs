using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<string> queue;
        private List<int> listLab3;
        private int counttt;
        private Dictionary<string, string> dDir;
        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            counttt = 0;
            queue = new Queue<string>();
            listLab3 = new List<int>();
            dDir = new Dictionary<string, string>();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listLab1.Add(int.Parse(tbElement.Text));
                lbList.ItemsSource = null;
                lbList.ItemsSource = listLab1;
                tbElement.Text = "";
                dDir = new Dictionary<string, string>();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int count = 0;
            foreach (int l in listLab1)
            {
                if (l > 0) count++;
            }
            Result.Text = "Количество не отрицательных:" + count.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {

                Price price = new Price(tbElementQueue.Text,int.Parse(tbCount.Text));
                if (price.name.ToLower() == "шариковая ручка")
                {
                    counttt++;

                }
                else { }
                queue.Enqueue(price.name +"  " +  price.cost);
                lbQueue.ItemsSource = null;
                lbQueue.ItemsSource = queue;
                tbElementQueue.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tbResultQueue.Text = counttt.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            listLab3.Add(int.Parse(tbElementAdd.Text));
            lbList3.ItemsSource = null;
            lbList3.ItemsSource = listLab3;
            tbElementAdd.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (listLab3.Count > 1)
            {
                listLab3.RemoveAt(0);
                lbList3.ItemsSource = null;
                lbList3.ItemsSource = listLab3;
            }
            else { MessageBox.Show("Массив пустой или состоит из 1 элемента"); }


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (listLab3.Count > 1)
            {
                listLab3.RemoveAt(listLab3.Count -1);
                lbList3.ItemsSource = null;
                lbList3.ItemsSource = listLab3;
            }
            else { MessageBox.Show("Массив пустой или состоит из 1 элемента"); }

        }

      

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            direct.ItemsSource = null;
            direct.ItemsSource = dDir;
            if (dDir.ContainsKey(directvv.Text.ToLower()))
            {
                res.Text = dDir[directvv.Text];



            }
            else
            {
                res.Text = "Access denied.";

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                dDir.Add("x", "ок");
                dDir.Add("r", "ок");
                dDir.Add("w", "ок");
                direct.ItemsSource = null;
                direct.ItemsSource = dDir;
                search.Text = dDir.Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

