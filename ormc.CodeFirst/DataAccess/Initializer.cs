namespace ormc.CodeFirst.DataAccess
{
    public static class Initializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}