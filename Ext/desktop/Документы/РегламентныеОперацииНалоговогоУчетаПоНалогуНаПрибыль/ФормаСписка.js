﻿Ext.require(['Данные.Документы.РегламентныеОперацииНалоговогоУчетаПоНалогуНаПрибыль'], function () 
{
	Ext.define('Документы.РегламентныеОперацииНалоговогоУчетаПоНалогуНаПрибыль.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаСписка',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Регламентные операции налогового учета (по налогу на прибыль)',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'ДокументСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
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
			Высота:380,
			Ширина:764,
			Верх:33,
			Лево:8,
			height: 380,width: 764,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Дата',
					width:'106',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Номер',
					width:'59',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'За период',
					width:'74',
					dataIndex:'ПериодРегистрации',
					flex:1,
				},
				{
					text:'Организация',
					width:'176',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Нормирование расходов на рекламу',
					width:'70',
					dataIndex:'НормированиеРасходовНаРекламу',
					flex:1,
				},
				{
					text:'Нормиров. расходов на добр. страх.',
					width:'70',
					dataIndex:'НормированиеРасходовНаДобровольноеСтрахование',
					flex:1,
				},
				{
					text:'Нормиров. представи- тельских расходов',
					width:'70',
					dataIndex:'НормированиеПредставительскихРасходов',
					flex:1,
				},
				{
					text:'Распред. расходов по видам деят.',
					width:'70',
					dataIndex:'РаспределениеРасходовПоВидамДеятельности',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РегламентныеОперацииНалоговогоУчетаПоНалогуНаПрибыль/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'ПериодРегистрации',
					},
					{
						name:'Организация',
					},
					{
						name:'НормированиеРасходовНаРекламу',
					},
					{
						name:'НормированиеРасходовНаДобровольноеСтрахование',
					},
					{
						name:'НормированиеПредставительскихРасходов',
					},
					{
						name:'РаспределениеРасходовПоВидамДеятельности',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ДокументСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РегламентныеОперацииНалоговогоУчетаПоНалогуНаПрибыль.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РегламентныеОперацииНалоговогоУчетаПоНалогуНаПрибыль.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'ДействияФормы',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 2, Координата: 0},
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
			Ширина:780,
			Верх:0,
			Лево:0,
			width: 780,
			height: 25,
			items:
			[
				{
					xtype: 'splitbutton',
					id:'Подменю2',
					text:'Перейти',
					menu: [
				{
					text:'Движения документа по регистрам',
					tooltip:'',
				},
				{
					text:'Структура подчиненности документа',
					tooltip:'',
				},
				'-',
					]
				},
				{
					id:'ДействиеПечать',
					text:'Печать по умолчанию',
					tooltip:'Печать по умолчанию',
				},
				{
					id:'ПроводкиДтКтНУ',
					text:'Дт/кт',
					tooltip:'Проводки НУ',
				},
			]
		},
		],
	}],
	dockedItems:
	[
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