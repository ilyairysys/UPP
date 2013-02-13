﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NapravleniyaIspolzovaniyaPribyli
	[Маршрут("Справочники/НаправленияИспользованияПрибыли","")]
	public class НаправленияИспользованияПрибылиЗапрос: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиЗапрос>
	{
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ПоСсылке","{Ссылка}")]
	public class НаправленияИспользованияПрибылиНайтиПоСсылке: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ПоКоду","{Код}")]
	public class НаправленияИспользованияПрибылиНайтиПоКоду: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ПоНаименованию","{Наименование}")]
	public class НаправленияИспользованияПрибылиНайтиПоНаименованию: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НаправленияИспользованияПрибылиВыбратьПоСсылке: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class НаправленияИспользованияПрибылиВыбратьПоКоду: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НаправленияИспользованияПрибылиВыбратьПоНаименованию: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НаправленияИспользованияПрибылиСтраницаПоСсылке: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class НаправленияИспользованияПрибылиСтраницаПоКоду: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НаправленияИспользованияПрибыли/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НаправленияИспользованияПрибылиСтраницаПоНаименованию: V82.СправочникиСсылка.НаправленияИспользованияПрибыли,IReturn<НаправленияИспользованияПрибылиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НаправленияИспользованияПрибылиОтвет
	{
		public string Ответ {get;set;}
	}

	public class НаправленияИспользованияПрибылиСервис : Service
	{
		
		public object Get(НаправленияИспользованияПрибылиНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.НаправленияИспользованияПрибыли.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new НаправленияИспользованияПрибылиОтвет() {Ответ = "НаправленияИспользованияПрибыли c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(НаправленияИспользованияПрибылиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.НаправленияИспользованияПрибыли.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(НаправленияИспользованияПрибылиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НаправленияИспользованияПрибылиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НаправленияИспользованияПрибылиЗапрос Запрос)
		{
			return new НаправленияИспользованияПрибылиОтвет {Ответ = "НаправленияИспользованияПрибыли, "};
		}

		public object Post(НаправленияИспользованияПрибылиЗапрос ЗапросНаправленияИспользованияПрибыли)
		{
			var Ссылка = (СправочникиСсылка.НаправленияИспользованияПрибыли)ЗапросНаправленияИспользованияПрибыли;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}