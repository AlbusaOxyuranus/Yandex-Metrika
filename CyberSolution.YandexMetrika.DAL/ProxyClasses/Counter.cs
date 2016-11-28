

namespace CyberSolution.YandexMetrika.DAL.ProxyClasses
{
    using System.Runtime.Serialization;
    [DataContract]
    public class Counter
    {
        /// <summary>
        /// Id Идентификатор счетчика
        /// </summary>
        [DataMember(Name = "id")]
        public decimal Id { get; set; }

        /// <summary>
        /// Status Статус счетчика. 
        /// Возможные значения:
        ///Active — Счетчик активен
        /// Deleted — Счетчик удален
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Логин владельца счетчика.
        /// </summary>
        [DataMember(Name = "owner_login")]
        public string OwnerLogin { get; set; }

        /// <summary>
        /// Статус установки кода счетчика. 
        ///Возможные значения:
        ///CS_ERR_INFECTED — не удалось проверить(сайт, на котором установлен счетчик или одно из его зеркал находится в списке зараженных сайтов).
        ///CS_NOT_FOUND — Не установлен.
        ///CS_ERR_OTHER_HTML_CODE — установлен другой счетчик.
        ///CS_ERR_CONNECT — не удалось проверить (ошибка соединения).
        /// CS_ERR_TIMEOUT — не удалось проверить (превышено время ожидания).
        ///CS_OK — Корректно установлен.
        /// </summary>
        [DataMember(Name = "code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// Наименование сайта (произвольная строка).
        /// </summary>
        [DataMember(Name= "name")]
        public string Name { get; set; }
        /// <summary>
        /// Полный домен сайта.
        /// </summary>
        [DataMember(Name= "site")]
        public object Site { get; set; }
    }
}
