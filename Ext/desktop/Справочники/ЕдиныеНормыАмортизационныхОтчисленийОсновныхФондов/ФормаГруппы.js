﻿Ext.define('Справочники.ЕдиныеНормыАмортизационныхОтчисленийОсновныхФондов.ФормаГруппы',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:463px;height:85px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Группа Единые нормы амортизационных отчислений на полное восстановление основных фондов',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:359px;top:33px;width:25px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:388px;top:33px;width:67px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование группы:',
			style: 'position:absolute;left:8px;top:33px;width:121px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:131px;top:33px;width:221px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:463px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:60px;width:463px;height:25px;',
			items:
			[
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
	]
});