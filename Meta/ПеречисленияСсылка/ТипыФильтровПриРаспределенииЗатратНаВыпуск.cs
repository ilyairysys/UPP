
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������������������������
	{
		������������ = - 1,
		�������������������� = 0,//�������������� ������
		��������� = 1,
	}
	public static partial class ������������������������������������������_��������//:������������������
	{
		public static readonly Guid �������������������� = new Guid("89426484-1abc-fc74-4e73-8832cb7864c4");//�������������� ������
		public static readonly Guid ��������� = new Guid("52f73ba7-39bb-4c5f-42e3-1d08399803b9");
		public static ������������������������������������������ ��������(this ������������������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������������ ��������(this ������������������������������������������ ��������, Guid ������)
		{
			if(������ == ��������������������)
			{
				return ������������������������������������������.��������������������;
			}
			else if(������ == ���������)
			{
				return ������������������������������������������.���������;
			}
			return ������������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������������������.��������������������: return ��������������������;
				case ������������������������������������������.���������: return ���������;
			}
			return Guid.Empty;
		}
	}
}
