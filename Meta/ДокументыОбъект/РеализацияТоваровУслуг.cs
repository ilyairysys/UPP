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
	public partial class РеализацияТоваровУслуг:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета БанковскийСчетОрганизации;//Банковский счет организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///(Упр)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыПередачиТоваров ВидПередачи;//Вид передачи
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузоотправитель;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Грузополучатель;
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта;//Дисконтная карта
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public string/*(0)*/ АдресДоставки;//Адрес доставки
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
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
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		public object Проект;
		///<summary>
		///(Общ)
		///</summary>
		public object Сделка;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады Склад;
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммаВключаетНДС;//Сумма включает НДС
		public V82.Перечисления/*Ссылка*/.ВидыОперацийРеализацияТоваров ВидОперации;//Вид операции
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаДоходовПоТареБУ;//Счет учета доходов по таре (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаДоходовПоТареНУ;//Счет учета доходов по таре (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасходовПоТареБУ;//Счет учета расходов по таре (БУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасходовПоТареНУ;//Счет учета расходов по таре (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоАвансам;//Счет учета расчетов по авансам
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяПрочихДоходовРасходовПоТаре;//Статья прочих доходов расходов по таре
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовПоТаре;//Счет учета расчетов по таре
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
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
		public V82.СправочникиСсылка.ФизическиеЛица ОтпускРазрешил;//Отпуск товара разрешил
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ОтпускПроизвел;//Отпуск товара произвел
		///<summary>
		///(Общ)
		///</summary>
		public string/*(15)*/ ДоверенностьНомер;//Номер доверенности
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДоверенностьДата;//Дата доверенности
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДоверенностьВыдана;//Организация выдавшая доверенность
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДоверенностьЧерезКого;//Сотрудник организации на которого выдана доверенность
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтключитьКонтрольВзаиморасчетов;//Отключить контроль взаиморасчетов
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж;//Условие продаж
		public string/*(0)*/ ДополнениеКАдресуДоставки;//Дополнение к адресу доставки
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер;//Главный бухгалтер
		public string/*(50)*/ ЗаГлавногоБухгалтераПоПриказу;//За главного бухгалтера по приказу
		public string/*(50)*/ ЗаРуководителяПоПриказу;//За руководителя по приказу
	}
}