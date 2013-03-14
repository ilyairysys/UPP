﻿Ext.define('Справочники.ВидыАнализовНоменклатуры.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:440px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Виды анализов номенклатуры',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:424px;height:280px;',
			height: 280,width: 424,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Код',
					width:'40',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:440px;height:25px;',
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