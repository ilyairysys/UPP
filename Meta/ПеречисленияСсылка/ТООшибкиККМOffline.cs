
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������Offline
	{
		������������ = - 1,
	///<summary>
	///���������� ��������� ��������� ��������� � ����������� ��� � ��������� ������� �������� �������.
	///</summary>
		��������������������� = 0,//��� ������� �������� ������� � ���, ������������ � ������ Off-Line, ��������� ������. ������ �� ���� ���������.
	///<summary>
	///���������� ��������� ��������� ��������� � ����������� ��� � ��������� ������� �������� ������.
	///</summary>
		�������������������� = 1,//��� ������� �������� ������ � �������� �� ���, ������������ � ������ Off-Line, ��������� ������. ����� �� ��� ��������.
	}
	public static partial class �����������Offline_��������//:������������������
	{
		///<summary>
		///���������� ��������� ��������� ��������� � ����������� ��� � ��������� ������� �������� �������.
		///</summary>
		public static readonly Guid ��������������������� = new Guid("6e850b98-409c-e050-471e-15e009205440");//��� ������� �������� ������� � ���, ������������ � ������ Off-Line, ��������� ������. ������ �� ���� ���������.
		///<summary>
		///���������� ��������� ��������� ��������� � ����������� ��� � ��������� ������� �������� ������.
		///</summary>
		public static readonly Guid �������������������� = new Guid("153a31bd-f7d5-d35b-46f7-56cc990cb8da");//��� ������� �������� ������ � �������� �� ���, ������������ � ������ Off-Line, ��������� ������. ����� �� ��� ��������.
		public static �����������Offline ��������(this �����������Offline ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static �����������Offline ��������(this �����������Offline ��������, Guid ������)
		{
			if(������ == ���������������������)
			{
				return �����������Offline.���������������������;
			}
			else if(������ == ��������������������)
			{
				return �����������Offline.��������������������;
			}
			return �����������Offline.������������;
		}
		public static byte[] ����(this �����������Offline ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this �����������Offline ��������)
		{
			switch (��������)
			{
				case �����������Offline.���������������������: return ���������������������;
				case �����������Offline.��������������������: return ��������������������;
			}
			return Guid.Empty;
		}
	}
}
