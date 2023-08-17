namespace DI_Service_Lifetime.Service
{
    public class SingleGuidService : ISingletonGuidService
    {
        private readonly Guid Id;
        public SingleGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
