
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(����)
		///</summary>
	public enum ����������������������������������
	{
		������������ = - 1,
		���������� = 0,//�� ��������
		�������� = 1,//�� ������
	}
	public static partial class ����������������������������������_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("bbd07ea0-e30f-148c-4a0f-6f24830e3156");//�� ��������
		public static readonly Guid �������� = new Guid("091c59b6-a638-3612-4d67-21554eb7551f");//�� ������
		public static ���������������������������������� ��������(this ���������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ���������������������������������� ��������(this ���������������������������������� ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return ����������������������������������.����������;
			}
			else if(������ == ��������)
			{
				return ����������������������������������.��������;
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
				case ����������������������������������.����������: return ����������;
				case ����������������������������������.��������: return ��������;
			}
			return Guid.Empty;
		}
	}
}
