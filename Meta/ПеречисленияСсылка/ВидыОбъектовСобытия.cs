
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������
	{
		������������ = - 1,
		���������� = 0,
		�������� = 1,
		�������������������� = 2,//������ ���������� ����
		��������������� = 3,//������ ���������
	}
	public static partial class �������������������_��������//:������������������
	{
		public static readonly Guid ���������� = new Guid("9f874a98-4395-bfb2-4790-5d02f87b5cd9");
		public static readonly Guid �������� = new Guid("2f184093-534b-869e-4a36-3b175b3356b0");
		public static readonly Guid �������������������� = new Guid("4dee5abb-0455-bd89-48e2-84cb65bdc508");//������ ���������� ����
		public static readonly Guid ��������������� = new Guid("ebbc399d-9175-6e48-4f4d-3e9fcb2dece5");//������ ���������
		public static ������������������� ��������(this ������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������� ��������(this ������������������� ��������, Guid ������)
		{
			if(������ == ����������)
			{
				return �������������������.����������;
			}
			else if(������ == ��������)
			{
				return �������������������.��������;
			}
			else if(������ == ��������������������)
			{
				return �������������������.��������������������;
			}
			else if(������ == ���������������)
			{
				return �������������������.���������������;
			}
			return �������������������.������������;
		}
		public static byte[] ����(this ������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������� ��������)
		{
			switch (��������)
			{
				case �������������������.����������: return ����������;
				case �������������������.��������: return ��������;
				case �������������������.��������������������: return ��������������������;
				case �������������������.���������������: return ���������������;
			}
			return Guid.Empty;
		}
	}
}
