﻿Ext.define('Отчеты.КнигаУчетаДоходовИРасходов.Форма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:652px;height:428px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Книга учета доходов и расходов',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:652px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
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
			name: 'Надпись1',
			text: 'Период составления отчета:',
			style: 'position:absolute;left:8px;top:33px;width:152px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Организация:',
			style: 'position:absolute;left:346px;top:33px;width:76px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:424px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:108px;width:636px;height:312px;',
			height: 312,width: 636,
			items:
			[
				{
					title:'Титульный лист',
				},
				{
					title:'Доходы и расходы',
				},
				{
					title:'Расходы на приобретение основных средств',
				},
				{
					title:'Расчет налоговой базы',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПериодСоставленияОтчета',
			text: '',
			style: 'position:absolute;left:184px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущийПериод',
			text: '',
			style: 'position:absolute;left:162px;top:33px;width:20px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:306px;top:33px;width:20px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Включение граф 4 "Доходы всего" и 6 "Расходы всего":',
			style: 'position:absolute;left:132px;top:57px;width:290px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРежимПечатиНДС',
			text: 'Режим печати НДС:',
			style: 'position:absolute;left:320px;top:81px;width:102px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Выводить расшифровки',
			style: 'position:absolute;left:8px;top:81px;width:142px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'C начала года',
			style: 'position:absolute;left:8px;top:57px;width:97px;height:19px;',
		},
	]
});