﻿Ext.define('Справочники.ТипыЗаписейЗаметок.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:534px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Справочник Типы записей заметок',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:518px;height:259px;',
			height: 259,width: 518,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Наименование',
					width:'350',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:534px;height:25px;',
			items:
			[
				'-',
			]
		},
	]
});