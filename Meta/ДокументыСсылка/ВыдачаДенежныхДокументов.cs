﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ВыдачаДенежныхДокументов:ДокументСсылка
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
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийВыдачаДенежныхДокументов ВидОперации;//Вид операции
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ) 
		///</summary>
		public object Контрагент;
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10)*/ КратностьВзаиморасчетов;//Кратность взаиморасчетов
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(10.4)*/ КурсВзаиморасчетов;//Курс взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Регл) 
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		public bool РучнаяКорректировка;//Ручная корректировка
		public object СубконтоДт1;//Субконто Дт1
		public object СубконтоДт2;//Субконто Дт2
		public object СубконтоДт3;//Субконто Дт3
		public object СчетУчетаДенежныхДокументов;//Счет учета денежных документов
		public string/*(0)*/ Выдано;
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяДоходовИРасходов;//Статья доходов и расходов
		public object СчетУчетаДоходов;//Счет учета доходов
		public object СчетУчетаРасходов;//Счет учета расходов
		public object СчетУчетаДоходовНУ;//Счет учета доходов (НУ)
		public object СчетУчетаРасходовНУ;//Счет учета расходов (НУ)
		public string/*(200)*/ Содержание_УСН;//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН;//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН;//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН;//Графа5
		public decimal/*(15.2)*/ Графа7_УСН;//Графа5
		public bool ДоходыЕНВД_УСН;//ДоходыЕНВД
		public bool РасходыЕНВД_УСН;//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН;//НДС УСН
		public bool РучнаяНастройка_УСН;//Ручная настройка УСН
	}
}