﻿Ext.define('Документы.РезервированиеТоваров.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:552px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Резервирование товаров',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:536px;height:380px;',
			height: 380,width: 536,
			columns:
			[
				{
					text:'',
					width:'32',
				},
				{
					text:'БУ',
					width:'20',
				},
				{
					text:'НУ',
					width:'20',
				},
				{
					text:'Дата',
					width:'132',
				},
				{
					text:'Номер',
					width:'80',
				},
				{
					text:'Вид операции',
					width:'120',
				},
				{
					text:'Заказ',
					width:'120',
				},
				{
					text:'Организация',
					width:'120',
				},
				{
					text:'Комментарий',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:552px;height:25px;',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'',
				},
				'-',
					]
				},
			]
		},
	]
});