
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
	///<summary>
	///(���)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ����������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("1dec52fd-9ee2-4d32-bf13-245265ae5381");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191955.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*50*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public V82.�����������������.���������������������������� ����������������������� {get;set;}//������� �� ��������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public decimal/*(15.3)*/ ��� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public decimal/*(15.3)*/ ����� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(10.3)*/ ����������� {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public decimal/*(10)*/ ��������������� {get;set;}//����� ����������
		[DataMember]
		[ProtoMember(13)]
		public bool ��������������������������� {get;set;}//��� ���������� ������������� � ������� ������

		public V82.�����������������.����������������  ��������������()
		{
			var ������ = new V82.�����������������.����������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.����������������������� = �����������������������;
			������.��� = ���;
			������.����� = �����;
			������.����������� = �����������;
			������.��������������� = ���������������;
			������.��������������������������� = ���������������������������;
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
