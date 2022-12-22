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

        public void RemoveItem(Body item) { bodies.Remove(item); }

        public void RemoveItem(Pants item) { pants.Remove(item); }

        public void RemoveItem(Shoes item) { shoes.Remove(item); }

        public Outfit GetMatchedOutfit(Body body) 
        {
            Pants MatchedPants = pants[0];
            Shoes MatchedShoes = shoes[0];

            foreach (Pants p in pants)
            {
                if (body.GetColor().Average() == p.GetColor().Average() + 5 || body.GetColor().Average() == p.GetColor().Average() - 5)
                {
                    MatchedPants = p;
                }
            }

            foreach (Shoes s in shoes)
            {
                if(body.GetColor().Average() == s.GetColor().Average() + 5 || body.GetColor().Average() == s.GetColor().Average() - 5)
                {
                    MatchedShoes = s;
                }
            }

            Outfit MatchedOutfit = new Outfit(body, MatchedPants, MatchedShoes);

            return MatchedOutfit;
        }

        #endregion
    }
}
