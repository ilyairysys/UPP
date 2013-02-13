﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ЦиклыОбмена:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ЦиклыОбмена НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена ВыбратьПоКоду(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена СтраницаПоКоду(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЦиклыОбмена СтраницаПоНаименованию(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld4228RRef [УчетнаяЗапись]
					,_Fld4229RRef [Тип]
					,_Fld4230 [Идентификатор]
					,_Fld4231_TYPE [Предмет_Тип],_Fld4231_RRRef [Предмет],_Fld4231_RTRef [Предмет_Вид]
					,_Fld4232RRef [Организация]
					,_Fld4233_TYPE [ВнешняяОрганизация_Тип],_Fld4233_RRRef [ВнешняяОрганизация],_Fld4233_RTRef [ВнешняяОрганизация_Вид]
					,_Fld4234 [ДатаСоздания]
					,_Fld4235 [ДатаЗакрытия]
					,_Fld4236 [ДатаПоследнегоСообщения]
					,_Fld4237_TYPE [ВидОтчета_Тип],_Fld4237_RRRef [ВидОтчета],_Fld4237_RTRef [ВидОтчета_Вид]
					,_Fld4238 [ДатаНачалаПериода]
					,_Fld4239 [ДатаОкончанияПериода]
					,_Fld4240 [ВидДокумента]
					,_Fld4241RRef [ВидУслуги]
					,_Fld4242RRef [ФорматОтвета]
					,_Fld4243 [Период]
					,_Fld4244RRef [Вид]
					,_Fld4245RRef [ФорматДокументооборота]
					From _Reference291(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЦиклыОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЦиклыОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота((byte[])Читалка.GetValue(6));
							Ссылка.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Идентификатор = Читалка.GetString(8);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(12));
							Ссылка.ДатаСоздания = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Ссылка.ДатаПоследнегоСообщения = Читалка.GetDateTime(18);
							Ссылка.ДатаНачалаПериода = Читалка.GetDateTime(22);
							Ссылка.ДатаОкончанияПериода = Читалка.GetDateTime(23);
							Ссылка.ВидДокумента = Читалка.GetDecimal(24);
							Ссылка.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(25));
							Ссылка.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(26));
							Ссылка.Период = Читалка.GetString(27);
							Ссылка.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка.Получить((byte[])Читалка.GetValue(28));
							Ссылка.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ЦиклыОбмена СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ЦиклыОбмена();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Идентификатор = "";
			Объект.Период = "";
			Объект.УчетнаяЗапись = new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота();
			Объект.Тип = V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.ВидУслуги = V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН.ПустаяСсылка;
			Объект.ФорматОтвета = V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН.ПустаяСсылка;
			Объект.Вид = V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена.ПустаяСсылка;
			Объект.ФорматДокументооборота = V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС.ПустаяСсылка;
			return Объект;
		}
	}
}