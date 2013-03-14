﻿Ext.define('Обработки.ОбщиеОбъектыРегламентированнойОтчетности.ФормаПараметрыИнтеграцииСоСпринтером',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:598px;height:128px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Параметры интеграции с ПК ""Спринтер"" компании ""Такском""',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:103px;width:598px;height:25px;',
			items:
			[
				{
					text:'Прочитать данные с настроечной дискеты',
				},
				'-',
				{
					text:'ОК',
				},
				'-',
				{
					text:'Отмена',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КодАбонента',
			style: 'position:absolute;left:189px;top:11px;width:64px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Отправки данных отчетности:',
			style: 'position:absolute;left:20px;top:79px;width:166px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Программы электронной почты:',
			style: 'position:absolute;left:20px;top:57px;width:166px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Логин:',
			style: 'position:absolute;left:20px;top:13px;width:42px;height:16px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогОтправкиДанныхОтчетности',
			style: 'position:absolute;left:189px;top:76px;width:401px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КаталогПрограммыЭлектроннойПочты',
			style: 'position:absolute;left:189px;top:53px;width:401px;height:19px;',
		},
	]
});