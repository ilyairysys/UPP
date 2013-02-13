﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyFinRezervov
	[Маршрут("Справочники/ВидыФинРезервов","")]
	public class ВидыФинРезервовЗапрос: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыФинРезервов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыФинРезервов/ПоСсылке","{Ссылка}")]
	public class ВидыФинРезервовНайтиПоСсылке: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыФинРезервов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыФинРезервов/ПоКоду","{Код}")]
	public class ВидыФинРезервовНайтиПоКоду: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыФинРезервов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыФинРезервов/ПоНаименованию","{Наименование}")]
	public class ВидыФинРезервовНайтиПоНаименованию: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыФинРезервовВыбратьПоСсылке: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыФинРезервовВыбратьПоКоду: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыФинРезервов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыФинРезервовВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыФинРезервов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыФинРезервовСтраницаПоСсылке: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыФинРезервов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыФинРезервовСтраницаПоКоду: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыФинРезервов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыФинРезервовСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыФинРезервов,IReturn<ВидыФинРезервовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыФинРезервовОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВидыФинРезервовСервис : Service
	{
		
		public object Get(ВидыФинРезервовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыФинРезервов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыФинРезервовОтвет() {Ответ = "ВидыФинРезервов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВидыФинРезервовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ВидыФинРезервов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ВидыФинРезервовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыФинРезервовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыФинРезервовЗапрос Запрос)
		{
			return new ВидыФинРезервовОтвет {Ответ = "ВидыФинРезервов, "};
		}

		public object Post(ВидыФинРезервовЗапрос ЗапросВидыФинРезервов)
		{
			var Ссылка = (СправочникиСсылка.ВидыФинРезервов)ЗапросВидыФинРезервов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}