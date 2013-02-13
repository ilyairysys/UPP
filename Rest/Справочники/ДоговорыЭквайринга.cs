﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//DogovoryEHkvajjringa
	[Маршрут("Справочники/ДоговорыЭквайринга","")]
	public class ДоговорыЭквайрингаЗапрос: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаЗапрос>
	{
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ПоСсылке","{Ссылка}")]
	public class ДоговорыЭквайрингаНайтиПоСсылке: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ПоКоду","{Код}")]
	public class ДоговорыЭквайрингаНайтиПоКоду: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ПоНаименованию","{Наименование}")]
	public class ДоговорыЭквайрингаНайтиПоНаименованию: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыЭквайрингаВыбратьПоСсылке: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыЭквайрингаВыбратьПоКоду: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоговорыЭквайринга/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорыЭквайрингаВыбратьПоНаименованию: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДоговорыЭквайрингаСтраницаПоСсылке: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ДоговорыЭквайрингаСтраницаПоКоду: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДоговорыЭквайринга/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ДоговорыЭквайрингаСтраницаПоНаименованию: V82.СправочникиСсылка.ДоговорыЭквайринга,IReturn<ДоговорыЭквайрингаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДоговорыЭквайрингаОтвет
	{
		public string Ответ {get;set;}
	}

	public class ДоговорыЭквайрингаСервис : Service
	{
		
		public object Get(ДоговорыЭквайрингаНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ДоговорыЭквайринга.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДоговорыЭквайрингаОтвет() {Ответ = "ДоговорыЭквайринга c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ДоговорыЭквайрингаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ДоговорыЭквайринга.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ДоговорыЭквайрингаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорыЭквайрингаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДоговорыЭквайрингаЗапрос Запрос)
		{
			return new ДоговорыЭквайрингаОтвет {Ответ = "ДоговорыЭквайринга, "};
		}

		public object Post(ДоговорыЭквайрингаЗапрос ЗапросДоговорыЭквайринга)
		{
			var Ссылка = (СправочникиСсылка.ДоговорыЭквайринга)ЗапросДоговорыЭквайринга;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}