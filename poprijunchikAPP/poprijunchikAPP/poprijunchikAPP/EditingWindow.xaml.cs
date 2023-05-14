using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для EditingWindow.xaml
    /// </summary>
    public partial class EditingWindow : Window
    {
        public poprijunDBEntities db = new poprijunDBEntities();
        public EditingWindow()
        {
            InitializeComponent();
			isEditingCheck();
			typee.ItemsSource = db.AgentType.ToList();
        }

		private void isEditingCheck()
        {
			if (SystemContext.isEditing)
			{
				AgentInfo agent = SystemContext.AgentInfo;
				Name.Text = agent.AgentName;
				email.Text = agent.AgentEmail;
				phone.Text = agent.Number;
				adrs.Text = agent.AgentAddress;
				prior.Text = agent.AgentPriority.ToString();
				director.Text = agent.Director;
				INN.Text = agent.INN;
				KPP.Text = agent.KPP;
				logo = null;
				typee.SelectedItem = (from at in db.AgentType where agent.TypeID == at.ID select at).FirstOrDefault();
				@new.Content = "Сохранить данные";
			}
			else
				delete.Visibility = Visibility.Hidden;
        }

		private void new_Click(object sender, RoutedEventArgs e)
		{
			if (@new.Content.ToString() == "Добавить")
			{
				AgentInfo ai = new AgentInfo { TypeID = (typee.SelectedItem as AgentType).ID, AgentName = Name.Text, AgentEmail = email.Text, Number = phone.Text, LogoPath = null, AgentAddress = adrs.Text, AgentPriority = Convert.ToInt32(prior.Text), Director = director.Text, INN = INN.Text, KPP = KPP.Text };
				db.AgentInfo.Add(ai);
				db.SaveChanges();
			}
			else if (@new.Content == "Сохранить данные")
			{
				AgentInfo agent = SystemContext.AgentInfo;
				agent.TypeID = (typee.SelectedItem as AgentType).ID;
				agent.AgentName = Name.Text;
				agent.AgentEmail = email.Text;
				agent.Number = phone.Text;
				agent.LogoPath = null;
				agent.AgentAddress = adrs.Text;
				agent.AgentPriority = Convert.ToInt32(prior.Text);
				agent.Director = director.Text;
				agent.INN = INN.Text;
				agent.KPP = KPP.Text;

				db.AgentInfo.AddOrUpdate(agent);
				db.SaveChanges();	
			}
			MessageBox.Show("Успешно");
		}

		private void delete_Click(object sender, RoutedEventArgs e)
		{
			var deleted = db.AgentInfo.ToList().FirstOrDefault(x => x.AgentName == Name.Text);
			db.AgentInfo.Remove(deleted);
			db.SaveChanges();
			MessageBox.Show("Агент удален");
		}

		private void exit_Click(object sender, RoutedEventArgs e)
		{
			ViewAllWindow ALW = new ViewAllWindow();
			this.Close();
			ALW.ShowDialog();
		}
	}
}
