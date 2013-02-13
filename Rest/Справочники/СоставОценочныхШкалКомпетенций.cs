﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SostavOcenochnykhSHkalKompetencijj
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций","")]
	public class СоставОценочныхШкалКомпетенцийЗапрос: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийЗапрос>
	{
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ПоСсылке","{Ссылка}")]
	public class СоставОценочныхШкалКомпетенцийНайтиПоСсылке: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ПоКоду","{Код}")]
	public class СоставОценочныхШкалКомпетенцийНайтиПоКоду: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ПоНаименованию","{Наименование}")]
	public class СоставОценочныхШкалКомпетенцийНайтиПоНаименованию: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставОценочныхШкалКомпетенцийВыбратьПоСсылке: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставОценочныхШкалКомпетенцийВыбратьПоКоду: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставОценочныхШкалКомпетенцийВыбратьПоНаименованию: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СоставОценочныхШкалКомпетенцийСтраницаПоСсылке: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СоставОценочныхШкалКомпетенцийСтраницаПоКоду: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СоставОценочныхШкалКомпетенций/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СоставОценочныхШкалКомпетенцийСтраницаПоНаименованию: V82.СправочникиСсылка.СоставОценочныхШкалКомпетенций,IReturn<СоставОценочныхШкалКомпетенцийСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СоставОценочныхШкалКомпетенцийОтвет
	{
		public string Ответ {get;set;}
	}

	public class СоставОценочныхШкалКомпетенцийСервис : Service
	{
		
		public object Get(СоставОценочныхШкалКомпетенцийНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СоставОценочныхШкалКомпетенций.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СоставОценочныхШкалКомпетенцийОтвет() {Ответ = "СоставОценочныхШкалКомпетенций c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СоставОценочныхШкалКомпетенций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СоставОценочныхШкалКомпетенцийСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СоставОценочныхШкалКомпетенцийЗапрос Запрос)
		{
			return new СоставОценочныхШкалКомпетенцийОтвет {Ответ = "СоставОценочныхШкалКомпетенций, "};
		}

		public object Post(СоставОценочныхШкалКомпетенцийЗапрос ЗапросСоставОценочныхШкалКомпетенций)
		{
			var Ссылка = (СправочникиСсылка.СоставОценочныхШкалКомпетенций)ЗапросСоставОценочныхШкалКомпетенций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}