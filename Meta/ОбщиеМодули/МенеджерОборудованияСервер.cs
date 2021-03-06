﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class МенеджерОборудованияСервер
	{
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция возвращает список подключенного в справочнике ПО

		public object ПолучитьСписокОборудования(/*ТипыПО = Неопределено, Идентификатор = Неопределено, РабочееМесто = Неопределено*/)
		{
			return null;
		}
		// Функция возвращает по идентификатору устройства его параметры

		public object ПолучитьПараметрыУстройства(/*Идентификатор*/)
		{
			return null;
		}
		// Процедура предназначена для сохранения параметров устройства
		//в реквизит Параметры типа хранилище значения в элементе справочника

		public object СохранитьПараметрыУстройства(/*Идентификатор, Параметры*/)
		{
			return null;
		}
		// Функция возвращает структуру с данными устройства
		//(со значениями реквизитов элемента справочника)

		public object ПолучитьДанныеУстройства(/*Идентификатор*/)
		{
			return null;
		}
		// Функция возвращает по идентификатору наименование драйвера устройства

		public object ПолучитьИмяДрайвераЭкземпляра(/*НаименованиеОбработчикаДрайвера*/)
		{
			//Результат = "";
			return null;
		}
		// Функция возвращает из переменной сеанса имя компьютера клиента

		public object ПолучитьРабочееМестоКлиента(/**/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			return null;
		}
		// Функция возвращает список рабочих мест, соответствующих указанному имени компьютера

		public object НайтиРабочиеМестаПоИД(/*ИдентификаторКлиента*/)
		{
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ
	|	РабочиеМеста.Ссылка
	|ИЗ
	|	Справочник.РабочиеМеста КАК РабочиеМеста
	|ГДЕ
	|	РабочиеМеста.Код = &Код
	|	И РабочиеМеста.ПометкаУдаления = ЛОЖЬ
	|");*/
			//Запрос.УстановитьПараметр("Код", ИдентификаторКлиента);
			//СписокКомпьютеров = Запрос.Выполнить().Выгрузить().ВыгрузитьКолонку("Ссылка");
			return null;
		}
		// Функция устанавливает в переменную сеанса имя компьютера клиента

		public void УстановитьРабочееМестоКлиента(/*РабочееМестоКлиента*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//ПараметрыСеанса.РабочееМестоКлиента = РабочееМестоКлиента;
			//ОбновитьПовторноИспользуемыеЗначения();
		}
		// Функция возвращает макет слип чека по наименованию макета
		//

		public object ПолучитьСлипЧек(/*ИмяМакета, ШиринаСлипЧека, Параметры, АвторизацияПИН = Ложь*/)
		{
			//Документ = Новый ТекстовыйДокумент();
			//СлипЧек  = "";
			//Макет    = ПолучитьОбщийМакет(ИмяМакета);
			//Область  = Макет.ПолучитьОбласть("Чек" + ШиринаСлипЧека + ?(АвторизацияПИН, "пин", ""));
			if(true/*Область <> Неопределено*/)
			{
				//Документ.Вывести(Область);
			}
			return null;
		}
		// Функция получает макет драйвера и сохраняет его во временное хранилище,
		// возвращая ссылку на временное хранилище

		public object ПолучитьМакетССервера(/*ИмяМакета*/)
		{
			//Ссылка = ПоместитьВоВременноеХранилище(ПолучитьОбщийМакет(ИмяМакета));
			return null;
		}
		// Функция возвращает значение константы
		//

		public object ПолучитьКонстанту(/*ИмяКонстанты*/)
		{
			//Константа = Константы[ИмяКонстанты].Получить();
			return null;
		}
		// Функция возвращает доступность сохранение данных пользователя
		//

		public object ПравоДоступаСохранениеДанныхПользователя(/**/)
		{
			return null;
		}
		// Функция возвращает имя перечисления из его метаданных
		//

		public object ПолучитьИмяТипаОборудования(/*ТипОборудования*/)
		{
			//Результат = Неопределено;
			//МтОбъект = ТипОборудования.Метаданные();
			//Индекс = Перечисления.ТипыПодключаемогоОборудования.Индекс(ТипОборудования);
			//Результат = МтОбъект.ЗначенияПеречисления[Индекс].Имя;
			return null;
		}
		// Функция возвращает созданное рабочее место клиента

		public object СоздатьРабочееМестоКлиента(/*Параметры*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//РабочееМесто = Справочники.РабочиеМеста.СоздатьЭлемент();
			//РабочееМесто.Код           = Параметры.ИдентификаторКлиента;
			//РабочееМесто.ИмяКомпьютера = Параметры.ИмяКомпьютера;
			//РабочееМесто.СетевойПорт   = Параметры.СетевойПорт;
			//МенеджерОборудованияКлиентСервер.ЗаполнитьНаименованиеРабочегоМеста(РабочееМесто, ПользователиИнформационнойБазы.ТекущийПользователь());
			//РабочееМесто.Записать();
			//УстановитьПривилегированныйРежим(Ложь);
			return null;
		}
		// СоздатьРабочееМестоКлиентаПоИД()
		// Процедура устанавливает значения параметров сеанса, относящихся к подключаемому оборудованию

		public void УстановитьПараметрыСеансаПодключаемогоОборудования(/*ИмяПараметра, УстановленныеПараметры*/)
		{
			if(true/*ИмяПараметра = "РабочееМестоКлиента"*/)
			{
				/*//Если с идентификатором клиента текущего сеанса связано одно рабочее место,
*/
				/*// то его сразу и запишем в параметры сеанса
*/
				//ТекущееРМ           = Справочники.РабочиеМеста.ПустаяСсылка();
				//СистемнаяИнформация = Новый СистемнаяИнформация();
				//СписокРМ = НайтиРабочиеМестаПоИД(ВРег(СистемнаяИнформация.ИдентификаторКлиента));
				if(true/*СписокРМ.Количество() = 0*/)
				{
					/*// Будет создано с клиента.
*/
				}
				//УстановитьРабочееМестоКлиента(ТекущееРМ);
				if(true/*ТипЗнч(УстановленныеПараметры) = Тип("Структура")*/)
				{
					//УстановленныеПараметры.Вставить("РабочееМестоКлиента");
				}
			}
		}
		// Функция возвращает набор пользовательских настроек,
		// связанных с механизмом подключаемого оборудования

		public object ПолучитьПользовательскиеНастройкиПодключаемогоОборудования(/**/)
		{
			//Настройки = Новый Структура();
			if(true/*НЕ ПравоДоступа("СохранениеДанныхПользователя", Метаданные)*/)
			{
			}
			//СписокНастроек = ХранилищеОбщихНастроек.ПолучитьСписок("ПользовательскиеНастройкиПодключаемогоОборудования");
			return null;
		}
		// Сохраняет пользовательские настройки подключаемого оборудования
		//

		public void СохранитьПользовательскиеНастройкиПодключаемогоОборудования(/*СписокНастроек*/)
		{
			if(true/*НЕ ПравоДоступа("СохранениеДанныхПользователя", Метаданные)*/)
			{
			}
			//ОбновитьПовторноИспользуемыеЗначения();
		}
		// Производит разложение данных дорожек магнитной карты по шаблонам
		// На входе:
		// ДанныеДорожек - массив строк. Значения полученные из дорожек.
		// ПараметрыДорожек - массив структур содержащих параметры настройки устройства
		//  * Использовать, булево - признак использования дорожки
		//  * НомерДорожки, число - порядковый номер дорожки 1-3
		//
		// На выходе:
		// Массив структур содержащих расшифрованные данные по всем подходящим шаблонам со ссылкой на них
		// * Массив - шаблоны
		//   * Структура - данные шаблона
		//     - Шаблон, СправочникСсылка.ШаблоныМагнитныхКарт
		//     - ДанныеДорожек, массив полей всех дорожек
		//       * Структура - данные поля
		//         - Поле
		//         - ЗначениеПоля

		public object РасшифроватьКодМагнитнойКарты(/*ДанныеДорожек, ПараметрыДорожек*/)
		{
			if(true/*ДанныеДорожек.Количество() = 0
		ИЛИ ПараметрыДорожек.Количество() = 0*/)
			{
				/*// нет данных
*/
			}
			//ДанныеОтбор = Новый Массив;
			//СчётчикДорожек = 0;
			/*// 1-ый этап. Ищем шаблоны совпадающие по длине кода
*/
			/*// а) При сравнении играют роль только доступные дорожки
*/
			/*// б) Необходимо чтобы хотя бы одна дорожка была доступной
*/
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	ШаблоныМагнитныхКарт.Ссылка,
	|	ШаблоныМагнитныхКарт.ДоступностьДорожки1,
	|	ШаблоныМагнитныхКарт.Префикс1,
	|	ШаблоныМагнитныхКарт.Суффикс1,
	|	ШаблоныМагнитныхКарт.ДлинаКода1,
	|	ШаблоныМагнитныхКарт.РазделительБлоков1,
	|	ШаблоныМагнитныхКарт.ДоступностьДорожки2,
	|	ШаблоныМагнитныхКарт.Префикс2,
	|	ШаблоныМагнитныхКарт.Суффикс2,
	|	ШаблоныМагнитныхКарт.ДлинаКода2,
	|	ШаблоныМагнитныхКарт.РазделительБлоков2,
	|	ШаблоныМагнитныхКарт.ДоступностьДорожки3,
	|	ШаблоныМагнитныхКарт.Префикс3,
	|	ШаблоныМагнитныхКарт.Суффикс3,
	|	ШаблоныМагнитныхКарт.ДлинаКода3,
	|	ШаблоныМагнитныхКарт.РазделительБлоков3
	|ИЗ
	|	Справочник.ШаблоныМагнитныхКарт КАК ШаблоныМагнитныхКарт
	|ГДЕ
	|	(ШаблоныМагнитныхКарт.ДоступностьДорожки1
	|			ИЛИ ШаблоныМагнитныхКарт.ДоступностьДорожки2
	|			ИЛИ ШаблоныМагнитныхКарт.ДоступностьДорожки3)
	|	И ВЫБОР
	|			КОГДА ШаблоныМагнитныхКарт.ДоступностьДорожки1
	|				ТОГДА ШаблоныМагнитныхКарт.ДлинаКода1 = &ДлинаКода1
	|			ИНАЧЕ ИСТИНА
	|		КОНЕЦ
	|	И ВЫБОР
	|			КОГДА ШаблоныМагнитныхКарт.ДоступностьДорожки2
	|				ТОГДА ШаблоныМагнитныхКарт.ДлинаКода2 = &ДлинаКода2
	|			ИНАЧЕ ИСТИНА
	|		КОНЕЦ
	|	И ВЫБОР
	|			КОГДА ШаблоныМагнитныхКарт.ДоступностьДорожки3
	|				ТОГДА ШаблоныМагнитныхКарт.ДлинаКода3 = &ДлинаКода3
	|			ИНАЧЕ ИСТИНА
	|		КОНЕЦ");*/
			//Запрос.УстановитьПараметр("ДлинаКода1", СтрДлина(ДанныеДорожек[0]));
			//Запрос.УстановитьПараметр("ДлинаКода2", СтрДлина(ДанныеДорожек[1]));
			//Запрос.УстановитьПараметр("ДлинаКода3", СтрДлина(ДанныеДорожек[2]));
			//Выборка = Запрос.Выполнить().Выбрать();
			//СписокШаблонов = Новый Массив;
			while(true/*Выборка.Следующий()*/)
			{
				/*// 2-ой этап - Пропускаем шаблоны не совпадающие по суффиксу, префиксу, разделителю.
*/
				if(true/*НЕ КодСоответствуетШаблонуМК(ДанныеДорожек, Выборка)*/)
				{
				}
				//ДанныеДорожки = Новый Массив;
				//Шаблон = Новый Структура("Шаблон, ДанныеДорожек", Выборка.Ссылка, ДанныеДорожки);
				//СписокШаблонов.Добавить(Шаблон);
			}
			if(true/*СписокШаблонов.Количество() = 0*/)
			{
			}
			return null;
		}
		// Определяет соответствует ли код карты шаблону
		// На входе:
		// ДанныеДорожек - Массив содержащий строки кода дорожки. Всего 3 Элемента.
		// ДанныеШаблона - структура содержащая данные шаблона:
		//	- Суффикс
		//	- Префикс
		//	- РазделительБлоков
		//	- ДлинаКода
		// На выходе:
		// Истина - код соответствует шаблону

		public object КодСоответствуетШаблонуМК(/*ДанныеДорожек, ДанныеШаблона*/)
		{
			return null;
		}
		// Возвращает список оборудования для которого необходима переустановка компоненты
		//

		public object ПолучитьСписокОборудованияДляПереустановки(/**/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//Список = Новый Массив;
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	ПодключаемоеОборудование.ИдентификаторУстройства,
	|	ПодключаемоеОборудование.ОбработчикДрайвера,
	|	ПодключаемоеОборудование.Ссылка
	|ИЗ
	|	Справочник.ПодключаемоеОборудование КАК ПодключаемоеОборудование
	|ГДЕ
	|	ПодключаемоеОборудование.ТребуетсяПереустановка");*/
			//Выборка = Запрос.Выполнить().Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
				/*Строка = Новый Структура("Ссылка, ИдентификаторУстройства, ОбработчикДрайвера",
			Выборка.Ссылка, Выборка.ИдентификаторУстройства, Выборка.ОбработчикДрайвера);*/
				//Список.Добавить(Строка);
			}
			return null;
		}
		// Устанавливает признак необходимости переустановки оборудования
		//

		public void УстановитьПризнакПереустановки(/*ПодключаемоеОборудованиеСсылка, Признак*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//СправочникОбъект = ПодключаемоеОборудованиеСсылка.ПолучитьОбъект();
			//СправочникОбъект.ТребуетсяПереустановка = Признак;
			//СправочникОбъект.Записать();
		}
		// Возвращает реквизит ОбработчикДрайвера по ссылке справочника ПодключаемоеОборудование
		//

		public object ПолучитьОбработчикДрайвераИзСсылки(/*ПодключаемоеОборудованиеСсылка*/)
		{
			return null;
		}
		// Возвращает реквизит ТребуетсяПереустановка по ссылке справочника ПодключаемоеОборудование
		//

		public object ПолучитьПризнакПереустановкиИзСсылки(/*ПодключаемоеОборудованиеСсылка*/)
		{
			return null;
		}
	}
}
