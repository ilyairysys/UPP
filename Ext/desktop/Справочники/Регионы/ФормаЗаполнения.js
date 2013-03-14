﻿Ext.define('Справочники.Регионы.ФормаЗаполнения',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:722px;height:450px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Заполнение справочника Регионы',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:425px;width:722px;height:25px;',
			items:
			[
				{
					text:'Заполнить / Обновить список',
				},
				'-',
				{
					text:'Дополнить справочник',
				},
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:234px;top:32px;width:480px;height:385px;',
			height: 385,width: 480,
			columns:
			[
				{
					text:'',
					width:'20',
				},
				{
					text:'Наименование',
					width:'220',
				},
				{
					text:'Код',
					width:'100',
				},
				{
					text:'Ссылка',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:422px;top:231px;width:155px;height:129px;',
			items:
			[
				{
					text:'Пометить вложенные',
				},
				{
					text:'Сбросить вложенные',
				},
				'-',
				{
					text:'Пометить текущий уровень',
				},
				{
					text:'Сбросить текущий уровень',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьРегионРодитель',
			text: 'Родительский элемент для вставки:',
			style: 'position:absolute;left:8px;top:8px;width:190px;height:18px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'РодительскийРегион',
			style: 'position:absolute;left:199px;top:8px;width:515px;height:19px;',
		},
	]
});