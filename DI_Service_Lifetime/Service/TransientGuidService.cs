namespace DI_Service_Lifetime.Service
{
    public class TransientGuidService : ITransientGuidService   
    {
        private readonly Guid Id;
        public TransientGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
