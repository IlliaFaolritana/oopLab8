using System.Collections;

namespace OOPlr8
{
    class Operation : IEnumerable<Category>
    {
        private readonly int value;
        private readonly Time time;
        private readonly List<Category> categories;

        public Operation(int value)
        {
            this.value = value;
            time = new Time();
            categories = new List<Category>();
        }
        public int Value
        {
            get { return value; }
        }
        public Time Time
        {
            get { return time; }
        }
        public void AddCategory(Category category)
        {
            categories.Add(category);
        }
        public void RemoveCategory(Category category)
        {
            categories.Remove(category);
        }
        public List<Category> GetCategories()
        {
            return categories;
        }
        public bool HasCategory(Category category)
        {
            foreach(Category thisCategory in categories)
            {
                if(category == thisCategory)
                    return true;
            }
            return false;
        }
        public IEnumerator<Category> GetEnumerator()
        {
            return categories.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
