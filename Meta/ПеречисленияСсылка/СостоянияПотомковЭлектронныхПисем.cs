
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������������������
	{
		������������ = - 1,
		������������� = 0,//����� ��������
		�������������� = 1,//����� ���������
		���������������������� = 2,//������������� ���������
		����������������������� = 3,//������������� ����������
	}
	public static partial class ���������������������������������_��������//:������������������
	{
		public static readonly Guid ������������� = new Guid("bcf8efa4-0201-d5db-4d1c-0227e9d845e7");//����� ��������
		public static readonly Guid �������������� = new Guid("45d0b2b6-c9c7-f902-42e3-36266cfcc943");//����� ���������
		public static readonly Guid ���������������������� = new Guid("43d7048f-bc14-370c-4d8b-351afecd9a98");//������������� ���������
		public static readonly Guid ����������������������� = new Guid("491e88bd-c05a-2b3c-4222-9b3d52ffc170");//������������� ����������
		public static ��������������������������������� ��������(this ��������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������������� ��������(this ��������������������������������� ��������, Guid ������)
		{
			if(������ == �������������)
			{
				return ���������������������������������.�������������;
			}
			else if(������ == ��������������)
			{
				return ���������������������������������.��������������;
			}
			else if(������ == ����������������������)
			{
				return ���������������������������������.����������������������;
			}
			else if(������ == �����������������������)
			{
				return ���������������������������������.�����������������������;
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
				case ���������������������������������.�������������: return �������������;
				case ���������������������������������.��������������: return ��������������;
				case ���������������������������������.����������������������: return ����������������������;
				case ���������������������������������.�����������������������: return �����������������������;
			}
			return Guid.Empty;
		}
	}
}
