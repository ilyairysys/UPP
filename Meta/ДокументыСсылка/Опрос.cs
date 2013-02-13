﻿
using System;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class Опрос:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public object ОпрашиваемоеЛицо;//Опрашиваемое лицо
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.ТиповыеАнкеты ТиповаяАнкета;//Типовая анкета
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.ДокументыСсылка.РассылкаАнкет Рассылка;
		public bool ОпросЗавершен;//Опрос завершен
	}
}