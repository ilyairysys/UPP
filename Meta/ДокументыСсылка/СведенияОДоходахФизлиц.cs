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
	///(Регл)
	///</summary>
	public partial class СведенияОДоходахФизлиц:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		public decimal/*(4)*/ НалоговыйПериод;//Налоговый период
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(20)*/ КонтактныйТелефонОтветственного;//Контактный телефон ответственного
		public bool УдалитьДляПередачиВИМНС;//Для передачи в ИФНС
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьОтветственного;//Должность ответственного
		public string/*(36)*/ ИдентификаторФайла;//Идентификатор файла
		public V82.Перечисления/*Ссылка*/.ПорядокФормированияСправкиОДоходахФизлица НазначениеСправки;//Назначение справки
	}
}