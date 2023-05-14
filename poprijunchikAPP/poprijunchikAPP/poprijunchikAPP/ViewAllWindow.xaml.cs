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

namespace poprijunchikAPP
{
    /// <summary>
    /// Логика взаимодействия для ViewAllWindow.xaml
    /// </summary>
    public partial class ViewAllWindow : Window
    {
        public ViewAllWindow()
        {
            InitializeComponent();
            LoadComponents();
        }

        //Создание метода загрзки основных компонентов системы
        private void LoadComponents()
        {
            using (var db = new poprijunDBEntities())
            {
                mainDataGrid.ItemsSource = (from ai in db.AgentInfo select ai).OrderBy(ai => ai.AgentName).ToList();
                var items = (from at in db.AgentType select at).ToList();
                items.Add(new AgentType() { TypeName = "Все типы" });
                FiltrComboBox.ItemsSource = items;
                FiltrComboBox.SelectedItem = items.Where(type => type.TypeName == "Все типы").FirstOrDefault();
            }
            SortComboBox.Items.Add("Отсортировать по имени");
            SortComboBox.Items.Add("Отсортировать по приоритетности");
            SortComboBox.SelectedItem = "Отсортировать по имени";
        }

        //Метод очищения бокса поиска при нажатии на него для удобства пользователя
        private void SearchingTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SearchingTextBox.Text = "";
        }
        
        //Обработчик изменения выбранного элемента в комбо боксе
        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new poprijunDBEntities())
            {
                if (SortComboBox.SelectedItem == "Отсортировать по имени")
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo select ai).OrderBy(ai => ai.AgentName).ToList();
                }
                else
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo select ai).OrderBy(ai => ai.AgentPriority).ToList();
                }
            }
            
        }

        //Обработчик изменения выбранного элемента в комбо боксе
        private void FiltrComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new poprijunDBEntities())
            {
                if ((FiltrComboBox.SelectedItem as AgentType).ID == 1)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 1 select ai).ToList();
                }
                else if ((FiltrComboBox.SelectedItem as AgentType).ID == 2)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 2 select ai).ToList();
                }
                else if ((FiltrComboBox.SelectedItem as AgentType).ID == 3)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 3 select ai).ToList();
                }
                else if ((FiltrComboBox.SelectedItem as AgentType).ID == 4)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 4 select ai).ToList();
                }
                else if ((FiltrComboBox.SelectedItem as AgentType).ID == 5)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 5 select ai).ToList();
                }
                else if ((FiltrComboBox.SelectedItem as AgentType).ID == 6)
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.TypeID == 6 select ai).ToList();
                }
                else
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo select ai).ToList();
                }
            }
        }

        //Обработчик изменения написанного текста в текст боксе
        private void SearchingTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (var db = new poprijunDBEntities())
            {
                List<AgentInfo> agentInfo;
                if (SearchingTextBox.Text == "")
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo select ai).OrderBy(ai => ai.AgentName).ToList();
                }
                else if (SearchingTextBox.Text == "Введите для поиска")
                {
                    return;
                }
                else
                {
                    mainDataGrid.ItemsSource = (from ai in db.AgentInfo where ai.AgentName.Contains(SearchingTextBox.Text) select ai).ToList();
                }
            }
        }

        private void AddNewAgent_Click(object sender, RoutedEventArgs e)
        {
            SystemContext.isEditing = false;
            EditingWindow editingWindow = new EditingWindow();
            this.Close();
            editingWindow.ShowDialog();
        }

        private void ChangeAgent_Click(object sender, RoutedEventArgs e)
        {
            if (mainDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования");
                return;
            }
            SystemContext.AgentInfo = (AgentInfo)mainDataGrid.SelectedItem;
            SystemContext.isEditing = true;
            EditingWindow editingWindow = new EditingWindow();
            this.Close();
            editingWindow.ShowDialog();
        }
    }
}
