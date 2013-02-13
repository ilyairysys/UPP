﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OtraslevyeSegmentyPoMSFO
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО","")]
	public class ОтраслевыеСегментыПоМСФОЗапрос: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОЗапрос>
	{
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ПоСсылке","{Ссылка}")]
	public class ОтраслевыеСегментыПоМСФОНайтиПоСсылке: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ПоКоду","{Код}")]
	public class ОтраслевыеСегментыПоМСФОНайтиПоКоду: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ПоНаименованию","{Наименование}")]
	public class ОтраслевыеСегментыПоМСФОНайтиПоНаименованию: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтраслевыеСегментыПоМСФОВыбратьПоСсылке: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтраслевыеСегментыПоМСФОВыбратьПоКоду: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтраслевыеСегментыПоМСФОВыбратьПоНаименованию: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОтраслевыеСегментыПоМСФОСтраницаПоСсылке: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОтраслевыеСегментыПоМСФОСтраницаПоКоду: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОтраслевыеСегментыПоМСФО/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОтраслевыеСегментыПоМСФОСтраницаПоНаименованию: V82.СправочникиСсылка.ОтраслевыеСегментыПоМСФО,IReturn<ОтраслевыеСегментыПоМСФОСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОтраслевыеСегментыПоМСФООтвет
	{
		public string Ответ {get;set;}
	}

	public class ОтраслевыеСегментыПоМСФОСервис : Service
	{
		
		public object Get(ОтраслевыеСегментыПоМСФОНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОтраслевыеСегментыПоМСФО.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОтраслевыеСегментыПоМСФООтвет() {Ответ = "ОтраслевыеСегментыПоМСФО c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ОтраслевыеСегментыПоМСФО.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОтраслевыеСегментыПоМСФОСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОтраслевыеСегментыПоМСФОЗапрос Запрос)
		{
			return new ОтраслевыеСегментыПоМСФООтвет {Ответ = "ОтраслевыеСегментыПоМСФО, "};
		}

		public object Post(ОтраслевыеСегментыПоМСФОЗапрос ЗапросОтраслевыеСегментыПоМСФО)
		{
			var Ссылка = (СправочникиСсылка.ОтраслевыеСегментыПоМСФО)ЗапросОтраслевыеСегментыПоМСФО;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}