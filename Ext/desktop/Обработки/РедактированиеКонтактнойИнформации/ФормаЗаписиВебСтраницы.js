﻿Ext.define('Обработки.РедактированиеКонтактнойИнформации.ФормаЗаписиВебСтраницы',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:334px;height:189px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Веб-страница',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Веб-страница:',
			style: 'position:absolute;left:14px;top:109px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Представление',
			style: 'position:absolute;left:106px;top:109px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись16',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:137px;width:98px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:106px;top:137px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:334px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:164px;width:334px;height:25px;',
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
		{
			xtype: 'label',
			name: 'НадписьОбъект',
			text: 'Объект:',
			style: 'position:absolute;left:8px;top:33px;width:98px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Объект',
			style: 'position:absolute;left:106px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись18',
			text: 'Вид веб-страницы:',
			style: 'position:absolute;left:8px;top:61px;width:98px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Вид',
			style: 'position:absolute;left:106px;top:61px;width:220px;height:19px;',
		},
	]
});