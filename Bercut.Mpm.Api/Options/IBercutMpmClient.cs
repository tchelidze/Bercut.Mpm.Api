using System.Threading.Tasks;
using Bercut.Mpm.Api.Operations;

namespace Bercut.Mpm.Api.Options
{
    public interface IBercutMpmClient
    {
        /// <summary xml:lang="ru">
        ///     Создание транзакции для проведения платежа (Invoke_pay)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Create a transaction for payment (Invoke_pay)
        /// </summary>
        Task<Act0.Response> Act0(Act0.Request request);

        /// <summary xml:lang="ru">
        ///     Подтверждение платежа (Commit_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     payment confirmation (Commit_inv)
        /// </summary>
        Task<Act1.Response> Act1(Act1.Request request);

        /// <summary xml:lang="ru">
        ///     Отмена транзакции по платежу (Abort_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Cancellation of a payment transaction (Abort_inv)
        /// </summary>
        Task<Act2.Response> Act2(Act2.Request request);

        /// <summary xml:lang="ru">
        ///     Проверка состояния транзакции
        /// </summary>
        /// <summary xml:lang="en">
        ///     Checking the transaction state
        /// </summary>
        Task<Act3.Response> Act3(Act3.Request request);

        /// <summary xml:lang="ru">
        ///     Проверка возможности проведения платежа (Check_inv)
        /// </summary>
        /// <summary xml:lang="en">
        ///     Checking the possibility of payment (Check_inv)
        /// </summary>
        Task<Act4.Response> Act4(Act4.Request request);

        /// <summary xml:lang="ru">
        ///     Смена пароля для Автоматического Терминала
        /// </summary>
        /// <summary xml:lang="en">
        ///     Change the password for the Automatic Terminal
        /// </summary>
        Task<Act5.Response> Act5(Act5.Request request);

        /// <summary xml:lang="ru">
        ///     Аннулирование платежа
        /// </summary>
        /// <summary xml:lang="en">
        ///     cancellation of payment
        /// </summary>
        Task<Act6.Response> Act6(Act6.Request request);

        /// <summary xml:lang="ru">
        ///     Получение баланса абонента
        /// </summary>
        /// <summary xml:lang="en">
        ///     Getting the balance of subscriber
        /// </summary>
        Task<Act7.Response> Act7(Act7.Request request);

        /// <summary xml:lang="ru">
        ///     Получение текущей квоты Партнера и значения порога квоты
        /// </summary>
        /// <summary xml:lang="en">
        ///     Preparation Partner current quota and threshold value quota
        /// </summary>
        Task<Act8.Response> Act8(Act8.Request request);

        /// <summary xml:lang="ru">
        ///     Получение информации о доступных услугах для Партнера
        /// </summary>
        /// <summary xml:lang="en">
        ///     Getting information about the services available to Partner
        /// </summary>
        Task<Act9.Response> Act9(Act9.Request request);

        /// <summary xml:lang="ru">
        ///     Проверка номера и доступности услуг
        /// </summary>
        /// <summary xml:lang="en">
        ///     Check the availability of rooms and services
        /// </summary>
        Task<Act10.Response> Act10(Act10.Request request);
    }
}