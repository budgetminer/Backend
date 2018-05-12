using BM2.Business.Base;
using BM2.DataAccess.Entities;
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
