﻿Ext.define('Отчеты.УнифицированнаяФормаМХ19СТипомЦен.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:644px;height:418px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Форма МХ-19 (по типу цен)',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:644px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Закрыть',
				},
					]
				},
				'-',
				{
					text:'Сформировать',
				},
				'-',
				{
					text:'Восстановить значения...',
				},
				{
					text:'Сохранить значения...',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:88px;top:33px;width:219px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСклад',
			text: 'Склад:',
			style: 'position:absolute;left:8px;top:57px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Склад',
			style: 'position:absolute;left:88px;top:57px;width:219px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипЦен',
			text: 'Тип цен:',
			style: 'position:absolute;left:8px;top:81px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ТипЦен',
			style: 'position:absolute;left:88px;top:81px;width:219px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить данные в первую колонку',
			style: 'position:absolute;left:322px;top:33px;width:209px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить данные во вторую колонку',
			style: 'position:absolute;left:322px;top:57px;width:209px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить данные в третью колонку',
			style: 'position:absolute;left:322px;top:81px;width:209px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата1',
			style: 'position:absolute;left:536px;top:33px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата2',
			style: 'position:absolute;left:536px;top:57px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата3',
			style: 'position:absolute;left:536px;top:81px;width:100px;height:19px;',
		},
	]
});