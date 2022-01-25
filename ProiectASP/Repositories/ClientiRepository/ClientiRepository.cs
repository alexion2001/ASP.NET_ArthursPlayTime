using Microsoft.EntityFrameworkCore;
using ProiectASP.Data;
using ProiectASP.Entities;
using ProiectASP.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.ClientiRepository
{
    public class ClientiRepository : GenericRepository<Clienti>, IClientiRepository
    {
        public ClientiRepository(Context context) : base(context) { }


        public async Task<List<Clienti>> GetAllClienti()
        {
            return await _context.Clienti.ToListAsync();
        }

        public async Task<Clienti> GetByIdClient(int id)
        {
            return await _context.Clienti.Where(a => a.IdClient.Equals(id)).FirstOrDefaultAsync();
        }


        public async Task<dynamic> GetAllComenziClient(string mail)
        {

            var result = (from client in _context.Clienti
                          join comenzi in _context.Comenzi 
                          on client.Mail equals mail

                          select new
                          {   id = comenzi.IdComanda,
                              data = comenzi.Data,
                              val = comenzi.Valoare
                          }).ToList();


            return result;
        }

        public async Task<dynamic> GetByMail(string mail)
        {

            var result = await _context.Clienti.Where(a => a.Mail.Equals(mail)).FirstOrDefaultAsync();
           
            return result;
        }
        

    }
}
