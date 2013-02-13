﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyParametrovVypuskaProdukcii
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции","")]
	public class ВидыПараметровВыпускаПродукцииЗапрос: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ПоСсылке","{Ссылка}")]
	public class ВидыПараметровВыпускаПродукцииНайтиПоСсылке: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ПоКоду","{Код}")]
	public class ВидыПараметровВыпускаПродукцииНайтиПоКоду: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ПоНаименованию","{Наименование}")]
	public class ВидыПараметровВыпускаПродукцииНайтиПоНаименованию: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыПараметровВыпускаПродукцииВыбратьПоСсылке: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыПараметровВыпускаПродукцииВыбратьПоКоду: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыПараметровВыпускаПродукцииВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыПараметровВыпускаПродукцииСтраницаПоСсылке: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыПараметровВыпускаПродукцииСтраницаПоКоду: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыПараметровВыпускаПродукции/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыПараметровВыпускаПродукцииСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыПараметровВыпускаПродукции,IReturn<ВидыПараметровВыпускаПродукцииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыПараметровВыпускаПродукцииОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВидыПараметровВыпускаПродукцииСервис : Service
	{
		
		public object Get(ВидыПараметровВыпускаПродукцииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыПараметровВыпускаПродукции.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыПараметровВыпускаПродукцииОтвет() {Ответ = "ВидыПараметровВыпускаПродукции c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ВидыПараметровВыпускаПродукции.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыПараметровВыпускаПродукцииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыПараметровВыпускаПродукцииЗапрос Запрос)
		{
			return new ВидыПараметровВыпускаПродукцииОтвет {Ответ = "ВидыПараметровВыпускаПродукции, "};
		}

		public object Post(ВидыПараметровВыпускаПродукцииЗапрос ЗапросВидыПараметровВыпускаПродукции)
		{
			var Ссылка = (СправочникиСсылка.ВидыПараметровВыпускаПродукции)ЗапросВидыПараметровВыпускаПродукции;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}