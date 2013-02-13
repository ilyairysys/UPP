﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyCFO
	[Маршрут("Справочники/ВидыЦФО","")]
	public class ВидыЦФОЗапрос: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыЦФО/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыЦФО/ПоСсылке","{Ссылка}")]
	public class ВидыЦФОНайтиПоСсылке: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыЦФО/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыЦФО/ПоКоду","{Код}")]
	public class ВидыЦФОНайтиПоКоду: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыЦФО/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыЦФО/ПоНаименованию","{Наименование}")]
	public class ВидыЦФОНайтиПоНаименованию: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЦФОВыбратьПоСсылке: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЦФОВыбратьПоКоду: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЦФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЦФОВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЦФО/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыЦФОСтраницаПоСсылке: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЦФО/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыЦФОСтраницаПоКоду: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЦФО/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыЦФОСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыЦФО,IReturn<ВидыЦФОСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыЦФООтвет
	{
		public string Ответ {get;set;}
	}

	public class ВидыЦФОСервис : Service
	{
		
		public object Get(ВидыЦФОНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыЦФО.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыЦФООтвет() {Ответ = "ВидыЦФО c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВидыЦФОНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ВидыЦФО.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ВидыЦФОВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЦФОСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыЦФОЗапрос Запрос)
		{
			return new ВидыЦФООтвет {Ответ = "ВидыЦФО, "};
		}

		public object Post(ВидыЦФОЗапрос ЗапросВидыЦФО)
		{
			var Ссылка = (СправочникиСсылка.ВидыЦФО)ЗапросВидыЦФО;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}