// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class Package
        {
            private static FormLink<IPackageGetter> Construct(uint id) => new FormLink<IPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPackageGetter> SMC_LeverPackage => Construct(0xbe3);
        }
    }
}
