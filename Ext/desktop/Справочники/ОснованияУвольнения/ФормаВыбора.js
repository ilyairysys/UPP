﻿Ext.define('Справочники.ОснованияУвольнения.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:425px;height:261px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Причины увольнения',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:409px;height:220px;',
			height: 220,width: 409,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'Наименование',
					width:'220',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:425px;height:25px;',
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