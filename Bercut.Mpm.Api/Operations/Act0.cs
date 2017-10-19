using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations
{
    public class Act0
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 0;

            /// <summary xml:lang="ru">
            ///     Номер лицевого счета для PostPaid-абонентов
            /// </summary>
            /// <summary xml:lang="en">
            ///     Account number for PostPaid-subscribers
            /// </summary>
            [ParameterName("PAY_ACCOUNT")]
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
            public string PayAmount { get; set; }

            /// <summary xml:lang="ru">
            ///     Идентификатор филиала
            /// </summary>
            /// <summary xml:lang="en">
            ///     branch identifier
            /// </summary>
            [ParameterName("BRANCH")]
            public string Branch { get; set; }

            /// <summary xml:lang="ru">
            ///     Тип источника платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     Type of payment source
            /// </summary>
            [ParameterName("SOURCE_TYPE")]
            public string SourceType { get; set; }

            /// <summary xml:lang="ru">
            ///     Код торговой точки
            /// </summary>
            /// <summary xml:lang="en">
            ///     Code outlet
            /// </summary>
            [ParameterName("TRADE_POINT")]
            public string TradePoint { get; set; }

            /// <summary xml:lang="ru">
            ///     Код валюты платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     The currency code payment
            /// </summary>
            [ParameterName("CURRENCY_CODE")]
            public string CurrencyCode { get; set; }

            /// <summary xml:lang="ru">
            ///     Идентификатор транзакции платежной системы
            /// </summary>
            /// <summary xml:lang="en">
            ///     The identifier of the payment transaction system
            /// </summary>
            [ParameterName("PAY_TRANS_ID")]
            public string PayTransId { get; set; }

            /// <summary xml:lang="ru">
            ///     Идентификатор подключаемой услуги.
            /// </summary>
            /// <summary xml:lang="en">
            ///     ID of the connected services
            /// </summary>
            [ParameterName("SERV_CODE")]
            public string ServCode { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan
        {
            /// <summary xml:lang="ru">
            ///     Идентификационный номер транзакции
            /// </summary>
            /// <summary xml:lang="en">
            ///     Transaction tracking number
            /// </summary>
            [DeserializeAs(Name = "pay_id")]
            public string PayId { get; set; }
        }
    }
}