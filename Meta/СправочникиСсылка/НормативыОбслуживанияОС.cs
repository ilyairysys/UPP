
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
	public partial class �����������������������:����������������,I������������ProtoBuf,I������������Json
	{
		public static readonly Guid ���������� = new Guid("04151f13-c635-439e-8800-4e49bed66283");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221192000.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public bool ��������� {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid �������� {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*9*/ ��� {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*50*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(0)*/ ����������� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public V82.������������/*������*/.����������������� ��������� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public DateTime ��������������� {get;set;}//���� �����������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.�����������������.������������ ������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.������������/*������*/.������������� ������������������������� {get;set;}//������������� ������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public decimal/*(10.2)*/ ������������������ {get;set;}//���������� ��������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public V82.�����������������.�������������������� ����������������� {get;set;}//�������� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(15.3)*/ �������������������������� {get;set;}//�������� ��������� ���������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(15.3)*/ ���������� {get;set;}

		public V82.�����������������.�����������������������  ��������������()
		{
			var ������ = new V82.�����������������.�����������������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.����������� = �����������;
			������.��������� = ���������;
			������.��������������� = ���������������;
			������.������ = ������;
			������.������������������������� = �������������������������;
			������.������������������ = ������������������;
			������.����������������� = �����������������;
			������.�������������������������� = ��������������������������;
			������.���������� = ����������;
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
