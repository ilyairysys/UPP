
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������������������������������
	{
		������������ = - 1,
		��������������������� = 0,//��������� ������ � ����� ...
		����������������������������������� = 1,//���������� ���������� ��������� ������
		������������������������������� = 2,//���������� ������ ���� "�����������"
		�������������������������� = 3,//���������� ������ ����������...
	}
	public static partial class ������������������������������������_��������//:������������������
	{
		public static readonly Guid ��������������������� = new Guid("abd838a1-c860-5c6a-40b6-e101abd447c9");//��������� ������ � ����� ...
		public static readonly Guid ����������������������������������� = new Guid("1e1480a6-f353-de6c-48ca-333eb4b73e10");//���������� ���������� ��������� ������
		public static readonly Guid ������������������������������� = new Guid("e21515b2-fd14-68fd-410a-4c7fe5e9a131");//���������� ������ ���� "�����������"
		public static readonly Guid �������������������������� = new Guid("d9c38b81-5660-f77a-4774-5d54132ab214");//���������� ������ ����������...
		public static ������������������������������������ ��������(this ������������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������ ��������(this ������������������������������������ ��������, Guid ������)
		{
			if(������ == ���������������������)
			{
				return ������������������������������������.���������������������;
			}
			else if(������ == �����������������������������������)
			{
				return ������������������������������������.�����������������������������������;
			}
			else if(������ == �������������������������������)
			{
				return ������������������������������������.�������������������������������;
			}
			else if(������ == ��������������������������)
			{
				return ������������������������������������.��������������������������;
			}
			return ������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������������.���������������������: return ���������������������;
				case ������������������������������������.�����������������������������������: return �����������������������������������;
				case ������������������������������������.�������������������������������: return �������������������������������;
				case ������������������������������������.��������������������������: return ��������������������������;
			}
			return Guid.Empty;
		}
	}
}
