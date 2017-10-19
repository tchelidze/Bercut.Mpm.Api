namespace Bercut.Mpm.Api.Operations.Shared
{
    public enum ResponseStatusCode
    {
        /// <summary xml:lang="ru"> 
        /// Данный тип операции требует регистрации препейд-абонента. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  This type of operation requires registration of a prepaid subscriber.      
        /// </summary>    
        Bsc_2110 = -2110,

        /// <summary xml:lang="ru"> 
        /// Услуга используется в качестве дополнительной. Удаление невозможно. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service is used as an additional service. Removal is not possible.      
        /// </summary>    
        Bsc_2109 = -2109,

        /// <summary xml:lang="ru"> 
        /// Не найден код услуги 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  No service code found      
        /// </summary>    
        Bsc_2108 = -2108,

        /// <summary xml:lang="ru"> 
        /// Данная дополнительная услуга была добавлена ранее 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  This additional service was added earlier      
        /// </summary>    
        Bsc_2107 = -2107,

        /// <summary xml:lang="ru"> 
        /// Невозможно определить предыдущий статус транзакции 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Can not determine previous transaction status      
        /// </summary>    
        Bsc_2106 = -2106,

        /// <summary xml:lang="ru"> 
        /// Сумма платежа меньше стоимости услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The payment amount is less than the cost of the service.      
        /// </summary>    
        Bsc_2105 = -2105,

        /// <summary xml:lang="ru"> 
        /// Не найдена групповая услуга для отключения. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  No group service was found to disconnect.      
        /// </summary>    
        Bsc_2104 = -2104,

        /// <summary xml:lang="ru"> 
        /// Ошибка получения информации об услуге. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Error getting service information.      
        /// </summary>    
        Bsc_2103 = -2103,

        /// <summary xml:lang="ru"> 
        /// Услуга не найдена (не поддерживается). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service not found (not supported).      
        /// </summary>    
        Bsc_2102 = -2102,

        /// <summary xml:lang="ru"> 
        /// Название услуги является обязательным. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The name of the service is mandatory.      
        /// </summary>    
        Bsc_2101 = -2101,

        /// <summary xml:lang="ru"> 
        /// Код услуги является обязательным. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service code is mandatory.      
        /// </summary>    
        Bsc_2100 = -2100,

        /// <summary xml:lang="ru"> 
        /// На счету абонента недостаточно средств после пополнения для подключения услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  On the subscriber's account, there are not enough funds after the recharge to connect the service.      
        /// </summary>    
        Bsc_2014 = -2014,

        /// <summary xml:lang="ru"> 
        /// Дата начала действия услуги не может быть больше даты окончания действия услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service start date can not be more than the expiration date of the service.      
        /// </summary>    
        Bsc_2011 = -2011,

        /// <summary xml:lang="ru"> 
        /// Поле не существует. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The field does not exist.      
        /// </summary>    
        Bsc_2010 = -2010,

        /// <summary xml:lang="ru"> 
        /// Таблица не существует. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The table does not exist.      
        /// </summary>    
        Bsc_2009 = -2009,

        /// <summary xml:lang="ru"> 
        /// Вы пытаетесь удалить (изменить) список по умолчанию. Запрещено. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  You are trying to delete (change) the default list. Forbidden.      
        /// </summary>    
        Bsc_2008 = -2008,

        /// <summary xml:lang="ru"> 
        /// Запрещено удалять список используемый в системе. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  It is forbidden to delete the list used in the system.      
        /// </summary>    
        Bsc_2007 = -2007,

        /// <summary xml:lang="ru"> 
        /// Ошибка при изменении статуса транзакции услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  An error occurred while changing the status of the service transaction.      
        /// </summary>    
        Bsc_2006 = -2006,

        /// <summary xml:lang="ru"> 
        /// Переход статуса транзакции по услуге запрещен. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Transition of the transaction status for the service is prohibited.      
        /// </summary>    
        Bsc_2005 = -2005,

        /// <summary xml:lang="ru"> 
        /// Неизвестный статус транзакции услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Unknown status of service transaction.      
        /// </summary>    
        Bsc_2004 = -2004,

        /// <summary xml:lang="ru"> 
        /// Неккоректный или пустой идентификатор транзакции услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Incorrect or empty service transaction identifier.      
        /// </summary>    
        Bsc_2003 = -2003,

        /// <summary xml:lang="ru"> 
        /// Ошибка при создании транзакции услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  An error occurred while creating the service transaction.      
        /// </summary>    
        Bsc_2002 = -2002,

        /// <summary xml:lang="ru"> 
        /// Управление услугами отключено. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service management is disabled.      
        /// </summary>    
        Bsc_2001 = -2001,

        /// <summary xml:lang="ru"> 
        /// Транзакция услуги не найдена. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  A service transaction was not found.      
        /// </summary>    
        Bsc_2000 = -2000,

        /// <summary xml:lang="ru"> 
        /// Дубликат. Запись существует 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Duplicate. The record exists      
        /// </summary>    
        Bsc_1000 = -1000,

        /// <summary xml:lang="ru"> 
        /// Исчерпано количество попыток 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Exhausted number of attempts      
        /// </summary>    
        Bsc_999 = -999,

        /// <summary xml:lang="ru"> 
        /// Невозможно подключить услугу 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Unable to activate service      
        /// </summary>    
        Bsc_777 = -777,

        /// <summary xml:lang="ru"> 
        /// Ошибка при отключении групповых услуг (повтор) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  An error occurred while disabling group services (repeat)      
        /// </summary>    
        Bsc_732 = -732,

        /// <summary xml:lang="ru"> 
        /// Отключение групповых услуг зависло в обработке (повтор) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Disabling group services was hanging in the processing (replay)      
        /// </summary>    
        Bsc_731 = -731,

        /// <summary xml:lang="ru"> 
        /// Ошибка при отключении услуги (повтор) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Error while disabling the service (retry)      
        /// </summary>    
        Bsc_722 = -722,

        /// <summary xml:lang="ru"> 
        /// Отключение услуги зависло в обработке (повтор) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The disconnection of the service was hanging in the processing (replay)      
        /// </summary>    
        Bsc_721 = -721,

        /// <summary xml:lang="ru"> 
        /// Ошибка при списании средств за услугу (повтор). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  An error occurred while charging for the service (repeat).      
        /// </summary>    
        Bsc_712 = -712,

        /// <summary xml:lang="ru"> 
        /// Транзакция зависла при списании средств за услугу (повтор). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The transaction is suspended when you write down the funds for the service (repeat).      
        /// </summary>    
        Bsc_711 = -711,

        /// <summary xml:lang="ru"> 
        /// Ошибка выполнения (повтор). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Runtime Error (Retry).      
        /// </summary>    
        Bsc_702 = -702,

        /// <summary xml:lang="ru"> 
        /// Транзакция услуги зависла в обработке (повтор). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service transaction is hung in processing (retry).      
        /// </summary>    
        Bsc_701 = -701,

        /// <summary xml:lang="ru"> 
        /// Количество попыток аннулирования бонусного платежа исчерпано. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The number of attempts to cancel the bonus payment has been exhausted.      
        /// </summary>    
        Bsc_118 = -118,

        /// <summary xml:lang="ru"> 
        /// Бонусный платеж не аннулирован. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Bonus payment is not canceled.      
        /// </summary>    
        Bsc_117 = -117,

        /// <summary xml:lang="ru"> 
        /// Платеж не аннулирован 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment is not canceled      
        /// </summary>    
        Bsc_115 = -115,

        /// <summary xml:lang="ru"> 
        /// Превышено кол-во попыток/Платеж отклонен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Exceeded attempts / Payment declined      
        /// </summary>    
        Bsc_112 = -112,

        /// <summary xml:lang="ru"> 
        /// Критичная ошибка/Платеж не выполнен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Critical error / Payment not completed      
        /// </summary>    
        Bsc_111 = -111,

        /// <summary xml:lang="ru"> 
        ///  Платеж отменен пользователем 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///   Payment canceled by user      
        /// </summary>    
        Bsc_104 = -104,

        /// <summary xml:lang="ru"> 
        /// Платеж отменен по таймауту 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment canceled on timeout      
        /// </summary>    
        Bsc_103 = -103,

        /// <summary xml:lang="ru"> 
        /// Проверка неуспешна/Платеж невозможен 
        /// Тарифный план уже подключен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Checking is unsuccessful / Payment is not possible      
        ///  Tariff plan is already connected      
        /// </summary>    
        Bsc_102 = -102,

        /// <summary xml:lang="ru"> 
        /// Услуга недоступна для подключения 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service unavailable for connection      
        /// </summary>    
        Bsc_101 = -101,

        /// <summary xml:lang="ru"> 
        /// Превышено ограничение на подключение услуги 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service Connection Limit Exceeded      
        /// </summary>    
        Bsc_100 = -100,

        /// <summary xml:lang="ru"> 
        /// Попытка подключить бесплатную услугу при ненулевом платеже 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Attempt to connect a free service with a non-zero payment      
        /// </summary>    
        Bsc_99 = -99,

        /// <summary xml:lang="ru"> 
        /// Попытка подключить услугу ненулевой стоимости при нулевом платеже 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Attempt to connect a non-zero cost service with zero payment      
        /// </summary>    
        Bsc_98 = -98,

        /// <summary xml:lang="ru"> 
        /// Попытка подключить услугу, кторая состоит в группе с другими услугами (фичер). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Attempt to connect the service, which is a group with other services (feature).      
        /// </summary>    
        Bsc_97 = -97,

        /// <summary xml:lang="ru"> 
        /// Услуга уже подключена 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service already connected      
        /// </summary>    
        Bsc_96 = -96,

        /// <summary xml:lang="ru"> 
        /// Нет доступных услуг для партнера по указанному условию. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  There are no available services for the partner on the specified condition.      
        /// </summary>    
        Bsc_95 = -95,

        /// <summary xml:lang="ru"> 
        /// Заказываемая услуга запрещена абоненту (по типу и тарифному плану). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The ordered service is forbidden to the subscriber (by type and tariff plan).      
        /// </summary>    
        Bsc_94 = -94,

        /// <summary xml:lang="ru"> 
        /// Не указан код услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service code is missing.      
        /// </summary>    
        Bsc_93 = -93,

        /// <summary xml:lang="ru"> 
        /// Истек срок действия заказываемой услуги. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The ordered service has expired.      
        /// </summary>    
        Bsc_92 = -92,

        /// <summary xml:lang="ru"> 
        /// Указанная услуга недоступна для партнера. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The specified service is not available to the partner.      
        /// </summary>    
        Bsc_91 = -91,

        /// <summary xml:lang="ru"> 
        /// Абонент принадлежит другому оператору (портирован) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The subscriber belongs to another operator (ported)      
        /// </summary>    
        Bsc_90 = -90,

        /// <summary xml:lang="ru"> 
        /// Аннулирование в биллинге (Amdocs) не прошло 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Cancellation in billing (Amdocs) has not passed      
        /// </summary>    
        Bsc_84 = -84,

        /// <summary xml:lang="ru"> 
        /// Аннулирование невозможно (баланс абонента меньше списываемой суммы) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Cancellation is not possible (the balance of the subscriber is less than the amount to be written off)      
        /// </summary>    
        Bsc_83 = -83,

        /// <summary xml:lang="ru"> 
        /// Платеж уже отменен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment already canceled      
        /// </summary>    
        Bsc_82 = -82,

        /// <summary xml:lang="ru"> 
        /// Время возможности аннулирования платежа истекло 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Time for cancellation of payment has expired      
        /// </summary>    
        Bsc_81 = -81,

        /// <summary xml:lang="ru"> 
        /// Отказано в смене пароля 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Refused to change password      
        /// </summary>    
        Bsc_60 = -60,

        /// <summary xml:lang="ru"> 
        /// Ошибка сценария 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Script Error      
        /// </summary>    
        Bsc_51 = -51,

        /// <summary xml:lang="ru"> 
        /// Ошибка выполнения запроса в БД 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Error executing the query in the database      
        /// </summary>    
        Bsc_50 = -50,

        /// <summary xml:lang="ru"> 
        /// Сбой биллинговой системы 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Billing system failure      
        /// </summary>    
        Bsc_49 = -49,

        /// <summary xml:lang="ru"> 
        /// Превышено количество попыток платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Exceeded number of payment attempts      
        /// </summary>    
        Bsc_48 = -48,

        /// <summary xml:lang="ru"> 
        /// Платеж зарегистрирован, но не проведен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment registered but not conducted      
        /// </summary>    
        Bsc_46 = -46,

        /// <summary xml:lang="ru"> 
        /// Платеж не найден 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment not found      
        /// </summary>    
        Bsc_45 = -45,

        /// <summary xml:lang="ru"> 
        /// Платеж на указанную сумму невозможен для данного абонента 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment for the specified amount is not possible for this subscriber      
        /// </summary>    
        Bsc_42 = -42,

        /// <summary xml:lang="ru"> 
        /// Прием платежей для абонента невозможен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Receiving payments for the subscriber is not possible      
        /// </summary>    
        Bsc_41 = -41,

        /// <summary xml:lang="ru"> 
        /// Абонент не найден 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Subscriber not found      
        /// </summary>    
        Bsc_40 = -40,

        /// <summary xml:lang="ru"> 
        /// Превышено количество попыток проведения платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Exceeded the number of payment attempts      
        /// </summary>    
        Bsc_38 = -38,

        /// <summary xml:lang="ru"> 
        /// Квота платежей исчерпана 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment quota exhausted      
        /// </summary>    
        Bsc_35 = -35,

        /// <summary xml:lang="ru"> 
        /// Прием платежей от партнера заблокирован 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Accepting payments from a partner is blocked      
        /// </summary>    
        Bsc_34 = -34,

        /// <summary xml:lang="ru"> 
        /// Неизвестный тип источника платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Unknown source of payment type      
        /// </summary>    
        Bsc_32 = -32,

        /// <summary xml:lang="ru"> 
        /// Сумма платежа вне диапазона, заданного для источника платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The amount of the payment is out of the range specified for the source of payment      
        /// </summary>    
        Bsc_31 = -31,

        /// <summary xml:lang="ru"> 
        /// Транзакция не найдена 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Transaction not found      
        /// </summary>    
        Bsc_27 = -27,

        /// <summary xml:lang="ru"> 
        /// Операция недопустима для данной транзакции 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The operation is invalid for this transaction      
        /// </summary>    
        Bsc_26 = -26,

        /// <summary xml:lang="ru"> 
        /// Доступ запрещен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Access is denied      
        /// </summary>    
        Bsc_25 = -25,

        /// <summary xml:lang="ru"> 
        /// Неверный формат комиссии 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Invalid commission format      
        /// </summary>    
        Bsc_22 = -22,

        /// <summary xml:lang="ru"> 
        /// Тип канала источника платежа указан неверно 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The source type of the source of payment is incorrect      
        /// </summary>    
        Bsc_21 = -21,

        /// <summary xml:lang="ru"> 
        /// Создание транзакции невозможно 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Creating a transaction is not possible      
        /// </summary>    
        Bsc_20 = -20,

        /// <summary xml:lang="ru"> 
        /// Неверный формат суммы платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Invalid payment amount format      
        /// </summary>    
        Bsc_19 = -19,

        /// <summary xml:lang="ru"> 
        /// Неверный формат даты платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Invalid payment date format      
        /// </summary>    
        Bsc_18 = -18,

        /// <summary xml:lang="ru"> 
        /// Не задан пароль 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Password not set      
        /// </summary>    
        Bsc_17 = -17,

        /// <summary xml:lang="ru"> 
        /// Задан недопустимый параметр 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Invalid parameter specified      
        /// </summary>    
        Bsc_16 = -16,

        /// <summary xml:lang="ru"> 
        /// Не задан идентификатор транзакции 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  No transaction ID specified      
        /// </summary>    
        Bsc_15 = -15,

        /// <summary xml:lang="ru"> 
        /// Валюта не поддерживается 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Currency not supported      
        /// </summary>    
        Bsc_14 = -14,

        /// <summary xml:lang="ru"> 
        /// Не задана сумма платежа 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  No payment amount specified      
        /// </summary>    
        Bsc_13 = -13,

        /// <summary xml:lang="ru"> 
        /// Номер получателя платежа не задан или неверен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The payee's payee number is not set or incorrect      
        /// </summary>    
        Bsc_12 = -12,

        /// <summary xml:lang="ru"> 
        /// Действие не предусмотрено 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Action not provided      
        /// </summary>    
        Bsc_11 = -11,

        /// <summary xml:lang="ru"> 
        /// Не задан номер чека 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Check number not specified      
        /// </summary>    
        Bsc_10 = -10,

        /// <summary xml:lang="ru"> 
        /// Не найден партнер. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  No partner found.      
        /// </summary>    
        Bsc_6 = -6,

        /// <summary xml:lang="ru"> 
        /// Неверный логин/пароль 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Invalid username / password      
        /// </summary>    
        Bsc_3 = -3,

        /// <summary xml:lang="ru"> 
        /// Доступ с данного IP не предусмотрен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Access from this IP is not provided      
        /// </summary>    
        Bsc_2 = -2,

        /// <summary xml:lang="ru"> 
        /// Успешно 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Successfully      
        /// </summary>    
        Bsc0 = 0,

        /// <summary xml:lang="ru"> 
        /// Транзакция создана 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Transaction created      
        /// </summary>    
        Bsc20 = 20,

        /// <summary xml:lang="ru"> 
        /// Платеж возможен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment is possible      
        /// </summary>    
        Bsc21 = 21,

        /// <summary xml:lang="ru"> 
        /// Платеж подтвержден 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment verified      
        /// </summary>    
        Bsc22 = 22,

        /// <summary xml:lang="ru"> 
        /// Платеж отменен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment canceled      
        /// </summary>    
        Bsc23 = 23,

        /// <summary xml:lang="ru"> 
        /// Платеж проведен успешно 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment successful      
        /// </summary>    
        Bsc45 = 45,

        /// <summary xml:lang="ru"> 
        /// Пароль успешно изменен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Password changed successfully      
        /// </summary>    
        Bsc60 = 60,

        /// <summary xml:lang="ru"> 
        /// Состояние транзакции определено 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The transaction status is defined      
        /// </summary>    
        Bsc70 = 70,

        /// <summary xml:lang="ru"> 
        /// Аннулирование платежа успешно проведено 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Cancellation successful      
        /// </summary>    
        Bsc80 = 80,

        /// <summary xml:lang="ru"> 
        /// Транзакция отправлена на аннулирование в Amdocs 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The transaction was sent for cancellation in Amdocs      
        /// </summary>    
        Bsc81 = 81,

        /// <summary xml:lang="ru"> 
        /// Файл для аннулирования от Amdocs получен 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The file for cancellation from Amdocs is received      
        /// </summary>    
        Bsc82 = 82,

        /// <summary xml:lang="ru"> 
        /// Запрос информации по доступным услугам для партнера успешно выполнен. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The request for information on the available services for the partner was successfully completed.      
        /// </summary>    
        Bsc100 = 100,

        /// <summary xml:lang="ru"> 
        /// Данные корректны/Платеж принят на исполнение 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The data is correct / The payment is accepted for execution      
        /// </summary>    
        Bsc101 = 101,

        /// <summary xml:lang="ru"> 
        /// Начата проверка возможности платежа. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The possibility of payment was started.      
        /// </summary>    
        Bsc102 = 102,

        /// <summary xml:lang="ru"> 
        /// Платеж подтвержден. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment verified.      
        /// </summary>    
        Bsc110 = 110,

        /// <summary xml:lang="ru"> 
        /// Платеж успешно завершен. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment successfully completed.      
        /// </summary>    
        Bsc111 = 111,

        /// <summary xml:lang="ru"> 
        /// Некритичная ошибка/Повтор проведения платежа. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Non-critical error / Repetition of payment.      
        /// </summary>    
        Bsc112 = 112,

        /// <summary xml:lang="ru"> 
        /// Платеж отправлен на аннулирование 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment sent for cancellation      
        /// </summary>    
        Bsc114 = 114,

        /// <summary xml:lang="ru"> 
        /// Платеж аннулирован 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment canceled      
        /// </summary>    
        Bsc115 = 115,

        /// <summary xml:lang="ru"> 
        /// Бонусный платеж подтвержден для аннулирования. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Bonus payment is confirmed for cancellation.      
        /// </summary>    
        Bsc117 = 117,

        /// <summary xml:lang="ru"> 
        /// Платеж находится в обработке биллинговой системой 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The payment is in processing by the billing system      
        /// </summary>    
        Bsc120 = 120,

        /// <summary xml:lang="ru"> 
        /// Транзакция услуги готова для обработки. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service transaction is ready for processing.      
        /// </summary>    
        Bsc700 = 700,

        /// <summary xml:lang="ru"> 
        /// Транзакция услуги выбрана для обработки. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service transaction is selected for processing.      
        /// </summary>    
        Bsc701 = 701,

        /// <summary xml:lang="ru"> 
        /// Списание средств за услугу 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service charge      
        /// </summary>    
        Bsc710 = 710,

        /// <summary xml:lang="ru"> 
        /// Выбрана для списания средств за услугу (в обработке) 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Selected for debiting funds for the service (in processing)      
        /// </summary>    
        Bsc711 = 711,

        /// <summary xml:lang="ru"> 
        /// Отключение услуги 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Disabling the service      
        /// </summary>    
        Bsc720 = 720,

        /// <summary xml:lang="ru"> 
        /// Услуга выбрана для отключения 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service selected for shutdown      
        /// </summary>    
        Bsc721 = 721,

        /// <summary xml:lang="ru"> 
        /// Услуга успешно отключена 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The service was successfully disabled      
        /// </summary>    
        Bsc722 = 722,

        /// <summary xml:lang="ru"> 
        /// Отключение групповых услуг 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Disabling group services      
        /// </summary>    
        Bsc730 = 730,

        /// <summary xml:lang="ru"> 
        /// Обработка отключения групповых услуг 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Processing of disabling group services      
        /// </summary>    
        Bsc731 = 731,

        /// <summary xml:lang="ru"> 
        /// Групповые услуги успешно отключены 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Group services successfully disabled      
        /// </summary>    
        Bsc732 = 732,

        /// <summary xml:lang="ru"> 
        /// Обработка услуги успешно завершена. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Service processing completed successfully.      
        /// </summary>    
        Bsc777 = 777,

        /// <summary xml:lang="ru"> 
        /// Статус переведен JOB-ом системы. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  The status of the transferred JOB system.      
        /// </summary>    
        Bsc999 = 999,

        /// <summary xml:lang="ru"> 
        /// Данные успешно изменены. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Data has been successfully changed.      
        /// </summary>    
        Bsc1000 = 1000,

        /// <summary xml:lang="ru"> 
        /// Платеж подтвержден (синхронное проведение платежа). 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Payment confirmed (synchronous payment).      
        /// </summary>    
        Bsc1101 = 1101,

        /// <summary xml:lang="ru"> 
        /// Действие администратора. 
        /// </summary>    
        /// <summary xml:lang="en">   
        ///  Admin action.      
        /// </summary>    
        Bsc2000 = 2000
    }
}