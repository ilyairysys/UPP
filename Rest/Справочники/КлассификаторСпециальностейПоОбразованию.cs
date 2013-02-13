﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlassifikatorSpecialnostejjPoObrazovaniyu
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию","")]
	public class КлассификаторСпециальностейПоОбразованиюЗапрос: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюЗапрос>
	{
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ПоСсылке","{Ссылка}")]
	public class КлассификаторСпециальностейПоОбразованиюНайтиПоСсылке: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ПоКоду","{Код}")]
	public class КлассификаторСпециальностейПоОбразованиюНайтиПоКоду: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ПоНаименованию","{Наименование}")]
	public class КлассификаторСпециальностейПоОбразованиюНайтиПоНаименованию: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторСпециальностейПоОбразованиюВыбратьПоСсылке: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторСпециальностейПоОбразованиюВыбратьПоКоду: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторСпециальностейПоОбразованиюВыбратьПоНаименованию: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КлассификаторСпециальностейПоОбразованиюСтраницаПоСсылке: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class КлассификаторСпециальностейПоОбразованиюСтраницаПоКоду: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлассификаторСпециальностейПоОбразованию/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КлассификаторСпециальностейПоОбразованиюСтраницаПоНаименованию: V82.СправочникиСсылка.КлассификаторСпециальностейПоОбразованию,IReturn<КлассификаторСпециальностейПоОбразованиюСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КлассификаторСпециальностейПоОбразованиюОтвет
	{
		public string Ответ {get;set;}
	}

	public class КлассификаторСпециальностейПоОбразованиюСервис : Service
	{
		
		public object Get(КлассификаторСпециальностейПоОбразованиюНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.КлассификаторСпециальностейПоОбразованию.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КлассификаторСпециальностейПоОбразованиюОтвет() {Ответ = "КлассификаторСпециальностейПоОбразованию c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.КлассификаторСпециальностейПоОбразованию.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторСпециальностейПоОбразованиюСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлассификаторСпециальностейПоОбразованиюЗапрос Запрос)
		{
			return new КлассификаторСпециальностейПоОбразованиюОтвет {Ответ = "КлассификаторСпециальностейПоОбразованию, "};
		}

		public object Post(КлассификаторСпециальностейПоОбразованиюЗапрос ЗапросКлассификаторСпециальностейПоОбразованию)
		{
			var Ссылка = (СправочникиСсылка.КлассификаторСпециальностейПоОбразованию)ЗапросКлассификаторСпециальностейПоОбразованию;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}