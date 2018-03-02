namespace NetCoreForce.Linq.Entity
{
    public enum SelectTypeEnum
    {
        /// <summary>
        /// For Default
        /// </summary>
        SelectIdAndUseAttachModel,
        SelectIdAndUseReplaceModel,
        SelectAllAndUseReplaceModel,
        SelectAllAndUseAttachModel,
    }
}
