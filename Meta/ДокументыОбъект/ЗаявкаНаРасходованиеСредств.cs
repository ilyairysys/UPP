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
	public partial class ЗаявкаНаРасходованиеСредств:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыОперацийЗаявкиНаРасходование ВидОперации;//Вид операции
		public DateTime ДатаРасхода;//Дата расхода
		///<summary>
		///Подотчетник, касса ККМ
		///</summary>
		public object Получатель;
		public object ДокументОснование;//Документ основание
		public V82.Перечисления/*Ссылка*/.ВидыДенежныхСредств ФормаОплаты;//Форма оплаты
		///<summary>
		///Р/с, касса 
		///</summary>
		public object БанковскийСчетКасса;//Банковский счет касса
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public decimal/*(10.4)*/ КурсДокумента;//Курс документа
		public decimal/*(10)*/ КратностьДокумента;//Кратность документа
		///<summary>
		///Валюта, в которой подотчетник должен отчитаться за истраченные деньги
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаВзаиморасчетовПодотчетника;//Валюта взаиморасчетов подотчетника
		public object РасчетныйДокумент;//Расчетный документ
		///<summary>
		///(Упр) срок погашения аванса подотчетником
		///</summary>
		public DateTime ДатаПогашенияАванса;//Дата погашения аванса
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public V82.СправочникиСсылка.СтатьиОборотовПоБюджетам СтатьяОборотов;//Статья оборотов
		public V82.СправочникиСсылка.Подразделения ЦФО;
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public object Номенклатура;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		public string/*(0)*/ Описание;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Упр)
		///</summary>
		public bool АвтоРезервированиеПоЗаявке;//Авторезервирование денежных средств
		///<summary>
		///(Упр)
		///</summary>
		public bool АвтоРазмещениеПоЗаявке;//Авторазмещение по заявке
		public bool ВключатьВПлатежныйКалендарь;//Включать в платежный календарь
		public V82.Перечисления/*Ссылка*/.ВидВыдачиДенежныхСредств ВидВыдачиДенежныхСредств;//Вид выдачи денежных средств
	}
}