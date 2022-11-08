using System.ComponentModel;

namespace DressUp_Logic
{
    public class RGBColor
    {
        #region Fields

        private float r = 0;
        private float g = 0;
        private float b = 0;

        #endregion

        #region Constructors

        public RGBColor(float _r, float _g, float _b)
        {
            r = _r;
            g = _g;
            b = _b;
        }

        #endregion

        #region Properties

        public float R { get { return r; } }
        public float G { get { return g; } }
        public float B { get { return b; } }

        #endregion

        #region Methods

        public static bool operator == (RGBColor c1, RGBColor c2)
        {
            if (c1 is null || c2 is null)
                return false;

            return c1.Equals(c2);
        }

        public static bool operator != (RGBColor c1, RGBColor c2)
        {
            if (c1 is null || c2 is null)
                return false;

            return !c1.Equals(c2);
        }
        
        public override bool Equals(object? obj)
        {
            if(obj is null || GetType() != obj.GetType())
                return false;   

            var color = (RGBColor)obj;
            
            return (r == color.r && g == color.g && b == color.b);
        }

        public override int GetHashCode()
        {
            return this.r.GetHashCode() ^ this.g.GetHashCode() ^ this.b.GetHashCode();
        }

        #endregion
    }
}
