namespace Finance.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    public HomePageViewModel()
    {
        Equations = new(new List<Equation>()
        {
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png" }
        });

        Topics = new(new List<Topic>()
        {
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},
            new Topic() { Name="Bonos", Image = "money_bag.png", Description="Sección de bonos", ReadTime="7 min"},

        });
    }

    [ObservableProperty]
    private Topic _selectedTopic;

    [ObservableProperty]
    private ObservableCollection<Topic> _topics;

    [ObservableProperty]
    private Equation _selectedEquation;

    [ObservableProperty]
    private ObservableCollection<Equation> _equations;
}