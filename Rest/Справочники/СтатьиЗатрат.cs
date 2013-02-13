﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StatiZatrat
	[Маршрут("Справочники/СтатьиЗатрат","")]
	public class СтатьиЗатратЗапрос: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратЗапрос>
	{
	}
	[Маршрут("Справочники/СтатьиЗатрат/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтатьиЗатрат/ПоСсылке","{Ссылка}")]
	public class СтатьиЗатратНайтиПоСсылке: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтатьиЗатрат/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтатьиЗатрат/ПоКоду","{Код}")]
	public class СтатьиЗатратНайтиПоКоду: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтатьиЗатрат/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтатьиЗатрат/ПоНаименованию","{Наименование}")]
	public class СтатьиЗатратНайтиПоНаименованию: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиЗатратВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиЗатратВыбратьПоКоду: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиЗатрат/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиЗатратВыбратьПоНаименованию: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиЗатрат/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СтатьиЗатратСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиЗатрат/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СтатьиЗатратСтраницаПоКоду: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиЗатрат/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СтатьиЗатратСтраницаПоНаименованию: V82.СправочникиСсылка.СтатьиЗатрат,IReturn<СтатьиЗатратСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СтатьиЗатратОтвет
	{
		public string Ответ {get;set;}
	}

	public class СтатьиЗатратСервис : Service
	{
		
		public object Get(СтатьиЗатратНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтатьиЗатрат.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтатьиЗатратОтвет() {Ответ = "СтатьиЗатрат c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СтатьиЗатратНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СтатьиЗатрат.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СтатьиЗатратВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиЗатратСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СтатьиЗатратЗапрос Запрос)
		{
			return new СтатьиЗатратОтвет {Ответ = "СтатьиЗатрат, "};
		}

		public object Post(СтатьиЗатратЗапрос ЗапросСтатьиЗатрат)
		{
			var Ссылка = (СправочникиСсылка.СтатьиЗатрат)ЗапросСтатьиЗатрат;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}