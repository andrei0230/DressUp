using SkiaSharp;

namespace DressUp_Logic
{
    public abstract class Item
    {
        #region Fields

        private string _name = "name";
        private string _photo = "photo";

        #endregion

        #region Constructors

        public Item(string name, string photo)
        {
            _name = name;
            _photo = photo;
        }

        #endregion

        #region Properties

        public string Name { get { return _name; } set { _name = value;  } }

        public string Photo { get { return _photo; } set { _photo = value; } }

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
