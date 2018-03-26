﻿using BM2.Business.Base;
using BM2.DataAccess.Entities;
using Digipolis.DataAccess;

namespace BM2.Business.Readers
{
    public class TeamReader : ReaderBase<Team>, ITeamReader
    {
        public TeamReader(IUnitOfWork uow) : base(uow)
        {
        }
    }
}