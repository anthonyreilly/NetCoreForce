namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Login page display type
    /// </summary>
    public enum DisplayTypes
    {
        /// <summary>
        /// Full-page authorization screen. This is the default value if none is specified.
        /// </summary>
        Page,

        /// <summary>
        /// Compact dialog optimized for modern Web browser popup windows.
        /// </summary>
        Popup,

        /// <summary>
        /// Mobile-optimized dialog designed for modern smartphones such as Android and iPhone.
        /// </summary>
        Touch,

        /// <summary>
        /// Mobile optimized dialog designed for smartphones such as BlackBerry OS 5 that don’t support touch screens.
        /// </summary>
        Mobile
    }
}