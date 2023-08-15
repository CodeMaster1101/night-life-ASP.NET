using night_life_sk.Data;
using night_life_sk.Models;

namespace night_life_sk.Repositories.place
{
    public interface IPartyPlaceRepository
    {
        public void Add(PartyPlace partyPlace);

        public HashSet<PartyPlace> FindAll();

        public PartyPlace FindById(int id);

        public void Update(PartyPlace partyPlace);

        public void Delete(int id);
    }
}
