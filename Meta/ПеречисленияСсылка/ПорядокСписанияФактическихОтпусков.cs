
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������������������������
	{
		������������ = - 1,
		������������������ = 0,//��������� ���������
		��������������������� = 1,//���������� �����������
	}
	public static partial class ����������������������������������_��������//:������������������
	{
		public static readonly Guid ������������������ = new Guid("eb31e2b2-87e6-3f02-4bac-80dc2dd8fea6");//��������� ���������
		public static readonly Guid ��������������������� = new Guid("8aaa5984-e3b5-f45c-4f57-2effbc89560f");//���������� �����������
		public static ���������������������������������� ��������(this ���������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������������������� ��������(this ���������������������������������� ��������, Guid ������)
		{
			if(������ == ������������������)
			{
				return ����������������������������������.������������������;
			}
			else if(������ == ���������������������)
			{
				return ����������������������������������.���������������������;
			}
			return ����������������������������������.������������;
		}
		public static byte[] ����(this ���������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������������������.������������������: return ������������������;
				case ����������������������������������.���������������������: return ���������������������;
			}
			return Guid.Empty;
		}
	}
}
