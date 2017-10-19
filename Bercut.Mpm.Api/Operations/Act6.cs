using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;

namespace Bercut.Mpm.Api.Operations
{
    public class Act6
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 6;

            /// <summary xml:lang="ru">
            ///     Новый пароль пользователя
            /// </summary>
            /// <summary xml:lang="en">
            ///     The new user's password
            /// </summary>
            [ParameterName("NEWPASSWORD")]
            public string Newpassword { get; set; }

            /// <summary xml:lang="ru">
            ///     Номер абонента-получателя платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     Number of recipient of payment
            /// </summary>
            [ParameterName("MSISDN")]
            public string Msisdn { get; set; }

            /// <summary xml:lang="ru">
            ///     Номер чека
            /// </summary>
            /// <summary xml:lang="en">
            ///     Check number
            /// </summary>
            [ParameterName("RECEIPT_NUM")]
            public string ReceiptNum { get; set; }

            /// <summary xml:lang="ru">
            ///     Идентификационный номер транзакции
            /// </summary>
            /// <summary xml:lang="en">
            ///     Transaction tracking number
            /// </summary>
            [ParameterName("PAY_ID")]
            public string PayId { get; set; }

            /// <summary xml:lang="ru">
            ///     Номер лицевого счета для PostPaid-абонентов
            /// </summary>
            /// <summary xml:lang="en">
            ///     Account number for PostPaid-subscribers
            /// </summary>
            [ParameterName("PAY_ACCOUNT")]
            public string PayAccount { get; set; }

            /// <summary xml:lang="ru">
            ///     Сумма платежа
            /// </summary>
            /// <summary xml:lang="en">
            ///     Amount of payment
            /// </summary>
            [ParameterName("PAY_AMOUNT")]
            public string PayAmount { get; set; }
        }

        public class Response : Base.Response
        { }
    }
}