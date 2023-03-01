namespace MonkeyGallery;

using MonkeyGallery.Models;
using System.ComponentModel;
using System.Text.Json;

public partial class MainPage : ContentPage
{
	Monkey monkey;
	int i = 0;
	private static List<Monkey> monkeys = new List<Monkey>()
	{
		new Monkey()
		{
			Name = "Baboon",
			Location= "Africa & Asia",
			Image= "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
			Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
			Population = 10000
		},
		new Monkey()
		{
			Name= "Blue Monkey",
			Location= "Central and East Africa",
			Details= "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
			Image= "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg",
			Population= 12000
		},
		new Monkey()
		{
			Name = "Capuchin Monkey",
			Location= "Central & South America",
			Details= "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
			Image= "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
			Population= 23000
		}
	};
	public MainPage()
	{
		monkey = new Monkey(monkeys[0]);
		this.BindingContext = monkey;
		InitializeComponent();
	}

    private void forward_Clicked(object sender, EventArgs e)
    {
        i = (i + 1) % monkeys.Count;
        monkey.Copy(monkeys[i]);
    }
    private void backward_Clicked(object sender, EventArgs e)
    {
		if (i == 0) i = monkeys.Count - 1;
		else
			i = (i - 1) % monkeys.Count;

        monkey.Copy(monkeys[i]);
    }
}

