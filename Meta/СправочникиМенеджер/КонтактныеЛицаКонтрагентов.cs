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
	///<summary>
	///Контактные лица контрагентов
	///</summary>
	public partial class КонтактныеЛицаКонтрагентов:СправочникМенеджер
	{
		
		public static СправочникиСсылка.КонтактныеЛицаКонтрагентов НайтиПоКоду(string Код)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
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
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов Выбрать()
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛицаКонтрагентов СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2458 [Должность]
					,_Fld2459 [Комментарий]
					,_Fld2460RRef [КонтактноеЛицо]
					,_Fld2461RRef [РольКонтактногоЛица]
					From _Reference129(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛицаКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛицаКонтрагентов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Должность = Читалка.GetString(6);
							Ссылка.Комментарий = Читалка.GetString(7);
							//Ссылка.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица((byte[])Читалка.GetValue(8));
							//Ссылка.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.КонтактныеЛицаКонтрагентов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.КонтактныеЛицаКонтрагентов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Должность = "";
			Объект.Комментарий = "";
			Объект.КонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛица();
			Объект.РольКонтактногоЛица = new V82.СправочникиСсылка.РолиКонтактныхЛиц();
			return Объект;
		}
	}
}