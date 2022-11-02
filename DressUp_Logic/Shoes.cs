namespace DressUp_Logic
{
    public class Shoes : Item, IColorable
    {
        public Shoes(string _name, string _photo) : base(_name, _photo) { }

        public double GetColor(string _photo)
        {
            double color = 0;

            return color;
        }
    }
}
