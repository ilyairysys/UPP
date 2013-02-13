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
	///<summary>
	///(Регл)
	///</summary>
	public partial class ВидыЕжегодныхОтпусков:СправочникОбъект
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
		public string/*9*/ Код;
		public string/*100*/ Наименование;
		public V82.Перечисления/*Ссылка*/.СпособыРасчетаОстаткаОтпуска СпособРасчетаОстаткаОтпуска;//Способ расчета остатка отпуска
		public decimal/*(2)*/ КоличествоДнейОтпускаВГод;//Количество дней отпуска в год
		public bool ПредоставлятьОтпускВсемСотрудникам;//Предоставлять отпуск всем сотрудникам
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
						Insert Into _Reference50(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld1937RRef
						,_Fld1938
						,_Fld1939)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@СпособРасчетаОстаткаОтпуска
						,@КоличествоДнейОтпускаВГод
						,@ПредоставлятьОтпускВсемСотрудникам)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference50
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1937RRef	= @СпособРасчетаОстаткаОтпуска
						,_Fld1938	= @КоличествоДнейОтпускаВГод
						,_Fld1939	= @ПредоставлятьОтпускВсемСотрудникам
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("СпособРасчетаОстаткаОтпуска", СпособРасчетаОстаткаОтпуска.Ключ());
					Команда.Parameters.AddWithValue("КоличествоДнейОтпускаВГод", КоличествоДнейОтпускаВГод);
					Команда.Parameters.AddWithValue("ПредоставлятьОтпускВсемСотрудникам", ПредоставлятьОтпускВсемСотрудникам);
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
					Команда.CommandText = @"Delete _Reference50
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}