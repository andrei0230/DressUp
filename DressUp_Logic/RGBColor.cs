using System.ComponentModel;

namespace DressUp_Logic
{
    public class RGBColor
    {
        #region Fields

        private float _r = 0;
        private float _g = 0;
        private float _b = 0;

        #endregion

        #region Constructors

        public RGBColor(float r, float g, float b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        #endregion

        #region Properties

        public float R { get { return _r; } }
        public float G { get { return _g; } }
        public float B { get { return _b; } }

        #endregion

        #region Methods

        public double Average() 
        { 
            double result = (this.R + this.G + this.B) / 3;
            result = Math.Round(result, 2);

            return result;
        }
        
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
            
            return (_r == color._r && _g == color._g && _b == color._b);
        }

        public override int GetHashCode()
        {
            return this._r.GetHashCode() ^ this._g.GetHashCode() ^ this._b.GetHashCode();
        }

        #endregion
    }
}
