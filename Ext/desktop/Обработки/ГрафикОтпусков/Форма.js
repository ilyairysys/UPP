﻿Ext.define('Обработки.ГрафикОтпусков.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:1000px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'График отпусков',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:777px;top:33px;width:215px;height:539px;',
			height: 539,width: 215,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:7px;top:33px;width:764px;height:539px;',
			height: 539,width: 764,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:107px;top:3px;width:322px;height:19px;',
			height: 19,width: 322,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'По центрам ответственности',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьПодразделение',
			text: 'Подразделение:',
			style: 'position:absolute;left:0px;top:2px;width:83px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Подразделение',
			style: 'position:absolute;left:88px;top:0px;width:234px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:0px;top:0px;width:71px;height:19px;',
		},
					]
				},
				{
					title:'По структуре юридических лиц',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:77px;top:0px;width:245px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВыборГода',
			style: 'position:absolute;left:20px;top:3px;width:48px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЗа',
			text: 'За',
			style: 'position:absolute;left:1px;top:3px;width:14px;height:17px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГод',
			text: 'год',
			style: 'position:absolute;left:72px;top:2px;width:22px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолеВводаРежимПланированияОтпусков',
			style: 'position:absolute;left:521px;top:3px;width:243px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСгруппироватьПо',
			text: 'Сгруппировать',
			style: 'position:absolute;left:441px;top:3px;width:76px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:926px;top:0px;width:74px;height:25px;',
			items:
			[
				{
					text:'',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:926px;height:25px;',
			items:
			[
				'-',
				{
					text:'Запланировать отпуск',
				},
				'-',
				{
					text:'',
				},
				'-',
				{
					text:'Остатки отпусков',
				},
				'-',
				{
					text:'Дополнительные дни отпуска',
				},
				'-',
				{
					text:'',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
	]
});