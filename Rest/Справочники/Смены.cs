﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Smeny
	[Маршрут("Справочники/Смены","")]
	public class СменыЗапрос: V82.СправочникиСсылка.Смены,IReturn<СменыЗапрос>
	{
	}
	[Маршрут("Справочники/Смены/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Смены/ПоСсылке","{Ссылка}")]
	public class СменыНайтиПоСсылке: V82.СправочникиСсылка.Смены,IReturn<СменыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Смены/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Смены/ПоКоду","{Код}")]
	public class СменыНайтиПоКоду: V82.СправочникиСсылка.Смены,IReturn<СменыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Смены/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Смены/ПоНаименованию","{Наименование}")]
	public class СменыНайтиПоНаименованию: V82.СправочникиСсылка.Смены,IReturn<СменыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Смены/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Смены/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Смены/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СменыВыбратьПоСсылке: V82.СправочникиСсылка.Смены,IReturn<СменыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Смены/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Смены/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Смены/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СменыВыбратьПоКоду: V82.СправочникиСсылка.Смены,IReturn<СменыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Смены/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Смены/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Смены/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СменыВыбратьПоНаименованию: V82.СправочникиСсылка.Смены,IReturn<СменыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Смены/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СменыСтраницаПоСсылке: V82.СправочникиСсылка.Смены,IReturn<СменыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Смены/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СменыСтраницаПоКоду: V82.СправочникиСсылка.Смены,IReturn<СменыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Смены/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СменыСтраницаПоНаименованию: V82.СправочникиСсылка.Смены,IReturn<СменыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СменыОтвет
	{
		public string Ответ {get;set;}
	}

	public class СменыСервис : Service
	{
		
		public object Get(СменыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СменыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Смены.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СменыОтвет() {Ответ = "Смены c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СменыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СменыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Смены.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СменыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СменыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СменыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СменыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СменыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СменыЗапрос Запрос)
		{
			return new СменыОтвет {Ответ = "Смены, "};
		}

		public object Post(СменыЗапрос ЗапросСмены)
		{
			var Ссылка = (СправочникиСсылка.Смены)ЗапросСмены;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}