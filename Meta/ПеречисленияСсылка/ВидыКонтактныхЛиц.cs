
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������
	{
		������������ = - 1,
		������������������������� = 0,//���������� ���� �����������
		�������������������� = 1,//������ ���������� ����
		������������� = 2,//������ �������
	}
	public static partial class �����������������_��������//:������������������
	{
		public static readonly Guid ������������������������� = new Guid("2482eca6-3511-1b4b-4df1-efa77d07649c");//���������� ���� �����������
		public static readonly Guid �������������������� = new Guid("37ce0795-01eb-f177-4ab4-ac8de9f6b899");//������ ���������� ����
		public static readonly Guid ������������� = new Guid("0f3f5392-ce6d-ebdb-4895-1e610106b669");//������ �������
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == �������������������������)
			{
				return �����������������.�������������������������;
			}
			else if(������ == ��������������������)
			{
				return �����������������.��������������������;
			}
			else if(������ == �������������)
			{
				return �����������������.�������������;
			}
			return �����������������.������������;
		}
		public static byte[] ����(this ����������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������� ��������)
		{
			switch (��������)
			{
				case �����������������.�������������������������: return �������������������������;
				case �����������������.��������������������: return ��������������������;
				case �����������������.�������������: return �������������;
			}
			return Guid.Empty;
		}
	}
}
