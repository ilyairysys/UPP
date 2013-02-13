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
	public partial class ЦиклыОбмена:СправочникОбъект
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
		public string/*10*/ Код;
		public string/*150*/ Наименование;
		public V82.СправочникиСсылка.УчетныеЗаписиДокументооборота УчетнаяЗапись;//Учетная запись
		public V82.Перечисления/*Ссылка*/.ТипыЦикловОбмена Тип;
		public string/*(100)*/ Идентификатор;//Идентификатор цикла обмена
		public object Предмет;
		public V82.СправочникиСсылка.Организации Организация;
		public object ВнешняяОрганизация;//Внешняя организация
		public DateTime ДатаСоздания;//Дата создания
		public DateTime ДатаЗакрытия;//Дата закрытия
		public DateTime ДатаПоследнегоСообщения;//Дата последнего сообщения
		public object ВидОтчета;//Вид отчета
		public DateTime ДатаНачалаПериода;//Дата начала периода
		public DateTime ДатаОкончанияПериода;//Дата окончания периода
		public decimal/*(3)*/ ВидДокумента;//Вид документа
		public V82.Перечисления/*Ссылка*/.ВидыУслугПриИОН ВидУслуги;//Вид услуги
		public V82.Перечисления/*Ссылка*/.ФорматОтветаНаЗапросИОН ФорматОтвета;//Формат ответа
		public string/*(16)*/ Период;
		public V82.Перечисления/*Ссылка*/.ВидыЦикловОбмена Вид;
		public V82.Перечисления/*Ссылка*/.ФорматыДокументооборотаСФНС ФорматДокументооборота;//Формат документооборота
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
						Insert Into _Reference291(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld4228RRef
						,_Fld4229RRef
						,_Fld4230
						,_Fld4232RRef
						,_Fld4234
						,_Fld4235
						,_Fld4236
						,_Fld4238
						,_Fld4239
						,_Fld4240
						,_Fld4241RRef
						,_Fld4242RRef
						,_Fld4243
						,_Fld4244RRef
						,_Fld4245RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@УчетнаяЗапись
						,@Тип
						,@Идентификатор
						,@Организация
						,@ДатаСоздания
						,@ДатаЗакрытия
						,@ДатаПоследнегоСообщения
						,@ДатаНачалаПериода
						,@ДатаОкончанияПериода
						,@ВидДокумента
						,@ВидУслуги
						,@ФорматОтвета
						,@Период
						,@Вид
						,@ФорматДокументооборота)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference291
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld4228RRef	= @УчетнаяЗапись
						,_Fld4229RRef	= @Тип
						,_Fld4230	= @Идентификатор
						,_Fld4232RRef	= @Организация
						,_Fld4234	= @ДатаСоздания
						,_Fld4235	= @ДатаЗакрытия
						,_Fld4236	= @ДатаПоследнегоСообщения
						,_Fld4238	= @ДатаНачалаПериода
						,_Fld4239	= @ДатаОкончанияПериода
						,_Fld4240	= @ВидДокумента
						,_Fld4241RRef	= @ВидУслуги
						,_Fld4242RRef	= @ФорматОтвета
						,_Fld4243	= @Период
						,_Fld4244RRef	= @Вид
						,_Fld4245RRef	= @ФорматДокументооборота
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("УчетнаяЗапись", УчетнаяЗапись.Ссылка);
					Команда.Parameters.AddWithValue("Тип", Тип.Ключ());
					Команда.Parameters.AddWithValue("Идентификатор", Идентификатор);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("ДатаСоздания", ДатаСоздания);
					Команда.Parameters.AddWithValue("ДатаЗакрытия", ДатаЗакрытия);
					Команда.Parameters.AddWithValue("ДатаПоследнегоСообщения", ДатаПоследнегоСообщения);
					Команда.Parameters.AddWithValue("ДатаНачалаПериода", ДатаНачалаПериода);
					Команда.Parameters.AddWithValue("ДатаОкончанияПериода", ДатаОкончанияПериода);
					Команда.Parameters.AddWithValue("ВидДокумента", ВидДокумента);
					Команда.Parameters.AddWithValue("ВидУслуги", ВидУслуги.Ключ());
					Команда.Parameters.AddWithValue("ФорматОтвета", ФорматОтвета.Ключ());
					Команда.Parameters.AddWithValue("Период", Период);
					Команда.Parameters.AddWithValue("Вид", Вид.Ключ());
					Команда.Parameters.AddWithValue("ФорматДокументооборота", ФорматДокументооборота.Ключ());
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
					Команда.CommandText = @"Delete _Reference291
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