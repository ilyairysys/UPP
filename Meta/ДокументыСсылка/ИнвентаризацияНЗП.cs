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
	public partial class ИнвентаризацияНЗП:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
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
		public object Заказ;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат;//Статья затрат
		///<summary>
		///(Общ)
		///</summary>
		public bool ВводитьЗаказыПоСтрокам;//Вводить заказы по строкам
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа;//Номенклатурная группа
		///<summary>
		///(Общ)
		///</summary>
		public bool ВводитьНоменклатурныеГруппыПоСтрокам;//Вводить номенклатурные группы по строкам
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
	}
}