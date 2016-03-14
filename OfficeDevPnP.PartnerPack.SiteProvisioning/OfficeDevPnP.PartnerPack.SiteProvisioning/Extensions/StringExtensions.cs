using System;

namespace OfficeDevPnP.PartnerPack.SiteProvisioning.Extensions
{
    public static class StringExtensions
    {
        public static int OrdinalIndexOf(this string str, string match)
        {
            return str.IndexOf(match, StringComparison.Ordinal);
        }

        public static int OrdinalLastIndexOf(this string str, string match)
        {
            return str.LastIndexOf(match, StringComparison.Ordinal);
        }
    }
}