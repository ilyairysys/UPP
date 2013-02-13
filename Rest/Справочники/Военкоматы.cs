﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Voenkomaty
	[Маршрут("Справочники/Военкоматы","")]
	public class ВоенкоматыЗапрос: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыЗапрос>
	{
	}
	[Маршрут("Справочники/Военкоматы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Военкоматы/ПоСсылке","{Ссылка}")]
	public class ВоенкоматыНайтиПоСсылке: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Военкоматы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Военкоматы/ПоКоду","{Код}")]
	public class ВоенкоматыНайтиПоКоду: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Военкоматы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Военкоматы/ПоНаименованию","{Наименование}")]
	public class ВоенкоматыНайтиПоНаименованию: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Военкоматы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВоенкоматыВыбратьПоСсылке: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Военкоматы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВоенкоматыВыбратьПоКоду: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Военкоматы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Военкоматы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВоенкоматыВыбратьПоНаименованию: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Военкоматы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВоенкоматыСтраницаПоСсылке: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Военкоматы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВоенкоматыСтраницаПоКоду: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Военкоматы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВоенкоматыСтраницаПоНаименованию: V82.СправочникиСсылка.Военкоматы,IReturn<ВоенкоматыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВоенкоматыОтвет
	{
		public string Ответ {get;set;}
	}

	public class ВоенкоматыСервис : Service
	{
		
		public object Get(ВоенкоматыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Военкоматы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВоенкоматыОтвет() {Ответ = "Военкоматы c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ВоенкоматыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.Военкоматы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ВоенкоматыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВоенкоматыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВоенкоматыЗапрос Запрос)
		{
			return new ВоенкоматыОтвет {Ответ = "Военкоматы, "};
		}

		public object Post(ВоенкоматыЗапрос ЗапросВоенкоматы)
		{
			var Ссылка = (СправочникиСсылка.Военкоматы)ЗапросВоенкоматы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}