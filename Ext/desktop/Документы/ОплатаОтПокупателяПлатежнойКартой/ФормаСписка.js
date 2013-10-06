﻿Ext.require(['Данные.Документы.ОплатаОтПокупателяПлатежнойКартой'], function () 
{
	Ext.define('Документы.ОплатаОтПокупателяПлатежнойКартой.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаСписка',
	style: 'position:absolute;width:780px;height:420px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Оплаты от покупателей платежными картами',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'Список',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:32px;width:764px;height:380px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: 'Форма', Граница: 'Верхняя', Номер: 0, Координата: 0},
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
			Верх:32,
			Лево:8,
			height: 380,width: 764,
			columns:
			[
				{
					text:' ',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'УУ',
					width:'20',
					dataIndex:'ОтражатьВУправленческомУчете',
					flex:1,
				},
				{
					text:'БУ',
					width:'20',
					dataIndex:'ОтражатьВБухгалтерскомУчете',
					flex:1,
				},
				{
					text:'НУ',
					width:'20',
					dataIndex:'ОтражатьВНалоговомУчете',
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
					text:'Вид операции',
					width:'120',
					dataIndex:'ВидОперации',
					flex:1,
				},
				{
					text:'Валюта документа',
					width:'70',
					dataIndex:'ВалютаДокумента',
					flex:1,
				},
				{
					text:'Сумма',
					width:'80',
					dataIndex:'СуммаДокумента',
					flex:1,
				},
				{
					text:'Организация',
					width:'120',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'120',
					dataIndex:'Подразделение',
					flex:1,
				},
				{
					text:'Ответственный',
					width:'120',
					dataIndex:'Ответственный',
					flex:1,
				},
				{
					text:'Основание',
					width:'0',
					dataIndex:'Основание',
					flex:1,
				},
				{
					text:'Приложение',
					width:'0',
					dataIndex:'Приложение',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'120',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Способ заполнения',
					width:'100',
					dataIndex:'СпособЗаполнения',
					flex:1,
				},
				{
					text:'Контрагент',
					width:'185',
					dataIndex:'Контрагент',
					flex:1,
				},
				{
					text:'Номер чека ККМ',
					width:'116',
					dataIndex:'НомерЧекаККМ',
					flex:1,
				},
				{
					text:'Эквайрер',
					width:'100',
					dataIndex:'Эквайрер',
					flex:1,
				},
				{
					text:'Договор эквайринга',
					width:'100',
					dataIndex:'ДоговорЭквайринга',
					flex:1,
				},
				{
					text:'Договор взаиморасчетов эквайрера',
					width:'100',
					dataIndex:'ДоговорРасчетовПоЭквайрингу',
					flex:1,
				},
				{
					text:'Счет учета расчетов с эквайером',
					width:'67',
					dataIndex:'СчетУчетаРасчетовСЭквайером',
					flex:1,
				},
				{
					text:'Вид оплаты',
					width:'162',
					dataIndex:'ВидОплаты',
					flex:1,
				},
				{
					text:'% торговой уступки',
					width:'106',
					dataIndex:'ПроцентТорговойУступки',
					flex:1,
				},
				{
					text:'Сумма торговой уступки',
					width:'134',
					dataIndex:'СуммаТорговойУступки',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОплатаОтПокупателяПлатежнойКартой/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'ОтражатьВУправленческомУчете',
					},
					{
						name:'ОтражатьВБухгалтерскомУчете',
					},
					{
						name:'ОтражатьВНалоговомУчете',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'ВидОперации',
					},
					{
						name:'ВалютаДокумента',
					},
					{
						name:'СуммаДокумента',
					},
					{
						name:'Организация',
					},
					{
						name:'Подразделение',
					},
					{
						name:'Ответственный',
					},
					{
						name:'Основание',
					},
					{
						name:'Приложение',
					},
					{
						name:'Комментарий',
					},
					{
						name:'СпособЗаполнения',
					},
					{
						name:'Контрагент',
					},
					{
						name:'НомерЧекаККМ',
					},
					{
						name:'Эквайрер',
					},
					{
						name:'ДоговорЭквайринга',
					},
					{
						name:'ДоговорРасчетовПоЭквайрингу',
					},
					{
						name:'СчетУчетаРасчетовСЭквайером',
					},
					{
						name:'ВидОплаты',
					},
					{
						name:'ПроцентТорговойУступки',
					},
					{
						name:'СуммаТорговойУступки',
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
						var грид = Ext.getCmp('Список');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ОплатаОтПокупателяПлатежнойКартой.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОплатаОтПокупателяПлатежнойКартой.ФормаСпискаСобытия");
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
					id:'Подменю3',
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
				'-',
				{
					id:'ДействиеПечать',
					text:'Печать по умолчанию',
					tooltip:'Печать по умолчанию',
				},
				'-',
				{
					id:'ПроводкиДтКт',
					text:'Дт/кт',
					tooltip:'Проводки БУ',
				},
				{
					id:'ПроводкиДтКтНУ',
					text:'Дт/кт',
					tooltip:'Проводки НУ',
				},
				'-',
				{
					id:'ПечатьКассовогоЧека',
					text:'Чек',
					tooltip:'Печать кассового чека',
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