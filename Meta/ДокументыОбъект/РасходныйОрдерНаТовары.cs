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
	public partial class РасходныйОрдерНаТовары:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыОперацийРасходныйОрдер ВидОперации;//Вид операции
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Склады Склад;
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///Заполняется при поступлении товаров, принятых на ответственное хранение
		///</summary>
		public object ДокументПередачи;//Документ передачи
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
	}
}