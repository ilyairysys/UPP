﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	public partial class СерверыДокументооборота:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*5*/ Код;
		public string/*150*/ Наименование;
		public string/*(255)*/ АдресЭлектроннойПочтыФНС;//Адрес электронной почты для документооборота с ФНС
		public decimal/*(5)*/ ДлительностьОжиданияСервера;//Длительность ожидания сервера
		public string/*(40)*/ Сертификат;
		public string/*(255)*/ АдресЭлектроннойПочтыПФР;//Адрес электронной почты для документооборота с ПФР
		public string/*(255)*/ АдресЭлектроннойПочтыФСГС;//Адрес электронной почты для документооборота с Росстатом
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference225(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3392
						,_Fld3393
						,_Fld3394
						,_Fld3395
						,_Fld3396)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@АдресЭлектроннойПочтыФНС
						,@ДлительностьОжиданияСервера
						,@Сертификат
						,@АдресЭлектроннойПочтыПФР
						,@АдресЭлектроннойПочтыФСГС)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference225
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3392	= @АдресЭлектроннойПочтыФНС
						,_Fld3393	= @ДлительностьОжиданияСервера
						,_Fld3394	= @Сертификат
						,_Fld3395	= @АдресЭлектроннойПочтыПФР
						,_Fld3396	= @АдресЭлектроннойПочтыФСГС
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("АдресЭлектроннойПочтыФНС", АдресЭлектроннойПочтыФНС);
					Команда.Parameters.AddWithValue("ДлительностьОжиданияСервера", ДлительностьОжиданияСервера);
					Команда.Parameters.AddWithValue("Сертификат", Сертификат);
					Команда.Parameters.AddWithValue("АдресЭлектроннойПочтыПФР", АдресЭлектроннойПочтыПФР);
					Команда.Parameters.AddWithValue("АдресЭлектроннойПочтыФСГС", АдресЭлектроннойПочтыФСГС);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference225
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			if(true/*КонтекстЭДО <> Неопределено*/)
			{
				//КонтекстЭДО.ПередЗаписьюОбъекта(ЭтотОбъект, Отказ);
			}
		}

		public void ПриЗаписи(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			if(true/*КонтекстЭДО <> Неопределено*/)
			{
				//КонтекстЭДО.ПриЗаписиОбъекта(ЭтотОбъект, Отказ);
			}
		}

		public void ОбработкаЗаполнения(/*СообщениеОснование*/)
		{
			if(true/*КонтекстЭДО <> Неопределено*/)
			{
				//КонтекстЭДО.ОбработкаЗаполненияОбъекта(ЭтотОбъект, СообщениеОснование);
			}
		}
	}
}