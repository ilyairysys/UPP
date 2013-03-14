﻿Ext.define('Справочники.СценарииПланирования.ФормаАвтозаполненияКурсов',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:348px;height:180px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: '',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:155px;width:348px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КоличествоПериодовРаспределения',
			style: 'position:absolute;left:240px;top:32px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Количество периодов для установки курсов:',
			style: 'position:absolute;left:8px;top:32px;width:230px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНачалаУстановкиКурсов',
			style: 'position:absolute;left:240px;top:8px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Начальная дата установки курсов:',
			style: 'position:absolute;left:8px;top:8px;width:230px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИсходныйКурс',
			style: 'position:absolute;left:240px;top:104px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Исходный курс для заполнения:',
			style: 'position:absolute;left:8px;top:104px;width:230px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПриращениеЗаПериод',
			style: 'position:absolute;left:240px;top:128px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Приращение за период',
			style: 'position:absolute;left:8px;top:128px;width:230px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КратностьНаИнтервал',
			style: 'position:absolute;left:240px;top:56px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Кратность на интервал заполнения:',
			style: 'position:absolute;left:8px;top:56px;width:230px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СпособЗаполнения',
			style: 'position:absolute;left:240px;top:80px;width:100px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Вид изменения курсов при заполнении:',
			style: 'position:absolute;left:8px;top:80px;width:230px;height:19px;',
		},
	]
});