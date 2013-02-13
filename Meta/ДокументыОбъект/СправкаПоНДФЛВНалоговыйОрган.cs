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
	public partial class СправкаПоНДФЛВНалоговыйОрган:ДокументОбъект
	{
		public decimal/*(4)*/ НалоговыйПериод;//Налоговый период
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(21)*/ ОКАТО_КПП;//ОКАТО/КПП
		public V82.Перечисления/*Ссылка*/.ОснованияДляПредставленияСправок2НДФЛ ОснованиеДляПредставленияСправок;//Основание для представления справок
		public string/*(84)*/ ИмяФайла;//Имя файла
		public string/*(20)*/ Телефон;
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер;//Главный бухгалтер
		public V82.СправочникиСсылка.ФизическиеЛица СправкуПодписал;//Справку подписал
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьПодписавшегоЛица;//Должность подписавшего лица
		public bool ПринятоНалоговымОрганом;//Принято в ИФНС
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///Ведет себя по правилам 2010 года.
		///</summary>
		public bool СпециальныйДокумент2011года;//Специальный документ 2011 года
		public string/*(4)*/ КодИФНС;//Код ИФНС
	}
}