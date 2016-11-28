namespace CyberSolution.YandexMetrika.BAL.Models
{
    /// <summary>
    /// Статусы счетчиков
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Не удалось проверить (ошибка соединения).
        /// </summary>
        CS_ERR_CONNECT,
        /// <summary>
        /// Установлен более одного раза.
        /// </summary>
        CS_ERR_DUPLICATED,
        /// <summary>
        /// Установлен некорректно.
        /// </summary>
        CS_ERR_HTML_CODE,
        /// <summary>
        /// Уже установлен другой счетчик.
        /// </summary>
        CS_ERR_OTHER_HTML_CODE,
        /// <summary>
        /// Не удалось проверить (превышено время ожидания).
        /// </summary>
        CS_ERR_TIMEOUT,
        /// <summary>
        /// Неизвестная ошибка.
        /// </summary>
        CS_ERR_UNKNOWN,
        /// <summary>
        /// Недавно создан.
        /// </summary>
        CS_NEW_COUNTER,
        /// <summary>
        /// Не применим к данному счетчику.
        /// </summary>
        CS_NA,
        /// <summary>
        /// Установлен не на всех страницах.
        /// </summary>
        CS_NOT_EVERYWHERE,
        /// <summary>
        /// Не установлен.
        /// </summary>
        CS_NOT_FOUND,
        /// <summary>
        /// Не установлен на главной странице.
        /// </summary>
        CS_NOT_FOUND_HOME,
        /// <summary>
        /// Не установлен на главной странице, но данные поступают.
        /// </summary>
        CS_NOT_FOUND_HOME_LOAD_DATA,
        /// <summary>
        /// Установлена устаревшая версия кода счетчика.
        /// </summary>
        CS_OBSOLETE,
        /// <summary>
        /// Корректно установлен.
        /// </summary>
        CS_OK,
        /// <summary>
        /// Установлен, но данные не поступают.
        /// </summary>
        CS_OK_NO_DATA,
        /// <summary>
        /// Ожидает проверки наличия.
        /// </summary>
        CS_WAIT_FOR_CHECKING,
        /// <summary>
        /// Ожидает проверки наличия, данные поступают.
        /// </summary>
        CS_WAIT_FOR_CHECKING_LOAD_DATA

    }
}
