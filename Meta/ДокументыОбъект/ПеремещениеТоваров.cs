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
	///(Общ)
	///</summary>
	public partial class ПеремещениеТоваров:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПеремещениеТоваров ВидОперации;//Вид операции
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
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
		public V82.СправочникиСсылка.Склады СкладОтправитель;//Склад отправитель
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Склады СкладПолучатель;//Склад получатель
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.ДокументыСсылка.ВнутреннийЗаказ ВнутреннийЗаказ;//Внутренний заказ
		///<summary>
		///Необходимые действия по включению или исключению НДС в стоимости товаров при перемещении
		///</summary>
		public V82.Перечисления/*Ссылка*/.ДействиеНДСВСтоимостиТоваров НДСвСтоимостиТоваров;//НДС в стоимости товаров
		///<summary>
		///(Регл)
		///</summary>
		public object СчетСписанияНДС;//Счет списания НДС
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС1;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС2;//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДС3;//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетСписанияНДСНУ;//Счет списания НДС (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ1;//Субконто 1 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ2;//Субконто 2 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоСписанияНДСНУ3;//Субконто 3 (налоговый учет)
		///<summary>
		///Для НДС
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа;//Номенклатурная группа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатратСписанияНДС;//Статья затрат списания НДС
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///(Общ) Сумма в розничных ценах
		///</summary>
		public decimal/*(15.2)*/ СуммаДокументаРозничная;//Розничная сумма документа
		public bool РаспределениеОстатковТоваровОрганизацийПоСкладам;//Распределение остатков товаров организаций по складам
	}
}