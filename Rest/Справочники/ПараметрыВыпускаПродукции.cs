﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ParametryVypuskaProdukcii
	[Маршрут("Справочники/ПараметрыВыпускаПродукции","")]
	public class ПараметрыВыпускаПродукцииЗапрос: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииЗапрос>
	{
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ПоСсылке","{Ссылка}")]
	public class ПараметрыВыпускаПродукцииНайтиПоСсылке: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ПоКоду","{Код}")]
	public class ПараметрыВыпускаПродукцииНайтиПоКоду: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ПоНаименованию","{Наименование}")]
	public class ПараметрыВыпускаПродукцииНайтиПоНаименованию: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыпускаПродукцииВыбратьПоСсылке: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыпускаПродукцииВыбратьПоКоду: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыпускаПродукцииВыбратьПоНаименованию: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПараметрыВыпускаПродукцииСтраницаПоСсылке: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПараметрыВыпускаПродукцииСтраницаПоКоду: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыпускаПродукции/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПараметрыВыпускаПродукцииСтраницаПоНаименованию: V82.СправочникиСсылка.ПараметрыВыпускаПродукции,IReturn<ПараметрыВыпускаПродукцииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПараметрыВыпускаПродукцииОтвет
	{
		public string Ответ {get;set;}
	}

	public class ПараметрыВыпускаПродукцииСервис : Service
	{
		
		public object Get(ПараметрыВыпускаПродукцииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПараметрыВыпускаПродукции.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПараметрыВыпускаПродукцииОтвет() {Ответ = "ПараметрыВыпускаПродукции c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ПараметрыВыпускаПродукцииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ПараметрыВыпускаПродукции.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ПараметрыВыпускаПродукцииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыпускаПродукцииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПараметрыВыпускаПродукцииЗапрос Запрос)
		{
			return new ПараметрыВыпускаПродукцииОтвет {Ответ = "ПараметрыВыпускаПродукции, "};
		}

		public object Post(ПараметрыВыпускаПродукцииЗапрос ЗапросПараметрыВыпускаПродукции)
		{
			var Ссылка = (СправочникиСсылка.ПараметрыВыпускаПродукции)ЗапросПараметрыВыпускаПродукции;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}