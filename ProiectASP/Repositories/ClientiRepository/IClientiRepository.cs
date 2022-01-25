using ProiectASP.Entities;
using ProiectASP.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.ClientiRepository
{
    public interface IClientiRepository : IGenericRepository<Clienti>
    {
        
            Task<Clienti> GetByIdClient(int id);
            Task<dynamic> GetByMail(string mail);
           Task<List<Clienti>> GetAllClienti();
            Task<dynamic> GetAllComenziClient(string mail);

    }
}
