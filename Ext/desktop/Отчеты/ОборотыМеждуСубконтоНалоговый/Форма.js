﻿Ext.define('Отчеты.ОборотыМеждуСубконтоНалоговый.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:716px;height:400px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Отчет Обороты между субконто',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьДатаНач',
			text: 'Период с:',
			style: 'position:absolute;left:20px;top:33px;width:56px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНач',
			style: 'position:absolute;left:80px;top:33px;width:84px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаКон',
			text: 'по:',
			style: 'position:absolute;left:168px;top:33px;width:28px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаКон',
			style: 'position:absolute;left:200px;top:33px;width:84px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:316px;top:33px;width:70px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:392px;top:33px;width:180px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:716px;height:25px;',
			items:
			[
				{
					text:'Сформировать',
				},
				{
					text:'Заголовок',
				},
				{
					text:'Настройка...',
				},
				'-',
				{
					text:'Възстанови стойностите...',
				},
				{
					text:'Съхрани стойностите...',
				},
				'-',
				{
					text:'Затвори',
				},
			]
		},
		{
			xtype: 'button',
			name: 'НастройкаПериода',
			text: '...',
			style: 'position:absolute;left:288px;top:33px;width:24px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВидУчета',
			text: 'Вид учета:',
			style: 'position:absolute;left:576px;top:33px;width:56px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидУчета',
			style: 'position:absolute;left:636px;top:33px;width:72px;height:19px;',
		},
	]
});