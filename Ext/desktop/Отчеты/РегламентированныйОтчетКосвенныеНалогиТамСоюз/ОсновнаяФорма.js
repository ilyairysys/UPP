﻿Ext.define('Отчеты.РегламентированныйОтчетКосвенныеНалогиТамСоюз.ОсновнаяФорма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:276px;height:237px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Косвенные налоги при ввозе товаров из государств - членов таможенного союза',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:212px;width:276px;height:25px;',
			items:
			[
				{
					text:'ОК',
				},
				'-',
				{
					text:'Отмена',
				},
				'-',
				{
					text:'Действие1',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПериодСоставленияОтчета',
			text: '',
			style: 'position:absolute;left:36px;top:83px;width:199px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущийПериод',
			text: '',
			style: 'position:absolute;left:14px;top:83px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:238px;top:83px;width:20px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ОписаниеНормативДок',
			text: '',
			style: 'position:absolute;left:8px;top:132px;width:254px;height:49px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораФормы',
			text: 'Выбрать форму',
			style: 'position:absolute;left:8px;top:185px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:8px;top:27px;width:260px;height:19px;',
		},
	]
});