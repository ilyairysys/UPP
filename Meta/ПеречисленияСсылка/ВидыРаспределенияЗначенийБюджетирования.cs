
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������������������������������������
	{
		������������ = - 1,
		�������������������� = 0,//�� �������� ����������
		��������������������� = 1,//�� �������� � ����������
	}
	public static partial class ���������������������������������������_��������//:������������������
	{
		public static readonly Guid �������������������� = new Guid("90ca1b88-4d3a-c919-443f-309b3b41ff0c");//�� �������� ����������
		public static readonly Guid ��������������������� = new Guid("fb9cfdbd-0113-b764-4777-05ea50e346aa");//�� �������� � ����������
		public static ��������������������������������������� ��������(this ��������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������������������� ��������(this ��������������������������������������� ��������, Guid ������)
		{
			if(������ == ��������������������)
			{
				return ���������������������������������������.��������������������;
			}
			else if(������ == ���������������������)
			{
				return ���������������������������������������.���������������������;
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
				case ���������������������������������������.��������������������: return ��������������������;
				case ���������������������������������������.���������������������: return ���������������������;
			}
			return Guid.Empty;
		}
	}
}
