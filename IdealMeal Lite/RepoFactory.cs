using DataLayer.Repositories.Implementations;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Factories
{
    public static class RepoFactory
    {
        public static Irepo GetRepo() => new FileRepo();
    }
}
