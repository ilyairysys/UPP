
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������
	{
		������������ = - 1,
		�������������� = 0,//�������� ������
		������������������ = 1,//���������� ��������
		�������������� = 2,//�������� ������
	}
	public static partial class �����������������_��������//:������������������
	{
		public static readonly Guid �������������� = new Guid("23a9eebe-d76d-0727-48bd-623fb1bad895");//�������� ������
		public static readonly Guid ������������������ = new Guid("a372bbb4-7ecd-6f89-4f7f-a6f02afbf282");//���������� ��������
		public static readonly Guid �������������� = new Guid("0b42d4b1-7522-fe0b-4160-438f28988e10");//�������� ������
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == ��������������)
			{
				return �����������������.��������������;
			}
			else if(������ == ������������������)
			{
				return �����������������.������������������;
			}
			else if(������ == ��������������)
			{
				return �����������������.��������������;
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
				case �����������������.��������������: return ��������������;
				case �����������������.������������������: return ������������������;
				case �����������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
