using System;
using System.Net;
using System.Threading.Tasks;
using Bercut.Mpm.Api.Exceptions;
using Bercut.Mpm.Api.Operations;
using Bercut.Mpm.Api.Operations.Shared;
using Bercut.Mpm.Api.Options;
using Restsharp.Get.AddObjectParameter.Extensions;
using RestSharp;

namespace Bercut.Mpm.Api
{
    public class BercutMpmClient : IBercutMpmClient
    {
        readonly BercutMpmClientOptions _bercutMpmClientOptions;

        public BercutMpmClient(Action<BercutMpmClientOptions> configureOptions)
            : this(ConfigureBercutMpmClientOptions(configureOptions))
        { }

        public BercutMpmClient(BercutMpmClientOptions options)
        {
            if (string.IsNullOrEmpty(options.UserName))
            {
                throw new ArgumentException("Must not be null", nameof(BercutMpmClientOptions.UserName));
            }

            if (string.IsNullOrEmpty(options.Password))
            {
                throw new ArgumentException("Must not be null", nameof(BercutMpmClientOptions.Password));
            }

            if (string.IsNullOrEmpty(options.Host))
            {
                throw new ArgumentException("Must not be null", nameof(BercutMpmClientOptions.Host));
            }

            _bercutMpmClientOptions = options;
        }

        /// <summary xml:lang="ru">
        ///     Создание транзакции для проведения платежа (Invoke_pay)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Create a transaction for payment (Invoke_pay)
        /// </summary>
        public async Task<Act0.Response> Act0(Act0.Request request)
            => await InvokeBercutMpmApi<Act0.Request, Act0.Response>(request);

        /// <summary xml:lang="ru">
        ///     Подтверждение платежа (Commit_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     payment confirmation (Commit_inv)
        /// </summary>
        public async Task<Act1.Response> Act1(Act1.Request request)
            => await InvokeBercutMpmApi<Act1.Request, Act1.Response>(request);

        /// <summary xml:lang="ru">
        ///     Отмена транзакции по платежу (Abort_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Cancellation of a payment transaction (Abort_inv)
        /// </summary>
        public async Task<Act2.Response> Act2(Act2.Request request)
            => await InvokeBercutMpmApi<Act2.Request, Act2.Response>(request);

        /// <summary xml:lang="ru">
        ///     Проверка состояния транзакции
        /// </summary>
        /// <summary xml:lang="en">
        ///     Checking the transaction state
        /// </summary>
        public async Task<Act3.Response> Act3(Act3.Request request)
            => await InvokeBercutMpmApi<Act3.Request, Act3.Response>(request);

        /// <summary xml:lang="ru">
        ///     Проверка возможности проведения платежа (Check_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Checking the possibility of payment (Check_inv)
        /// </summary>
        public async Task<Act4.Response> Act4(Act4.Request request)
            => await InvokeBercutMpmApi<Act4.Request, Act4.Response>(request);

        /// <summary xml:lang="ru">
        ///     Смена пароля для Автоматического Терминала
        /// </summary>
        /// <summary xml:lang="en">
        ///     Change the password for the Automatic Terminal
        /// </summary>
        public async Task<Act5.Response> Act5(Act5.Request request)
            => await InvokeBercutMpmApi<Act5.Request, Act5.Response>(request);

        /// <summary xml:lang="ru">
        ///     Аннулирование платежа
        /// </summary>
        /// <summary xml:lang="en">
        ///     cancellation of payment
        /// </summary>
        public async Task<Act6.Response> Act6(Act6.Request request)
            => await InvokeBercutMpmApi<Act6.Request, Act6.Response>(request);

        /// <summary xml:lang="ru">
        ///     Получение баланса абонента
        /// </summary>
        /// <summary xml:lang="en">
        ///     Getting the balance of subscriber
        /// </summary>
        public async Task<Act7.Response> Act7(Act7.Request request)
            => await InvokeBercutMpmApi<Act7.Request, Act7.Response>(request);

        /// <summary xml:lang="ru">
        ///     Получение текущей квоты Партнера и значения порога квоты
        /// </summary>
        /// <summary xml:lang="en">
        ///     Preparation Partner current quota and threshold value quota
        /// </summary>
        public async Task<Act8.Response> Act8(Act8.Request request)
            => await InvokeBercutMpmApi<Act8.Request, Act8.Response>(request);

        /// <summary xml:lang="ru">
        ///     Получение информации о доступных услугах для Партнера
        /// </summary>
        /// <summary xml:lang="en">
        ///     Getting information about the services available to Partner
        /// </summary>
        public async Task<Act9.Response> Act9(Act9.Request request)
            => await InvokeBercutMpmApi<Act9.Request, Act9.Response>(request);

        /// <summary xml:lang="ru">
        ///     Проверка номера и доступности услуг
        /// </summary>
        /// <summary xml:lang="en">
        ///     Check the availability of rooms and services
        /// </summary>
        public async Task<Act10.Response> Act10(Act10.Request request)
            => await InvokeBercutMpmApi<Act10.Request, Act10.Response>(request);

        async Task<TResponse> InvokeBercutMpmApi<TRequest, TResponse>(TRequest request)
            where TResponse : new()
            where TRequest : Base.Request
        {
            request.UserName = _bercutMpmClientOptions.UserName;
            request.Password = _bercutMpmClientOptions.Password;

            var bercutMpmApiRestClient = new RestClient($"{_bercutMpmClientOptions.Host}/work.html");
            var bercutMpnApiRequest = new RestRequest("", Method.GET);
            bercutMpnApiRequest.AddObjectParameter(request);
            bercutMpnApiRequest.AddHeader("Content-Type", "application/xml");
            bercutMpnApiRequest.AddHeader("Accept", "application/xml");

            var responseCompletionSource = new TaskCompletionSource<TResponse>();
            bercutMpmApiRestClient.ExecuteAsync<TResponse>(bercutMpnApiRequest, response =>
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    responseCompletionSource.SetException(new InvalidBercutApiResponseException(response.StatusCode, response.ErrorMessage));
                    return;
                }

                responseCompletionSource.SetResult(response.Data);
            });
            return await responseCompletionSource.Task;
        }

        static BercutMpmClientOptions ConfigureBercutMpmClientOptions(Action<BercutMpmClientOptions> configurer)
        {
            var options = new BercutMpmClientOptions();
            configurer(options);
            return options;
        }
    }
}