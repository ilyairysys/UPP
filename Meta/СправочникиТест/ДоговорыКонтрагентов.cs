﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ДоговорыКонтрагентов: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника ДоговорыКонтрагентов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.ДоговорыКонтрагентов.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,50);//"Наименование " + НомерЭлемента;

				Объект.ВалютаВзаиморасчетов = V82.Справочники/*Менеджер*/.Валюты.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Валюты();
				Объект.ВедениеВзаиморасчетов = (V82.Перечисления/*Ссылка*/.ВедениеВзаиморасчетовПоДоговорам)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВедениеВзаиморасчетовПоДоговорам));
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ВидУсловийДоговора = (V82.Перечисления/*Ссылка*/.ВидыУсловийДоговоровВзаиморасчетов)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыУсловийДоговоровВзаиморасчетов));
				Объект.ДержатьРезервБезОплатыОграниченноеВремя = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДопустимаяСуммаЗадолженности = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.ДопустимоеЧислоДнейЗадолженности = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.Организация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Организации();
				Объект.КонтролироватьСуммуЗадолженности = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КонтролироватьЧислоДнейЗадолженности = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОбособленныйУчетТоваровПоЗаказамПокупателей = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПроцентКомиссионногоВознаграждения = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.СпособРасчетаКомиссионногоВознаграждения = (V82.Перечисления/*Ссылка*/.СпособыРасчетаКомиссионногоВознаграждения)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпособыРасчетаКомиссионногоВознаграждения));
				Объект.ПроцентПредоплаты = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.ВидДоговора = (V82.Перечисления/*Ссылка*/.ВидыДоговоровКонтрагентов)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыДоговоровКонтрагентов));
				Объект.ЧислоДнейРезерваБезОплаты = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.УчетАгентскогоНДС = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ВидАгентскогоДоговора = (V82.Перечисления/*Ссылка*/.ВидыАгентскихДоговоров)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыАгентскихДоговоров));
				Объект.РасчетыВУсловныхЕдиницах = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КонтролироватьДенежныеСредстваКомитента = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РеализацияНаЭкспорт = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Дата = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.Номер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,20);
				Объект.ВидВзаиморасчетов = V82.Справочники/*Менеджер*/.ВидыВзаиморасчетов.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ВидыВзаиморасчетов();
				Объект.ВестиПоДокументамРасчетовСКонтрагентом = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОсновнаяСтатьяДвиженияДенежныхСредств = V82.Справочники/*Менеджер*/.СтатьиДвиженияДенежныхСредств.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств();
				Объект.СрокДействия = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.НаименованиеДляСчетаФактурыНаАванс = V82.Справочники/*Менеджер*/.Номенклатура.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Номенклатура();
				Объект.ПорядокРегистрацииСчетовФактурНаАвансПоДоговору = (V82.Перечисления/*Ссылка*/.ПорядокРегистрацииСчетовФактурНаАванс)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ПорядокРегистрацииСчетовФактурНаАванс));
				Объект.НалоговыйАгентПоОплате = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.УстановленСрокОплатыДляРезервовПоСомнительнымДолгам = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.СрокОплатыДляРезервовПоСомнительнымДолгам = ГенераторСлучайныхЧисел.Следующий(99999);

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ДоговорыКонтрагентов.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника ДоговорыКонтрагентов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.ДоговорыКонтрагентов.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника ДоговорыКонтрагентов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ДоговорыКонтрагентов.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}
