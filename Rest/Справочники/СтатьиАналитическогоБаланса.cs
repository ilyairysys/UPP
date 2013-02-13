﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StatiAnaliticheskogoBalansa
	[Маршрут("Справочники/СтатьиАналитическогоБаланса","")]
	public class СтатьиАналитическогоБалансаЗапрос: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаЗапрос>
	{
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ПоСсылке","{Ссылка}")]
	public class СтатьиАналитическогоБалансаНайтиПоСсылке: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ПоКоду","{Код}")]
	public class СтатьиАналитическогоБалансаНайтиПоКоду: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ПоНаименованию","{Наименование}")]
	public class СтатьиАналитическогоБалансаНайтиПоНаименованию: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиАналитическогоБалансаВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиАналитическогоБалансаВыбратьПоКоду: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиАналитическогоБалансаВыбратьПоНаименованию: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СтатьиАналитическогоБалансаСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СтатьиАналитическогоБалансаСтраницаПоКоду: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиАналитическогоБаланса/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СтатьиАналитическогоБалансаСтраницаПоНаименованию: V82.СправочникиСсылка.СтатьиАналитическогоБаланса,IReturn<СтатьиАналитическогоБалансаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СтатьиАналитическогоБалансаОтвет
	{
		public string Ответ {get;set;}
	}

	public class СтатьиАналитическогоБалансаСервис : Service
	{
		
		public object Get(СтатьиАналитическогоБалансаНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтатьиАналитическогоБаланса.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтатьиАналитическогоБалансаОтвет() {Ответ = "СтатьиАналитическогоБаланса c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СтатьиАналитическогоБалансаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СтатьиАналитическогоБаланса.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СтатьиАналитическогоБалансаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиАналитическогоБалансаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СтатьиАналитическогоБалансаЗапрос Запрос)
		{
			return new СтатьиАналитическогоБалансаОтвет {Ответ = "СтатьиАналитическогоБаланса, "};
		}

		public object Post(СтатьиАналитическогоБалансаЗапрос ЗапросСтатьиАналитическогоБаланса)
		{
			var Ссылка = (СправочникиСсылка.СтатьиАналитическогоБаланса)ЗапросСтатьиАналитическогоБаланса;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}