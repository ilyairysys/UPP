
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������������
	{
		������������ = - 1,
		��������������� = 0,//�������� �������
		������� = 1,//������� ������� (���������� �����, �������� �����)
		��������� = 2,//��������� �������
		������������������� = 3,//������� ������������
		��������������������� = 4,//��� ��������
	}
	public static partial class �����������������������_��������//:������������������
	{
		public static readonly Guid ��������������� = new Guid("b713e6bb-302f-023d-478d-388d251ff74e");//�������� �������
		public static readonly Guid ������� = new Guid("690ee580-fa45-3d2b-42b9-d07629f5f7fa");//������� ������� (���������� �����, �������� �����)
		public static readonly Guid ��������� = new Guid("aded8b84-3246-57e1-48dd-24c6b24998a9");//��������� �������
		public static readonly Guid ������������������� = new Guid("3c1eb19b-6387-2831-4fc6-690fe3b4d67c");//������� ������������
		public static readonly Guid ��������������������� = new Guid("e13f89bb-0b86-ac7d-4033-84e7b898cd9a");//��� ��������
		public static ����������������������� ��������(this ����������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������� ��������(this ����������������������� ��������, Guid ������)
		{
			if(������ == ���������������)
			{
				return �����������������������.���������������;
			}
			else if(������ == �������)
			{
				return �����������������������.�������;
			}
			else if(������ == ���������)
			{
				return �����������������������.���������;
			}
			else if(������ == �������������������)
			{
				return �����������������������.�������������������;
			}
			else if(������ == ���������������������)
			{
				return �����������������������.���������������������;
			}
			return �����������������������.������������;
		}
		public static byte[] ����(this ����������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������.���������������: return ���������������;
				case �����������������������.�������: return �������;
				case �����������������������.���������: return ���������;
				case �����������������������.�������������������: return �������������������;
				case �����������������������.���������������������: return ���������������������;
			}
			return Guid.Empty;
		}
	}
}
