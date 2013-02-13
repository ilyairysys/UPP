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
	public partial class КомандировкиОрганизаций:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public string/*(0)*/ СтранаНазначения;//Страна назначения
		public string/*(0)*/ ОрганизацияНазначения;//Организация назначения
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(0)*/ ОснованиеКомандировки;//Основание командировки
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public bool ДанныеПрошлойВерсии;//Перенесен из 7.7
		public V82.ДокументыСсылка.КомандировкиОрганизаций ИсправляемыйДокумент;//Исправляемый документ
		public ХранилищеЗначения ДвиженияИсправляемогоДокумента;//Движения исправляемого документа
	}
}