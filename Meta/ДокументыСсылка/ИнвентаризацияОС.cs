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
	///Инвентаризация ОС
	///</summary>
	public partial class ИнвентаризацияОС:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///Организация
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(0)*/ Комментарий;
		public DateTime ДатаНачалаИнвентаризации;//Дата начала инвентаризации
		public DateTime ДатаОкончанияИнвентаризации;//Дата окончания инвентаризации
		public string/*(0)*/ ПричинаПроведенияИнвентаризации;//Причина проведения инвентаризации
		///<summary>
		///Документ-основание для проведения инвентаризации
		///</summary>
		public string/*(50)*/ ДокументОснованиеВид;//Документ-основание
		public DateTime ДокументОснованиеДата;//Дата документа-основания
		public string/*(10)*/ ДокументОснованиеНомер;//Номер документа-основания
	}
}