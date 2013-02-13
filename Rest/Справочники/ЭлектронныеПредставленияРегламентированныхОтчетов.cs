﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//EHlektronnyePredstavleniyaReglamentirovannykhOtchetov
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов","")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовЗапрос: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовЗапрос>
	{
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ПоСсылке","{Ссылка}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоСсылке: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ПоКоду","{Код}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоКоду: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ПоНаименованию","{Наименование}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоНаименованию: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоСсылке: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоКоду: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоНаименованию: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоСсылке: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоКоду: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ЭлектронныеПредставленияРегламентированныхОтчетов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоНаименованию: V82.СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов,IReturn<ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ЭлектронныеПредставленияРегламентированныхОтчетовОтвет
	{
		public string Ответ {get;set;}
	}

	public class ЭлектронныеПредставленияРегламентированныхОтчетовСервис : Service
	{
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			string СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ЭлектронныеПредставленияРегламентированныхОтчетов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ЭлектронныеПредставленияРегламентированныхОтчетовОтвет() {Ответ = "ЭлектронныеПредставленияРегламентированныхОтчетов c кодом '" + Запрос.Код+"' не найдено."};
			}
			return Ссылка;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			return V82.Справочники.ЭлектронныеПредставленияРегламентированныхОтчетов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс);
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ЭлектронныеПредставленияРегламентированныхОтчетовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ЭлектронныеПредставленияРегламентированныхОтчетовЗапрос Запрос)
		{
			return new ЭлектронныеПредставленияРегламентированныхОтчетовОтвет {Ответ = "ЭлектронныеПредставленияРегламентированныхОтчетов, "};
		}

		public object Post(ЭлектронныеПредставленияРегламентированныхОтчетовЗапрос ЗапросЭлектронныеПредставленияРегламентированныхОтчетов)
		{
			var Ссылка = (СправочникиСсылка.ЭлектронныеПредставленияРегламентированныхОтчетов)ЗапросЭлектронныеПредставленияРегламентированныхОтчетов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}