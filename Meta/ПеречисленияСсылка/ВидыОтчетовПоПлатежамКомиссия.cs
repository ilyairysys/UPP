
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������������������
	{
		������������ = - 1,
		����� = 0,
		������ = 1,
		����������� = 2,//����� ������
	}
	public static partial class �����������������������������_��������//:������������������
	{
		public static readonly Guid ����� = new Guid("f0c6e094-d121-7885-4198-298090f2c608");
		public static readonly Guid ������ = new Guid("e068818f-82aa-3d42-4277-ac558318bffd");
		public static readonly Guid ����������� = new Guid("eb7f709d-1d70-2a66-4bbc-fd8489e5bff9");//����� ������
		public static ����������������������������� ��������(this ����������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������������� ��������(this ����������������������������� ��������, Guid ������)
		{
			if(������ == �����)
			{
				return �����������������������������.�����;
			}
			else if(������ == ������)
			{
				return �����������������������������.������;
			}
			else if(������ == �����������)
			{
				return �����������������������������.�����������;
			}
			return �����������������������������.������������;
		}
		public static byte[] ����(this ����������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������������.�����: return �����;
				case �����������������������������.������: return ������;
				case �����������������������������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
