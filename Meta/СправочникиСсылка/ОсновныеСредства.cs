
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
		public static readonly Guid ���������� = new Guid("445ce11c-52df-46ef-945d-46be54138d89");
		public static readonly DateTime ������������ = DateTime.ParseExact("20121221191633.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*100*/ ������������ {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public bool ������������� {get;set;}//������� ��������������
		///<summary>
		///����� ��������������� ������� ������������
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ �������������������� {get;set;}//����� ���������������
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.������������/*������*/.��������������������� ��������������������� {get;set;}//��������������� ������
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.������������/*������*/.�������� �������� {get;set;}//������ ��
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public DateTime ����������� {get;set;}//���� ������� (���������)
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public string/*(0)*/ �������������� {get;set;}//��������� �����
		///<summary>
		///(���) �����������-������������
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ ������������ {get;set;}
		///<summary>
		///(����)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.�����������������.����������������������������������������� ��������� {get;set;}//��� �� ����
		///<summary>
		///��� ������� ������� ������������
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public string/*(2)*/ ���������� {get;set;}//��� �������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public string/*(0)*/ ����������� {get;set;}
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public string/*(0)*/ ������������������ {get;set;}//������ ������������
		///<summary>
		///(���)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public string/*(0)*/ ������������� {get;set;}//����� �������� (���������������)
		[DataMember]
		[ProtoMember(21)]
		public bool ��������� {get;set;}//�������� ���������� ��� ��������� ������ ������ (����������)
		[DataMember]
		[ProtoMember(22)]
		public string/*(100)*/ ���������������� {get;set;}//����������� �����
		[DataMember]
		[ProtoMember(23)]
		public string/*(21)*/ ������������� {get;set;}//�������� �����
		[DataMember]
		[ProtoMember(24)]
		public V82.������������/*������*/.������������������� ������������������� {get;set;}//���������� ���������

		public V82.�����������������.����������������  ��������������()
		{
			var ������ = new V82.�����������������.����������������();
			������._�������� = false;
			������.������ = ������;
			������.������ = ������;
			������.��������������� = ���������������;
			������.���������������� = ����������������;
			������.��������� = ���������;
			������.�������� = ��������;
			������.��� = ���;
			������.������������ = ������������;
			������.������������� = �������������;
			������.�������������������� = ��������������������;
			������.��������������������� = ���������������������;
			������.�������� = ��������;
			������.����������� = �����������;
			������.�������������� = ��������������;
			������.������������ = ������������;
			������.��������� = ���������;
			������.���������� = ����������;
			������.����������� = �����������;
			������.������������������ = ������������������;
			������.������������� = �������������;
			������.��������� = ���������;
			������.���������������� = ����������������;
			������.������������� = �������������;
			������.������������������� = �������������������;
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
