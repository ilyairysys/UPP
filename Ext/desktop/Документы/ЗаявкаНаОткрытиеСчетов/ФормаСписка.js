﻿Ext.require(['Данные.Документы.ЗаявкаНаОткрытиеСчетов'], function () 
{
	Ext.define('Документы.ЗаявкаНаОткрытиеСчетов.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаСписка',
	style: 'position:absolute;width:1000px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Заявка на открытие счетов',
	
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
			style: 'position:absolute;left:8px;top:57px;width:984px;height:256px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 5, Координата: 0},
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
			Высота:256,
			Ширина:984,
			Верх:57,
			Лево:8,
			height: 256,width: 984,
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
					width:'132',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'Организация',
					width:'120',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Сотрудники',
					width:'101',
					dataIndex:'КраткийСоставДокумента',
					flex:1,
				},
				{
					text:'Ответственный',
					width:'120',
					dataIndex:'Ответственный',
					flex:1,
				},
				{
					text:'Банковский счет',
					width:'120',
					dataIndex:'БанковскийСчет',
					flex:1,
				},
				{
					text:'№ договора',
					width:'80',
					dataIndex:'НомерДоговора',
					flex:1,
				},
				{
					text:'Обработано в банке',
					width:'100',
					dataIndex:'ОбработаноВБанке',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'220',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Валюта',
					width:'80',
					dataIndex:'Валюта',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗаявкаНаОткрытиеСчетов/ВыбратьПоСсылке/100', timeout: 200},
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
						name:'Организация',
					},
					{
						name:'КраткийСоставДокумента',
					},
					{
						name:'Ответственный',
					},
					{
						name:'БанковскийСчет',
					},
					{
						name:'НомерДоговора',
					},
					{
						name:'ОбработаноВБанке',
					},
					{
						name:'Комментарий',
					},
					{
						name:'Валюта',
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
						Ext.require(['Справочники.ЗаявкаНаОткрытиеСчетов.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЗаявкаНаОткрытиеСчетов.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'ДействияФормы',
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
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
			Ширина:1000,
			Верх:0,
			Лево:0,
			width: 1000,
			height: 25,
			items:
			[
				{
					xtype: 'splitbutton',
					id:'Подменю',
					text:'',
					menu: [
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
					]
				},
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
					]
				},
					]
				},
				'-',
				{
					id:'Действие',
					text:'&Добавить',
					tooltip:'Добавить',
					iconCls:'x-copy',
				},
				'-',
				{
					id:'Действие1',
					text:'',
					tooltip:'',
				},
				{
					id:'Действие2',
					text:'Изменить',
					tooltip:'Изменить текущий элемент',
					iconCls:'x-Change',
				},
				{
					id:'Действие3',
					text:'Установить пометку удаления',
					tooltip:'Установить пометку удаления',
				},
				'-',
				{
					id:'Действие4',
					text:'',
					tooltip:'',
				},
				{
					id:'Действие5',
					text:'',
					tooltip:'',
				},
				'-',
				{
					id:'Действие6',
					text:'Установить отбор и сортировку списка...',
					tooltip:'Отбор и сортировка',
					iconCls:'x-FilterAndSort',
				},
				{
					id:'Действие7',
					text:'Отбор по значению в текущей колонке',
					tooltip:'Отбор по значению в текущей колонке',
					iconCls:'x-FilterByCurrentValue',
				},
				{
					xtype: 'splitbutton',
					id:'Подменю1',
					text:'',
					menu: [
					]
				},
				{
					id:'Действие8',
					text:'Отключить отбор',
					tooltip:'Отключить отбор',
					iconCls:'x-ClearFilter',
				},
				'-',
				{
					id:'Действие9',
					text:'Обновить',
					tooltip:'Обновить текущий список',
					iconCls:'x-Refresh',
				},
				'-',
				{
					id:'Действие10',
					text:'Справка',
					tooltip:'Открыть справку',
				},
				{
					xtype: 'splitbutton',
					id:'Подменю2',
					text:'',
					menu: [
				{
					text:'',
					tooltip:'',
				},
				{
					text:'',
					tooltip:'',
				},
				'-',
				{
					text:'Лицевые счета сотрудников организации',
					tooltip:'Лицевые счета сотрудников организации',
				},
				{
					text:'',
					tooltip:'',
				},
					]
				},
			]
		},
		{
			xtype: 'panel',
			id: 'ПанельОтборПоОрганизации',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
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
			Ширина:984,
			Верх:33,
			Лево:8,
			Групповой: true,
			height: 19,width: 984,
			tabBar:{hidden:true},
			items:
			[
				{
					id: 'Страница1',
					items:
					[
		{
			xtype: 'checkbox',
			id: 'ОрганизацияФлаг',
			boxLabel: 'Организация:',
			style: 'position:absolute;left:0px;top:0px;width:87px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ОрганизацияФлаг', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ОрганизацияФлаг', Граница: 'Верхняя', Номер: 6, Координата: 0},
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
			Ширина:87,
			Верх:0,
			Лево:0,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Организация',
			width: 220,
			height: 19,
			style: 'position:absolute;left:92px;top:0px;width:220px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Центр', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Организация', Граница: 'Верхняя', Номер: 7, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 6, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:220,
			Верх:0,
			Лево:92,
		},
					]
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