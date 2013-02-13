﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ЗаказПокупателя:ДокументОбъект
	{
		public string/*(0)*/ АдресДоставки;//Адрес доставки
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийЗаказПокупателя ВидОперации;//Вид операции
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ВремяНапоминания;//Время напоминания
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОплаты;//Дата оплаты
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОтгрузки;//Дата отгрузки
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта;//Дисконтная карта
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public bool ИспользоватьПлановуюСебестоимость;//Использовать плановую себестоимость
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ ИтогПлановаяСебестоимость;//Итоговая плановая себестоимость в валюте управленческого учета
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		///<summary>
		///(Общ) Курс валюты взаиморасчетов по договору
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		///<summary>
		///(Упр)
		///</summary>
		public bool НапомнитьОСобытии;//Напомнить о событии
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public object СтруктурнаяЕдиница;//Банк/касса
		///<summary>
		///(Общ)
		///</summary>
		public object СкладГруппа;//Склад-группа
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС;//Сумма включает НДС
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public bool УчитыватьНДС;//Учитывать НДС
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузополучатель;
		public V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов КонтактноеЛицоКонтрагента;//Контактное лицо контрагента
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж;//Условие продаж
		public string/*(0)*/ ДополнениеКАдресуДоставки;//Дополнение к адресу доставки
		public object ДокументОснование;//Документ основание
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузоотправитель;
		public string/*(20)*/ НомерВходящегоДокументаЭлектронногоОбмена;//Номер входящего документа электронного обмена
		public DateTime ДатаВходящегоДокументаЭлектронногоОбмена;//Дата входящего документа электронного обмена
		public string/*(30)*/ НомерПоДаннымПокупателя;//Номер по данным покупателя
		public DateTime ДатаПоДаннымПокупателя;//Дата по данным покупателя
	}
}