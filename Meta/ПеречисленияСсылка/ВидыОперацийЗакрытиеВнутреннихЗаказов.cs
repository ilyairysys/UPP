
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		��������������� = 0,//�������� ���������� �������
	///<summary>
	///(���)
	///</summary>
		�������������� = 1,//������ �������� � ����������
	}
	public static partial class �������������������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������� = new Guid("79f5e9ac-5bdc-44d5-48d0-bda4f72b9f1c");//�������� ���������� �������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������������� = new Guid("ff18c09e-509c-6872-436f-00d210ae8308");//������ �������� � ����������
		public static ������������������������������������� ��������(this ������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������� ��������(this ������������������������������������� ��������, Guid ������)
		{
			if(������ == ���������������)
			{
				return �������������������������������������.���������������;
			}
			else if(������ == ��������������)
			{
				return �������������������������������������.��������������;
			}
			return �������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������������������.���������������: return ���������������;
				case �������������������������������������.��������������: return ��������������;
			}
			return Guid.Empty;
		}
	}
}
