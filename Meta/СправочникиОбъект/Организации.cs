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
	public partial class Организации:СправочникОбъект
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
		///(Общ)
		///</summary>
		public string/*(3)*/ Префикс;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИНН;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПП;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(14)*/ РегистрационныйНомерПФР;//Регистрационный номер ПФР
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации ГоловнаяОрганизация;//Головная организация
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НаименованиеПолное;//Полное наименование
		///<summary>
		///(Регл)
		///</summary>
		public string/*(10)*/ КодПоОКПО;//Код по ОКПО
		///<summary>
		///(Регл)
		///</summary>
		public string/*(11)*/ КодПоОКАТО;//Код по ОКАТО
		///<summary>
		///(Регл)
		///</summary>
		public string/*(4)*/ КодИМНС;//Код ИФНС
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(5.2)*/ РайонныйКоэффициент;//Районный коэффициент
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ЮрФизЛицо ЮрФизЛицо;//Юр. / физ. лицо
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ТерриториальныеУсловия ТерриториальныеУсловияПФР;//Территориальные условия ПФР
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета ОсновнойБанковскийСчет;//Основной банковский счет
		public V82.Перечисления/*Ссылка*/.ВидыСтавокЕСНиПФР ВидСтавокЕСНиПФР;//Вид ставок ЕСН и ПФР
		public string/*(150)*/ НаименованиеПлательщикаПриПеречисленииНалогов;//Наименование плательщика при перечислении в бюджет
		public bool ИностраннаяОрганизация;//Иностранная организация
		public DateTime ДатаРегистрации;//Дата государственной регистрации
		public string/*(2)*/ КодОКОПФ;//Код ОКОПФ
		public string/*(254)*/ НаименованиеОКОПФ;//Наименование ОКОПФ
		public string/*(2)*/ КодОКФС;//Код ОКФС
		public string/*(254)*/ НаименованиеОКФС;//Наименование ОКФС
		public string/*(25)*/ СвидетельствоСерияНомер;//Серия и номер свидетельства о постановке на учет
		public DateTime СвидетельствоДатаВыдачи;//Дата выдачи свидетельства о постановке на учет
		public string/*(254)*/ СвидетельствоНаименованиеОргана;//Наименование налогового органа, выдавшего свидетельство
		public string/*(4)*/ СвидетельствоКодОргана;//Код налогового органа, выдавшего свидетельство
		///<summary>
		///Заполняется в случае, если организация не российская
		///</summary>
		public V82.СправочникиСсылка.КлассификаторСтранМира СтранаРегистрации;//Страна регистрации
		public V82.СправочникиСсылка.КлассификаторСтранМира СтранаПостоянногоМестонахождения;//Страна постоянного местонахождения
		public string/*(50)*/ КодВСтранеРегистрации;//Код налогоплательщика в стране регистрации
		public string/*(15)*/ ОГРН;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(254)*/ НаименованиеИнострОрганизации;//Полное наименование иностранной организации
		///<summary>
		///(Регл)
		///</summary>
		public string/*(14)*/ РегистрационныйНомерФСС;//Регистрационный номер ФСС
		public string/*(254)*/ НаименованиеИМНС;//Наименование ИФНС
		public string/*(8)*/ КодОКВЭД;//Код основного вида деятельности по ОКВЭД
		public string/*(254)*/ НаименованиеОКВЭД;//Наименование основного вида деятельности по ОКВЭД
		public string/*(5)*/ КодОКОНХ;//Код ОКОНХ
		public V82.СправочникиСсылка.ФизическиеЛица ИндивидуальныйПредприниматель;//Индивидуальный предприниматель
		public bool УдалитьОбменЗадействован;//Удалить обмен задействован
		public string/*(7)*/ ОбменКодАбонента;//Код абонента
		public string/*(0)*/ ОбменКаталогОтправкиДанныхОтчетности;//Каталог выкладки данных отчетности для обмена с ИФНС
		public string/*(0)*/ ОбменКаталогПрограммыЭлектроннойПочты;//Каталог программы электронной почты для обмена с ИФНС
		///<summary>
		///(Регл)
		///</summary>
		public decimal/*(5.2)*/ РайонныйКоэффициентРФ;//Районный коэффициент РФ
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВРегламентированномУчете;//Отражать в регламентированном учете
		public string/*(4)*/ КодИФНСПолучателя;//Код ИФНС - получателя отчетности
		public string/*(100)*/ НаименованиеТерриториальногоОрганаПФР;//Наименование территориального органа ПФР
		public string/*(160)*/ НаименованиеСокращенное;//Наименование сокращенное
		public V82.Перечисления/*Ссылка*/.ВидыОбменаСКонтролирующимиОрганами ВидОбменаСКонтролирующимиОрганами;//Вид обмена с контролирующими органами
		public V82.СправочникиСсылка.УчетныеЗаписиДокументооборота УчетнаяЗаписьОбмена;//Учетная запись обмена
		public string/*(7)*/ КодОрганаПФР;//Код органа ПФР
		///<summary>
		///Код органа Федеральной службы государственной статистики
		///</summary>
		public string/*(5)*/ КодОрганаФСГС;//Код органа ФСГС
		///<summary>
		///(Регл)
		///</summary>
		public string/*(14)*/ ДополнительныйКодФСС;//Дополнительный код ФСС
		///<summary>
		///(Регл)
		///</summary>
		public string/*(5)*/ КодПодчиненностиФСС;//Код подчиненности ФСС
		public decimal/*(5)*/ ЦифровойИндексОбособленногоПодразделения;//Цифровой индекс обособленного подразделения:
		///<summary>
		///(Регл)
		///</summary>
		public string/*(15)*/ РегистрационныйНомерТФОМС;//Регистрационный номер ТФОМС
		///<summary>
		///(Регл)
		///</summary>
		public string/*(14)*/ ИПРегистрационныйНомерПФР;//Регистрационный номер ПФР индивидуального предпринимателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(10)*/ ИПРегистрационныйНомерФСС;//Регистрационный номер ФСС индивидуального предпринимателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(5)*/ ИПКодПодчиненностиФСС;//Код подчиненности ФСС индивидуального предпринимателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(15)*/ ИПРегистрационныйНомерТФОМС;//Регистрационный номер ТФОМС индивидуального предпринимателя
		public string/*(135)*/ НаименованиеТерриториальногоОрганаФСС;//Наименование территориального органа ФСС
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
						Insert Into _Reference172(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3012
						,_Fld3013
						,_Fld3014
						,_Fld3015
						,_Fld3016RRef
						,_Fld3017
						,_Fld3018
						,_Fld3019
						,_Fld3020
						,_Fld3021
						,_Fld3022RRef
						,_Fld3023RRef
						,_Fld3024RRef
						,_Fld3025RRef
						,_Fld3026
						,_Fld3027
						,_Fld3028
						,_Fld3029
						,_Fld3030
						,_Fld3031
						,_Fld3032
						,_Fld3033
						,_Fld3034
						,_Fld3035
						,_Fld3036
						,_Fld3037RRef
						,_Fld3038RRef
						,_Fld3039
						,_Fld3040
						,_Fld3041
						,_Fld3042
						,_Fld3043
						,_Fld3044
						,_Fld3045
						,_Fld3046
						,_Fld3047RRef
						,_Fld3048
						,_Fld3049
						,_Fld3050
						,_Fld3051
						,_Fld3052
						,_Fld3053
						,_Fld3054
						,_Fld3055
						,_Fld3056
						,_Fld3057RRef
						,_Fld3058RRef
						,_Fld3059
						,_Fld3060
						,_Fld3061
						,_Fld3062
						,_Fld3063
						,_Fld3064
						,_Fld3065
						,_Fld3066
						,_Fld3067
						,_Fld3068
						,_Fld3069)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Префикс
						,@ИНН
						,@КПП
						,@РегистрационныйНомерПФР
						,@ГоловнаяОрганизация
						,@НаименованиеПолное
						,@КодПоОКПО
						,@КодПоОКАТО
						,@КодИМНС
						,@РайонныйКоэффициент
						,@ЮрФизЛицо
						,@ТерриториальныеУсловияПФР
						,@ОсновнойБанковскийСчет
						,@ВидСтавокЕСНиПФР
						,@НаименованиеПлательщикаПриПеречисленииНалогов
						,@ИностраннаяОрганизация
						,@ДатаРегистрации
						,@КодОКОПФ
						,@НаименованиеОКОПФ
						,@КодОКФС
						,@НаименованиеОКФС
						,@СвидетельствоСерияНомер
						,@СвидетельствоДатаВыдачи
						,@СвидетельствоНаименованиеОргана
						,@СвидетельствоКодОргана
						,@СтранаРегистрации
						,@СтранаПостоянногоМестонахождения
						,@КодВСтранеРегистрации
						,@ОГРН
						,@НаименованиеИнострОрганизации
						,@РегистрационныйНомерФСС
						,@НаименованиеИМНС
						,@КодОКВЭД
						,@НаименованиеОКВЭД
						,@КодОКОНХ
						,@ИндивидуальныйПредприниматель
						,@УдалитьОбменЗадействован
						,@ОбменКодАбонента
						,@ОбменКаталогОтправкиДанныхОтчетности
						,@ОбменКаталогПрограммыЭлектроннойПочты
						,@РайонныйКоэффициентРФ
						,@ОтражатьВРегламентированномУчете
						,@КодИФНСПолучателя
						,@НаименованиеТерриториальногоОрганаПФР
						,@НаименованиеСокращенное
						,@ВидОбменаСКонтролирующимиОрганами
						,@УчетнаяЗаписьОбмена
						,@КодОрганаПФР
						,@КодОрганаФСГС
						,@ДополнительныйКодФСС
						,@КодПодчиненностиФСС
						,@ЦифровойИндексОбособленногоПодразделения
						,@РегистрационныйНомерТФОМС
						,@ИПРегистрационныйНомерПФР
						,@ИПРегистрационныйНомерФСС
						,@ИПКодПодчиненностиФСС
						,@ИПРегистрационныйНомерТФОМС
						,@НаименованиеТерриториальногоОрганаФСС)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference172
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3012	= @Префикс
						,_Fld3013	= @ИНН
						,_Fld3014	= @КПП
						,_Fld3015	= @РегистрационныйНомерПФР
						,_Fld3016RRef	= @ГоловнаяОрганизация
						,_Fld3017	= @НаименованиеПолное
						,_Fld3018	= @КодПоОКПО
						,_Fld3019	= @КодПоОКАТО
						,_Fld3020	= @КодИМНС
						,_Fld3021	= @РайонныйКоэффициент
						,_Fld3022RRef	= @ЮрФизЛицо
						,_Fld3023RRef	= @ТерриториальныеУсловияПФР
						,_Fld3024RRef	= @ОсновнойБанковскийСчет
						,_Fld3025RRef	= @ВидСтавокЕСНиПФР
						,_Fld3026	= @НаименованиеПлательщикаПриПеречисленииНалогов
						,_Fld3027	= @ИностраннаяОрганизация
						,_Fld3028	= @ДатаРегистрации
						,_Fld3029	= @КодОКОПФ
						,_Fld3030	= @НаименованиеОКОПФ
						,_Fld3031	= @КодОКФС
						,_Fld3032	= @НаименованиеОКФС
						,_Fld3033	= @СвидетельствоСерияНомер
						,_Fld3034	= @СвидетельствоДатаВыдачи
						,_Fld3035	= @СвидетельствоНаименованиеОргана
						,_Fld3036	= @СвидетельствоКодОргана
						,_Fld3037RRef	= @СтранаРегистрации
						,_Fld3038RRef	= @СтранаПостоянногоМестонахождения
						,_Fld3039	= @КодВСтранеРегистрации
						,_Fld3040	= @ОГРН
						,_Fld3041	= @НаименованиеИнострОрганизации
						,_Fld3042	= @РегистрационныйНомерФСС
						,_Fld3043	= @НаименованиеИМНС
						,_Fld3044	= @КодОКВЭД
						,_Fld3045	= @НаименованиеОКВЭД
						,_Fld3046	= @КодОКОНХ
						,_Fld3047RRef	= @ИндивидуальныйПредприниматель
						,_Fld3048	= @УдалитьОбменЗадействован
						,_Fld3049	= @ОбменКодАбонента
						,_Fld3050	= @ОбменКаталогОтправкиДанныхОтчетности
						,_Fld3051	= @ОбменКаталогПрограммыЭлектроннойПочты
						,_Fld3052	= @РайонныйКоэффициентРФ
						,_Fld3053	= @ОтражатьВРегламентированномУчете
						,_Fld3054	= @КодИФНСПолучателя
						,_Fld3055	= @НаименованиеТерриториальногоОрганаПФР
						,_Fld3056	= @НаименованиеСокращенное
						,_Fld3057RRef	= @ВидОбменаСКонтролирующимиОрганами
						,_Fld3058RRef	= @УчетнаяЗаписьОбмена
						,_Fld3059	= @КодОрганаПФР
						,_Fld3060	= @КодОрганаФСГС
						,_Fld3061	= @ДополнительныйКодФСС
						,_Fld3062	= @КодПодчиненностиФСС
						,_Fld3063	= @ЦифровойИндексОбособленногоПодразделения
						,_Fld3064	= @РегистрационныйНомерТФОМС
						,_Fld3065	= @ИПРегистрационныйНомерПФР
						,_Fld3066	= @ИПРегистрационныйНомерФСС
						,_Fld3067	= @ИПКодПодчиненностиФСС
						,_Fld3068	= @ИПРегистрационныйНомерТФОМС
						,_Fld3069	= @НаименованиеТерриториальногоОрганаФСС
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Префикс", Префикс);
					Команда.Parameters.AddWithValue("ИНН", ИНН);
					Команда.Parameters.AddWithValue("КПП", КПП);
					Команда.Parameters.AddWithValue("РегистрационныйНомерПФР", РегистрационныйНомерПФР);
					Команда.Parameters.AddWithValue("ГоловнаяОрганизация", ГоловнаяОрганизация.Ссылка);
					Команда.Parameters.AddWithValue("НаименованиеПолное", НаименованиеПолное);
					Команда.Parameters.AddWithValue("КодПоОКПО", КодПоОКПО);
					Команда.Parameters.AddWithValue("КодПоОКАТО", КодПоОКАТО);
					Команда.Parameters.AddWithValue("КодИМНС", КодИМНС);
					Команда.Parameters.AddWithValue("РайонныйКоэффициент", РайонныйКоэффициент);
					Команда.Parameters.AddWithValue("ЮрФизЛицо", ЮрФизЛицо.Ключ());
					Команда.Parameters.AddWithValue("ТерриториальныеУсловияПФР", ТерриториальныеУсловияПФР.Ссылка);
					Команда.Parameters.AddWithValue("ОсновнойБанковскийСчет", ОсновнойБанковскийСчет.Ссылка);
					Команда.Parameters.AddWithValue("ВидСтавокЕСНиПФР", ВидСтавокЕСНиПФР.Ключ());
					Команда.Parameters.AddWithValue("НаименованиеПлательщикаПриПеречисленииНалогов", НаименованиеПлательщикаПриПеречисленииНалогов);
					Команда.Parameters.AddWithValue("ИностраннаяОрганизация", ИностраннаяОрганизация);
					Команда.Parameters.AddWithValue("ДатаРегистрации", ДатаРегистрации);
					Команда.Parameters.AddWithValue("КодОКОПФ", КодОКОПФ);
					Команда.Parameters.AddWithValue("НаименованиеОКОПФ", НаименованиеОКОПФ);
					Команда.Parameters.AddWithValue("КодОКФС", КодОКФС);
					Команда.Parameters.AddWithValue("НаименованиеОКФС", НаименованиеОКФС);
					Команда.Parameters.AddWithValue("СвидетельствоСерияНомер", СвидетельствоСерияНомер);
					Команда.Parameters.AddWithValue("СвидетельствоДатаВыдачи", СвидетельствоДатаВыдачи);
					Команда.Parameters.AddWithValue("СвидетельствоНаименованиеОргана", СвидетельствоНаименованиеОргана);
					Команда.Parameters.AddWithValue("СвидетельствоКодОргана", СвидетельствоКодОргана);
					Команда.Parameters.AddWithValue("СтранаРегистрации", СтранаРегистрации.Ссылка);
					Команда.Parameters.AddWithValue("СтранаПостоянногоМестонахождения", СтранаПостоянногоМестонахождения.Ссылка);
					Команда.Parameters.AddWithValue("КодВСтранеРегистрации", КодВСтранеРегистрации);
					Команда.Parameters.AddWithValue("ОГРН", ОГРН);
					Команда.Parameters.AddWithValue("НаименованиеИнострОрганизации", НаименованиеИнострОрганизации);
					Команда.Parameters.AddWithValue("РегистрационныйНомерФСС", РегистрационныйНомерФСС);
					Команда.Parameters.AddWithValue("НаименованиеИМНС", НаименованиеИМНС);
					Команда.Parameters.AddWithValue("КодОКВЭД", КодОКВЭД);
					Команда.Parameters.AddWithValue("НаименованиеОКВЭД", НаименованиеОКВЭД);
					Команда.Parameters.AddWithValue("КодОКОНХ", КодОКОНХ);
					Команда.Parameters.AddWithValue("ИндивидуальныйПредприниматель", ИндивидуальныйПредприниматель.Ссылка);
					Команда.Parameters.AddWithValue("УдалитьОбменЗадействован", УдалитьОбменЗадействован);
					Команда.Parameters.AddWithValue("ОбменКодАбонента", ОбменКодАбонента);
					Команда.Parameters.AddWithValue("ОбменКаталогОтправкиДанныхОтчетности", ОбменКаталогОтправкиДанныхОтчетности);
					Команда.Parameters.AddWithValue("ОбменКаталогПрограммыЭлектроннойПочты", ОбменКаталогПрограммыЭлектроннойПочты);
					Команда.Parameters.AddWithValue("РайонныйКоэффициентРФ", РайонныйКоэффициентРФ);
					Команда.Parameters.AddWithValue("ОтражатьВРегламентированномУчете", ОтражатьВРегламентированномУчете);
					Команда.Parameters.AddWithValue("КодИФНСПолучателя", КодИФНСПолучателя);
					Команда.Parameters.AddWithValue("НаименованиеТерриториальногоОрганаПФР", НаименованиеТерриториальногоОрганаПФР);
					Команда.Parameters.AddWithValue("НаименованиеСокращенное", НаименованиеСокращенное);
					Команда.Parameters.AddWithValue("ВидОбменаСКонтролирующимиОрганами", ВидОбменаСКонтролирующимиОрганами.Ключ());
					Команда.Parameters.AddWithValue("УчетнаяЗаписьОбмена", УчетнаяЗаписьОбмена.Ссылка);
					Команда.Parameters.AddWithValue("КодОрганаПФР", КодОрганаПФР);
					Команда.Parameters.AddWithValue("КодОрганаФСГС", КодОрганаФСГС);
					Команда.Parameters.AddWithValue("ДополнительныйКодФСС", ДополнительныйКодФСС);
					Команда.Parameters.AddWithValue("КодПодчиненностиФСС", КодПодчиненностиФСС);
					Команда.Parameters.AddWithValue("ЦифровойИндексОбособленногоПодразделения", ЦифровойИндексОбособленногоПодразделения);
					Команда.Parameters.AddWithValue("РегистрационныйНомерТФОМС", РегистрационныйНомерТФОМС);
					Команда.Parameters.AddWithValue("ИПРегистрационныйНомерПФР", ИПРегистрационныйНомерПФР);
					Команда.Parameters.AddWithValue("ИПРегистрационныйНомерФСС", ИПРегистрационныйНомерФСС);
					Команда.Parameters.AddWithValue("ИПКодПодчиненностиФСС", ИПКодПодчиненностиФСС);
					Команда.Parameters.AddWithValue("ИПРегистрационныйНомерТФОМС", ИПРегистрационныйНомерТФОМС);
					Команда.Parameters.AddWithValue("НаименованиеТерриториальногоОрганаФСС", НаименованиеТерриториальногоОрганаФСС);
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
					Команда.CommandText = @"Delete _Reference172
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}