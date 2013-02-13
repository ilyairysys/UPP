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
	public partial class РегистрацияРазовыхНачисленийРаботниковОрганизаций:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public DateTime ПериодРегистрации;//Период регистрации
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.ДокументыСсылка.РегистрацияРазовыхНачисленийРаботниковОрганизаций ПерерассчитываемыйДокумент;//Перерассчитываемый документ
		public V82.Перечисления/*Ссылка*/.СпособыРегистрацииВремени СпособРегистрацииВремени;//Способ регистрации времени
	}
}