﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ProfiliIzmeneniyaPlanovPoPeriodam
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам","")]
	public class ПрофилиИзмененияПлановПоПериодамЗапрос: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамЗапрос>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ПоСсылке","{Ссылка}")]
	public class ПрофилиИзмененияПлановПоПериодамНайтиПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ПоКоду","{Код}")]
	public class ПрофилиИзмененияПлановПоПериодамНайтиПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ПоНаименованию","{Наименование}")]
	public class ПрофилиИзмененияПлановПоПериодамНайтиПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоПериодамВыбратьПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоПериодамВыбратьПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоПериодамВыбратьПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоПериодамСтраницаПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоПериодамСтраницаПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоПериодам/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоПериодамСтраницаПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам,IReturn<ПрофилиИзмененияПлановПоПериодамСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПрофилиИзмененияПлановПоПериодамОтвет
	{
		public string Ответ {get;set;}
	}

	public class ПрофилиИзмененияПлановПоПериодамСервис : Service
	{
		
		public object Get(ПрофилиИзмененияПлановПоПериодамНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПрофилиИзмененияПлановПоПериодам.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПрофилиИзмененияПлановПоПериодамОтвет() {Ответ = "ПрофилиИзмененияПлановПоПериодам c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ПрофилиИзмененияПлановПоПериодам.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоПериодамСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПрофилиИзмененияПлановПоПериодамЗапрос Запрос)
		{
			return new ПрофилиИзмененияПлановПоПериодамОтвет {Ответ = "ПрофилиИзмененияПлановПоПериодам, "};
		}

		public object Post(ПрофилиИзмененияПлановПоПериодамЗапрос ЗапросПрофилиИзмененияПлановПоПериодам)
		{
			var Ссылка = (СправочникиСсылка.ПрофилиИзмененияПлановПоПериодам)ЗапросПрофилиИзмененияПлановПоПериодам;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}