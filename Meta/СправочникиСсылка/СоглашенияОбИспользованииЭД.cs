
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	[ProtoContract]
	[DataContract]
	public partial class ���������������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("c000410b-b593-4ef1-8c9c-d464abe8dd86");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191415.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long ���������������������� = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid ������ {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long ������ {get;set;}
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		[DataMember]
		[ProtoMember(3)]
		public bool ��������������� {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool ���������������� {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*100*/ ������������ {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*(9)*/ ����� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public DateTime ���� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public V82.������������/*������*/.��������������� �������������� {get;set;}//������ ������
		[DataMember]
		[ProtoMember(9)]
		public V82.������������/*������*/.������������������� ���������������� {get;set;}//������ ����������
		[DataMember]
		[ProtoMember(10)]
		public V82.�����������������.����������� ����������� {get;set;}
		[DataMember]
		[ProtoMember(11)]
		public V82.�����������������.����������� ���������� {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public string/*(10)*/ ������� {get;set;}
		[DataMember]
		[ProtoMember(13)]
		public string/*(50)*/ ������������������������ {get;set;}//�������������
		[DataMember]
		[ProtoMember(14)]
		public string/*(50)*/ ������������������������ {get;set;}//������������� �����������
		[DataMember]
		[ProtoMember(15)]
		public V82.�����������������.�������������� ����������������������������������� {get;set;}//���������� �����������
		[DataMember]
		[ProtoMember(16)]
		public ����������������� ���������������������������������� {get;set;}//���������� ��� ����������
		[DataMember]
		[ProtoMember(17)]
		public object ����������������������� {get;set;}//����� ������� �����������
		[DataMember]
		[ProtoMember(18)]
		public string/*(255)*/ ����������������������� {get;set;}//����� ������� �����������
		[DataMember]
		[ProtoMember(19)]
		public DateTime ������������ {get;set;}//���� ��������
		[DataMember]
		[ProtoMember(20)]
		public V82.�����������������.������������ ������������� {get;set;}//������������� �� �����
		[DataMember]
		[ProtoMember(21)]
		public string/*(0)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(22)]
		public V82.�����������������.��������������������������� ����������������� {get;set;}//������� ����������
		[DataMember]
		[ProtoMember(23)]
		public bool ���������������������������� {get;set;}//��������� ����������� ��������
		[DataMember]
		[ProtoMember(24)]
		public bool ���������� {get;set;}//��� �������
		[DataMember]
		[ProtoMember(25)]
		public bool ��������������� {get;set;}//��� ����� ����� �������������
		[DataMember]
		[ProtoMember(26)]
		public V82.�����������������.�������������� ������������������ {get;set;}//����������
		[DataMember]
		[ProtoMember(27)]
		public string/*(100)*/ ������������� {get;set;}//����� ��������

		public V82.�����������������.���������������������������  ��������������()
		{
			var ������ = new V82.�����������������.���������������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.������������ = ������������;
			������.����� = �����;
			������.���� = ����;
			������.�������������� = ��������������;
			������.���������������� = ����������������;
			������.����������� = �����������;
			������.���������� = ����������;
			������.������� = �������;
			������.������������������������ = ������������������������;
			������.������������������������ = ������������������������;
			������.����������������������������������� = �����������������������������������;
			������.���������������������������������� = ����������������������������������;
			������.����������������������� = �����������������������;
			������.����������������������� = �����������������������;
			������.������������ = ������������;
			������.������������� = �������������;
			������.����������� = �����������;
			������.����������������� = �����������������;
			������.���������������������������� = ����������������������������;
			������.���������� = ����������;
			������.��������������� = ���������������;
			������.������������������ = ������������������;
			������.������������� = �������������;
			return ������;
		}

		public void ������������ProtoBuf(Stream �����)
		{
			Serializer.Serialize(�����,this);
		}
		
		public string ������������Json()
		{
			return this.ToJson();
		}
		
		public string ������������Xml()
		{
			return this.ToXml();
		}
	}
}
