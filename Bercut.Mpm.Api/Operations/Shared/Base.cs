using System;
using System.Xml.Serialization;
using Restsharp.Get.AddObjectParameter.Attributes;
using RestSharp.Deserializers;

namespace Bercut.Mpm.Api.Operations.Shared
{
    public class Base
    {
        public abstract class Request
        {
            /// <summary xml:lang="ru">
            ///     Код операции
            /// </summary>
            /// <summary xml:lang="en">
            ///     Operation code
            /// </summary>
            [ParameterName("ACT")]
            [IncludeParameter]
            internal abstract int Act { get; }

            /// <summary xml:lang="ru">
            ///     Логин терминала
            /// </summary>
            /// <summary xml:lang="en">
            ///     Terminal login
            /// </summary>
            [ParameterName("USERNAME")]
            [IncludeParameter]
            internal string UserName { get; set; }

            /// <summary xml:lang="ru">
            ///     Пароль пользователя
            /// </summary>
            /// <summary xml:lang="en">
            ///     the user's password
            /// </summary>
            [ParameterName("PASSWORD")]
            [IncludeParameter]
            internal string Password { get; set; }
        }

        [XmlRoot(Namespace = "Base")]
        [DeserializeAs(Name = "pay-response")]
        public abstract class Response
        {
            /// <summary xml:lang="ru">
            ///     Результат операции
            /// </summary>
            /// <summary xml:lang="en">
            ///     The result of the operation
            /// </summary>
            [XmlElement("status_code")]
            public virtual ResponseStatusCode StatusCode { get; set; }
        }

        [XmlRoot(Namespace = "Base")]
        public abstract class ResponseWithTimeSpan : Response
        {
            const string BercutTimeStampFormat = "dd.MM.yyyy HH:mm:ss";

            [DeserializeAs(Name = "time_stamp")]
            public string TimeStampString
            {
                get => TimeStamp.ToString(BercutTimeStampFormat);
                set => TimeStamp = DateTime.ParseExact(value, BercutTimeStampFormat, null);
            }

            /// <summary xml:lang="ru">
            ///     Дата проведения операции в формате DD.MM.YYYY HH24:MI:SS
            /// </summary>
            /// <summary xml:lang="en">
            ///     Date of the transaction in the format DD.MM.YYYY HH24: MI: SS
            /// </summary>
            [XmlIgnore]
            public DateTime TimeStamp { get; private set; }
        }
    }
}