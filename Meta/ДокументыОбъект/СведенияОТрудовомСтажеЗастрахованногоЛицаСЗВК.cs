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
	///(Регл)
	///</summary>
	public partial class СведенияОТрудовомСтажеЗастрахованногоЛицаСЗВК:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public string/*(4)*/ ТипСведений;//Тип сведений
		public string/*(20)*/ ВидКомплектации;//Вид комплектации
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.Перечисления/*Ссылка*/.ФорматФайлаПФР ФорматФайла;//Формат файла
		public string/*(5)*/ НомерПачки;//Номер пачки
	}
}