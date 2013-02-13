﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ЗапросВФССОПроверкеРаботодателя:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Физическое лицо
		public V82.Перечисления/*Ссылка*/.ВидыПособийСоциальногоСтрахования ВидПособия;//Вид пособия
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель;
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьРуководителя;//Должность руководителя
		public string/*(14)*/ РегистрационныйНомерФСС;//Регистрационный номер ФСС
		public string/*(14)*/ ДополнительныйКодФСС;//Дополнительный код ФСС
		public string/*(5)*/ КодПодчиненностиФСС;//Код подчиненности ФСС
		public string/*(135)*/ НаименованиеТерриториальногоОрганаФСС;//Наименование территориального органа ФСС
		public string/*(240)*/ АдресОрганизации;//Адрес организации
		public string/*(14)*/ СтраховойНомерПФР;//Страховой номер ПФР
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Фамилия;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Имя;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Отчество;
		public string/*(240)*/ Адрес;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
	}
}