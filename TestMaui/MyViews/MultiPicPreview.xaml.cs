using TestMaui.Models;
using TestMaui.ViewModel;

namespace TestMaui.MyViews;

public partial class MultiPicPreview : ContentView
{
	private Image[] images = new Image[4];

	private MultiPic multiPic;
	public MultiPic MultiPicProperty
	{
		get => multiPic;

		set
		{
			multiPic = value;
			OnPropertyChanged();
		}
	}
	public MultiPicPreview()
	{
		InitializeComponent();
	}

    /*
	public void Init(MultiPic mp)
	{
		this.multiPic = mp;
        mp.CollectionChange += this.UpdateImageLayout;
		ColoredBorder.BackgroundColor = new Color(0, 255, 0);
	}
    */
    /*
    private void UpdateImageLayout(object sender, CollectionChangeEventArgs ccea)
    {
        Console.WriteLine("[UpdateLayout] Called");
        if (ccea.Action != CollectionChangeAction.Add) return;
       
        IList<Pic> pics = ccea.Element as IList<Pic>;

        for (int i = 0; i < images.Length; i++)
        {
            if (images[i] == null) continue;
            if (CollectionBox.Contains(images[i]))
            {
                CollectionBox.Remove(images[i]);
            }
        }//Removes all pictures before adding them back in

        if (pics.Count >= 3) CollectionBox.RowDefinitions[2] = new RowDefinition(new GridLength(160));// 2 rows
        else CollectionBox.RowDefinitions[2] = new RowDefinition(new GridLength(16));// 1 row

        if (pics.Count > 3)
        {

            {
                CollectionBox.Add(images[0], 1, 1);
                CollectionBox.SetColumnSpan(images[0], 1);
                images[0].HeightRequest = 128;
                images[0].WidthRequest = 128;
                images[0].Source = pics[0].Source;
            }
            {
                CollectionBox.Add(images[1], 2, 1);
                CollectionBox.SetColumnSpan(images[1], 1);
                images[1].HeightRequest = 128;
                images[1].WidthRequest = 128;
                images[1].Source = pics[1].Source;
            }
            {
                CollectionBox.Add(images[2], 1, 2);
                CollectionBox.SetColumnSpan(images[2], 1);
                images[2].HeightRequest = 128;
                images[2].WidthRequest = 128;
                images[2].Source = pics[2].Source;
            }
            {
                CollectionBox.Add(images[3], 2, 2);
                CollectionBox.SetColumnSpan(images[3], 1);
                images[3].HeightRequest = 128;
                images[3].WidthRequest = 128;
                images[3].Source = pics[3].Source;
            }
        }//4 or more elements
        else
        {
            switch (pics.Count())
            {
                case 0:
                    return;
                case 1:
                    CollectionBox.Add(images[0], 1, 1);
                    CollectionBox.SetColumnSpan(images[0], 2);
                    images[0].HeightRequest = 144;
                    images[0].WidthRequest = 144;
                    images[0].Source = pics[0].Source;
                    break;
                case 2:
                    {
                        CollectionBox.Add(images[0], 1, 1);
                        CollectionBox.SetColumnSpan(images[0], 1);
                        images[0].HeightRequest = 128;
                        images[0].WidthRequest = 128;
                        images[0].Source = pics[0].Source;
                    }
                    {
                        CollectionBox.Add(images[1], 2, 1);
                        CollectionBox.SetColumnSpan(images[1], 1);
                        images[1].HeightRequest = 128;
                        images[1].WidthRequest = 128;
                        images[1].Source = pics[1].Source;
                    }
                    break;
                case 3:
                    CollectionBox.Add(images[0], 1, 1);
                    CollectionBox.SetColumnSpan(images[0], 2);
                    images[0].HeightRequest = 144;
                    images[0].WidthRequest = 144;
                    images[0].Source = pics[0].Source; //Top Pic

                    {
                        CollectionBox.Add(images[1], 1, 2);
                        CollectionBox.SetColumnSpan(images[1], 1);
                        images[1].HeightRequest = 128;
                        images[1].WidthRequest = 128;
                        images[1].Source = pics[1].Source;
                    }
                    {
                        CollectionBox.Add(images[2], 2, 2);
                        CollectionBox.SetColumnSpan(images[2], 1);
                        images[2].HeightRequest = 128;
                        images[2].WidthRequest = 128;
                        images[2].Source = pics[2].Source;
                    }



                    break;
            }//PositionPicture
        }//3 or less

        Console.WriteLine("[UpdateLayout] " + images[0].Source + " was placed in " + CollectionBox.GetRow(images[0]) + "," + CollectionBox.GetColumn(images[0]));

    }
    */

    public void AddClicked(object sender, EventArgs e)
    {
        multiPic.AddPic(new Pic());
    }
}