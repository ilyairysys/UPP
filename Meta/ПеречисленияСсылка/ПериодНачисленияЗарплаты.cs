
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������������������
	{
		������������ = - 1,
		������������ = 0,//������� �����
		���������������������������� = 1,//������ �������� �������� ������
		���������������������������� = 2,//������ �������� �������� ������
		������������� = 3,//������� ������
		��������������� = 4,//��������� ������
	}
	public static partial class ������������������������_��������//:������������������
	{
		public static readonly Guid ������������ = new Guid("fc49d894-fb45-cccc-41bd-f14bf662e0b1");//������� �����
		public static readonly Guid ���������������������������� = new Guid("7c5f319a-5437-8620-4fd0-48e8e513a5cb");//������ �������� �������� ������
		public static readonly Guid ���������������������������� = new Guid("eaf0f5a2-9c15-d261-4163-db10d9c249cd");//������ �������� �������� ������
		public static readonly Guid ������������� = new Guid("5b1744ad-0bbd-b9a0-4dc4-2516ccd13237");//������� ������
		public static readonly Guid ��������������� = new Guid("0586f6bf-eb4b-a20a-4e0f-6833c9b695ec");//��������� ������
		public static ������������������������ ��������(this ������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������ ��������(this ������������������������ ��������, Guid ������)
		{
			if(������ == ������������)
			{
				return ������������������������.������������;
			}
			else if(������ == ����������������������������)
			{
				return ������������������������.����������������������������;
			}
			else if(������ == ����������������������������)
			{
				return ������������������������.����������������������������;
			}
			else if(������ == �������������)
			{
				return ������������������������.�������������;
			}
			else if(������ == ���������������)
			{
				return ������������������������.���������������;
			}
			return ������������������������.������������;
		}
		public static byte[] ����(this ������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������.������������: return ������������;
				case ������������������������.����������������������������: return ����������������������������;
				case ������������������������.����������������������������: return ����������������������������;
				case ������������������������.�������������: return �������������;
				case ������������������������.���������������: return ���������������;
			}
			return Guid.Empty;
		}
	}
}
