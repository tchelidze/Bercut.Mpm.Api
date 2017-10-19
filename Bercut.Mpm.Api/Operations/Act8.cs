using System;
using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;

namespace Bercut.Mpm.Api.Operations
{
    public class Act8
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 8;

            /// <summary xml:lang="ru">
            ///     Дата и время проведения операции
            /// </summary>
            /// <summary xml:lang="en">
            ///     Date and time of the transaction
            /// </summary>
            [ParameterName("PAY_DATE")]
            public string PayDate { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan
        {
            /// <summary xml:lang="ru">
            ///     Текущее значение квоты Партнера
            /// </summary>
            /// <summary xml:lang="en">
            ///     The current value of Partner's quota
            /// </summary>
            [ParameterName("QUOTA_CUR")]
            public string QuotaCur { get; set; }

            /// <summary xml:lang="ru">
            ///     Заданный порог квоты
            /// </summary>
            /// <summary xml:lang="en">
            ///     The predetermined threshold quota
            /// </summary>
            [ParameterName("QUOTA_CRIT")]
            public DateTime QuotaCrit { get; set; }
        }
    }
}