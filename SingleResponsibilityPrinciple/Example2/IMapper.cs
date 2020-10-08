namespace SingleResponsibilityPrinciple.Example2
{
    public interface IMapper <Destination> where Destination : class
    {
        Destination Map(object sourceModel);
    }
}
