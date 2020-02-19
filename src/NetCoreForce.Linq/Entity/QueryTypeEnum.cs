namespace NetCoreForce.Linq.Entity
{
    public enum QueryTypeEnum
    {
#if NETSTANDARD2_1
        ListAsync = 0,
        FirstAsync,
        FirstOrDefaultAsync,
        SingleAsync,
        SingleOrDefaultAsync,
        AnyAsync,
        CountAsync,
#else
        List = 0,
        First,
        FirstOrDefault,
        Single,
        SingleOrDefault,
        Any,
        Count,
#endif
        Enumerator
    }
}
