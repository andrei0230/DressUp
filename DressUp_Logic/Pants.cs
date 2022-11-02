namespace DressUp_Logic
{
    public class Pants : Item, IColorable
    {
        public Pants(string _name, string _photo) : base(_name, _photo) { }

        public double GetColor(string _photo)
        {
            double color = 0;

            return color;
        }
    }
}
