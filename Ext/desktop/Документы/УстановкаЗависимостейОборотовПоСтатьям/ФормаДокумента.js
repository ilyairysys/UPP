﻿Ext.define('Документы.УстановкаЗависимостейОборотовПоСтатьям.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:656px;height:413px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Установка зависимостей оборотов по статьям',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:94px;top:33px;width:77px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Дата:',
			style: 'position:absolute;left:179px;top:33px;width:33px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:212px;top:33px;width:102px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Сценарий:',
			style: 'position:absolute;left:8px;top:57px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Сценарий',
			style: 'position:absolute;left:94px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Статья оборотов:',
			style: 'position:absolute;left:334px;top:57px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтатьяОборотовВлияющая',
			style: 'position:absolute;left:428px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'ЦФО:',
			style: 'position:absolute;left:8px;top:81px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЦФО',
			style: 'position:absolute;left:94px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Проект:',
			style: 'position:absolute;left:334px;top:81px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Проект',
			style: 'position:absolute;left:428px;top:81px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Контрагент:',
			style: 'position:absolute;left:8px;top:105px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Контрагент',
			style: 'position:absolute;left:94px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'Номенклатура:',
			style: 'position:absolute;left:334px;top:105px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номенклатура',
			style: 'position:absolute;left:428px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись9',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:129px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:94px;top:129px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:172px;width:640px;height:24px;',
			items:
			[
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:196px;width:640px;height:160px;',
			height: 160,width: 640,
			columns:
			[
				{
					text:'Статья оборотов',
					width:'119',
				},
				{
					text:'Реквизит для суммы',
					width:'112',
				},
				{
					text:'К-т  для суммы',
					width:'82',
				},
				{
					text:'Реквизит для кол-ва',
					width:'116',
				},
				{
					text:'К-т для кол-ва',
					width:'86',
				},
				{
					text:'Изменение по периодам',
					width:'121',
				},
				{
					text:'Зависимая номенклатура',
					width:'97',
				},
				{
					text:'Зависимый контрагент',
					width:'67',
				},
				{
					text:'Зависимый проект',
					width:'100',
				},
				{
					text:'Зависимый ЦФО',
					width:'100',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:656px;height:25px;',
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
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:388px;width:656px;height:25px;',
			items:
			[
				{
					text:'Печать',
				},
				'-',
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
			name: 'Надпись10',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:361px;width:84px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:94px;top:361px;width:554px;height:19px;',
		},
	]
});