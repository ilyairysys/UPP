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
	///Ввод начальных остатков для подсистемы взаиморасчетов
	///</summary>
	public partial class ВводНачальныхОстатковПоВзаиморасчетам:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам ВидОперации;//Вид операции
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
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		public bool ОтразитьВРегистрахРасчетовОрганизации;//Отразить в регистрах расчетов организации
		public bool ФормироватьПроводкиПоВводуНачальныхОстатков;//Формировать проводки по вводу начальных остатков
		public bool ОтразитьВРегистреВзаиморасчетовПоДокументам;//Отразить в регистре взаиморасчетов по документам
	}
}