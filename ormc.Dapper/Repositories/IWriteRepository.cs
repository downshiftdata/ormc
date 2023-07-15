namespace ormc.Dapper.Repositories
{
    public interface IWriteRepository
    {
        void AddDriver(Models.DapperDriver value);
        void EditDriver(Models.DapperDriver value);
        void RemoveDriver(Models.DapperDriver value);
    }
}