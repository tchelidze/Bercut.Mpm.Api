using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;

namespace Bercut.Mpm.Api.Operations
{
    public class Act2
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 2;

            /// <summary xml:lang="ru">
            ///     Идентификационный номер транзакции
            /// </summary>
            /// <summary xml:lang="en">
            ///     Transaction tracking number
            /// </summary>
            [ParameterName("PAY_ID")]
            public string PayId { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan
        { }
    }
}