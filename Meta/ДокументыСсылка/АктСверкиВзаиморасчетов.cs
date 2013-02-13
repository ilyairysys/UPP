﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class АктСверкиВзаиморасчетов:ДокументСсылка
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
		public V82.СправочникиСсылка.Организации Организация;
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
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
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
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ПредставительОрганизации;//Представитель организации
		public V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов ПредставительКонтрагента;//Представитель контрагента
		///<summary>
		///(Общ) Остаток на начало 
		///</summary>
		public decimal/*(15.2)*/ ОстатокНаНачало;//Остаток на начало
		///<summary>
		///(Общ) Остаток на конец
		///</summary>
		public decimal/*(15.2)*/ Расхождение;
		///<summary>
		///Признак согласования сверки
		///</summary>
		public bool СверкаСогласована;//Сверка согласована
	}
}