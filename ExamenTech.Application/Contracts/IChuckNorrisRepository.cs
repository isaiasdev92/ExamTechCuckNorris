using ExamenTech.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTech.Application.Contracts
{
    public interface IChuckNorrisRepository
    {
        Task<CuckNorriseJokeResponse> SearchObject(string query);
    }
}
