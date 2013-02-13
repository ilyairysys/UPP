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
	///(Упр)
	///</summary>
	public partial class ТипыЦенНоменклатурыКонтрагентов:СправочникОбъект
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
		public V82.СправочникиСсылка.Валюты ВалютаЦены;//Валюта цены по умолчанию
		///<summary>
		///Истина - цена включает НДС, ложь - не включает
		///</summary>
		public bool ЦенаВключаетНДС;//Цена включает НДС
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦеныНоменклатуры;//Тип цены номенклатуры
		public string/*(0)*/ ОписаниеТипаЦеныНоменклатурыКонтрагента;//Описание типа цены номенклатуры контрагента
		public string/*(0)*/ Комментарий;
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
						Insert Into _Reference270(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_OwnerIDRRef
						,_Code
						,_Description
						,_Fld3977RRef
						,_Fld3978
						,_Fld3979RRef
						,_Fld3980
						,_Fld3981)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Владелец
						,@Код
						,@Наименование
						,@ВалютаЦены
						,@ЦенаВключаетНДС
						,@ТипЦеныНоменклатуры
						,@ОписаниеТипаЦеныНоменклатурыКонтрагента
						,@Комментарий)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference270
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_OwnerIDRRef	= @Владелец
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3977RRef	= @ВалютаЦены
						,_Fld3978	= @ЦенаВключаетНДС
						,_Fld3979RRef	= @ТипЦеныНоменклатуры
						,_Fld3980	= @ОписаниеТипаЦеныНоменклатурыКонтрагента
						,_Fld3981	= @Комментарий
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Владелец", Владелец);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВалютаЦены", ВалютаЦены.Ссылка);
					Команда.Parameters.AddWithValue("ЦенаВключаетНДС", ЦенаВключаетНДС);
					Команда.Parameters.AddWithValue("ТипЦеныНоменклатуры", ТипЦеныНоменклатуры.Ссылка);
					Команда.Parameters.AddWithValue("ОписаниеТипаЦеныНоменклатурыКонтрагента", ОписаниеТипаЦеныНоменклатурыКонтрагента);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
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
					Команда.CommandText = @"Delete _Reference270
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура - обработчик события "ПередЗаписью" формы.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			/*// среди всех типов цен одного контрагента не может быть более одного,
*/
			/*// ссылающегося на данный тип цен компании
*/
			if(true/*НЕ ОбменДанными.Загрузка И ЗначениеЗаполнено(ТипЦеныНоменклатуры)*/)
			{
				//Отбор = Новый Структура("ТипЦеныНоменклатуры",ТипЦеныНоменклатуры);
				//Выборка = Справочники.ТипыЦенНоменклатурыКонтрагентов.Выбрать(,Владелец,Отбор,);
				while(true/*Выборка.Следующий()*/)
				{
					if(true/*Ссылка <> Выборка.Ссылка*/)
					{
						/*// такой тип цен уже встречался
*/
						/*Предупреждение("Тип цен номенклатуры "+Выборка.ТипЦеныНоменклатуры.Наименование+" уже использовался "
				              +"в типе цен номенклатуры контрагента "+Выборка.Наименование+"!");*/
						//Отказ = Истина;
					}
				}
				//;;
			}
		}
	}
}