﻿Ext.define('Документы.ПлатежноеПоручениеВходящее.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:420px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Платежные поручения входящие',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:32px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:' ',
					width:'32',
				},
				{
					text:'ОУ',
					width:'20',
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
					text:'Опл',
					width:'27',
				},
				{
					text:'Дата',
					width:'132',
				},
				{
					text:'Дата оплаты',
					width:'80',
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
					text:'Сумма',
					width:'80',
				},
				{
					text:'Счет организации',
					width:'120',
				},
				{
					text:'Контрагент',
					width:'120',
				},
				{
					text:'Организация',
					width:'120',
				},
				{
					text:'Подразделение',
					width:'118',
				},
				{
					text:'Ответственный',
					width:'120',
				},
				{
					text:'Номер вход. документа',
					width:'250',
				},
				{
					text:'Дата вход. документа',
					width:'105',
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
					text:'Перейти',
					menu: [
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
					]
				},
				'-',
				{
					text:'Дт/кт',
				},
				{
					text:'Дт/кт',
				},
			]
		},
	]
});