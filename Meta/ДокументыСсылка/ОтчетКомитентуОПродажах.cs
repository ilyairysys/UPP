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
	public partial class ОтчетКомитентуОПродажах:ДокументСсылка
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
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.СпособыРасчетаКомиссионногоВознаграждения СпособРасчетаКомиссионногоВознаграждения;//Способ расчета комиссионного вознаграждения
		///<summary>
		///(Общ) Сумма комиссионного вознаграждения в валюте взаиморасчетов (долга перед комиссионером за услугу по реализации товаров)
		///</summary>
		public decimal/*(15.2)*/ СуммаВознаграждения;//Сумма вознаграждения 
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.СтавкиНДС СтавкаНДСВознаграждения;//Ставка НДС с комиссионного вознаграждения
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public object Сделка;
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ) Процент от прибыли или с продаж, по которому рассчитывается сумма комиссионного вознаграждения
		///</summary>
		public decimal/*(5.2)*/ ПроцентКомиссионногоВознаграждения;//Процент комиссионного вознаграждения
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов ТипЦен;//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоАвансам;//Счет учета расчетов по авансам
		public bool УдержатьКомиссионноеВознаграждение;//Удержать комиссионное вознаграждение
		public V82.СправочникиСсылка.Номенклатура УслугаПоВознаграждению;//Услуга по вознаграждению за комиссию
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДоходовБУ;//Счет доходов (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДоходовНУ;//Счет доходов (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ;//Субконто (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ;//Субконто (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаНДСПоРеализации;//Счет учета НДС по реализации
		public object Проект;
	}
}