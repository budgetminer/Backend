using BM2.Business.Base;
using DataAccess;

namespace BM2.Business.Writers
{
    public class TeamWriter : WriterBase<Team>, ITeamWriter
    {
        public TeamWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
