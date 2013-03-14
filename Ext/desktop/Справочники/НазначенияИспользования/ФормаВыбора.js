﻿Ext.define('Справочники.НазначенияИспользования.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:500px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Назначения использования',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:484px;height:259px;',
			height: 259,width: 484,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Код',
					width:'35',
				},
				{
					text:'Наименование',
					width:'175',
				},
				{
					text:'Способ погашения стоимости',
					width:'161',
				},
				{
					text:'Срок полезного использования',
					width:'44',
				},
				{
					text:'Количество',
					width:'68',
				},
				{
					text:'Единица',
					width:'70',
				},
				{
					text:'Способ отражения расходов',
					width:'153',
				},
				{
					text:'Владелец',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:500px;height:25px;',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
	]
});