using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations
{
    public class Act7
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 7;

            /// <summary xml:lang="ru">
            ///     Номер лицевого счета для PostPaid-абонентов
            /// </summary>
            /// <summary xml:lang="en">
            ///     Account number for PostPaid-subscribers
            /// </summary>
            [ParameterName("PAY_ACCOUNT")]
            [ParameterDefaultValue(0)]
            public string PayAccount { get; set; }

            /// <summary xml:lang="ru">
            ///     Номер абонента-получателя платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     Number of recipient of payment
            /// </summary>
            [ParameterName("MSISDN")]
            public string Msisdn { get; set; }

            /// <summary xml:lang="ru">
            ///     Сумма платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     Amount of payment
            /// </summary>
            [ParameterName("PAY_AMOUNT")]
            [ParameterDefaultValue(0)]
            public string PayAmount { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan, IResponseWithBalance
        {
            /// <summary xml:lang="ru">
            ///     Номер лицевого счета для PostPaid-абонентов
            /// </summary>
            /// <summary xml:lang="en">
            ///     Account number for PostPaid-subscribers
            /// </summary>
            [DeserializeAs(Name = "pay_account")]
            public string PayAccount { get; set; }

            /// <summary xml:lang="ru">
            ///     ФИО абонента. Необязательный параметр
            /// </summary>
            /// <summary xml:lang="en">
            ///     subscriber name. Optional
            /// </summary>
            [DeserializeAs(Name = "name")]
            public string Name { get; set; }
            /// <summary xml:lang="ru">
            ///     Баланс абонента
            /// </summary>
            /// <summary xml:lang="en">
            ///     the subscriber's balance
            /// </summary>
            [DeserializeAs(Name = "balance")]
            public string Balance { get; set; }
        }
    }
}