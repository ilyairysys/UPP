
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������������������������������������������
	{
		������������ = - 1,
		������� = 0,//�� �����
		���������������������������� = 1,//����������� ������ � ������ ����
	}
	public static partial class �������������������������������������������������������_��������//:������������������
	{
		public static readonly Guid ������� = new Guid("5691758c-ad76-2cbe-4ff4-39f090217c54");//�� �����
		public static readonly Guid ���������������������������� = new Guid("1c9d09bd-d833-0b21-4cf9-493ab0218520");//����������� ������ � ������ ����
		public static ������������������������������������������������������� ��������(this ������������������������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������������������������� ��������(this ������������������������������������������������������� ��������, Guid ������)
		{
			if(������ == �������)
			{
				return �������������������������������������������������������.�������;
			}
			else if(������ == ����������������������������)
			{
				return �������������������������������������������������������.����������������������������;
			}
			return �������������������������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������������������������������������.�������: return �������;
				case �������������������������������������������������������.����������������������������: return ����������������������������;
			}
			return Guid.Empty;
		}
	}
}
