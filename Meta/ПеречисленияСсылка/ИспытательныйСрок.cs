
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �����������������
	{
		������������ = - 1,
		�������������������� = 0,//� ������������� ������
		���������������������� = 1,//��� �������������� �����
	}
	public static partial class �����������������_��������//:������������������
	{
		public static readonly Guid �������������������� = new Guid("8d475089-ef5c-ab52-4476-1b60feca8e78");//� ������������� ������
		public static readonly Guid ���������������������� = new Guid("edc05aa4-6cb7-acff-48ed-056980e9568e");//��� �������������� �����
		public static ����������������� ��������(this ����������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������� ��������(this ����������������� ��������, Guid ������)
		{
			if(������ == ��������������������)
			{
				return �����������������.��������������������;
			}
			else if(������ == ����������������������)
			{
				return �����������������.����������������������;
			}
			return �����������������.������������;
		}
		public static byte[] ����(this ����������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������� ��������)
		{
			switch (��������)
			{
				case �����������������.��������������������: return ��������������������;
				case �����������������.����������������������: return ����������������������;
			}
			return Guid.Empty;
		}
	}
}
