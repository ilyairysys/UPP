﻿Ext.require(['Данные.Отчеты.РегламентированныйОтчетАвансыТранспорт'], function () 
{
	Ext.define('Отчеты.РегламентированныйОтчетАвансыТранспорт.ФормаОтчета2006кв1',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаОтчета2006кв1',
	style: 'position:absolute;width:670px;height:488px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Налоговый расчет по авансовым платежам по транспортному налогу',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельФормы',
			style: 'position:absolute;left:0px;top:0px;width:670px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельФормы', Граница: 'Верхняя', Номер: 15, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:670,
			Верх:0,
			Лево:0,
			width: 670,
			height: 25,
			items:
			[
				{
					id:'Очистить',
					text:'Очистить',
					tooltip:'Очистить все данные отчета',
				},
				'-',
				'-',
				'-',
				{
					id:'КнопкаНастройкаСтраниц',
					text:'Настройка...',
					tooltip:'',
				},
				'-',
				{
					id:'Расшифровка',
					text:'Расшифровка',
					tooltip:'',
				},
				'-',
				{
					id:'Поиск',
					text:'Поиск',
					tooltip:'Поиск в регламентированном отчете',
				},
				'-',
				{
					id:'КнопкаЗаполнитьСведенияОбОрганизации',
					text:'Обновить',
					tooltip:'Обновить сведения об организации и ответственных лицах',
				},
				'-',
				{
					id:'РасширитьПолеБланка',
					text:'Расширить поле бланка',
					tooltip:'Расширить поле бланка',
				},
				'-',
				{
					id:'Справка',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
		{
			xtype: 'panel',
			id: 'ОсновнаяПанель',
			style: 'position:absolute;left:8px;top:122px;width:654px;height:310px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 468, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Верхняя', Номер: 469, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:310,
			Ширина:654,
			Верх:122,
			Лево:8,
			Групповой: true,
			height: 310,width: 654,
			items:
			[
				{
					id: 'Титульный',
				},
				{
					id: 'Раздел1',
					items:
					[
		{
			xtype: 'button',
			id: 'КнопкаДобавитьДопСтраницуРаздел1',
			text: 'Добавить',
			style: 'position:absolute;left:397px;top:265px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 50, Координата: 0},
					Нижняя: { Элемент: 'КнопкаДобавитьДопСтраницуРаздел1', Граница: 'Верхняя', Номер: 453, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:265,
			Лево:397,
		},
		{
			xtype: 'button',
			id: 'КнопкаУдалитьДопСтраницуРаздел1',
			text: 'Удалить',
			style: 'position:absolute;left:482px;top:265px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 50, Координата: 0},
					Нижняя: { Элемент: 'КнопкаУдалитьДопСтраницуРаздел1', Граница: 'Верхняя', Номер: 454, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:265,
			Лево:482,
		},
		{
			xtype: 'button',
			id: 'КнопкаПредыдущаяСтраницаРаздел1',
			text: '',
			style: 'position:absolute;left:267px;top:265px;width:20px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 50, Координата: 0},
					Нижняя: { Элемент: 'КнопкаПредыдущаяСтраницаРаздел1', Граница: 'Верхняя', Номер: 456, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:20,
			Верх:265,
			Лево:267,
		},
		{
			xtype: 'button',
			id: 'КнопкаСледующаяСтраницаРаздел1',
			text: '',
			style: 'position:absolute;left:371px;top:265px;width:20px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 50, Координата: 0},
					Нижняя: { Элемент: 'КнопкаСледующаяСтраницаРаздел1', Граница: 'Верхняя', Номер: 458, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:20,
			Верх:265,
			Лево:371,
		},
		{
			xtype: 'button',
			id: 'КнопкаПерейтиНаСтраницуРаздел1',
			text: 'Перейти',
			style: 'position:absolute;left:566px;top:265px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 50, Координата: 0},
					Нижняя: { Элемент: 'КнопкаПерейтиНаСтраницуРаздел1', Граница: 'Верхняя', Номер: 459, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:265,
			Лево:566,
		},
					]
				},
				{
					id: 'Раздел2',
					items:
					[
		{
			xtype: 'button',
			id: 'КнопкаДобавитьДопСтрокиРаздел2',
			text: 'Добавить',
			style: 'position:absolute;left:481px;top:265px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаДобавитьДопСтрокиРаздел2', Граница: 'Верхняя', Номер: 410, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:265,
			Лево:481,
		},
		{
			xtype: 'button',
			id: 'КнопкаУдалитьДопСтрокиРаздел2',
			text: 'Удалить',
			style: 'position:absolute;left:566px;top:265px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаУдалитьДопСтрокиРаздел2', Граница: 'Верхняя', Номер: 411, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:265,
			Лево:566,
		},
		{
			xtype: 'button',
			id: 'КнопкаДобавитьДопСтраницуРаздел2',
			text: 'Добавить',
			style: 'position:absolute;left:396px;top:241px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаДобавитьДопСтраницуРаздел2', Граница: 'Верхняя', Номер: 460, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:241,
			Лево:396,
		},
		{
			xtype: 'button',
			id: 'КнопкаУдалитьДопСтраницуРаздел2',
			text: 'Удалить',
			style: 'position:absolute;left:481px;top:241px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаУдалитьДопСтраницуРаздел2', Граница: 'Верхняя', Номер: 461, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:241,
			Лево:481,
		},
		{
			xtype: 'button',
			id: 'КнопкаПредыдущаяСтраницаРаздел2',
			text: '',
			style: 'position:absolute;left:266px;top:241px;width:20px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаПредыдущаяСтраницаРаздел2', Граница: 'Верхняя', Номер: 463, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:20,
			Верх:241,
			Лево:266,
		},
		{
			xtype: 'button',
			id: 'КнопкаСледующаяСтраницаРаздел2',
			text: '',
			style: 'position:absolute;left:370px;top:241px;width:20px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаСледующаяСтраницаРаздел2', Граница: 'Верхняя', Номер: 465, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:20,
			Верх:241,
			Лево:370,
		},
		{
			xtype: 'button',
			id: 'КнопкаПерейтиНаСтраницуРаздел2',
			text: 'Перейти',
			style: 'position:absolute;left:566px;top:241px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 25, Координата: 0},
					Нижняя: { Элемент: 'КнопкаПерейтиНаСтраницуРаздел2', Граница: 'Верхняя', Номер: 466, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:241,
			Лево:566,
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			id: '_ИндикаторВнешнегоОтчета',
			text: 'Внешний отчет',
			style: 'position:absolute;left:584px;top:5px;width:78px;height:15px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '_ИндикаторВнешнегоОтчета', Граница: 'Верхняя', Номер: 435, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:15,
			Ширина:78,
			Верх:5,
			Лево:584,
		},
		{
			xtype: 'panel',
			id: 'ПанельЭУВерхняя',
			style: 'position:absolute;left:8px;top:74px;width:654px;height:48px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 472, Координата: 0},
					Нижняя: { Элемент: 'ПанельЭУВерхняя', Граница: 'Верхняя', Номер: 468, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:48,
			Ширина:654,
			Верх:74,
			Лево:8,
			Групповой: true,
			height: 48,width: 654,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница1',
					items:
					[
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			id: 'ПолеВводаТочностьЕдиницыИзмерения',
			style: 'position:absolute;left:228px;top:0px;width:32px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:32,
			Верх:0,
			Лево:228,
			width: 32,
			height: 19,
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			id: 'ПолеВводаДатаСдачи',
			width: 80,
			height: 19,
			style: 'position:absolute;left:82px;top:24px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:24,
			Лево:82,
		},
		{
			xtype: 'combobox',
			id: 'ПолеВыбораЕдиницаИзмерения',
			style: 'position:absolute;left:82px;top:0px;width:80px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:0,
			Лево:82,
			width: 80,
			height: 19,
		},
		{
			xtype: 'combobox',
			id: 'ПолеВыбораВидДокумента',
			style: 'position:absolute;left:431px;top:24px;width:116px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:116,
			Верх:24,
			Лево:431,
			width: 116,
			height: 19,
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			id: 'НомерКорректировки',
			style: 'position:absolute;left:562px;top:24px;width:49px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:49,
			Верх:24,
			Лево:562,
			width: 49,
			height: 19,
		},
		{
			xtype: 'checkbox',
			id: 'ФлажокОтклАвтоРасчет',
			boxLabel: 'Отключить авторасчет вычисляемых ячеек',
			style: 'position:absolute;left:168px;top:24px;width:247px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:247,
			Верх:24,
			Лево:168,
		},
					]
				},
			]
		},
		{
			xtype: 'panel',
			id: 'ПанельЭУНижняя',
			style: 'position:absolute;left:8px;top:432px;width:654px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:654,
			Верх:432,
			Лево:8,
			Групповой: true,
			height: 25,width: 654,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница1',
					items:
					[
		{
			xtype: 'label',
			id: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:183px;top:6px;width:80px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьКомментарий', Граница: 'Верхняя', Номер: 433, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:80,
			Верх:6,
			Лево:183,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Комментарий',
			width: 391,
			height: 19,
			style: 'position:absolute;left:263px;top:6px;width:391px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Комментарий', Граница: 'Верхняя', Номер: 434, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:391,
			Верх:6,
			Лево:263,
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			id: 'Статус',
			name: 'Статус.Представление',
			width: 119,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:47px;top:6px;width:119px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Статус', Граница: 'Верхняя', Номер: 471, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:119,
			Верх:6,
			Лево:47,
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетАвансыТранспорт.ФормаОтчета2006кв1События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетАвансыТранспорт.ФормаОтчета2006кв1События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетАвансыТранспорт.ФормаОтчета2006кв1События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетАвансыТранспорт.ФормаОтчета2006кв1События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
					]
				},
			]
		},
		{
			xtype: 'panel',
			id: 'ПанельОтправки',
			style: 'position:absolute;left:8px;top:33px;width:654px;height:37px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:37,
			Ширина:654,
			Верх:33,
			Лево:8,
			Групповой: true,
			height: 37,width: 654,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница1',
					items:
					[
		{
			xtype: 'panel',
			id: 'ПанельОтправкиВнутренняя',
			style: 'position:absolute;left:2px;top:0px;width:652px;height:35px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:35,
			Ширина:652,
			Верх:0,
			Лево:2,
			Групповой: true,
			height: 35,width: 652,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница1',
					items:
					[
					]
				},
			]
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельДействий',
			style: 'position:absolute;left:0px;top:463px;width:670px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'КоманднаяПанельДействий', Граница: 'Нижняя', Номер: 16, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:670,
			Верх:463,
			Лево:0,
			width: 670,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
			]
		},
	],
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});