
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ����������������������������
	{
		������������ = - 1,
		������������������������ = 0,//������������� �����������
		����������������������� = 1,//������������� ����������
		�������������������� = 2,//��� ���������� �������
		������������������������� = 3,//��� ������������ ����������
		�������������������������������� = 4,//������������� ���������� ���������
	}
	public static partial class ����������������������������_��������//:������������������
	{
		public static readonly Guid ������������������������ = new Guid("5f0c0f9f-95e2-2f4c-4ba3-7c0761e2d4b9");//������������� �����������
		public static readonly Guid ����������������������� = new Guid("11c1a0a0-4a2b-dbeb-4c5e-6b3ae925a087");//������������� ����������
		public static readonly Guid �������������������� = new Guid("1af55399-64cc-447f-4444-b310c9601f36");//��� ���������� �������
		public static readonly Guid ������������������������� = new Guid("502f68b5-a898-5c07-4dea-9c7f989c5739");//��� ������������ ����������
		public static readonly Guid �������������������������������� = new Guid("cf422698-75df-a4cd-4f40-b550419be58d");//������������� ���������� ���������
		public static ���������������������������� ��������(this ���������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������������� ��������(this ���������������������������� ��������, Guid ������)
		{
			if(������ == ������������������������)
			{
				return ����������������������������.������������������������;
			}
			else if(������ == �����������������������)
			{
				return ����������������������������.�����������������������;
			}
			else if(������ == ��������������������)
			{
				return ����������������������������.��������������������;
			}
			else if(������ == �������������������������)
			{
				return ����������������������������.�������������������������;
			}
			else if(������ == ��������������������������������)
			{
				return ����������������������������.��������������������������������;
			}
			return ����������������������������.������������;
		}
		public static byte[] ����(this ���������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ���������������������������� ��������)
		{
			switch (��������)
			{
				case ����������������������������.������������������������: return ������������������������;
				case ����������������������������.�����������������������: return �����������������������;
				case ����������������������������.��������������������: return ��������������������;
				case ����������������������������.�������������������������: return �������������������������;
				case ����������������������������.��������������������������������: return ��������������������������������;
			}
			return Guid.Empty;
		}
	}
}
