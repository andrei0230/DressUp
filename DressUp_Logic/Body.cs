namespace DressUp_Logic
{
    public class Body : Item, IColorable
    {
        public Body(string _name, string _photo) : base(_name, _photo) { }

        public double GetColor(string _photo)
        {
            double color = 0;

            return color;
        }
    }
}