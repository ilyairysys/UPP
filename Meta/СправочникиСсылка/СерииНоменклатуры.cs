
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
	public partial class �����������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("0675623a-8763-43c0-94dc-e6f81b5173ab");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191917.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public Guid �������� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*9*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*100*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public string/*(25)*/ ������������� {get;set;}//�������� �����
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public DateTime ������������ {get;set;}//���� ��������
		///<summary>
		///(����) ����� ��� �� ���������
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.�����������������.��������� �������� {get;set;}//����� ���
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.�����������������.���������������������� ������������������� {get;set;}//������ �������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.��������������������������������� ������������������� {get;set;}//�������� �����������
		///<summary>
		///(���) ����� �������������� ����������
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public string/*(0)*/ ����������� {get;set;}

		public V82.�����������������.�����������������  ��������������()
		{
			var ������ = new V82.�����������������.�����������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������� = �������������;
			������.������������ = ������������;
			������.�������� = ��������;
			������.������������������� = �������������������;
			������.������������������� = �������������������;
			������.����������� = �����������;
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
