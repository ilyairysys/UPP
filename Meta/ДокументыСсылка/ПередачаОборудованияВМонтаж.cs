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
	public partial class ПередачаОборудованияВМонтаж:ДокументСсылка
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
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства;//Объект строительства
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат;//Статья затрат
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады Склад;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаБУОбъектаСтроительства;//Счет учета БУ объекта строительства
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Обш)
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаНУОбъектаСтроительства;//Счет учета НУ объекта строительства
	}
}