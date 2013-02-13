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
	///(Общ)
	///</summary>
	public partial class ДоговорыКонтрагентов:СправочникОбъект
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
		public string/*50*/ Наименование;
		///<summary>
		///(Общ) Определяет валюту взаиморасчетов по договору, не может меняться, если по договору проведен хотя бы один документ
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаВзаиморасчетов;//Валюта взаиморасчетов
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВедениеВзаиморасчетовПоДоговорам ВедениеВзаиморасчетов;//Ведение взаиморасчетов
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Упр) 
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыУсловийДоговоровВзаиморасчетов ВидУсловийДоговора;//Вид условий договора
		///<summary>
		///(Упр) Держать резерв без оплаты ограниченное/неограниченное время
		///</summary>
		public bool ДержатьРезервБезОплатыОграниченноеВремя;//Держать резерв без оплаты ограниченное время
		///<summary>
		///(Упр) 
		///</summary>
		public decimal/*(15.2)*/ ДопустимаяСуммаЗадолженности;//Допустимая сумма дебиторской задолженности
		///<summary>
		///(Упр) 
		///</summary>
		public decimal/*(10)*/ ДопустимоеЧислоДнейЗадолженности;//Допустимое число дней дебиторской задолженности
		///<summary>
		///(Общ) 
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Упр) 
		///</summary>
		public bool КонтролироватьСуммуЗадолженности;//Контролировать сумму дебиторской задолженности
		///<summary>
		///(Упр) 
		///</summary>
		public bool КонтролироватьЧислоДнейЗадолженности;//Контролировать число дней дебиторской задолженности
		///<summary>
		///(Общ) Обособленный партионный учет Товаров по заказам покупателей
		///</summary>
		public bool ОбособленныйУчетТоваровПоЗаказамПокупателей;//Обособленный учет Товаров по заказам покупателей
		///<summary>
		///(Общ) 
		///</summary>
		public decimal/*(5.2)*/ ПроцентКомиссионногоВознаграждения;//Процент комиссионного вознаграждения
		///<summary>
		///(Общ) 
		///</summary>
		public V82.Перечисления/*Ссылка*/.СпособыРасчетаКомиссионногоВознаграждения СпособРасчетаКомиссионногоВознаграждения;//Способ расчета комиссионного вознаграждения
		///<summary>
		///(Упр) 
		///</summary>
		public decimal/*(5.2)*/ ПроцентПредоплаты;//Процент предоплаты
		///<summary>
		///(Общ) Тип цен по умолчанию для оформления покупок по данному договору
		///</summary>
		public object ТипЦен;//Тип цен
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыДоговоровКонтрагентов ВидДоговора;//Вид договора
		///<summary>
		///(Упр) Если 0, то неограничено
		///</summary>
		public decimal/*(10)*/ ЧислоДнейРезерваБезОплаты;//Число дней резерва без оплаты
		///<summary>
		///Признак того что в данном договоре организация выступает в качестве налогового агента
		///</summary>
		public bool УчетАгентскогоНДС;//Учет агентского НДС
		///<summary>
		///Разновидность договора с обязанностью оплаты организацией НДС в качестве налогового агента 
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыАгентскихДоговоров ВидАгентскогоДоговора;//Вид агентского договора
		///<summary>
		///(Регл)
		///</summary>
		public bool РасчетыВУсловныхЕдиницах;//Расчеты в условных единицах
		public bool КонтролироватьДенежныеСредстваКомитента;//Контролировать денежные средства комитента
		public bool РеализацияНаЭкспорт;//Реализация на экспорт
		public DateTime Дата;
		public string/*(20)*/ Номер;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ВидыВзаиморасчетов ВидВзаиморасчетов;//Вид взаиморасчетов
		public bool ВестиПоДокументамРасчетовСКонтрагентом;//Вести по документам расчетов с контрагентом
		public object ОсновнойПроект;//Основной проект
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств ОсновнаяСтатьяДвиженияДенежныхСредств;//Основная статья движения денежных средств
		public DateTime СрокДействия;//Срок действия договора
		public V82.СправочникиСсылка.Номенклатура НаименованиеДляСчетаФактурыНаАванс;//Обобщенное наименование товаров для счета-фактуры на аванс
		public V82.Перечисления/*Ссылка*/.ПорядокРегистрацииСчетовФактурНаАванс ПорядокРегистрацииСчетовФактурНаАвансПоДоговору;//Порядок регистрации счетов-фактур на аванс по договору
		public bool НалоговыйАгентПоОплате;//НДС при исполнении обязанностей налогового агента начисляется по оплате
		///<summary>
		///Если не установлен, для контроля просроченной задолженности используется срок из учетной политики организации
		///</summary>
		public bool УстановленСрокОплатыДляРезервовПоСомнительнымДолгам;//Установлен срок оплаты для резервов по сомнительным долгам
		///<summary>
		///Срок в днях, после которого долг считается просроченным
		///</summary>
		public decimal/*(5)*/ СрокОплатыДляРезервовПоСомнительнымДолгам;//Срок оплаты для резервов по сомнительным долгам
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
						Insert Into _Reference86(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_OwnerIDRRef
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld2200RRef
						,_Fld2201RRef
						,_Fld2202
						,_Fld2203RRef
						,_Fld2204
						,_Fld2205
						,_Fld2206
						,_Fld2207RRef
						,_Fld2208
						,_Fld2209
						,_Fld2210
						,_Fld2211
						,_Fld2212RRef
						,_Fld2213
						,_Fld2215RRef
						,_Fld2216
						,_Fld2217
						,_Fld2218RRef
						,_Fld2219
						,_Fld2220
						,_Fld2221
						,_Fld2222
						,_Fld2223
						,_Fld2224RRef
						,_Fld2225
						,_Fld2227RRef
						,_Fld2228
						,_Fld2229RRef
						,_Fld2230RRef
						,_Fld2231
						,_Fld2232
						,_Fld2233)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Владелец
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@ВалютаВзаиморасчетов
						,@ВедениеВзаиморасчетов
						,@Комментарий
						,@ВидУсловийДоговора
						,@ДержатьРезервБезОплатыОграниченноеВремя
						,@ДопустимаяСуммаЗадолженности
						,@ДопустимоеЧислоДнейЗадолженности
						,@Организация
						,@КонтролироватьСуммуЗадолженности
						,@КонтролироватьЧислоДнейЗадолженности
						,@ОбособленныйУчетТоваровПоЗаказамПокупателей
						,@ПроцентКомиссионногоВознаграждения
						,@СпособРасчетаКомиссионногоВознаграждения
						,@ПроцентПредоплаты
						,@ВидДоговора
						,@ЧислоДнейРезерваБезОплаты
						,@УчетАгентскогоНДС
						,@ВидАгентскогоДоговора
						,@РасчетыВУсловныхЕдиницах
						,@КонтролироватьДенежныеСредстваКомитента
						,@РеализацияНаЭкспорт
						,@Дата
						,@Номер
						,@ВидВзаиморасчетов
						,@ВестиПоДокументамРасчетовСКонтрагентом
						,@ОсновнаяСтатьяДвиженияДенежныхСредств
						,@СрокДействия
						,@НаименованиеДляСчетаФактурыНаАванс
						,@ПорядокРегистрацииСчетовФактурНаАвансПоДоговору
						,@НалоговыйАгентПоОплате
						,@УстановленСрокОплатыДляРезервовПоСомнительнымДолгам
						,@СрокОплатыДляРезервовПоСомнительнымДолгам)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference86
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_OwnerIDRRef	= @Владелец
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2200RRef	= @ВалютаВзаиморасчетов
						,_Fld2201RRef	= @ВедениеВзаиморасчетов
						,_Fld2202	= @Комментарий
						,_Fld2203RRef	= @ВидУсловийДоговора
						,_Fld2204	= @ДержатьРезервБезОплатыОграниченноеВремя
						,_Fld2205	= @ДопустимаяСуммаЗадолженности
						,_Fld2206	= @ДопустимоеЧислоДнейЗадолженности
						,_Fld2207RRef	= @Организация
						,_Fld2208	= @КонтролироватьСуммуЗадолженности
						,_Fld2209	= @КонтролироватьЧислоДнейЗадолженности
						,_Fld2210	= @ОбособленныйУчетТоваровПоЗаказамПокупателей
						,_Fld2211	= @ПроцентКомиссионногоВознаграждения
						,_Fld2212RRef	= @СпособРасчетаКомиссионногоВознаграждения
						,_Fld2213	= @ПроцентПредоплаты
						,_Fld2215RRef	= @ВидДоговора
						,_Fld2216	= @ЧислоДнейРезерваБезОплаты
						,_Fld2217	= @УчетАгентскогоНДС
						,_Fld2218RRef	= @ВидАгентскогоДоговора
						,_Fld2219	= @РасчетыВУсловныхЕдиницах
						,_Fld2220	= @КонтролироватьДенежныеСредстваКомитента
						,_Fld2221	= @РеализацияНаЭкспорт
						,_Fld2222	= @Дата
						,_Fld2223	= @Номер
						,_Fld2224RRef	= @ВидВзаиморасчетов
						,_Fld2225	= @ВестиПоДокументамРасчетовСКонтрагентом
						,_Fld2227RRef	= @ОсновнаяСтатьяДвиженияДенежныхСредств
						,_Fld2228	= @СрокДействия
						,_Fld2229RRef	= @НаименованиеДляСчетаФактурыНаАванс
						,_Fld2230RRef	= @ПорядокРегистрацииСчетовФактурНаАвансПоДоговору
						,_Fld2231	= @НалоговыйАгентПоОплате
						,_Fld2232	= @УстановленСрокОплатыДляРезервовПоСомнительнымДолгам
						,_Fld2233	= @СрокОплатыДляРезервовПоСомнительнымДолгам
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Владелец", Владелец);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВалютаВзаиморасчетов", ВалютаВзаиморасчетов.Ссылка);
					Команда.Parameters.AddWithValue("ВедениеВзаиморасчетов", ВедениеВзаиморасчетов.Ключ());
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ВидУсловийДоговора", ВидУсловийДоговора.Ключ());
					Команда.Parameters.AddWithValue("ДержатьРезервБезОплатыОграниченноеВремя", ДержатьРезервБезОплатыОграниченноеВремя);
					Команда.Parameters.AddWithValue("ДопустимаяСуммаЗадолженности", ДопустимаяСуммаЗадолженности);
					Команда.Parameters.AddWithValue("ДопустимоеЧислоДнейЗадолженности", ДопустимоеЧислоДнейЗадолженности);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("КонтролироватьСуммуЗадолженности", КонтролироватьСуммуЗадолженности);
					Команда.Parameters.AddWithValue("КонтролироватьЧислоДнейЗадолженности", КонтролироватьЧислоДнейЗадолженности);
					Команда.Parameters.AddWithValue("ОбособленныйУчетТоваровПоЗаказамПокупателей", ОбособленныйУчетТоваровПоЗаказамПокупателей);
					Команда.Parameters.AddWithValue("ПроцентКомиссионногоВознаграждения", ПроцентКомиссионногоВознаграждения);
					Команда.Parameters.AddWithValue("СпособРасчетаКомиссионногоВознаграждения", СпособРасчетаКомиссионногоВознаграждения.Ключ());
					Команда.Parameters.AddWithValue("ПроцентПредоплаты", ПроцентПредоплаты);
					Команда.Parameters.AddWithValue("ВидДоговора", ВидДоговора.Ключ());
					Команда.Parameters.AddWithValue("ЧислоДнейРезерваБезОплаты", ЧислоДнейРезерваБезОплаты);
					Команда.Parameters.AddWithValue("УчетАгентскогоНДС", УчетАгентскогоНДС);
					Команда.Parameters.AddWithValue("ВидАгентскогоДоговора", ВидАгентскогоДоговора.Ключ());
					Команда.Parameters.AddWithValue("РасчетыВУсловныхЕдиницах", РасчетыВУсловныхЕдиницах);
					Команда.Parameters.AddWithValue("КонтролироватьДенежныеСредстваКомитента", КонтролироватьДенежныеСредстваКомитента);
					Команда.Parameters.AddWithValue("РеализацияНаЭкспорт", РеализацияНаЭкспорт);
					Команда.Parameters.AddWithValue("Дата", Дата);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ВидВзаиморасчетов", ВидВзаиморасчетов.Ссылка);
					Команда.Parameters.AddWithValue("ВестиПоДокументамРасчетовСКонтрагентом", ВестиПоДокументамРасчетовСКонтрагентом);
					Команда.Parameters.AddWithValue("ОсновнаяСтатьяДвиженияДенежныхСредств", ОсновнаяСтатьяДвиженияДенежныхСредств.Ссылка);
					Команда.Parameters.AddWithValue("СрокДействия", СрокДействия);
					Команда.Parameters.AddWithValue("НаименованиеДляСчетаФактурыНаАванс", НаименованиеДляСчетаФактурыНаАванс.Ссылка);
					Команда.Parameters.AddWithValue("ПорядокРегистрацииСчетовФактурНаАвансПоДоговору", ПорядокРегистрацииСчетовФактурНаАвансПоДоговору.Ключ());
					Команда.Parameters.AddWithValue("НалоговыйАгентПоОплате", НалоговыйАгентПоОплате);
					Команда.Parameters.AddWithValue("УстановленСрокОплатыДляРезервовПоСомнительнымДолгам", УстановленСрокОплатыДляРезервовПоСомнительнымДолгам);
					Команда.Parameters.AddWithValue("СрокОплатыДляРезервовПоСомнительнымДолгам", СрокОплатыДляРезервовПоСомнительнымДолгам);
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
					Команда.CommandText = @"Delete _Reference86
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ЭКСПОРТИРУЕМЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция проверяет, существуют ли ссылки на договор в движениях регистров накопления.
		// Если есть - нельзя менять:
		//  - Валюту взаиморасчетов
		//  - Ведение взаиморасчетов.
		//
		// Параметры:
		//  Нет.
		//
		// Возвращаемое значение:
		//  Истина - если есть движения, Ложь - если нет.
		//

		public object СуществуютСсылки(/**/)
		{
			return null;
		}
		//  СуществуютСсылки()
		////////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура вызывается перед записью элемента справочника.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			/*// Проверим можно ли изменять реквизиты договора.
