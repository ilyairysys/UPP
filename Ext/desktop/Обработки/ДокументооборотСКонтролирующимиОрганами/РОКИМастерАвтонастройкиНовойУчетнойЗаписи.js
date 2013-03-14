﻿Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.РОКИМастерАвтонастройкиНовойУчетнойЗаписи',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:600px;height:400px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Автоматическая настройка параметров учетной записи абонентов ""Такском""',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:375px;width:600px;height:25px;',
			items:
			[
				{
					text:'<  Назад',
				},
				{
					text:'Далее  >',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:375px;',
			height: 375,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись26',
			text: 'Автоматическая настройка параметров учетной записи',
			style: 'position:absolute;left:12px;top:25px;width:576px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись43',
			text: 'Для того чтобы приступить к настройке нажмите кнопку "Далее >".',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Мастер автоматической настройки поможет настроить параметры учетной записи по информации с "сервера ресурсов общей ключевой информации" специализированного оператора связи компании "Такском".

На данном сервере Интернета в зашифрованном виде размещается информация о параметрах учетных записей налогоплательщиков - абонентов компании.',
			style: 'position:absolute;left:10px;top:99px;width:581px;height:66px;',
		},
					]
				},
				{
					title:'Страница2',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись28',
			text: 'Указание параметров организации-абонента ',
			style: 'position:absolute;left:12px;top:25px;width:576px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись29',
			text: 'Укажите организацию, для которой необходимо настроить параметры учетной записи,
или задайте ее ИНН и КПП.

Эти параметры необходимы для обращения к серверу Интернет, на котором хранятся настройки.',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
		{
			xtype: 'radio',
			boxLabel: 'Организация:',
			style: 'position:absolute;left:13px;top:119px;width:93px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:28px;top:141px;width:560px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Параметры:',
			style: 'position:absolute;left:13px;top:169px;width:93px;height:15px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:29px;top:192px;width:372px;height:20px;',
			height: 20,width: 372,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'ИНН:',
			style: 'position:absolute;left:0px;top:3px;width:69px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'КПП:',
			style: 'position:absolute;left:201px;top:3px;width:69px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ИНН',
			style: 'position:absolute;left:74px;top:0px;width:97px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'КПП',
			style: 'position:absolute;left:275px;top:1px;width:97px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Страница3',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись30',
			text: 'Регистрация личного сертификата лица, ответственного за шифрование',
			style: 'position:absolute;left:12px;top:25px;width:576px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись31',
			text: 'Один из сертификатов ответственных лиц организации, изданных для налогоплательщика удостоверяющим центром, предназначен для целей шифрования. Необходимо зарегистрировать этот личный сертификат в системе перед обращением за информацией о настройках к серверу "Такском".
Для этого укажите файл с сертификатом и соответствующий ему ключевой контейнер (контейнер должен быть доступен в момент выбора).',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись32',
			text: 'Файл сертификата:',
			style: 'position:absolute;left:12px;top:145px;width:112px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись33',
			text: 'Ключевой контейнер:',
			style: 'position:absolute;left:12px;top:172px;width:112px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатШифрованиеФайл',
			style: 'position:absolute;left:130px;top:143px;width:458px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатШифрованиеКонтейнер',
			style: 'position:absolute;left:130px;top:170px;width:458px;height:19px;',
		},
					]
				},
				{
					title:'Страница4',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись34',
			text: 'Сертификат:',
			style: 'position:absolute;left:12px;top:145px;width:112px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись35',
			text: 'Ключевой контейнер:',
			style: 'position:absolute;left:12px;top:172px;width:112px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатРуководителя',
			style: 'position:absolute;left:130px;top:143px;width:458px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатРуководителяКонтейнер',
			style: 'position:absolute;left:130px;top:170px;width:458px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись36',
			text: 'Регистрация сертификата руководителя организации',
			style: 'position:absolute;left:12px;top:25px;width:576px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись37',
			text: 'Выберите ключевой контейнер и нажмите кнопку "Далее >" для регистрации сертификата руководителя с привязкой к соответствующему закрытому ключу.

В момент регистрации ключевой носитель (дискета или USB-устройство), содержащий контейнер с закрытым ключом, должен быть вставлен в дисковод для гибких дисков или USB-порт компьютера.',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Страница5',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись38',
			text: 'Сертификат:',
			style: 'position:absolute;left:12px;top:145px;width:112px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись39',
			text: 'Ключевой контейнер:',
			style: 'position:absolute;left:12px;top:172px;width:112px;height:15px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатБухгалтера',
			style: 'position:absolute;left:130px;top:143px;width:458px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СертификатБухгалтераКонтейнер',
			style: 'position:absolute;left:130px;top:170px;width:458px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись41',
			text: 'Выберите ключ��вой контейнер и нажмите кнопку "Далее >" для регистрации сертификата главного бухгалтера с привязкой к соответствующему закрытому ключу.

В момент регистрации ключевой носитель (дискета или USB-устройство), содержащий контейнер с закрытым ключом, должен быть вставлен в дисковод для гибких дисков или USB-порт компьютера.',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Страница6',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:64px;',
			height: 64,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись42',
			text: 'Сохранение информации в ИБ и завершение работы мастера',
			style: 'position:absolute;left:12px;top:25px;width:576px;height:15px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:276px;width:600px;height:99px;',
			height: 99,width: 600,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись44',
			text: 'Нажмите "Готово" для сохранения информации в информационной базе и завершения работы мастера.',
			style: 'position:absolute;left:12px;top:9px;width:578px;height:82px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись45',
			text: 'Настройка учетной записи успешно завершена.',
			style: 'position:absolute;left:12px;top:128px;width:250px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Открыть форму учетной записи',
			style: 'position:absolute;left:12px;top:239px;width:182px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сопоставить учетную запись организации ',
			style: 'position:absolute;left:12px;top:212px;width:582px;height:15px;',
		},
					]
				},
			]
		},
	]
});