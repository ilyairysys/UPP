﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SotrudnikiOrganizacijj
	[Маршрут("Справочники/СотрудникиОрганизаций","")]
	public class СотрудникиОрганизацийЗапрос: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийЗапрос>
	{
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ПоСсылке","{Ссылка}")]
	public class СотрудникиОрганизацийНайтиПоСсылке: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ПоКоду","{Код}")]
	public class СотрудникиОрганизацийНайтиПоКоду: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ПоНаименованию","{Наименование}")]
	public class СотрудникиОрганизацийНайтиПоНаименованию: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СотрудникиОрганизацийВыбратьПоСсылке: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СотрудникиОрганизацийВыбратьПоКоду: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СотрудникиОрганизаций/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СотрудникиОрганизацийВыбратьПоНаименованию: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СотрудникиОрганизацийСтраницаПоСсылке: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СотрудникиОрганизацийСтраницаПоКоду: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СотрудникиОрганизаций/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СотрудникиОрганизацийСтраницаПоНаименованию: V82.СправочникиСсылка.СотрудникиОрганизаций,IReturn<СотрудникиОрганизацийСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СотрудникиОрганизацийОтвет
	{
		public string Ответ {get;set;}
	}

	public class СотрудникиОрганизацийСервис : Service
	{
		
		public object Get(СотрудникиОрганизацийНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СотрудникиОрганизаций.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СотрудникиОрганизацийОтвет() {Ответ = "СотрудникиОрганизаций c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(СотрудникиОрганизацийНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.СотрудникиОрганизаций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(СотрудникиОрганизацийВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СотрудникиОрганизацийСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СотрудникиОрганизацийЗапрос Запрос)
		{
			return new СотрудникиОрганизацийОтвет {Ответ = "СотрудникиОрганизаций, "};
		}

		public object Post(СотрудникиОрганизацийЗапрос ЗапросСотрудникиОрганизаций)
		{
			var Ссылка = (СправочникиСсылка.СотрудникиОрганизаций)ЗапросСотрудникиОрганизаций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}