﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ОтчетПроизводстваЗаСмену:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеВозвратныхОтходов;//Автоматически распределять возвратные отходы на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеМатериалов;//Автоматически распределять материалы на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеПрочихЗатрат;//Автоматически распределять прочие затраты на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public bool АвтораспределениеТехнологическихОпераций;//Автоматически распределять тех. операции на продукцию
		///<summary>
		///(Общ)
		///</summary>
		public bool ВводитьСтатьиЗатратПоСтрокам;//Вводить статьи затрат по строкам
		public V82.ДокументыСсылка.ЗаданиеНаПроизводство ЗаданиеНаПроизводство;//Задание на производство
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады Склад;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат;//Статья затрат по умолчанию
		public bool ИспользоватьВозвратныеОтходы;//Использовать возвратные отходы
		public bool ИспользоватьЗаданияНаПроизводство;//Использовать задания на производство
		public bool ИспользоватьЗаказы;//Использовать заказы
		public bool ИспользоватьЗаказыНаОбслуживаниеОС;//Использовать заказы на обслуживание ОС
		public bool ИспользоватьМатериалы;//Использовать материалы
		public bool ИспользоватьНаправленияВыпуска;//Использовать направления выпуска
		public bool ИспользоватьНаработку;//Использовать наработку
		public bool ИспользоватьПодразделенияНЗП;//Использовать подразделения НЗП
		public bool ИспользоватьПрочиеЗатраты;//Использовать прочие затраты
		public bool ИспользоватьТехнологическиеОперации;//Использовать технологические операции
		public bool РазрешитьПревышениеЛимита;//Разрешить превышение лимита
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады СкладОтходов;//Склад отходов
		public bool ИспользоватьАналитикуНЗП;//Использовать аналитику НЗП
		public bool УчитыватьТариф;//Учитывать тариф
		public bool УчитыватьКТУ;//Учитывать КТУ
	}
}