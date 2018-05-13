using BM2.Business.Base;
using DataAccess;

namespace BM2.Business.Readers
{
    public class TeamReader : ReaderBase<Team>, ITeamReader
    {
        public TeamReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
