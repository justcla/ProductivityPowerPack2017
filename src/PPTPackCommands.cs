namespace ProductivityPowerPack
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidVSPackageString = "9996012b-8251-40e7-b2b1-e0222355ba77";
        public const string guidVSPackageCmdSetString = "231940e2-0949-4e7c-997d-de5a9e3c40fd";
        public static Guid guidVSPackage = new Guid(guidVSPackageString);
        public static Guid guidVSPackageCmdSet = new Guid(guidVSPackageCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenuGroup = 0x1021;
        public const int ResetExtensions = 0x0200;
    }
}
