
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������������������������
	{
		������������ = - 1,
		������������������������������������ = 0,//������ ������������� �� ���������� �����
		��������������������������������������������� = 1,//������ ������������� �� ��������� ���������� �����
	}
	public static partial class ���������������������������������������_��������//:������������������
	{
		public static readonly Guid ������������������������������������ = new Guid("d0e9968e-d8f3-c9bc-499b-5981fb9df0cc");//������ ������������� �� ���������� �����
		public static readonly Guid ��������������������������������������������� = new Guid("093739a7-37b2-91a5-4971-047f88001e0e");//������ ������������� �� ��������� ���������� �����
		public static ��������������������������������������� ��������(this ��������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������������������� ��������(this ��������������������������������������� ��������, Guid ������)
		{
			if(������ == ������������������������������������)
			{
				return ���������������������������������������.������������������������������������;
			}
			else if(������ == ���������������������������������������������)
			{
				return ���������������������������������������.���������������������������������������������;
			}
			return ���������������������������������������.������������;
		}
		public static byte[] ����(this ��������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������������������.������������������������������������: return ������������������������������������;
				case ���������������������������������������.���������������������������������������������: return ���������������������������������������������;
			}
			return Guid.Empty;
		}
	}
}
