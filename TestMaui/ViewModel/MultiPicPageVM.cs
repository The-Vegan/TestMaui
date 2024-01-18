using System.Collections.ObjectModel;

namespace TestMaui.ViewModel
{
    public class MultiPicPageVM
    {
        ObservableCollection<MultiPic> multiPics = new ObservableCollection<MultiPic>();
        public ObservableCollection<MultiPic> MultiPics { get { return multiPics; } }
        public MultiPicPageVM() { }

        internal void AddElement(MultiPic item)
        {
            multiPics.Add(item);
            Console.WriteLine("[MultiPicPageVM] Added a MultiPic");
        }
    }
}
