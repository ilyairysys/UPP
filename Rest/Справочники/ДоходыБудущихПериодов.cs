﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//DokhodyBudushhikhPeriodov
	[Маршрут("Справочники/ДоходыБудущихПериодов","")]
	public class ДоходыБудущихПериодовЗапрос: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовЗапрос>
	{
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ПоСсылке","{Ссылка}")]
	public class ДоходыБудущихПериодовНайтиПоСсылке: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ПоКоду","{Код}")]
	public class ДоходыБудущихПериодовНайтиПоКоду: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ПоНаименованию","{Наименование}")]
	public class ДоходыБудущихПериодовНайтиПоНаименованию: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоходыБудущихПериодовВыбратьПоСсылке: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоходыБудущихПериодовВыбратьПоКоду: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДоходыБудущихПериодов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоходыБудущихПериодовВыбратьПоНаименованию: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДоходыБудущихПериодовСтраницаПоСсылке: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ДоходыБудущихПериодовСтраницаПоКоду: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДоходыБудущихПериодов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ДоходыБудущихПериодовСтраницаПоНаименованию: V82.СправочникиСсылка.ДоходыБудущихПериодов,IReturn<ДоходыБудущихПериодовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДоходыБудущихПериодовОтвет
	{
		public string Ответ {get;set;}
	}

	public class ДоходыБудущихПериодовСервис : Service
	{
		
		public object Get(ДоходыБудущихПериодовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ДоходыБудущихПериодов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДоходыБудущихПериодовОтвет() {Ответ = "ДоходыБудущихПериодов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ДоходыБудущихПериодовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ДоходыБудущихПериодов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ДоходыБудущихПериодовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДоходыБудущихПериодовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДоходыБудущихПериодовЗапрос Запрос)
		{
			return new ДоходыБудущихПериодовОтвет {Ответ = "ДоходыБудущихПериодов, "};
		}

		public object Post(ДоходыБудущихПериодовЗапрос ЗапросДоходыБудущихПериодов)
		{
			var Ссылка = (СправочникиСсылка.ДоходыБудущихПериодов)ЗапросДоходыБудущихПериодов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}