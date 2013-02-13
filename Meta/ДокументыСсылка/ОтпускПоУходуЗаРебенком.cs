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
	///(Регл)
	///</summary>
	public partial class ОтпускПоУходуЗаРебенком:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;//Физическое лицо
		public DateTime ДатаДействия;//Дата действия
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public DateTime ДатаОкончанияПособияДоПолутораЛет;//Дата окончания пособия до полутора лет
		public DateTime ДатаОкончанияПособияДоТрехЛет;//Дата окончания пособия до трех лет
		public decimal/*(15.2)*/ СреднедневнойЗаработок;//Среднедневной заработок
		public decimal/*(2)*/ КоличествоДетей;//Количество детей
		public decimal/*(1)*/ КоличествоПервыхДетей;//Количество первых детей
		public bool ВыплачиватьПособиеДоПолутораЛет;//Выплачивать пособие до полутора лет
		public bool ВыплачиватьПособиеДоТрехЛет;//Выплачивать пособие до трех лет
		public V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию УдалитьПриказ;//Удалить приказ
		public bool ОсвобождатьСтавку;//Освобождать ставку
		public bool ДанныеПрошлойВерсии;//Перенесен из 7.7
		public V82.ДокументыСсылка.ОтпускПоУходуЗаРебенком ИсправляемыйДокумент;//Исправляемый документ
		public ХранилищеЗначения ДвиженияИсправляемогоДокумента;//Движения исправляемого документа
		///<summary>
		///Дата начала расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаНачало;//Период расчета среднего заработка начало
		///<summary>
		///Дата окончания расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаОкончание;//Период расчета среднего заработка окончание
		public bool ПрименятьЛьготыПриНачисленииПособия;//Применять льготы при начислении пособия
		public decimal/*(15.2)*/ СреднедневнойЗаработокПереходногоПериода2010;//Среднедневной заработок переходного периода - 2010
		public bool УчитыватьЗаработокПредыдущихСтрахователей;//Учитывать заработок предыдущих страхователей
		public bool РасчетПоПравилам2010Года;//Расчет по правилам 2010 года
		public bool ПеречислятьПособиеПочтовымПереводом;//Перечислять пособие почтовым переводом
		public V82.СправочникиСсылка.Банки Банк;
		public string/*(100)*/ НаименованиеБанка;//Наименование банка
		public string/*(9)*/ БИКБанка;//БИК банка
		public string/*(20)*/ НомерЛицевогоСчета;//Номер лицевого счета
		public string/*(240)*/ АдресПочтовый;//Адрес почтовый
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Фамилия;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Имя;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Отчество;
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВидДокумента;//Вид документа
		public string/*(14)*/ СерияДокумента;//Серия документа
		public string/*(14)*/ НомерДокумента;//Номер документа
		public DateTime ДатаВыдачиДокумента;//Дата выдачи документа
		public DateTime ДатаДействияДокумента;//Дата действия документа
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьУполномоченного;//Должность уполномоченного
		public V82.СправочникиСсылка.ФизическиеЛица Уполномоченный;
		public string/*(240)*/ АдресРегистрации;//Адрес регистрации
		public DateTime ДатаСправкиОНеполученииПособияОтОтца;//Дата справки о неполучении пособия от отца
		public string/*(20)*/ НомерСправкиОНеполученииПособияОтОтца;//Номер справки о неполучении пособия от отца
		public DateTime ДатаСправкиОНеполученииПособияОтМатери;//Дата справки о неполучении пособия от матери
		public string/*(20)*/ НомерСправкиОНеполученииПособияОтМатери;//Номер справки о неполучении пособия от матери
		public bool ПроживаниеРаботаВЛьготнойЗоне;//Проживание работа в льготной зоне
		public V82.Перечисления/*Ссылка*/.ВидыЗонРадиационногоПоражения СтатусЛьготнойЗоны;//Статус льготной зоны
		public DateTime ДатаСправкиПоДругимМестамРаботы;//Дата справки по другим местам работы
		public string/*(20)*/ НомерСправкиПоДругимМестамРаботы;//Номер справки по другим местам работы
		public string/*(0)*/ КемВыданДокумент;//Кем выдан документ
		public DateTime ДатаВыдачиДокументаНаПроживание;//Дата выдачи документа на проживание
		public string/*(14)*/ НомерДокументаНаПроживание;//Номер документа на проживание
		public string/*(14)*/ СерияДокументаНаПроживание;//Серия документа на проживание
		public string/*(100)*/ НаименованиеДокументаНаПроживание;//Наименование документа на проживание
		///<summary>
		///Корреспонденский счет банка
		///</summary>
		public string/*(20)*/ КоррСчетБанка;//Корр. счет банка
		public string/*(15)*/ Телефон;
		public bool РасчетПособияИзТарифнойСтавки;//Расчет пособия из тарифной ставки
		public decimal/*(15.2)*/ ТарифнаяСтавкаОклад;//Тарифная ставка оклад
		public string/*(30)*/ ТелефонСоставителя;//Телефон составителя
		public string/*(17)*/ АдресПочтовыйКодПоКЛАДР;//Адрес почтовый код по КЛАДР
	}
}