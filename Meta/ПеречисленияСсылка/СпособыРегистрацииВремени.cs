
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���) ������������� ��� �������� ������� ����������� ������� ������� ���������� � ��������� (����������� ��� �������)
		///</summary>
	public enum �������������������������
	{
		������������ = - 1,
		������������������������ = 0,//����������� ����������� �������
		������������������������ = 1,//����������� ������� � �����
	}
	public static partial class �������������������������_��������//:������������������
	{
		public static readonly Guid ������������������������ = new Guid("59c9088f-8134-8197-4458-4466a6ff4ec4");//����������� ����������� �������
		public static readonly Guid ������������������������ = new Guid("9c21fe9c-547d-6486-4f48-c866f232c059");//����������� ������� � �����
		public static ������������������������� ��������(this ������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������� ��������(this ������������������������� ��������, Guid ������)
		{
			if(������ == ������������������������)
			{
				return �������������������������.������������������������;
			}
			else if(������ == ������������������������)
			{
				return �������������������������.������������������������;
			}
			return �������������������������.������������;
		}
		public static byte[] ����(this ������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������.������������������������: return ������������������������;
				case �������������������������.������������������������: return ������������������������;
			}
			return Guid.Empty;
		}
	}
}
