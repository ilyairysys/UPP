
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������
	{
		������������ = - 1,
		��������������������������������������������� = 0,//�� �������� ������� � �������������� �������������
		���������������������������������������������� = 1,//�� �������������� ������������� � �������� ��������
	}
	public static partial class ������������������������_��������//:������������������
	{
		public static readonly Guid ��������������������������������������������� = new Guid("11a94189-cebb-dce3-49fa-e6088a80824f");//�� �������� ������� � �������������� �������������
		public static readonly Guid ���������������������������������������������� = new Guid("d19b97b8-e311-9410-496a-ecd6d36999df");//�� �������������� ������������� � �������� ��������
		public static ������������������������ ��������(this ������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������ ��������(this ������������������������ ��������, Guid ������)
		{
			if(������ == ���������������������������������������������)
			{
				return ������������������������.���������������������������������������������;
			}
			else if(������ == ����������������������������������������������)
			{
				return ������������������������.����������������������������������������������;
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
				case ������������������������.���������������������������������������������: return ���������������������������������������������;
				case ������������������������.����������������������������������������������: return ����������������������������������������������;
			}
			return Guid.Empty;
		}
	}
}
