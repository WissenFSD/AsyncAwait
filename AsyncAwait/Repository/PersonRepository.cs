using AsyncAwait.DMO;
using Microsoft.EntityFrameworkCore;

namespace AsyncAwait.Repository
{
	public class PersonRepository
	{
		private AdventureWorks2019Context _context;
        public PersonRepository(AdventureWorks2019Context context)
        {
            _context = context;
        }
        public List<Person> GetPerson()
		{
			return _context.People.ToList();

		}
		public async Task<List<Person>> GetAsyncPerson()
		{
			var peoples = await _context.People.ToListAsync();

			return peoples;
		}
		
		
	}
}
