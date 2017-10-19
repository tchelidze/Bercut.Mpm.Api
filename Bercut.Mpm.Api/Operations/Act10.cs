using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations
{
    public class Act10
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 10;

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
            ///     Номер лицевого счета для PostPaid-абонентов
            /// </summary>
            /// <summary xml:lang="en">
            ///     Account number for PostPaid-subscribers
            /// </summary>
            [ParameterName("PAY_ACCOUNT")]
            public string PayAccount { get; set; }

            /// <summary xml:lang="ru">
            ///     Идентификатор подключаемой услуги.
            /// </summary>
            /// <summary xml:lang="en">
            ///     ID of the connected services
            /// </summary>
            [ParameterName("SERV_CODE")]
            public string ServCode { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan, IResponseWithBalance
        {
            /// <summary xml:lang="ru">
            ///     Баланс абонента
            /// </summary>
            /// <summary xml:lang="en">
            ///     the subscriber's balance
            /// </summary>
            [DeserializeAs(Name = "balance")]
            public string Balance { get; set; }

            /// <summary xml:lang="ru">
            ///     Признак отрицательного баланса. Значение «YES» означает, что баланс отрицательный. Значение «NO» свидетельствует о
            ///     положительности баланса. Нулевой баланс является положительным.
            /// </summary>
            /// <summary xml:lang="en">
            ///     Negative balance sign. The value of «YES» means that the negative balance. The value of «NO» indicates the balance
            ///     is positive.Zero balance is positive
            /// </summary>
            [DeserializeAs(Name = "negative_balance")]
            public string NegativeBalance { get; set; }

            /// <summary xml:lang="ru">
            ///     Результат операции. При успешном завершении значение параметра «21»
            /// </summary>
            /// <summary xml:lang="en">
            ///     The result of the operation. the value "21" parameter upon successful completion
            /// </summary>
            [DeserializeAs(Name = "status_code")]
            public override ResponseStatusCode StatusCode { get; set; }
        }
    }
}