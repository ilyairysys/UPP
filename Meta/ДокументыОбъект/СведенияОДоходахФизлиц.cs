﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class СведенияОДоходахФизлиц:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		[DataMember]
		[ProtoMember(10)]
		public decimal/*(4)*/ НалоговыйПериод {get;set;}//Налоговый период
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public string/*(20)*/ КонтактныйТелефонОтветственного {get;set;}//Контактный телефон ответственного
		[DataMember]
		[ProtoMember(13)]
		public bool УдалитьДляПередачиВИМНС {get;set;}//Для передачи в ИФНС
		///<summary>
		///Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(15)]
		public string/*(100)*/ КраткийСоставДокумента {get;set;}//Краткий состав документа
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьОтветственного {get;set;}//Должность ответственного
		[DataMember]
		[ProtoMember(17)]
		public string/*(36)*/ ИдентификаторФайла {get;set;}//Идентификатор файла
		[DataMember]
		[ProtoMember(18)]
		public V82.Перечисления/*Ссылка*/.ПорядокФормированияСправкиОДоходахФизлица НазначениеСправки {get;set;}//Назначение справки
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document447(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld11369RRef
						,_Fld11370
						,_Fld11371RRef
						,_Fld11372
						,_Fld11373
						,_Fld11374
						,_Fld11375
						,_Fld11376RRef
						,_Fld11377
						,_Fld18841RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@Организация
						,@НалоговыйПериод
						,@Ответственный
						,@КонтактныйТелефонОтветственного
						,@УдалитьДляПередачиВИМНС
						,@Комментарий
						,@КраткийСоставДокумента
						,@ДолжностьОтветственного
						,@ИдентификаторФайла
						,@НазначениеСправки)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document447
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld11369RRef	= @Организация
						,_Fld11370	= @НалоговыйПериод
						,_Fld11371RRef	= @Ответственный
						,_Fld11372	= @КонтактныйТелефонОтветственного
						,_Fld11373	= @УдалитьДляПередачиВИМНС
						,_Fld11374	= @Комментарий
						,_Fld11375	= @КраткийСоставДокумента
						,_Fld11376RRef	= @ДолжностьОтветственного
						,_Fld11377	= @ИдентификаторФайла
						,_Fld18841RRef	= @НазначениеСправки
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("НалоговыйПериод", НалоговыйПериод);
					Команда.Parameters.AddWithValue("КонтактныйТелефонОтветственного", КонтактныйТелефонОтветственного);
					Команда.Parameters.AddWithValue("УдалитьДляПередачиВИМНС", УдалитьДляПередачиВИМНС);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("КраткийСоставДокумента", КраткийСоставДокумента);
					Команда.Parameters.AddWithValue("ИдентификаторФайла", ИдентификаторФайла);
					Команда.Parameters.AddWithValue("НазначениеСправки", НазначениеСправки.Ключ());
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
					Команда.CommandText = @"Delete _Document447
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}