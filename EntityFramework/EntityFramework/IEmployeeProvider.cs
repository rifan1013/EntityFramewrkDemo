namespace EntityFramework
{
    internal interface IEmployeeProvider
    {
        Employee Get(int id);
    }
}