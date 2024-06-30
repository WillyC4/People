using People.Models;
using People.Repositorios;
using System.Collections.Generic;

namespace People.Views;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";
        Person person = new Person()
        {
            Name = newPerson.Text
        };
        App.PersonRepo.AddNewPerson(person);
       // App.PersonRepo.AddNewPerson(newPerson.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

       List<Person> people = App.PersonRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }

}

