using System.Collections.ObjectModel;

namespace Lab_Test;

public partial class MainPage : ContentPage
{
    // Artwork list for the CollectionView
    public ObservableCollection<ArtWork> ArtWorks { get; } =
        new ObservableCollection<ArtWork>
        {
            new ArtWork
            {
                Title = "Peach Tree in Blossom",
                Price = "$950,000",
                Image = "drawone.jpeg"
            },
            new ArtWork
            {
                Title = "Wheat Field with Cypresses",
                Price = "$1,200,000",
                Image = "drawtwo.jpeg"
            },
            new ArtWork
            {
                Title = "Starry Night Over the Rhone",
                Price = "$1,800,000",
                Image = "drawthree.jpeg"
            },
            new ArtWork
            {
                Title = "The Yellow House",
                Price = "$1,300,000",
                Image = "drawfour.jpeg"
            },
            new ArtWork
            {
                Title = "Sunflowers",
                Price = "$2,000,000",
                Image = "drawfive.jpeg"
            },
            new ArtWork
            {
                Title = "Wheat Field and Cypress",
                Price = "$1,250,000",
                Image = "drawsix.jpeg"
            },
            new ArtWork
            {
                Title = "The Starry Night",
                Price = "$3,000,000",
                Image = "drawseven.jpeg"
            }
        };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        this.Title = string.Empty;
    }
}

// Simple model class
public class ArtWork
{
    public string Title { get; set; }
    public string Price { get; set; }
    public string Image { get; set; }
}
