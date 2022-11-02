namespace DressUp_Logic
{
    public abstract class Item
    {
        #region Fields

        private string name = "name";
        private string photo = "photo";

        #endregion

        #region Constructors

        public Item(string _name, string _photo)
        {
            Name = _name;
            Photo = _photo;
        }

        #endregion

        #region Properties

        public string Name { get { return name; } set { name = value;  } }

        public string Photo { get { return photo; } set { photo = value; } }   

        #endregion
    }
}
