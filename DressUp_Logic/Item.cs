using SkiaSharp;

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

        #region Methods

        public RGBColor GetColor()
        {
            SKFileStream fs = new SKFileStream(Photo);
            SKBitmap bmap = SKBitmap.Decode(fs);

            float r = 0;
            float g = 0;
            float b = 0;
            int num = 0;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    r += bmap.GetPixel(i,j).Red;
                    g += bmap.GetPixel(i,j).Green;
                    b += bmap.GetPixel(i,j).Blue;
                    num++;
                }
            }

            int red = (int)(r / num);
            int green = (int)(g / num);
            int blue = (int)(b / num);

            RGBColor color = new RGBColor(red, green, blue);

            return color;
        }

        #endregion

    }
}
