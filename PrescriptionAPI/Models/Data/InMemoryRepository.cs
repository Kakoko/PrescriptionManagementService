namespace PrescriptionAPI.Models.Data
{
    public class InMemoryRepository : IPrescriptionRepository
    {

        private static List<Prescription> prescriptions = new List<Prescription>()
        {
            new Prescription(){ Id = 1 , Amount = 200.00m , 
                Frequency = 3 , PatientName = "Code Unparalled"},
              new Prescription(){ Id = 2 , Amount = 500.00m ,
                Frequency = 3 , PatientName = "No one"},
                new Prescription(){ Id = 3 , Amount = 1000.00m ,
                Frequency = 3 , PatientName = "Bad Coding practice"}
        };

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
            return prescriptions[id];
        }

        public IEnumerable<Prescription> GetAll()
        {
            return prescriptions;
        }

        public void Update(Prescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
