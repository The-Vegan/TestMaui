using System.ComponentModel;
using TestMaui.Models;

namespace TestMaui.ViewModel
{
    public class MultiPic : BindableObject
    {
        public event CollectionChangeEventHandler CollectionChange;

        public IList<Pic> Pictures = new List<Pic>();
        private string collectionName;
        public string CollectionName
        {
            get => collectionName;
            set
            {
                collectionName = value;
                OnPropertyChanged();
            }
        }

        public MultiPic() { }

        public MultiPic(Pic p) 
        {
            if (p == null) return;

            this.CollectionName = p.Category;
            AddPic(p);
        }
        public MultiPic(Pic[] p)
        {
            if (p.Length == 0) return;
            if (p[0] == null) return;

            this.CollectionName = p[0].Category;
            this.Pictures.Add(p[0]);
            for(int i = 1;i < p.Length;i++)
            {
                AddPic(p[i]);
            }
        }
        public void AddPic(Pic p)
        {
            if (p == null) return;

            if(string.IsNullOrEmpty(this.CollectionName)) this.CollectionName = p.Category;
            else if (p.Category != this.CollectionName) return;

            Console.WriteLine("[MultiPic] Adding pic : " + p.Source);

            this.Pictures.Add(p);
            CollectionChange?.Invoke(this, new CollectionChangeEventArgs(CollectionChangeAction.Add, this.Pictures));
        }
    }
}
