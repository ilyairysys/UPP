
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ����������������������������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		���������������� = 0,//������ ����������
	///<summary>
	///(���)
	///</summary>
		�������������������������������� = 1,//������� �������� ������� ����������
	///<summary>
	///(���)
	///</summary>
		������������������ = 2,//������������ ������
		������������������������ = 3,//������� �� �������� � ������
		��������������������������� = 4,//������ ������� � �������������
		������������������� = 5,//������� �� ������ ����
	///<summary>
	///(���)
	///</summary>
		�������������� = 6,//������������ ���������� �����
	///<summary>
	///(���)
	///</summary>
		��������������������������������������� = 7,//������������ �������� ������� ������������
		���������������������������������������� = 8,//������ �������� ����������� �������� �������
	}
	public static partial class ����������������������������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������������� = new Guid("e61ced84-cc00-fad1-4860-c9ebc01ae3dc");//������ ����������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������������������������� = new Guid("80892e83-2c0a-374b-4971-27ff3008facd");//������� �������� ������� ����������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������������ = new Guid("d7bcfc85-4c87-2e70-4e5b-47f2756df7fb");//������������ ������
		public static readonly Guid ������������������������ = new Guid("f34e67ba-f24e-1986-4ecd-dcbf45eab9e7");//������� �� �������� � ������
		public static readonly Guid ��������������������������� = new Guid("d0305996-6605-f5e8-4351-a3d5b7334ce2");//������ ������� � �������������
		public static readonly Guid ������������������� = new Guid("05a902b1-b173-3ee5-4233-5eb00963b1f1");//������� �� ������ ����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������� = new Guid("31d9399b-fb55-7841-4806-d3dab1ca288d");//������������ ���������� �����
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������������������������������� = new Guid("dfe7fb9b-8df5-138b-4cd2-24619e68ce90");//������������ �������� ������� ������������
		public static readonly Guid ���������������������������������������� = new Guid("56060699-4d4b-858a-4458-9a22280366e2");//������ �������� ����������� �������� �������
		public static ���������������������������������������������� ��������(this ���������������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������������������������������� ��������(this ���������������������������������������������� ��������, Guid ������)
		{
			if(������ == ����������������)
			{
				return ����������������������������������������������.����������������;
			}
			else if(������ == ��������������������������������)
			{
				return ����������������������������������������������.��������������������������������;
			}
			else if(������ == ������������������)
			{
				return ����������������������������������������������.������������������;
			}
			else if(������ == ������������������������)
			{
				return ����������������������������������������������.������������������������;
			}
			else if(������ == ���������������������������)
			{
				return ����������������������������������������������.���������������������������;
			}
			else if(������ == �������������������)
			{
				return ����������������������������������������������.�������������������;
			}
			else if(������ == ��������������)
			{
				return ����������������������������������������������.��������������;
			}
			else if(������ == ���������������������������������������)
			{
				return ����������������������������������������������.���������������������������������������;
			}
			else if(������ == ����������������������������������������)
			{
				return ����������������������������������������������.����������������������������������������;
			}
			return ����������������������������������������������.������������;
		}
		public static byte[] ����(this ���������������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������������������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������������������������������.����������������: return ����������������;
				case ����������������������������������������������.��������������������������������: return ��������������������������������;
				case ����������������������������������������������.������������������: return ������������������;
				case ����������������������������������������������.������������������������: return ������������������������;
				case ����������������������������������������������.���������������������������: return ���������������������������;
				case ����������������������������������������������.�������������������: return �������������������;
				case ����������������������������������������������.��������������: return ��������������;
				case ����������������������������������������������.���������������������������������������: return ���������������������������������������;
				case ����������������������������������������������.����������������������������������������: return ����������������������������������������;
			}
			return Guid.Empty;
		}
	}
}
