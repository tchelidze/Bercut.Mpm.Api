using System;
using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations
{
    public class Act9
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 9;

            /// <summary xml:lang="ru">
            ///     Дата, за которую необходимо получить информацию, в формате DDMMYYYY. Если значение не указано, то возвращается
            ///     перечень активных услуг за текущую дату.
            /// </summary>
            /// <summary xml:lang="en">
            ///     The date for which is necessary to obtain the information in the format DDMMYYYY.  If not specified, it returns a
            ///     list of active services for the current date
            /// </summary>
            [ParameterName("DATE_SERVICE")]
            public DateTime DateService { get; set; }

            /// <summary xml:lang="ru">
            ///     Код услуги. Если значение параметра задано, возвращаются данные только по указанной услуге. Если значение не
            ///     задано, возвращается информация по всем услугам Партнера. Необязательный параметр
            /// </summary>
            /// <summary xml:lang="en">
            ///     service code. If the parameter is set, return data only on the specified service. If not specified, returns
            ///     information on all services partners.Optional.
            /// </summary>
            [ParameterName("SERV_CODE")]
            public string ServCode { get; set; }
        }

        public class Response : Base.ResponseWithTimeSpan
        {
            /// <summary xml:lang="ru">
            ///     Код услуги в модуле MobiPay
            /// </summary>
            /// <summary xml:lang="en">
            ///     Services MobiPay code in the module.
            /// </summary>
            [DeserializeAs(Name = "serv_code")]
            public string ServCode { get; set; }

            /// <summary xml:lang="ru">
            ///     Название услуги
            /// </summary>
            /// <summary xml:lang="en">
            ///     Name of the service
            /// </summary>
            [DeserializeAs(Name = "serv_name")]
            public string ServName { get; set; }

            /// <summary xml:lang="ru">
            ///     Метод расчета. Возможные значения:
            ///     • Метод №1 — Партнер присылает всю сумму за услуги,. Оператор возвращает процент комиссионных за подключенные
            ///     услуги при взаиморасчете с Партнером.
            ///     • Метод №2 — Партнер присылает всю сумму за услуги за вычетом комиссионных.
            /// </summary>
            /// <summary xml:lang="en">
            ///     The method of calculation. Possible values are:
            ///     • Method №1 - Partner sends the whole amount for the services,. The operator returns the percentage fees connected
            ///     services for settlements with partners.
            ///     • Method №2 - Partner sends the whole amount for the services, net of commissions
            /// </summary>
            [DeserializeAs(Name = "serv_metod_calc")]
            public string ServMetodCalc { get; set; }

            /// <summary xml:lang="ru">
            ///     Размер оплаты за услугу для Партнера
            /// </summary>
            /// <summary xml:lang="en">
            ///     The amount of payment for the service for partners
            /// </summary>
            [DeserializeAs(Name = "serv_price")]
            public string ServPrice { get; set; }

            /// <summary xml:lang="ru">
            ///     Размер оплаты за услугу для абонента
            /// </summary>
            /// <summary xml:lang="en">
            ///     The amount of payment for the service to the subscriber
            /// </summary>
            [DeserializeAs(Name = "serv_price_subscriber")]
            public string ServPriceSubscriber { get; set; }

            /// <summary xml:lang="ru">
            ///     Процент, взимаемый от общей суммы за услугу
            /// </summary>
            /// <summary xml:lang="en">
            ///     Interest charged on the total amount for the service
            /// </summary>
            [DeserializeAs(Name = "serv_percent")]
            public string ServPercent { get; set; }

            /// <summary xml:lang="ru">
            ///     Дата и время начала действия услуги
            /// </summary>
            /// <summary xml:lang="en">
            ///     Date and time of commencement of the service
            /// </summary>
            [DeserializeAs(Name = "serv_stime")]
            public string ServStime { get; set; }

            /// <summary xml:lang="ru">
            ///     Дата и время окончания действия услуги
            /// </summary>
            /// <summary xml:lang="en">
            ///     Date and time of completion of the service
            /// </summary>
            [DeserializeAs(Name = "serv_etime")]
            public string ServEtime { get; set; }
        }
    }
}