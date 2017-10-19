using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations
{
    public class Act1
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 1;

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
        {
            /// <summary xml:lang="ru">
            ///     Номер чека
            /// </summary>
            /// <summary xml:lang="en">
            ///     Check number
            /// </summary>
            [DeserializeAs(Name = "receipt")]
            public string Receipt { get; set; }
        }
    }
}