
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������������������������
	{
		������������ = - 1,
		��������������� = 0,//�������, ��������
		����������� = 1,
	///<summary>
	///(���)
	///</summary>
		������������ = 2,
	}
	public static partial class ���������������������������_��������//:������������������
	{
		public static readonly Guid ��������������� = new Guid("94d32e9a-347f-77ac-42ad-c9820b913b73");//�������, ��������
		public static readonly Guid ����������� = new Guid("5d437fae-1733-fbda-44a9-4e3679f92bdd");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ������������ = new Guid("bf44a3af-a382-2bf0-4246-df0f2c8cd774");
		public static ��������������������������� ��������(this ��������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������� ��������(this ��������������������������� ��������, Guid ������)
		{
			if(������ == ���������������)
			{
				return ���������������������������.���������������;
			}
			else if(������ == �����������)
			{
				return ���������������������������.�����������;
			}
			else if(������ == ������������)
			{
				return ���������������������������.������������;
			}
			return ���������������������������.������������;
		}
		public static byte[] ����(this ��������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������.���������������: return ���������������;
				case ���������������������������.�����������: return �����������;
				case ���������������������������.������������: return ������������;
			}
			return Guid.Empty;
		}
	}
}
