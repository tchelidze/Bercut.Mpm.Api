using Bercut.Mpm.Api.Operations.Shared;

namespace Bercut.Mpm.Api.Operations.Extensions
{
    public static class IResponseWithBalanceExtensions
    {
        public static double ParseBalance(this IResponseWithBalance responseWithBalance)
            => double.Parse(responseWithBalance.Balance);

        public static bool HasNumericValue(this IResponseWithBalance responseWithBalance)
            => !string.IsNullOrEmpty(responseWithBalance.Balance) && responseWithBalance.Balance != "N/A";
    }
}