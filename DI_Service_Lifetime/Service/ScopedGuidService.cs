namespace DI_Service_Lifetime.Service
{
    public class ScopedGuidService : IScopedGuidService
    {
        private readonly Guid Id;
        public ScopedGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
