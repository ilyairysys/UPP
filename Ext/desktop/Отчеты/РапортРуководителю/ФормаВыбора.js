﻿Ext.define('Отчеты.РапортРуководителю.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:238px;height:294px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Показатели рапорта',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:269px;width:238px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:33px;width:220px;height:228px;',
			height: 228,width: 220,
			columns:
			[
				{
					text:'Показатель',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:10px;top:8px;width:220px;height:24px;',
			items:
			[
				{
					text:'Снять пометки',
				},
				{
					text:'Установить пометки',
				},
			]
		},
	]
});