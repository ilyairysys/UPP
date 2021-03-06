﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class УдалитьКорректировочныйСчетФактураПолученный:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("1a0dda0d-f30a-4b13-9232-112e47425105");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012028.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		public V82.ДокументыСсылка.СчетФактураПолученный СчетФактура {get;set;}//Счет-фактура
		public string/*(30)*/ НомерВходящегоДокумента {get;set;}//Номер входящего документа
		public DateTime ДатаВходящегоДокумента {get;set;}//Дата входящего документа
		public string/*(250)*/ НаименованиеПродавца {get;set;}//Наименование продавца
		public string/*(12)*/ ИННПродавца {get;set;}//ИНН продавца
		public string/*(9)*/ КПППродавца {get;set;}//КПП продавца
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента {get;set;}//Валюта документа
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		public decimal/*(15.2)*/ РазницаСНДСКУменьшению {get;set;}//Разница с НДС к уменьшению
		public decimal/*(15.2)*/ РазницаСНДСКДоплате {get;set;}//Разница с НДС к доплате
		public decimal/*(15.2)*/ РазницаНДСКУменьшению {get;set;}//Разница НДС к уменьшению
		public decimal/*(15.2)*/ РазницаНДСКДоплате {get;set;}//Разница НДС к доплате
		public bool РучнаяКорректировка {get;set;}//Ручная корректировка
		
		public УдалитьКорректировочныйСчетФактураПолученный()
		{
		}
		
		public УдалитьКорректировочныйСчетФактураПолученный(byte[] УникальныйИдентификатор)
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
					,_Number [Номер]
					,_Fld25673RRef [Организация]
					,_Fld25674RRef [Контрагент]
					,_Fld25675RRef [ДоговорКонтрагента]
					,_Fld25676RRef [СчетФактура]
					,_Fld25677 [НомерВходящегоДокумента]
					,_Fld25678 [ДатаВходящегоДокумента]
					,_Fld25679 [НаименованиеПродавца]
					,_Fld25680 [ИННПродавца]
					,_Fld25681 [КПППродавца]
					,_Fld25682RRef [ВалютаДокумента]
					,_Fld25683RRef [Ответственный]
					,_Fld25684 [Комментарий]
					,_Fld25685 [РазницаСНДСКУменьшению]
					,_Fld25686 [РазницаСНДСКДоплате]
					,_Fld25687 [РазницаНДСКУменьшению]
					,_Fld25688 [РазницаНДСКДоплате]
					,_Fld25689 [РучнаяКорректировка]
					From _Document23178(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Номер = Читалка.GetString(3);
							СчетФактура = new V82.ДокументыСсылка.СчетФактураПолученный((byte[])Читалка.GetValue(7));
							НомерВходящегоДокумента = Читалка.GetString(8);
							ДатаВходящегоДокумента = Читалка.GetDateTime(9);
							НаименованиеПродавца = Читалка.GetString(10);
							ИННПродавца = Читалка.GetString(11);
							КПППродавца = Читалка.GetString(12);
							Комментарий = Читалка.GetString(15);
							РазницаСНДСКУменьшению = Читалка.GetDecimal(16);
							РазницаСНДСКДоплате = Читалка.GetDecimal(17);
							РазницаНДСКУменьшению = Читалка.GetDecimal(18);
							РазницаНДСКДоплате = Читалка.GetDecimal(19);
							РучнаяКорректировка = ((byte[])Читалка.GetValue(20))[0]==1;
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.ДокументыОбъект.УдалитьКорректировочныйСчетФактураПолученный  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.УдалитьКорректировочныйСчетФактураПолученный();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.Контрагент = Контрагент;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.СчетФактура = СчетФактура;
			Объект.НомерВходящегоДокумента = НомерВходящегоДокумента;
			Объект.ДатаВходящегоДокумента = ДатаВходящегоДокумента;
			Объект.НаименованиеПродавца = НаименованиеПродавца;
			Объект.ИННПродавца = ИННПродавца;
			Объект.КПППродавца = КПППродавца;
			Объект.ВалютаДокумента = ВалютаДокумента;
			Объект.Ответственный = Ответственный;
			Объект.Комментарий = Комментарий;
			Объект.РазницаСНДСКУменьшению = РазницаСНДСКУменьшению;
			Объект.РазницаСНДСКДоплате = РазницаСНДСКДоплате;
			Объект.РазницаНДСКУменьшению = РазницаНДСКУменьшению;
			Объект.РазницаНДСКДоплате = РазницаНДСКДоплате;
			Объект.РучнаяКорректировка = РучнаяКорректировка;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.УдалитьКорректировочныйСчетФактураПолученный ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.УдалитьКорректировочныйСчетФактураПолученный)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.УдалитьКорректировочныйСчетФактураПолученный(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}