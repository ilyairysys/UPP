﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ИзменениеЗаказаПокупателя:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.ДокументыСсылка.ЗаказПокупателя ЗаказПокупателя;//Заказ покупателя
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		public bool УчитыватьНДС;//Учитывать НДС
		public bool СуммаВключаетНДС;//Сумма включает НДС
		public object СтруктурнаяЕдиница;//Структурная единица
		///<summary>
		///Курс валюты взаиморасчетов по договору
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public decimal/*(15.2)*/ ИтогПлановаяСебестоимость;//Итоговая плановая себестоимость в валюте управленческого учета
		///<summary>
		///(Общ)
		///</summary>
		public bool ИспользоватьПлановуюСебестоимость;//Использовать плановую себестоимость
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта;//Дисконтная карта
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж;//Условие продаж
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
	}
}