using Bercut.Mpm.Api.Operations.Shared;
using Restsharp.Get.AddObjectParameter.Attributes;

namespace Bercut.Mpm.Api.Operations
{
    public class Act5
    {
        public class Request : Base.Request
        {
            /// <inheritdoc />
            internal override int Act { get; } = 5;

            /// <summary xml:lang="ru">
            ///     Новый пароль пользователя
            /// </summary>
            /// <summary xml:lang="en">
            ///     The new user's password
            /// </summary>
            [ParameterName("NEWPASSWORD")]
            public string Newpassword { get; set; }
        }

        public class Response : Base.Response
        { }
    }
}