*/
			/*// Проверка осуществляется только если записывается уже существующий договор
*/
			if(true/*НЕ ОбменДанными.Загрузка И НЕ ЭтоНовый()*/)
			{
				if(true/*ЭтоГруппа*/)
				{
					/*// Для группы владельца менять нельзя
*/
					if(true/*Владелец <> Ссылка.Владелец*/)
					{
						//Сообщить("Нельзя изменять контрагента для группы договоров.", СтатусСообщения.Важное);
						//Отказ = Истина;
					}
				}
			}
			/*// Проверим заполнение и очистим неиспользуемые реквизиты элемента договора.
*/
			if(true/*Не ЭтоГруппа*/)
			{
				/*// Проверим, заполнена ли валюта.
*/
				if(true/*НЕ ОбменДанными.Загрузка И НЕ ЗначениеЗаполнено(ВалютаВзаиморасчетов)*/)
				{
					//Сообщить("Не указана валюта договора.", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				/*// Проверим, заполнена ли организация.
*/
				if(true/*НЕ ОбменДанными.Загрузка И НЕ ЗначениеЗаполнено(Организация)*/)
				{
					//Сообщить("Не указана организация, от которой заключен договор.", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				/*// Проверим, заполнен ли способ ведения взаиморасчетов.
*/
				if(true/*НЕ ОбменДанными.Загрузка И НЕ ЗначениеЗаполнено(ВедениеВзаиморасчетов)*/)
				{
					//Сообщить("Не указан способ ведения взаиморасчетов по договору.", СтатусСообщения.Важное);
					//Отказ = Истина;
				}
				/*// Проверим, заполнен ли вид договора.
*/
				if(true/*НЕ ОбменДанными.Загрузка*/)
				{
					if(true/*НЕ ЗначениеЗаполнено(ВидДоговора)*/)
					{
						//Сообщить("Не указан вид договора.", СтатусСообщения.Важное);
						//Отказ = Истина;
					}
				}
			}
		}
		// ПередЗаписью()

		public void ОбработкаЗаполнения(/*ДанныеЗаполнения, СтандартнаяОбработка*/)
		{
			if(true/*ЭтоГруппа*/)
			{
			}
			//Контрагент = Владелец;
			if(true/*ТипЗнч(ДанныеЗаполнения) = Тип("Структура") И ДанныеЗаполнения.Свойство("Владелец")*/)
			{
				//Контрагент = ДанныеЗаполнения.Владелец;
			}
			if(true/*НЕ ЗначениеЗаполнено(ВидДоговора)*/)
			{
				if(true/*НЕ ЗначениеЗаполнено(Контрагент)*/)
				{
					//ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.Прочее;
				}
			}
			if(true/*ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.Прочее*/)
			{
				//ВедениеВзаиморасчетов = Перечисления.ВедениеВзаиморасчетовПоДоговорам.ПоДоговоруВЦелом;
			}
			if(true/*Контрагент.НеЯвляетсяРезидентом И ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.СПокупателем*/)
			{
				//РеализацияНаЭкспорт = Истина;
			}
			if(true/*НЕ ЗначениеЗаполнено(ВалютаВзаиморасчетов)*/)
			{
				//ВалютаВзаиморасчетов = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнаяВалютаВзаиморасчетов");
				if(true/*НЕ ЗначениеЗаполнено(ВалютаВзаиморасчетов)*/)
				{
					//ВалютаВзаиморасчетов = Константы.ВалютаУправленческогоУчета.Получить();
				}
			}
			if(true/*НЕ ЗначениеЗаполнено(Организация)*/)
			{
				if(true/*НЕ (ТипЗнч(ДанныеЗаполнения) = Тип("Структура") И ДанныеЗаполнения.Свойство("Организация"))*/)
				{
					//Организация = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнаяОрганизация");
				}
			}
			if(true/*НЕ ЗначениеЗаполнено(ВидУсловийДоговора)*/)
			{
				//ВидУсловийДоговора = Перечисления.ВидыУсловийДоговоровВзаиморасчетов.БезДополнительныхУсловий;
			}
			if(true/*ВидДоговора <> Перечисления.ВидыДоговоровКонтрагентов.Прочее*/)
			{
				//ВестиПоДокументамРасчетовСКонтрагентом = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновныеРасчетыПоДокументамСКонтрагентами");
			}
			if(true/*(ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.СПоставщиком
	 ИЛИ  ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.СПокупателем)
	   И ВалютаВзаиморасчетов <> Константы.ВалютаРегламентированногоУчета.Получить()*/)
			{
				//РасчетыВУсловныхЕдиницах = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновныеРасчетыПоДоговоруВУсловныхЕдиницах");
			}
			if(true/*ВидДоговора = Перечисления.ВидыДоговоровКонтрагентов.СПокупателем*/)
			{
				//ПроцентПредоплаты = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнойРазмерПредоплатыПоЗаказуПокупателя");
			}
			if(true/*ВедениеВзаиморасчетов = Перечисления.ВедениеВзаиморасчетовПоДоговорам.ПоДоговоруВЦелом
	 ИЛИ ВедениеВзаиморасчетов = Перечисления.ВедениеВзаиморасчетовПоДоговорам.ПоЗаказам*/)
			{
				//ОбособленныйУчетТоваровПоЗаказамПокупателей = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОсновнойОбособленныйУчетТоваровПоЗаказамПокупателей");
			}
		}
	}
}