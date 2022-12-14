using System.IO;

namespace DressUp_Logic
{
    public class OutfitManager
    {
        #region Fields

        private List<Body> _bodylist;
        private List<Pants> _pantslist;
        private List<Shoes> _shoeslist;
        private int _coloraccuracy;

        #endregion

        #region Constructors

        public OutfitManager()
        {
            _bodylist = new List<Body>();
            _pantslist = new List<Pants>();
            _shoeslist = new List<Shoes>();
            _coloraccuracy = 5;
        }

        #endregion

        #region Properties

        public List<Body> BodyList { get { return _bodylist; } }
        
        public List<Pants> PantsList { get { return _pantslist; } }

        public List<Shoes> ShoesList { get { return _shoeslist; } }

        public int ColorAccuracy { get { return _coloraccuracy; } set { _coloraccuracy = value; } }

        #endregion

        #region Methods

        public void AddItem(Body item) { _bodylist.Add(item); }
        
        public void AddItem(Pants item) { _pantslist.Add(item); }

        public void AddItem(Shoes item) { _shoeslist.Add(item); }

        public void RemoveItem(Body item) { _bodylist.Remove(item); }

        public void RemoveItem(Pants item) { _pantslist.Remove(item); }

        public void RemoveItem(Shoes item) { _shoeslist.Remove(item); }

        public Outfit GetMatchedOutfit(Body body) 
        {
            Pants MatchedPants = PantsList[0];
            Shoes MatchedShoes = ShoesList[0];

            foreach (Pants p in PantsList)
            {
                if (body.GetColor().Average() == p.GetColor().Average() + ColorAccuracy || body.GetColor().Average() == p.GetColor().Average() - ColorAccuracy)
                {
                    MatchedPants = p;
                }
            }

            foreach (Shoes s in ShoesList)
            {
                if(body.GetColor().Average() == s.GetColor().Average() + ColorAccuracy || body.GetColor().Average() == s.GetColor().Average() - ColorAccuracy)
                {
                    MatchedShoes = s;
                }
            }

            Outfit MatchedOutfit = new Outfit(body, MatchedPants, MatchedShoes);

            return MatchedOutfit;
        }

        public Outfit GetMatchedOutfit(Pants pants)
        {
            Body MatchedBody = BodyList[0];
            Shoes MatchedShoes = ShoesList[0];

            foreach (Body b in BodyList)
            {
                if (pants.GetColor().Average() == b.GetColor().Average() + ColorAccuracy || pants.GetColor().Average() == b.GetColor().Average() - ColorAccuracy)
                {
                    MatchedBody = b;
                }
            }

            foreach (Shoes s in ShoesList)
            {
                if (pants.GetColor().Average() == s.GetColor().Average() + ColorAccuracy || pants.GetColor().Average() == s.GetColor().Average() - ColorAccuracy)
                {
                    MatchedShoes = s;
                }
            }

            Outfit MatchedOutfit = new Outfit(MatchedBody, pants, MatchedShoes);

            return MatchedOutfit;
        }

        public Outfit GetMatchedOutfit(Shoes shoes)
        {
            Body MatchedBody = BodyList[0];
            Pants MatchedPants = PantsList[0];

            foreach (Body b in BodyList)
            {
                if (shoes.GetColor().Average() == b.GetColor().Average() + ColorAccuracy || shoes.GetColor().Average() == b.GetColor().Average() - ColorAccuracy)
                {
                    MatchedBody = b;
                }
            }

            foreach (Pants p in PantsList)
            {
                if (shoes.GetColor().Average() == p.GetColor().Average() + ColorAccuracy || shoes.GetColor().Average() == p.GetColor().Average() - ColorAccuracy)
                {
                    MatchedPants = p;
                }
            }

            Outfit MatchedOutfit = new Outfit(MatchedBody, MatchedPants, shoes);

            return MatchedOutfit;
        }

        #endregion
    }
}
