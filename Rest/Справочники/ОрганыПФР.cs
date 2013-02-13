﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OrganyPFR
	[Маршрут("Справочники/ОрганыПФР","")]
	public class ОрганыПФРЗапрос: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРЗапрос>
	{
	}
	[Маршрут("Справочники/ОрганыПФР/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОрганыПФР/ПоСсылке","{Ссылка}")]
	public class ОрганыПФРНайтиПоСсылке: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОрганыПФР/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОрганыПФР/ПоКоду","{Код}")]
	public class ОрганыПФРНайтиПоКоду: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОрганыПФР/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОрганыПФР/ПоНаименованию","{Наименование}")]
	public class ОрганыПФРНайтиПоНаименованию: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганыПФРВыбратьПоСсылке: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганыПФРВыбратьПоКоду: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОрганыПФР/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОрганыПФРВыбратьПоНаименованию: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОрганыПФР/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОрганыПФРСтраницаПоСсылке: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОрганыПФР/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОрганыПФРСтраницаПоКоду: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОрганыПФР/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОрганыПФРСтраницаПоНаименованию: V82.СправочникиСсылка.ОрганыПФР,IReturn<ОрганыПФРСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОрганыПФРОтвет
	{
		public string Ответ {get;set;}
	}

	public class ОрганыПФРСервис : Service
	{
		
		public object Get(ОрганыПФРНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОрганыПФР.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОрганыПФРОтвет() {Ответ = "ОрганыПФР c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ОрганыПФРНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ОрганыПФР.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ОрганыПФРВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОрганыПФРСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОрганыПФРЗапрос Запрос)
		{
			return new ОрганыПФРОтвет {Ответ = "ОрганыПФР, "};
		}

		public object Post(ОрганыПФРЗапрос ЗапросОрганыПФР)
		{
			var Ссылка = (СправочникиСсылка.ОрганыПФР)ЗапросОрганыПФР;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}