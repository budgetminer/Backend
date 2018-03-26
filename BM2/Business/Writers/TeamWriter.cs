using BM2.Business.Base;
using BM2.DataAccess.Entities;
using Digipolis.DataAccess;

namespace BM2.Business.Writers
{
    public class TeamWriter : WriterBase<Team>, ITeamWriter
    {
        public TeamWriter(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
