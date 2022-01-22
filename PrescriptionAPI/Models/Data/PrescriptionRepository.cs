namespace PrescriptionAPI.Models.Data
{
    public class PrescriptionRepository : IPrescriptionRepository
    {

        private readonly PrescriptionDataContext _context;

        public PrescriptionRepository(PrescriptionDataContext context)
        {
            _context = context;
        }
        public void Create(Prescription prescription)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Prescription Get(int id)
        {
            return _context.Prescriptions.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Prescription> GetAll()
        {
            return _context.Prescriptions.ToList();
        }

        public void Update(Prescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
