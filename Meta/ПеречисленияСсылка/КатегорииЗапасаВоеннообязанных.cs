
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ������������������������������
	{
		������������ = - 1,
		��45��� = 0,//1 - �� 45 ���
		��50��� = 1,//2 - �� 50 ���
		��55��� = 2,//3 - �� 55 ���
	}
	public static partial class ������������������������������_��������//:������������������
	{
		public static readonly Guid ��45��� = new Guid("a46ae283-c07e-8fac-47cc-05967c325e71");//1 - �� 45 ���
		public static readonly Guid ��50��� = new Guid("f75b289d-ebae-f35e-4c8c-2a8dda06cae5");//2 - �� 50 ���
		public static readonly Guid ��55��� = new Guid("3973c3be-49af-4263-45ed-f882ff9313b9");//3 - �� 55 ���
		public static ������������������������������ ��������(this ������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������ ��������(this ������������������������������ ��������, Guid ������)
		{
			if(������ == ��45���)
			{
				return ������������������������������.��45���;
			}
			else if(������ == ��50���)
			{
				return ������������������������������.��50���;
			}
			else if(������ == ��55���)
			{
				return ������������������������������.��55���;
			}
			return ������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������.��45���: return ��45���;
				case ������������������������������.��50���: return ��50���;
				case ������������������������������.��55���: return ��55���;
			}
			return Guid.Empty;
		}
	}
}
