
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������������������
	{
		������������ = - 1,
	///<summary>
	///��� �����������, �� ���� ������ �� ������������
	///</summary>
		������ = 0,
	///<summary>
	///���� ����������
	///</summary>
		���� = 1,
	///<summary>
	///�������� � ������������
	///</summary>
		����� = 2,
	///<summary>
	///��� �����������, �� ����� ����������
	///</summary>
		��������� = 3,//����� ����
	}
	public static partial class ���������������������������������_��������//:������������������
	{
		///<summary>
		///��� �����������, �� ���� ������ �� ������������
		///</summary>
		public static readonly Guid ������ = new Guid("0129c2ae-b2fb-98c7-437b-e27fa5000a97");
		///<summary>
		///���� ����������
		///</summary>
		public static readonly Guid ���� = new Guid("13096a96-c8ba-af53-401f-585500ee0163");
		///<summary>
		///�������� � ������������
		///</summary>
		public static readonly Guid ����� = new Guid("baf06792-d37a-b9dc-4b3f-dc3e6ca93df7");
		///<summary>
		///��� �����������, �� ����� ����������
		///</summary>
		public static readonly Guid ��������� = new Guid("45e1cba4-47a3-5ea5-4839-77fb9f1fbf74");//����� ����
		public static ��������������������������������� ��������(this ��������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������������� ��������(this ��������������������������������� ��������, Guid ������)
		{
			if(������ == ������)
			{
				return ���������������������������������.������;
			}
			else if(������ == ����)
			{
				return ���������������������������������.����;
			}
			else if(������ == �����)
			{
				return ���������������������������������.�����;
			}
			else if(������ == ���������)
			{
				return ���������������������������������.���������;
			}
			return ���������������������������������.������������;
		}
		public static byte[] ����(this ��������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������������.������: return ������;
				case ���������������������������������.����: return ����;
				case ���������������������������������.�����: return �����;
				case ���������������������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
