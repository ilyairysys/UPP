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
	///(Общ)
	///</summary>
	public partial class ЕдиницыИзмерения:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ЕдиницыИзмерения НайтиПоКоду(string Код)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
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
		
		public static СправочникиВыборка.ЕдиницыИзмерения Выбрать()
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЕдиницыИзмерения СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2307RRef [ЕдиницаПоКлассификатору]
					,_Fld2308 [Вес]
					,_Fld2309 [Объем]
					,_Fld2310 [Коэффициент]
					,_Fld2311 [ПорогОкругления]
					,_Fld2312 [ПредупреждатьОНецелыхМестах]
					From _Reference97(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЕдиницыИзмерения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЕдиницыИзмерения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(6));
							Ссылка.Вес = Читалка.GetDecimal(7);
							Ссылка.Объем = Читалка.GetDecimal(8);
							Ссылка.Коэффициент = Читалка.GetDecimal(9);
							Ссылка.ПорогОкругления = Читалка.GetDecimal(10);
							Ссылка.ПредупреждатьОНецелыхМестах = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ЕдиницыИзмерения СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ЕдиницыИзмерения();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ЕдиницаПоКлассификатору = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			return Объект;
		}
	}
}