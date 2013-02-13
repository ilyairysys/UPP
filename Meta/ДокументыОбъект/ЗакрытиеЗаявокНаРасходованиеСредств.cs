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
	public partial class ЗакрытиеЗаявокНаРасходованиеСредств:ДокументОбъект
	{
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public bool ОтборЦФО;//Отбор по ЦФО
		public V82.СправочникиСсылка.Подразделения ЦФО;
		public bool ОтборОтветственный;//Отбор ответственный
		///<summary>
		///Ответственный для отбора заявок
		///</summary>
		public V82.СправочникиСсылка.Пользователи ОтветственныйЗаявка;//Ответственный заявка
		public bool ОтборКонтрагент;//Отбор по контрагенту
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public DateTime ОтборДатаНач;//Дата начала отбора
		public DateTime ОтборДатаКон;//Дата конца отбора
	}
}