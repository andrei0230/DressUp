namespace DressUp_Logic
{
    public class Outfit
    {
        #region Fields

        private Body _body;
        private Pants _pants;
        private Shoes _shoes;

        #endregion

        #region Constructors

        public Outfit(Body body, Pants pants, Shoes shoes)
        {
            _body = body;
            _pants = pants;
            _shoes = shoes;
        }

        #endregion

        #region Properties

        public Body Body { get { return _body; } }
        public Pants Pants { get { return _pants; } }
        public Shoes Shoes { get { return _shoes; } }

        #endregion

        #region Methods

        #endregion
    }
}
