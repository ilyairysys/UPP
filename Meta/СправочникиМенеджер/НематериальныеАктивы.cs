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
	public partial class НематериальныеАктивы:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НематериальныеАктивы НайтиПоКоду(string Код)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
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
		
		public static СправочникиВыборка.НематериальныеАктивы Выбрать()
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НематериальныеАктивы СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2898 [НаименованиеПолное]
					,_Fld2899RRef [ВидНМА]
					,_Fld2900RRef [АмортизационнаяГруппа]
					,_Fld2901 [ПрочиеСведения]
					,_Fld2902RRef [ВидОбъектаУчета]
					From _Reference161(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НематериальныеАктивы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НематериальныеАктивы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.НаименованиеПолное = Читалка.GetString(6);
							Ссылка.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ПрочиеСведения = Читалка.GetString(9);
							Ссылка.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НематериальныеАктивы СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НематериальныеАктивы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.НаименованиеПолное = "";
			Объект.ПрочиеСведения = "";
			Объект.ВидНМА = V82.Перечисления/*Ссылка*/.ВидыНМА.ПустаяСсылка;
			Объект.АмортизационнаяГруппа = V82.Перечисления/*Ссылка*/.АмортизационныеГруппы.ПустаяСсылка;
			Объект.ВидОбъектаУчета = V82.Перечисления/*Ссылка*/.ВидыОбъектовУчетаНМА.ПустаяСсылка;
			return Объект;
		}
	}
}