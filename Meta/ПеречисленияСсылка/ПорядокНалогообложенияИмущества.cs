
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �������������������������������
	{
		������������ = - 1,
		������������������������� = 0,//������ ������ �� �����������
		������������������������������ = 1,//������������� �� ���������������
		��������������������������� = 2,//���������� �� ��������� ������
		������������������������� = 3,//�� �������� ���������������
	}
	public static partial class �������������������������������_��������//:������������������
	{
		public static readonly Guid ������������������������� = new Guid("3a396b94-e90a-2636-41bc-faa60c07ce07");//������ ������ �� �����������
		public static readonly Guid ������������������������������ = new Guid("a93c7aa7-fbc7-0421-43b6-978229bbc58e");//������������� �� ���������������
		public static readonly Guid ��������������������������� = new Guid("d9870896-9b1a-26de-4180-5feb0436483a");//���������� �� ��������� ������
		public static readonly Guid ������������������������� = new Guid("682cb58f-8e98-786c-4cc6-0b154a7bc47f");//�� �������� ���������������
		public static ������������������������������� ��������(this ������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������� ��������(this ������������������������������� ��������, Guid ������)
		{
			if(������ == �������������������������)
			{
				return �������������������������������.�������������������������;
			}
			else if(������ == ������������������������������)
			{
				return �������������������������������.������������������������������;
			}
			else if(������ == ���������������������������)
			{
				return �������������������������������.���������������������������;
			}
			else if(������ == �������������������������)
			{
				return �������������������������������.�������������������������;
			}
			return �������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������������.�������������������������: return �������������������������;
				case �������������������������������.������������������������������: return ������������������������������;
				case �������������������������������.���������������������������: return ���������������������������;
				case �������������������������������.�������������������������: return �������������������������;
			}
			return Guid.Empty;
		}
	}
}
