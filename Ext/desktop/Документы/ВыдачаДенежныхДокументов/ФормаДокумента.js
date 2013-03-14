﻿Ext.define('Документы.ВыдачаДенежныхДокументов.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:670px;height:371px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Выдача денежных документов',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:88px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:186px;top:33px;width:16px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:319px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:96px;top:33px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:204px;top:33px;width:112px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:102px;top:319px;width:560px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:670px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:107px;width:654px;height:159px;',
			height: 159,width: 654,
			items:
			[
				{
					title:'Кому',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:6px;width:640px;height:126px;',
			height: 126,width: 640,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Возврат поставщику',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаРасчетовСКонтрагентом',
			text: 'Счет расчетов:',
			style: 'position:absolute;left:0px;top:80px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасчетовСКонтрагентом',
			style: 'position:absolute;left:82px;top:80px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКонтрагент',
			text: 'Контрагент:',
			style: 'position:absolute;left:0px;top:0px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДоговорКонтрагента',
			style: 'position:absolute;left:82px;top:54px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Контрагент',
			style: 'position:absolute;left:82px;top:0px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДоговор',
			text: 'Договор:',
			style: 'position:absolute;left:0px;top:54px;width:82px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыдано',
			text: 'Выдано:',
			style: 'position:absolute;left:0px;top:26px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Выдано',
			style: 'position:absolute;left:82px;top:26px;width:558px;height:19px;',
		},
					]
				},
				{
					title:'Прочее',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаРасчетовСКонтрагентомПрочее',
			text: 'Счет дебета:',
			style: 'position:absolute;left:0px;top:28px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасчетовСКонтрагентомПрочее',
			style: 'position:absolute;left:83px;top:28px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконтоДт1',
			text: 'Субконто Дт1:',
			style: 'position:absolute;left:0px;top:53px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоДт1',
			style: 'position:absolute;left:83px;top:53px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконтоДт2',
			text: 'Субконто Дт2:',
			style: 'position:absolute;left:0px;top:78px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоДт2',
			style: 'position:absolute;left:83px;top:78px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСубконтоДт3',
			text: 'Субконто Дт3:',
			style: 'position:absolute;left:0px;top:103px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СубконтоДт3',
			style: 'position:absolute;left:83px;top:103px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыданоПрочее',
			text: 'Выдано:',
			style: 'position:absolute;left:0px;top:0px;width:82px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВыданоПрочее',
			style: 'position:absolute;left:82px;top:0px;width:558px;height:19px;',
		},
					]
				},
				{
					title:'Выдача подотчетному лицу',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьПодотчетноеЛицо',
			text: 'Подотчетное лицо:',
			style: 'position:absolute;left:0px;top:0px;width:80px;height:29px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодотчетноеЛицо',
			style: 'position:absolute;left:83px;top:0px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВыданоПодотчетноеЛицо',
			text: 'Выдано:',
			style: 'position:absolute;left:0px;top:29px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВыданоПодотчетноеЛицо',
			style: 'position:absolute;left:83px;top:29px;width:557px;height:19px;',
		},
					]
				},
			]
		},
					]
				},
				{
					title:'Денежные документы',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:640px;height:24px;',
			items:
			[
				'-',
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:640px;height:102px;',
			height: 102,width: 640,
			columns:
			[
				{
					text:'№',
					width:'28',
				},
				{
					text:'Денежный документ',
					width:'180',
				},
				{
					text:'Количество',
					width:'100',
				},
				{
					text:'Стоимость',
					width:'120',
				},
				{
					text:'Сумма возврата',
					width:'120',
				},
			]
		},
					]
				},
				{
					title:'Счета доходов и расходов',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаДоходов',
			text: 'Счет учета доходов:',
			style: 'position:absolute;left:6px;top:57px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаДоходов',
			style: 'position:absolute;left:160px;top:57px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаРасходов',
			text: 'Счет учета расходов:',
			style: 'position:absolute;left:6px;top:80px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасходов',
			style: 'position:absolute;left:160px;top:80px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатьяДоходовИРасходов',
			text: 'Статья доходов и расходов:',
			style: 'position:absolute;left:6px;top:34px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СтатьяДоходовИРасходов',
			style: 'position:absolute;left:160px;top:34px;width:357px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаДоходовНУ',
			text: 'Счет учета доходов (НУ):',
			style: 'position:absolute;left:283px;top:57px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаДоходовНУ',
			style: 'position:absolute;left:437px;top:57px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаРасходовНУ',
			text: 'Счет учета расходов (НУ):',
			style: 'position:absolute;left:283px;top:80px;width:150px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаРасходовНУ',
			style: 'position:absolute;left:437px;top:80px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:295px;width:92px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:102px;top:295px;width:560px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВсего',
			text: 'Всего,USD:',
			style: 'position:absolute;left:470px;top:271px;width:72px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Всего',
			style: 'position:absolute;left:542px;top:271px;width:120px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:346px;width:670px;height:25px;',
			items:
			[
				{
					text:'ОК',
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
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:96px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетУчетаДенежныхДокументов',
			text: 'Счет учета:',
			style: 'position:absolute;left:8px;top:81px;width:88px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'СчетУчетаДенежныхДокументов',
			style: 'position:absolute;left:96px;top:81px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаДокумента',
			text: 'Валюта:',
			style: 'position:absolute;left:191px;top:81px;width:44px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВалютаДокумента',
			style: 'position:absolute;left:236px;top:81px;width:80px;height:19px;',
		},
	]
});