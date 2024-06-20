namespace OOPlr8
{
    class Category
    {
        private string name;
        public Category(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}
