using System.Linq.Expressions;

namespace DressUp_Logic
{
    public class OutfitManager
    {
        #region Fields

        private List<Body> bodies;
        private List<Pants> pants;
        private List<Shoes> shoes;

        #endregion

        #region Constructors

        public OutfitManager()
        {
            bodies = new List<Body>();
            pants = new List<Pants>();
            shoes = new List<Shoes>();
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public void AddItem(Body item) { bodies.Add(item); }
        
        public void AddItem(Pants item) { pants.Add(item); }

        public void AddItem(Shoes item) { shoes.Add(item); }

        #endregion
    }
}
