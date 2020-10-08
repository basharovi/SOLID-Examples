namespace SingleResponsibilityPrinciple.Example2
{
    public interface IMapper <TDestination> where TDestination : class
    {
        TDestination Map(object sourceModel);
    }
}
