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
	///(Упр)
	///</summary>
	public partial class АктуализацияБюджетов:ДокументОбъект
	{
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаКонца;//Дата конца
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		public bool АктуализироватьБюджеты;//Актуализировать бюджеты
		public bool ПеренестиТранзакции;//Перенести транзакции
	}
}