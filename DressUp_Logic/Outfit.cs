namespace DressUp_Logic
{
    public class Outfit
    {
        #region Fields

        private Body body;
        private Pants pants;
        private Shoes shoes;

        #endregion

        #region Constructors

        public Outfit(Body _body, Pants _pants, Shoes _shoes)
        {
            body = _body;
            pants = _pants;
            shoes = _shoes;
        }

        #endregion

        #region Properties

        public Body Body { get { return body; } }
        public Pants Pants { get { return pants; } }
        public Shoes Shoes { get { return shoes; } }

        #endregion

        #region Methods

        #endregion
    }
}
