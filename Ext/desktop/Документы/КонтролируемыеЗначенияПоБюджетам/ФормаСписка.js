﻿Ext.define('Документы.КонтролируемыеЗначенияПоБюджетам.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:421px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Контролируемые значения по бюджетам',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:'',
					width:'32',
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
					text:'Сценарий',
					width:'120',
				},
				{
					text:'Вид контролируемых значений',
					width:'120',
				},
				{
					text:'Использование контролируемых значений',
					width:'120',
				},
				{
					text:'Вид ограничения оборотов',
					width:'120',
				},
				{
					text:'Контролирующий сценарий',
					width:'120',
				},
				{
					text:'Ответственный',
					width:'120',
				},
				{
					text:'Состояние',
					width:'100',
				},
				{
					text:'Дата начала контроля оборотов ',
					width:'80',
				},
				{
					text:'Дата конца контроля оборотов ',
					width:'80',
				},
				{
					text:'Вид отклонения контролируемых значений',
					width:'120',
				},
				{
					text:'Отклонение',
					width:'80',
				},
				{
					text:'Комментарий',
					width:'120',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
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