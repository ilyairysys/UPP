
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������������
	{
		������������ = - 1,
		���������� = 0,
		���������������� = 1,//�� ��������� �����
	}
	public static partial class ������������������������������_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("83acb797-2c60-97b7-42c1-0decb634b956");
		public static readonly Guid ���������������� = new Guid("6eab3fbc-6937-7443-422c-e907d91b3353");//�� ��������� �����
		public static ������������������������������ ��������(this ������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������ ��������(this ������������������������������ ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return ������������������������������.����������;
			}
			else if(������ == ����������������)
			{
				return ������������������������������.����������������;
			}
			return ������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������.����������: return ����������;
				case ������������������������������.����������������: return ����������������;
			}
			return Guid.Empty;
		}
	}
}
