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
	public partial class СписаниеНЗП:ДокументСсылка
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
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
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
		public V82.Перечисления/*Ссылка*/.ВидыНормативнойСтоимостиПроизводства ТипСтоимости;//Тип стоимости
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДт;//Счет дебета
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт1;//Субконто дебета 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт2;//Субконто дебета 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт3;//Субконто дебета 3
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДтНУ;//Счет дебета (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ1;//Субконто дебета 1 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ2;//Субконто дебета 2 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ3;//Субконто дебета 3 (налоговый учет)
		public V82.ДокументыСсылка.ИнвентаризацияНЗП ДокИнвентаризация;//Документ инвентаризации
	}
}