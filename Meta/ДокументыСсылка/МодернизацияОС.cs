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
	public partial class МодернизацияОС:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Регл)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыСобытийОС ВидОперацийСОсновнымиСредствами;//Вид операций с основными средствами
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства;//Объект строительства
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
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СобытияОС Событие;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СобытияОС СобытиеРегл;//Событие (регл)
		///<summary>
		///(Упр)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьУУ;//Стоимость по управленческому учету
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьБУ;//Стоимость БУ
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьБУХоз;//Стоимость БУ (Хоз. способ)
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьНУ;//Стоимость НУ
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьНУХоз;//Стоимость НУ (хоз. способ)
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьПР;//Стоимость (ПР)
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьПРХоз;//Стоимость (ПР) (хоз. способ)
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьВР;//Стоимость (ВР)
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьВРХоз;//Стоимость (ВР) (хоз. способ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаБУВнеоборотногоАктива;//Счет учета БУ внеоборотного актива
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаНУВнеоборотногоАктива;//Счет учета НУ внеоборотного актива
		public object СчетУчетаЗатратПоАмортизационнойПремии;//Счет учета затрат по амортизационной премии
		public object СубконтоПоАмортизационнойПремии1;//Субконто по амортизационной премии1
		public object СубконтоПоАмортизационнойПремии2;//Субконто по амортизационной премии2
		public object СубконтоПоАмортизационнойПремии3;//Субконто по амортизационной премии3
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(15.2)*/ СтоимостьУСН;//Стоимость УСН
		public bool ВключатьАПВСоставРасходовПриОтраженииМодернизации;//Включать амортизационную премию в состав расходов при отражении модернизации
	}
}